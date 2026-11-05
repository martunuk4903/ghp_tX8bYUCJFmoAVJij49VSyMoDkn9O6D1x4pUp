"""Flatten a Unity prefab/scene (prefab VARIANTS + nested instances) into a readable
hierarchy with effective overrides. Read-only diagnostic tool."""
import sys, re, os

ROOT = 'Assets'
GUIDMAP = {}
CACHE = {}
SHOW = []   # extra propertyPaths to print


def build_guidmap():
    for dp, dn, fn in os.walk(ROOT):
        for f in fn:
            if f.endswith('.meta'):
                p = os.path.join(dp, f)
                try:
                    t = open(p, encoding='utf-8', errors='replace').read()
                except Exception:
                    continue
                m = re.search(r'^guid:\s*([0-9a-f]{32})', t, re.M)
                if m:
                    GUIDMAP[m.group(1)] = p[:-5].replace(os.sep, '/')


def load(path):
    docs = {}
    cur = None
    for ln in open(path, encoding='utf-8', errors='replace').read().split('\n'):
        m = re.match(r'^--- !u!(\d+) &(-?\d+)(.*)$', ln)
        if m:
            cur = {'type': m.group(1), 'id': m.group(2), 'lines': [],
                   'stripped': 'stripped' in m.group(3)}
            docs[m.group(2)] = cur
            continue
        if cur is not None:
            cur['lines'].append(ln)
    return docs


def D(path):
    if path not in CACHE:
        CACHE[path] = load(path)
    return CACHE[path]


def val(doc, key):
    for l in doc['lines']:
        m = re.match(r'^\s*' + re.escape(key) + r':\s*(.*)$', l)
        if m:
            return m.group(1).strip()
    return None


def fid(s):
    if not s:
        return None
    m = re.search(r'fileID:\s*(-?\d+)', s)
    return m.group(1) if m else None


def gid(s):
    if not s:
        return None
    m = re.search(r'guid:\s*([0-9a-f]{32})', s)
    return m.group(1) if m else None


def seq(doc, key, pat):
    out = []
    inl = False
    for l in doc['lines']:
        if re.match(r'^\s*' + re.escape(key) + r':', l):
            if l.strip().endswith('[]'):
                return []
            inl = True
            continue
        if inl:
            m = re.match(pat, l)
            if m:
                out.append(m.groups())
            else:
                break
    return out


def children(d):
    return [x[0] for x in seq(d, 'm_Children', r'^\s*- \{fileID:\s*(-?\d+)\}')]


def comps(d):
    return [x[0] for x in seq(d, 'm_Component', r'^\s*- component: \{fileID:\s*(-?\d+)\}')]


def parse_mods(d):
    out = {}
    L = d['lines']
    for i in range(len(L)):
        m = re.match(r'^\s*- target: \{fileID:\s*(-?\d+), guid:\s*([0-9a-f]{32}), type: \d+\}', L[i])
        if not m:
            continue
        pp = v = orf = None
        for j in range(i + 1, min(i + 5, len(L))):
            if re.match(r'^\s*- target:', L[j]):
                break
            mm = re.match(r'^\s*propertyPath:\s*(.*)$', L[j])
            if mm:
                pp = mm.group(1).strip()
            mm = re.match(r'^\s*value:\s*(.*)$', L[j])
            if mm:
                v = mm.group(1).strip()
            mm = re.match(r'^\s*objectReference:\s*(.*)$', L[j])
            if mm:
                orf = mm.group(1).strip()
        if pp is not None:
            out[(m.group(1), pp)] = (v, orf)
    return out


def added(d, key):
    out = []
    L = d['lines']
    for i in range(len(L)):
        if re.match(r'^\s*' + key + r':', L[i]):
            if L[i].strip().endswith('[]'):
                continue
            j = i + 1
            while j < len(L):
                if re.match(r'^\s{0,4}\w', L[j]):
                    break
                m = re.match(r'^\s*- targetCorrespondingSourceObject: \{fileID:\s*(-?\d+)', L[j])
                if m:
                    ao = None
                    for k in range(j + 1, min(j + 4, len(L))):
                        mm = re.match(r'^\s*addedObject: \{fileID:\s*(-?\d+)\}', L[k])
                        if mm:
                            ao = mm.group(1)
                    if ao:
                        out.append((m.group(1), ao))
                j += 1
    return out


def top_transforms(path):
    return [i for i, d in D(path).items()
            if d['type'] in ('224', '4') and not d['stripped']
            and fid(val(d, 'm_Father')) in (None, '0')]


def base_instance(path):
    for i, d in D(path).items():
        if d['type'] == '1001' and fid(val(d, 'm_TransformParent')) in (None, '0'):
            return i
    return None


def chain(path):
    """[(file, mods, addedGOs, addedComps)] from base prefab upward."""
    if top_transforms(path):
        return [(path, {}, [], [])]
    bi = base_instance(path)
    if bi is None:
        return [(path, {}, [], [])]
    bd = D(path)[bi]
    sg = gid(val(bd, 'm_SourcePrefab'))
    sp = GUIDMAP.get(sg)
    if not sp or not os.path.exists(sp):
        return [(path, {}, [], [])]
    return chain(sp) + [(path, parse_mods(bd), added(bd, 'm_AddedGameObjects'),
                         added(bd, 'm_AddedComponents'))]


class Ctx:
    def __init__(self, layers):
        self.mods = {}
        self.addgo = {}
        self.addcp = {}
        self.base = layers[0][0]
        for (f, m, ag, ac) in layers:
            self.mods.update(m)
            for (t, a) in ag:
                self.addgo.setdefault(t, []).append((f, a))
            for (t, a) in ac:
                self.addcp.setdefault(t, []).append((f, a))

    def ov(self, oid, prop, default=None):
        e = self.mods.get((oid, prop))
        if e is None:
            return default
        v, orf = e
        if orf and 'fileID: 0' not in orf:
            return (v or '') + ' @' + orf
        return v


def clabel(path, cid, ctx):
    docs = D(path)
    cd = docs.get(cid)
    if not cd:
        return '??#' + cid
    t = cd['type']
    if t == '114':
        eci = (val(cd, 'm_EditorClassIdentifier') or '').split('::')[-1]
        sg = gid(val(cd, 'm_Script'))
        nm = eci or os.path.basename(GUIDMAP.get(sg, str(sg)))
        return 'MB[' + nm + ']#' + cid
    names = {'4': 'Tr', '224': 'RT', '222': 'CR', '223': 'Canvas', '20': 'Cam',
             '50': 'RB2D', '212': 'SR', '61': 'Box2D', '114': 'MB', '95': 'Animator'}
    return names.get(t, 't' + t) + '#' + cid


def emit(path, trid, depth, ctx, maxdepth, tag=''):
    if depth > maxdepth:
        return
    docs = D(path)
    d = docs.get(trid)
    if d is None:
        print('  ' * depth + '?missing ' + trid + ' @' + os.path.basename(path))
        return
    goid = fid(val(d, 'm_GameObject'))
    g = docs.get(goid or '')
    name = ctx.ov(goid, 'm_Name', val(g, 'm_Name') if g else '?')
    act = val(g, 'm_IsActive') if g else '?'
    a2 = ctx.ov(goid, 'm_IsActive')
    if a2 is not None:
        act = a2 + '*'
    cs = []
    if g:
        for c in comps(g):
            cs.append(clabel(path, c, ctx))
    for (f2, ao) in ctx.addcp.get(goid, []):
        cs.append('+' + clabel(f2, ao, ctx))
    extra = ''
    for pp in SHOW:
        v = ctx.ov(trid, pp)
        if v is None and goid:
            v = ctx.ov(goid, pp)
        if v is not None:
            extra += ' ' + pp + '=' + str(v)
    print('  ' * depth + str(name) + ' <' + str(act) + '> tr' + trid + ' go' + str(goid) +
          tag + ' :: ' + ' '.join(cs) + extra)
    for ch in children(d):
        cd = docs.get(ch)
        if cd is None:
            continue
        if cd['stripped']:
            pi = fid(val(cd, 'm_PrefabInstance'))
            pid = docs.get(pi)
            if not pid:
                continue
            sg = gid(val(pid, 'm_SourcePrefab'))
            sp = GUIDMAP.get(sg)
            srctr = fid(val(cd, 'm_CorrespondingSourceObject'))
            if sp and os.path.exists(sp):
                layers = chain(sp) + [(path, parse_mods(pid),
                                       added(pid, 'm_AddedGameObjects'),
                                       added(pid, 'm_AddedComponents'))]
                sub = Ctx(layers)
                # outer overrides on nested-prefab objects
                for k, v in ctx.mods.items():
                    sub.mods.setdefault(k, v)
                for k, v in ctx.addgo.items():
                    sub.addgo.setdefault(k, []).extend(v)
                for k, v in ctx.addcp.items():
                    sub.addcp.setdefault(k, []).extend(v)
                print('  ' * (depth + 1) + '>>> [' + os.path.basename(sp) + '] inst' + str(pi))
                start = srctr if srctr in D(sub.base) else (top_transforms(sub.base) or [None])[0]
                if start:
                    emit(sub.base, start, depth + 2, sub, maxdepth)
            else:
                print('  ' * (depth + 1) + '>>> guid ' + str(sg) + ' UNRESOLVED inst' + str(pi))
            continue
        emit(path, ch, depth + 1, ctx, maxdepth, tag)
    for key in (trid, goid):
        for (f2, ao) in ctx.addgo.get(key, []):
            emit(f2, ao, depth + 1, ctx, maxdepth, ' (+' + os.path.basename(f2)[:14] + ')')


def scene_roots(path):
    out = []
    for i, d in D(path).items():
        if d['type'] == '1660057539':
            inl = False
            for l in d['lines']:
                if re.match(r'^\s*m_Roots:', l):
                    inl = True
                    continue
                if inl:
                    m = re.match(r'^\s*- \{fileID:\s*(-?\d+)\}', l)
                    if m:
                        out.append(m.group(1))
                    else:
                        break
    return out


build_guidmap()
p = sys.argv[1]
md = int(sys.argv[2]) if len(sys.argv) > 2 else 99
if len(sys.argv) > 3:
    SHOW = sys.argv[3].split(',')
if p.endswith('.unity'):
    for r in scene_roots(p):
        d = D(p)[r]
        if d['type'] == '1001':
            sg = gid(val(d, 'm_SourcePrefab'))
            sp = GUIDMAP.get(sg)
            print('### SCENE ROOT -> ' + str(sp) + ' inst' + r)
            if sp:
                layers = chain(sp) + [(p, parse_mods(d), added(d, 'm_AddedGameObjects'),
                                       added(d, 'm_AddedComponents'))]
                ctx = Ctx(layers)
                for t in top_transforms(ctx.base):
                    emit(ctx.base, t, 1, ctx, md)
        else:
            emit(p, r, 0, Ctx([(p, {}, [], [])]), md)
else:
    layers = chain(p)
    ctx = Ctx(layers)
    for t in top_transforms(ctx.base):
        emit(ctx.base, t, 0, ctx, md)

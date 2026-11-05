import sys, re, os
ROOT = 'Assets'
GUIDMAP = {}

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
            cur = {'type': m.group(1), 'id': m.group(2), 'lines': [], 'stripped': 'stripped' in m.group(3)}
            docs[m.group(2)] = cur
            continue
        if cur is not None:
            cur['lines'].append(ln)
    return docs

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

def listof(doc, key, pat):
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
    return [x[0] for x in listof(d, 'm_Children', r'^\s*- \{fileID:\s*(-?\d+)\}')]

def comps(d):
    return [x[0] for x in listof(d, 'm_Component', r'^\s*- component: \{fileID:\s*(-?\d+)\}')]

def mods(d):
    out = []
    L = d['lines']
    for i in range(len(L)):
        m = re.match(r'^\s*- target: \{fileID:\s*(-?\d+), guid:\s*([0-9a-f]{32}), type: \d+\}', L[i])
        if m:
            pp = v = orf = None
            for j in range(i + 1, min(i + 5, len(L))):
                mm = re.match(r'^\s*propertyPath:\s*(.*)$', L[j])
                if mm:
                    pp = mm.group(1).strip()
                mm = re.match(r'^\s*value:\s*(.*)$', L[j])
                if mm:
                    v = mm.group(1).strip()
                mm = re.match(r'^\s*objectReference:\s*(.*)$', L[j])
                if mm:
                    orf = mm.group(1).strip()
            out.append((m.group(1), m.group(2), pp, v, orf))
    return out

CACHE = {}

def getdocs(path):
    if path not in CACHE:
        CACHE[path] = load(path)
    return CACHE[path]

def walk(path, trid, depth, modmap, maxdepth):
    if depth > maxdepth:
        return
    docs = getdocs(path)
    d = docs.get(trid)
    if not d:
        print('  ' * depth + '?missing ' + str(trid))
        return
    g = docs.get(fid(val(d, 'm_GameObject')) or '')
    name = val(g, 'm_Name') if g else '?'
    act = val(g, 'm_IsActive') if g else '?'
    goid = g['id'] if g else '?'
    if (goid, 'm_Name') in modmap:
        name = modmap[(goid, 'm_Name')]
    if (goid, 'm_IsActive') in modmap:
        act = modmap[(goid, 'm_IsActive')] + '*'
    cs = []
    if g:
        for c in comps(g):
            cd = docs.get(c)
            if not cd:
                continue
            t = cd['type']
            if t == '114':
                eci = (val(cd, 'm_EditorClassIdentifier') or '').split('::')[-1]
                cs.append('MB[' + (eci or str(fid(val(cd, 'm_Script')))) + ']#' + c)
            else:
                cs.append(t + '#' + c)
    print('  ' * depth + name + ' <' + str(act) + '> tr' + trid + ' go' + str(goid) + ' :: ' + ' '.join(cs))
    for ch in children(d):
        cd = docs.get(ch)
        if cd is None:
            continue
        if cd['stripped']:
            pi = fid(val(cd, 'm_PrefabInstance'))
            pid = docs.get(pi)
            if pid:
                sg = gid(val(pid, 'm_SourcePrefab'))
                sp = GUIDMAP.get(sg)
                nm = {}
                for (t, gg, pp, v, orf) in mods(pid):
                    nm[(t, pp)] = (v or '') if (orf is None or 'fileID: 0' in orf) else (v or '') + ' @' + str(orf)
                srctr = fid(val(cd, 'm_CorrespondingSourceObject'))
                if sp and os.path.exists(sp):
                    print('  ' * (depth + 1) + '>>> PREFAB ' + os.path.basename(sp) + ' (inst ' + str(pi) + ')')
                    walk(sp, srctr, depth + 2, nm, maxdepth)
                else:
                    print('  ' * (depth + 1) + '>>> PREFAB guid=' + str(sg) + ' UNRESOLVED (inst ' + str(pi) + ')')
            continue
        walk(path, ch, depth + 1, modmap, maxdepth)

def scene_roots(path):
    docs = getdocs(path)
    out = []
    for i, d in docs.items():
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

def walk_root(path, rid, maxdepth):
    docs = getdocs(path)
    d = docs.get(rid)
    if d is None:
        return
    if d['type'] == '1001':
        sg = gid(val(d, 'm_SourcePrefab'))
        sp = GUIDMAP.get(sg)
        nm = {}
        for (t, gg, pp, v, orf) in mods(d):
            nm[(t, pp)] = (v or '') if (orf is None or 'fileID: 0' in orf) else (v or '') + ' @' + str(orf)
        print('>>> SCENE-ROOT PREFAB ' + str(sp) + ' (inst ' + rid + ')')
        if sp:
            sd = getdocs(sp)
            for i2, d2 in sd.items():
                if d2['type'] in ('224', '4') and not d2['stripped'] and fid(val(d2, 'm_Father')) in (None, '0'):
                    walk(sp, i2, 1, nm, maxdepth)
    else:
        walk(path, rid, 0, {}, maxdepth)

build_guidmap()
p = sys.argv[1]
md = int(sys.argv[3]) if len(sys.argv) > 3 else 99
docs = getdocs(p)
if len(sys.argv) > 2 and sys.argv[2] != '-':
    walk(p, sys.argv[2], 0, {}, md)
else:
    rs = scene_roots(p)
    if rs:
        for r in rs:
            walk_root(p, r, md)
    else:
        for i, d in docs.items():
            if d['type'] in ('224', '4') and not d['stripped'] and fid(val(d, 'm_Father')) in (None, '0'):
                walk(p, i, 0, {}, md)

import sys, re, os
def load(path):
    docs={}
    cur=None; curid=None; curtype=None
    lines=open(path, encoding='utf-8', errors='replace').read().split('\n')
    for ln in lines:
        m=re.match(r'^--- !u!(\d+) &(\d+)(.*)$', ln)
        if m:
            curtype=m.group(1); curid=m.group(2)
            cur={'type':curtype,'id':curid,'lines':[],'stripped':'stripped' in m.group(3)}
            docs[curid]=cur
            continue
        if cur is not None: cur['lines'].append(ln)
    return docs
def val(doc,key):
    for l in doc['lines']:
        m=re.match(r'^\s*'+re.escape(key)+r':\s*(.*)$', l)
        if m: return m.group(1).strip()
    return None
def fid(s):
    if not s: return None
    m=re.search(r'fileID:\s*(-?\d+)', s)
    return m.group(1) if m else None
def build(docs):
    # GameObject (1) -> name, components ; RectTransform(224)/Transform(4) -> parent/children
    go={}; tr={}
    for i,d in docs.items():
        if d['type']=='1': go[i]=d
        if d['type'] in ('224','4'): tr[i]=d
    return go,tr
def children(doc):
    out=[]; inch=False
    for l in doc['lines']:
        if re.match(r'^\s*m_Children:', l):
            if l.strip().endswith('[]'): return []
            inch=True; continue
        if inch:
            m=re.match(r'^\s*- \{fileID:\s*(-?\d+)\}', l)
            if m: out.append(m.group(1))
            else:
                if l.strip() and not l.startswith('  - '): break
    return out
def comps(doc):
    out=[]; inc=False
    for l in doc['lines']:
        if re.match(r'^\s*m_Component:', l):
            if l.strip().endswith('[]'): return []
            inc=True; continue
        if inc:
            m=re.match(r'^\s*- component: \{fileID:\s*(-?\d+)\}', l)
            if m: out.append(m.group(1))
            else: break
    return out
def dump(path, rootid=None, maxdepth=99):
    docs=load(path); go,tr=build(docs)
    def goof(trid):
        d=docs.get(trid)
        if not d: return None
        return fid(val(d,'m_GameObject'))
    def pr(trid, depth):
        if depth>maxdepth: return
        d=docs.get(trid)
        if not d: 
            print('  '*depth+f'?{trid}'); return
        gid=goof(trid); g=docs.get(gid) if gid else None
        name=val(g,'m_Name') if g else '?'
        act=val(g,'m_IsActive') if g else '?'
        cs=[]
        if g:
            for c in comps(g):
                cd=docs.get(c)
                if not cd: continue
                t=cd['type']
                if t=='114':
                    sc=fid(val(cd,'m_Script'))
                    eci=val(cd,'m_EditorClassIdentifier') or ''
                    cs.append(f"MB({eci.split('::')[-1] or sc}:{c})")
                else:
                    cs.append(f"{t}:{c}")
        print('  '*depth+f'{name} [tr{trid} go{gid} act={act}] {" ".join(cs)}')
        for ch in children(d): pr(ch, depth+1)
    roots=[]
    if rootid: roots=[rootid]
    else:
        for i,d in tr.items():
            if not d['stripped'] and fid(val(d,'m_Father')) in (None,'0'): roots.append(i)
    for r in roots: pr(r,0)
if __name__=='__main__':
    dump(sys.argv[1], sys.argv[2] if len(sys.argv)>2 else None, int(sys.argv[3]) if len(sys.argv)>3 else 99)

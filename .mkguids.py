"""Allocate fresh, collision-checked guids for every asset codegen will author (CLAUDE-unity.md B.2)."""
import os, re, json, hashlib

ROOT = 'Assets'
used = set()
for dp, dn, fn in os.walk(ROOT):
    for f in fn:
        if f.endswith('.meta'):
            try:
                t = open(os.path.join(dp, f), encoding='utf-8', errors='replace').read()
            except Exception:
                continue
            for m in re.finditer(r'([0-9a-f]{32})', t):
                used.add(m.group(1))
# also every guid referenced anywhere in scenes/prefabs/assets, so we never shadow a package guid
for dp, dn, fn in os.walk(ROOT):
    for f in fn:
        if f.endswith(('.unity', '.prefab', '.asset', '.mat')):
            try:
                t = open(os.path.join(dp, f), encoding='utf-8', errors='replace').read()
            except Exception:
                continue
            for m in re.finditer(r'guid:\s*([0-9a-f]{32})', t):
                used.add(m.group(1))
print('guids already in use:', len(used))

NAMES = [
    # sprites (the fixed Codex contract, nothing else)
    'spr:logo', 'spr:icon_home', 'spr:icon_pause',
    'spr:sprite_1', 'spr:sprite_2', 'spr:sprite_3', 'spr:sprite_4', 'spr:sprite_5',
    'spr:button_rect', 'spr:button_round',
    # scripts
    'cs:TrailPalette', 'cs:TrailConfig', 'cs:StageTable', 'cs:PlayerProgress',
    'cs:TextReadability', 'cs:UiKit', 'cs:MenuDirector', 'cs:MenuViewRouter',
    'cs:SplashDresser', 'cs:StageMapView', 'cs:RewardsView', 'cs:MissionsView',
    'cs:ProfileView', 'cs:SettingsView', 'cs:PlayCtaDresser', 'cs:TemplateTextCleaner',
    'cs:TrailGenerator', 'cs:TrailRunDirector', 'cs:ClimberController', 'cs:RowPool',
    'cs:RunHudView', 'cs:GamePopPresenter', 'cs:LaneTapArea', 'cs:TrailSegment',
    'cs:StatPill', 'cs:MenuBoot', 'cs:GameBoot', 'cs:TrailSkin', 'cs:MissionBoard',
    'cs:RewardBoard', 'cs:TrailRow',
    # folders
    'dir:ScriptsGenerated', 'dir:PrefabsGenerated',
    # prefabs
    'pf:Coin', 'pf:EmberCore', 'pf:VentPlume', 'pf:Climber', 'pf:TrailTile',
    'pf:TrailRail', 'pf:SparkPuff', 'pf:TrailRow',
]

out = {}
# keep any guid already written to disk in a previous pass — a published guid is forever
if os.path.exists('.guids.json'):
    prev = json.load(open('.guids.json'))
    for n, g in prev.items():
        kind, nm = n.split(':', 1)
        disk = {'spr': 'Assets/Art/Sprites/%s.png.meta' % nm,
                'cs': 'Assets/Scripts/Generated/%s.cs.meta' % nm,
                'pf': 'Assets/Prefabs/Generated/%s.prefab.meta' % nm}.get(kind)
        if disk and os.path.exists(disk) and g in open(disk, encoding='utf-8').read():
            out[n] = g

for n in NAMES:
    if n in out:
        continue
    i = 0
    while True:
        g = hashlib.md5(('V0lcanoTrailC0in/' + n + '/' + str(i)).encode()).hexdigest()
        if g not in used:
            used.add(g)
            out[n] = g
            break
        i += 1

json.dump(out, open('.guids.json', 'w'), indent=1, sort_keys=True)
print('allocated', len(out))
for k in sorted(out):
    print(' ', k, out[k])

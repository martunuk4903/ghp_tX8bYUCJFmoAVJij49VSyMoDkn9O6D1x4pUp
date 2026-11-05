"""Write Assets/Art/Sprites/<name>.png.meta for the fixed Codex contract + assets.json."""
import json, os

G = json.load(open('.guids.json'))
OUT = 'Assets/Art/Sprites'
os.makedirs(OUT, exist_ok=True)

META = """fileFormatVersion: 2
guid: {guid}
TextureImporter:
  internalIDToNameTable: []
  externalObjects: {{}}
  serializedVersion: 13
  mipmaps:
    mipMapMode: 0
    enableMipMap: 0
    sRGBTexture: 1
    linearTexture: 0
    fadeOut: 0
    borderMipMap: 0
    mipMapsPreserveCoverage: 0
    alphaTestReferenceValue: 0.5
    mipMapFadeDistanceStart: 1
    mipMapFadeDistanceEnd: 3
  bumpmap:
    convertToNormalMap: 0
    externalNormalMap: 0
    heightScale: 0.25
    normalMapFilter: 0
    flipGreenChannel: 0
  isReadable: 0
  streamingMipmaps: 0
  streamingMipmapsPriority: 0
  vTOnly: 0
  ignoreMipmapLimit: 0
  grayScaleToAlpha: 0
  generateCubemap: 6
  cubemapConvolution: 0
  seamlessCubemap: 0
  textureFormat: 1
  maxTextureSize: 2048
  textureSettings:
    serializedVersion: 2
    filterMode: 1
    aniso: 1
    mipBias: 0
    wrapU: 1
    wrapV: 1
    wrapW: 1
  nPOTScale: 0
  lightmap: 0
  compressionQuality: 50
  spriteMode: 1
  spriteExtrude: 1
  spriteMeshType: 0
  alignment: 0
  spritePivot: {{x: 0.5, y: 0.5}}
  spritePixelsToUnits: 100
  spriteBorder: {{x: {bl}, y: {bb}, z: {br}, w: {bt}}}
  spriteGenerateFallbackPhysicsShape: 1
  alphaUsage: 1
  alphaIsTransparency: 1
  spriteTessellationDetail: -1
  textureType: 8
  textureShape: 1
  singleChannelComponent: 0
  flipbookRows: 1
  flipbookColumns: 1
  maxTextureSizeSet: 0
  compressionQualitySet: 0
  textureFormatSet: 0
  ignorePngGamma: 0
  applyGammaDecoding: 0
  swizzle: 50462976
  cookieLightType: 0
  platformSettings:
  - serializedVersion: 4
    buildTarget: DefaultTexturePlatform
    maxTextureSize: 2048
    resizeAlgorithm: 0
    textureFormat: -1
    textureCompression: 1
    compressionQuality: 50
    crunchedCompression: 0
    allowsAlphaSplitting: 0
    overridden: 0
    ignorePlatformSupport: 0
    androidETC2FallbackOverride: 0
    forceMaximumCompressionQuality_BC6H_BC7: 0
  spriteSheet:
    serializedVersion: 2
    sprites: []
    outline: []
    customData:
    physicsShape: []
    bones: []
    spriteID: 5e97eb03825dee720800000000000000
    internalID: 0
    vertices: []
    indices:
    edges: []
    weights: []
    secondaryTextures: []
    spriteCustomMetadata:
      entries: []
    nameFileIdTable: {{}}
  mipmapLimitGroupName:
  pSDRemoveMatte: 0
  userData:
  assetBundleName:
  assetBundleVariant:
"""

# name -> 9-slice border (left, bottom, right, top). 0 = genuinely square content art.
SPRITES = {
    'logo':         (0, 0, 0, 0),
    'icon_home':    (24, 24, 24, 24),
    'icon_pause':   (24, 24, 24, 24),
    'sprite_1':     (0, 0, 0, 0),
    'sprite_2':     (0, 0, 0, 0),
    'sprite_3':     (0, 0, 0, 0),
    'sprite_4':     (0, 0, 0, 0),
    'sprite_5':     (48, 48, 48, 48),
    'button_rect':  (56, 40, 56, 40),
    'button_round': (40, 40, 40, 40),
}

for name, (bl, bb, br, bt) in SPRITES.items():
    guid = G['spr:' + name]
    p = os.path.join(OUT, name + '.png.meta')
    open(p, 'w', encoding='utf-8', newline='\n').write(
        META.format(guid=guid, bl=bl, bb=bb, br=br, bt=bt))
    print('meta', p, guid)

# ── assets.json ────────────────────────────────────────────────────────────────
STYLE = ('Chunky casual mobile game art with thick black outlines. '
         'Never photographic, no DSLR look, no film grain, no lens flare, no bokeh, '
         'no depth of field.')

entries = [
    {
        'name': 'bg_game', 'type': 'bg', 'transparent': False,
        'target': 'Assets/Art/Textures/_BASE/Backgrounds/BG_game.png',
        'prompt': (STYLE + ' Portrait 9:16. A coin trail cut into the black basalt flank of a '
                   'live volcano, seen head-on and climbing away from the viewer; molten orange '
                   'fissures glow across the lower third, cooled ash-grey rock fills the middle, '
                   'a dark smoking ridge closes the top. Palette volcanic black #0B0B0F, ember '
                   'red #E03A12, ember glow #FF7A2A, molten gold #D4AF37. The central vertical '
                   'band is calm and low-contrast so gameplay sprites read on top of it; no '
                   'characters, no coins, no text, no noise in the top or bottom 15% where the '
                   'HUD sits.'),
    },
    {
        'name': 'bg_main', 'type': 'bg', 'transparent': False,
        'target': 'Assets/Art/Textures/_BASE/Backgrounds/BG_main.png',
        'prompt': (STYLE + ' Portrait 9:16. The same volcano world as the game background but a '
                   'wider establishing view: the whole volcano cone at dusk with gold rim light '
                   'on the ridge and an ember glow pooling at the base. Darker and emptier '
                   'through the middle so menu cards and the loading bar read on top. Palette '
                   'volcanic black #0B0B0F, ember red #E03A12, molten gold #D4AF37. No '
                   'characters, no text, no letters of any kind.'),
    },
    {
        'name': 'logo', 'type': 'sprite', 'transparent': True,
        'target': 'Assets/Art/Sprites/logo.png',
        'prompt': ('An abstract emblem only - a cracked basalt hexagon with a molten gold core '
                   'and three ember fissures radiating outward. ' + STYLE + ' Symmetric, no '
                   'facing direction, centred, filling the frame. Palette volcanic black #0B0B0F, '
                   'ember red #E03A12, molten gold #D4AF37. Absolutely no letters, words, '
                   'monogram or title of any kind. Transparent background, crisp silhouette, '
                   'minimal ground shadow.'),
    },
    {
        'name': 'icon_home', 'type': 'sprite', 'transparent': True,
        'target': 'Assets/Art/Sprites/icon_home.png',
        'prompt': ('A single flat back-arrow glyph pointing LEFT inside a rounded basalt tile. '
                   + STYLE + ' Molten gold #D4AF37 arrow on a dark #1C1C24 tile. Side view, '
                   'facing LEFT. Square canvas, centred, transparent background, no text. '
                   '9-slice spriteBorder {24,24,24,24}.'),
    },
    {
        'name': 'icon_pause', 'type': 'sprite', 'transparent': True,
        'target': 'Assets/Art/Sprites/icon_pause.png',
        'prompt': ('A single flat pause glyph - two thick vertical bars - inside a rounded basalt '
                   'tile. ' + STYLE + ' Molten gold #D4AF37 bars on a dark #1C1C24 tile. '
                   'Symmetric, no facing direction. Square canvas, centred, transparent '
                   'background, no text. 9-slice spriteBorder {24,24,24,24}.'),
    },
    {
        'name': 'sprite_1', 'type': 'sprite', 'transparent': True,
        'target': 'Assets/Art/Sprites/sprite_1.png',
        'prompt': ('The climber - a stocky volcano trail runner in a heat suit with a glowing '
                   'ember-cored backpack, bold readable silhouette. ' + STYLE + ' Side view, '
                   'facing RIGHT. Palette charcoal suit, molten gold #D4AF37 visor and trim, '
                   'ember red #E03A12 core glow. One subject, centred, fully in frame, '
                   'transparent background, minimal ground shadow, no text, no other objects.'),
    },
    {
        'name': 'sprite_2', 'type': 'sprite', 'transparent': True,
        'target': 'Assets/Art/Sprites/sprite_2.png',
        'prompt': ('A vent plume hazard - a burst of lava and sparks erupting UPWARD out of a '
                   'cracked basalt vent, tall vertical shape. ' + STYLE + ' Nose UP, vertically '
                   'symmetric about its centre line. Palette ember red #E03A12 core, ember glow '
                   '#FF7A2A tips, black #0B0B0F rock at the base. One subject, centred, fully in '
                   'frame, transparent background, no text.'),
    },
    {
        'name': 'sprite_3', 'type': 'sprite', 'transparent': True,
        'target': 'Assets/Art/Sprites/sprite_3.png',
        'prompt': ('A trail coin - a thick round molten-gold token with a raised rim and a small '
                   'ember spark etched into its face, seen flat-on. ' + STYLE + ' Symmetric, no '
                   'facing direction. Palette molten gold #D4AF37 with #F5D77A highlights and an '
                   'ember red #E03A12 spark. One subject, centred, fully in frame, transparent '
                   'background, minimal ground shadow, no text.'),
    },
    {
        'name': 'sprite_4', 'type': 'sprite', 'transparent': True,
        'target': 'Assets/Art/Sprites/sprite_4.png',
        'prompt': ('An ember core pickup - a faceted molten crystal shard glowing from inside, '
                   'floating. ' + STYLE + ' Symmetric, no facing direction. Palette ember glow '
                   '#FF7A2A core, ember red #E03A12 edges, thin molten gold #D4AF37 rim. One '
                   'subject, centred, fully in frame, transparent background, no text.'),
    },
    {
        'name': 'sprite_5', 'type': 'sprite', 'transparent': True,
        'target': 'Assets/Art/Sprites/sprite_5.png',
        'prompt': ('A basalt trail tile - a square slab of dark hexagonal volcanic rock with a '
                   'thin molten seam entering at the top edge and leaving at the bottom edge. '
                   + STYLE + ' Symmetric, no facing direction. It is stretched by the engine, so '
                   'the slab edges must be uniform and the border decoration must stay inside the '
                   'margin. Palette black #0B0B0F rock, ember red #E03A12 seam, ash grey #1C1C24 '
                   'facets. Transparent background, no text. 9-slice spriteBorder {48,48,48,48}.'),
    },
    {
        'name': 'button_rect', 'type': 'sprite', 'transparent': True,
        'target': 'Assets/Art/Sprites/button_rect.png',
        'prompt': ('A wide rounded rectangular button face of polished basalt with a molten gold '
                   'rim and a soft ember glow along the bottom edge. ' + STYLE + ' Symmetric, no '
                   'facing direction, empty centre - it is a plate that text is drawn on top of, '
                   'so no glyph, no icon and no text inside it. Palette surface #1C1C24, molten '
                   'gold #D4AF37 rim, ember glow #FF7A2A. Transparent background. 9-slice '
                   'spriteBorder {56,40,56,40}.'),
    },
    {
        'name': 'button_round', 'type': 'sprite', 'transparent': True,
        'target': 'Assets/Art/Sprites/button_round.png',
        'prompt': ('A circular button face of polished basalt with a molten gold rim and an inner '
                   'ember glow. ' + STYLE + ' Symmetric, no facing direction, empty centre - a '
                   'plate that a glyph is drawn on top of, so no icon and no text inside it. '
                   'Palette surface #1C1C24, molten gold #D4AF37 rim, ember glow #FF7A2A. '
                   'Transparent background. 9-slice spriteBorder {40,40,40,40}.'),
    },
]

json.dump({'assets': entries}, open('assets.json', 'w', encoding='utf-8'), indent=2)
print('assets.json:', len(entries), 'entries')

using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The UGUI building blocks this game draws itself with. Creation order IS draw order
/// (C.13): a frame is always made BEFORE the content it surrounds, a caption always AFTER
/// the plate it sits on.
/// Every label here is created to the C.10/C.12 contract - wrapping off, autosize on,
/// fontSizeMin at the 24 readability floor, line breaks only where the caller typed a \n.
/// </summary>
public static class _0xa9abda03
{
    /// <summary>A plate that fills its parent.</summary>
    /// <summary>
    /// Makes a fully transparent Image usable as a hit area. Unity's "Cull Transparent Mesh" is
    /// ON by default and drops the mesh of a graphic whose alpha is 0 - and a dropped mesh is
    /// never raycast against, so the control is silently dead. Nothing in a compile, a wiring
    /// check or a layout gate sees it: the Button exists, the listener is attached, the rect is
    /// right, and the tap does nothing. Every transparent raycast target goes through here.
    /// </summary>
    public static void KeepHittable(Image _0x335ec170)
    {
        if (_0x335ec170 == null)
            return;
        _0x335ec170.raycastTarget = true;
        CanvasRenderer _0x9a1a128c = _0x335ec170.GetComponent<CanvasRenderer>();
        if (_0x9a1a128c != null)
            _0x9a1a128c.cullTransparentMesh = false;
    }

    /// <summary>
    /// A cross drawn from two rotated 9-slice bars. The template leaves the popup close
    /// Image with no sprite, which Unity paints as a solid WHITE square (B.1/C.3) - this is
    /// the replacement, and it never depends on art that might not exist.
    /// </summary>
    public static void Cross(Transform _0xf0848d0d, Sprite _0xc875e95c, float _0xcbce8dd9, float _0x7f16b983, Color _0x2da574ce)
    {
        RectTransform _0x29e927e1 = Node(_0xf0848d0d, _0x12e72f00._0x8a1706d8(new byte[6] { 227, 242, 239, 243, 243, 193 }, 128), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(_0xcbce8dd9, _0x7f16b983));
        Image _0xe3b2c55a = _0x29e927e1.gameObject.AddComponent<Image>();
        _0xe3b2c55a.sprite = _0xc875e95c;
        _0xe3b2c55a.type = Image.Type.Sliced; // a 9-slice plate, never aspect-preserved
        _0xe3b2c55a.color = _0x2da574ce;
        Slice(_0xe3b2c55a, 2.5f);
        _0xe3b2c55a.raycastTarget = false;
        _0x29e927e1.localRotation = Quaternion.Euler(0f, 0f, 45f);
        RectTransform _0xc86263ee = Node(_0xf0848d0d, _0x12e72f00._0x8a1706d8(new byte[6] { 42, 59, 38, 58, 58, 11 }, 73), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(_0xcbce8dd9, _0x7f16b983));
        Image _0xaee899d1 = _0xc86263ee.gameObject.AddComponent<Image>();
        _0xaee899d1.sprite = _0xc875e95c;
        _0xaee899d1.type = Image.Type.Sliced; // a 9-slice plate, never aspect-preserved
        _0xaee899d1.color = _0x2da574ce;
        Slice(_0xaee899d1, 2.5f);
        _0xaee899d1.raycastTarget = false;
        _0xc86263ee.localRotation = Quaternion.Euler(0f, 0f, -45f);
    }

    /// <summary>
    /// A button: plate, optional icon, caption LAST so the label is on top of its own face
    /// (E.1). The caller wires it with a lambda (C.1) - never a method group.
    /// </summary>
    public static Button Cta(Transform _0xf788d170, string _0x6d4e9cd6, _0x4831bce5 _0x27fa3a51, string _0xc4b4576b, float _0xa873fd7b, Vector2 _0xa2b079cd, Vector2 _0xf2cbcd8d, Vector2 _0xc0630c58, Color _0x22caf41e, Color _0xadab9d3c, Color _0x26dc5496, float _0x93182e47)
    {
        RectTransform _0x6c8d6b94 = Node(_0xf788d170, _0x6d4e9cd6, _0xa2b079cd, _0xf2cbcd8d, _0xc0630c58);
        Image _0xb8b8d7f7 = _0x6c8d6b94.gameObject.AddComponent<Image>();
        _0xb8b8d7f7.sprite = _0x27fa3a51._0x6b00fe61;
        _0xb8b8d7f7.type = Image.Type.Sliced; // a 9-slice plate, never aspect-preserved
        Slice(_0xb8b8d7f7, _0x93182e47);
        _0xb8b8d7f7.color = new Color(1f, 1f, 1f, 0f);
        KeepHittable(_0xb8b8d7f7);
        PlateFill(_0x6c8d6b94, _0x12e72f00._0x8a1706d8(new byte[6] { 18, 9, 0, 5, 14, 22 }, 97), _0x27fa3a51._0x6b00fe61, _0x82ba3493.Fade(_0x82ba3493.Ink, 0.55f), -7f, _0x93182e47);
        PlateFill(_0x6c8d6b94, _0x12e72f00._0x8a1706d8(new byte[6] { 180, 185, 164, 178, 179, 164 }, 214), _0x27fa3a51._0x6b00fe61, _0xadab9d3c, 0f, _0x93182e47);
        Image _0x63b383e7 = PlateFill(_0x6c8d6b94, _0x12e72f00._0x8a1706d8(new byte[4] { 167, 160, 162, 164 }, 193), _0x27fa3a51._0x6b00fe61, _0x22caf41e, 3f, _0x93182e47);
        PlateFill(_0x6c8d6b94, _0x12e72f00._0x8a1706d8(new byte[4] { 62, 53, 54, 46 }, 89), _0x27fa3a51._0x6b00fe61, _0x82ba3493.Fade(_0x82ba3493.EmberGlow, 0.14f), 3f, _0x93182e47);
        if (!string.IsNullOrEmpty(_0xc4b4576b))
        {
            Label(_0x6c8d6b94, _0x12e72f00._0x8a1706d8(new byte[7] { 78, 76, 93, 89, 68, 66, 67 }, 45), _0x27fa3a51._0xb210014d, _0xc4b4576b, _0xa873fd7b, _0x26dc5496, TextAlignmentOptions.Center, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(_0xc0630c58.x - 40f, _0xc0630c58.y - 24f));
        }

        Button _0x30b5e256 = _0x6c8d6b94.gameObject.AddComponent<Button>();
        // The tint target is the VISIBLE face, not the transparent hit plate: the ColorBlock
        // multiplies through the CanvasRenderer, so tinting an alpha-0 graphic shows nothing and
        // the button looks unresponsive. Multiplying around white keeps the face's palette
        // colour, and a later runtime recolour of that face survives the press states.
        _0x30b5e256.targetGraphic = _0x63b383e7;
        ColorBlock _0x3cd6fd00 = _0x30b5e256.colors;
        _0x3cd6fd00.normalColor = Color.white;
        _0x3cd6fd00.highlightedColor = new Color(1.12f, 1.08f, 1f, 1f);
        _0x3cd6fd00.pressedColor = new Color(0.72f, 0.66f, 0.62f, 1f);
        _0x3cd6fd00.selectedColor = Color.white;
        _0x3cd6fd00.disabledColor = new Color(0.55f, 0.55f, 0.55f, 0.6f);
        _0x3cd6fd00.fadeDuration = 0.08f;
        _0x30b5e256.colors = _0x3cd6fd00;
        return _0x30b5e256;
    }

    /// <summary>A round icon button - face plate, then the glyph on top, no caption inside.</summary>
    public static Button IconButton(Transform _0x63b63b1c, string _0xe3b9ca9e, _0x4831bce5 _0x9a5fae12, Sprite _0xeddb3221, Vector2 _0xc47d20d1, Vector2 _0x89230642, float _0xeb7d3a02, Color _0xc23d6035, Color _0xb362e452)
    {
        Button _0x6e0b57b1 = Cta(_0x63b63b1c, _0xe3b9ca9e, _0x9a5fae12, string.Empty, 32f, _0xc47d20d1, _0x89230642, new Vector2(_0xeb7d3a02, _0xeb7d3a02), _0xc23d6035, _0xb362e452, _0x82ba3493.TextPrimary, 0.22f);
        if (_0xeddb3221 != null)
        {
            RectTransform _0x46714e8c = Node(_0x6e0b57b1.transform, _0x12e72f00._0x8a1706d8(new byte[5] { 77, 70, 83, 90, 66 }, 42), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(_0xeb7d3a02 * 0.56f, _0xeb7d3a02 * 0.56f));
            Image _0xedc96a52 = _0x46714e8c.gameObject.AddComponent<Image>();
            _0xedc96a52.sprite = _0xeddb3221;
            _0xedc96a52.color = Color.white;
            _0xedc96a52.preserveAspect = true;
            _0xedc96a52.raycastTarget = false;
        }

        return _0x6e0b57b1;
    }

    /// <summary>The same card, handing back both the border and the body fill.</summary>
    public static RectTransform Card(Transform _0x16e57986, string _0xbb5365bf, Sprite _0x688eec65, Vector2 _0xb0f2b59d, Vector2 _0x6d1e0d04, Vector2 _0x59599275, Color _0x9ac00e7f, Color _0xa2403050, float _0xc161d792, out Image _0x2e1e0662, out Image _0x342b3272)
    {
        RectTransform _0x0ce73aaf = Node(_0x16e57986, _0xbb5365bf, _0xb0f2b59d, _0x6d1e0d04, _0x59599275);
        PlateFill(_0x0ce73aaf, _0x12e72f00._0x8a1706d8(new byte[6] { 171, 176, 185, 188, 183, 175 }, 216), _0x688eec65, _0x82ba3493.Fade(_0x82ba3493.Ink, 0.55f), -8f, _0xc161d792);
        _0x2e1e0662 = PlateFill(_0x0ce73aaf, _0x12e72f00._0x8a1706d8(new byte[6] { 130, 143, 146, 132, 133, 146 }, 224), _0x688eec65, _0xa2403050, 0f, _0xc161d792);
        _0x342b3272 = PlateFill(_0x0ce73aaf, _0x12e72f00._0x8a1706d8(new byte[4] { 197, 200, 195, 222 }, 167), _0x688eec65, _0x9ac00e7f, 3f, _0xc161d792);
        PlateFill(_0x0ce73aaf, _0x12e72f00._0x8a1706d8(new byte[5] { 209, 202, 199, 199, 204 }, 162), _0x688eec65, _0x82ba3493.Fade(_0x82ba3493.Gold, 0.07f), 3f, _0xc161d792);
        return _0x0ce73aaf;
    }

    /// <summary>A 9-sliced plate. roundness: lower = rounder corners.</summary>
    public static Image Plate(Transform _0x1596882d, string _0xe8e191da, Sprite _0x32b4e854, Color _0x53a777e1, Vector2 _0x0431f176, Vector2 _0x8ec70991, Vector2 _0xc4454942, float _0x9dad750f)
    {
        RectTransform _0x55bd874b = Node(_0x1596882d, _0xe8e191da, _0x0431f176, _0x8ec70991, _0xc4454942);
        Image _0x5f6967d6 = _0x55bd874b.gameObject.AddComponent<Image>();
        _0x5f6967d6.sprite = _0x32b4e854;
        _0x5f6967d6.type = Image.Type.Sliced; // a 9-slice plate, never aspect-preserved
        _0x5f6967d6.color = _0x53a777e1;
        Slice(_0x5f6967d6, _0x9dad750f);
        _0x5f6967d6.raycastTarget = false;
        return _0x5f6967d6;
    }

    /// <summary>An invisible button that covers a whole row or tile - no plates, just the hit area.</summary>
    public static Button HitButton(Transform _0xef725f1b, string _0xa38c638e, Sprite _0x6b698473, Vector2 _0x3ebb4b92)
    {
        return HitButton(_0xef725f1b, _0xa38c638e, _0x6b698473, new Vector2(0.5f, 0.5f), Vector2.zero, _0x3ebb4b92);
    }

    /// <summary>The same card, handing back its border layer so the caller can light it.</summary>
    public static RectTransform Card(Transform _0xfde46570, string _0x6d3f05e9, Sprite _0xafca4189, Vector2 _0x4acf516f, Vector2 _0xa1439751, Vector2 _0xd60e7b3b, Color _0x97c189a7, Color _0xfea6314d, float _0x2df8a3ae, out Image _0x3467b4c3)
    {
        Image _0x0a08fd1a;
        return Card(_0xfde46570, _0x6d3f05e9, _0xafca4189, _0x4acf516f, _0xa1439751, _0xd60e7b3b, _0x97c189a7, _0xfea6314d, _0x2df8a3ae, out _0x3467b4c3, out _0x0a08fd1a);
    }

    /// <summary>
    /// A themed card: shadow, body, border, inner sheen - frame first, so whatever the caller
    /// adds next lands on top of it (C.13/C.63). Returns the rect to put content into.
    /// </summary>
    public static RectTransform Card(Transform _0x87712701, string _0xd7d4936d, Sprite _0xfa2b4106, Vector2 _0x12d7651e, Vector2 _0x19545660, Vector2 _0x8289025b, Color _0xb280e741, Color _0x0b9a3253, float _0xfac97c22)
    {
        Image _0xeccc2109;
        Image _0x7e6e7aa4;
        return Card(_0x87712701, _0xd7d4936d, _0xfa2b4106, _0x12d7651e, _0x19545660, _0x8289025b, _0xb280e741, _0x0b9a3253, _0xfac97c22, out _0xeccc2109, out _0x7e6e7aa4);
    }

    /// <summary>The themed empty-state line every list shows when it has nothing in it (G.2).</summary>
    public static void EmptyState(Transform _0xa2c7722e, TMP_FontAsset _0xda47075a, string _0xb5f92db1)
    {
        Label(_0xa2c7722e, _0x12e72f00._0x8a1706d8(new byte[10] { 194, 202, 215, 211, 222, 244, 211, 198, 211, 194 }, 167), _0xda47075a, _0xb5f92db1, 34f, _0x82ba3493.TextMuted, TextAlignmentOptions.Center, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(900f, 140f));
    }

    /// <summary>A TMP label built to the C.10 / C.12 contract.</summary>
    public static TextMeshProUGUI Label(Transform _0xfbaa169c, string _0xb79ef3e8, TMP_FontAsset _0x491204bf, string _0xb290e474, float _0x16fef8fc, Color _0xbee8c9ab, TextAlignmentOptions _0x0f9d20f5, Vector2 _0x94987380, Vector2 _0xad52d925, Vector2 _0x3f1c0ecb)
    {
        RectTransform _0x279852cb = Node(_0xfbaa169c, _0xb79ef3e8, _0x94987380, _0xad52d925, _0x3f1c0ecb);
        TextMeshProUGUI _0x14d491d2 = _0x279852cb.gameObject.AddComponent<TextMeshProUGUI>();
        if (_0x491204bf != null)
            _0x14d491d2.font = _0x491204bf;
        _0x14d491d2.text = _0xb290e474;
        _0x14d491d2.color = _0xbee8c9ab;
        _0x14d491d2.alignment = _0x0f9d20f5;
        _0x14d491d2.raycastTarget = false;
        _0x14d491d2.textWrappingMode = TextWrappingModes.NoWrap;
        _0x14d491d2.overflowMode = TextOverflowModes.Overflow;
        _0x14d491d2.enableAutoSizing = true;
        _0x14d491d2.fontSizeMin = 24f;
        _0x14d491d2.fontSizeMax = _0x16fef8fc;
        _0x14d491d2.fontSize = _0x16fef8fc;
        _0xfa2169a3.ApplyOutline(_0x14d491d2);
        return _0x14d491d2;
    }

    /// <summary>
    /// Gives a 9-sliced Image a multiplier that can never be wider than the rect it is drawn
    /// into. <paramref name = "roundness"/> is only the FLOOR - see PlateRound. Every plate in
    /// this kit goes through here, so no caller can pick a literal that slivers a small plate.
    /// </summary>
    public static void Slice(Image _0xba63b086, float _0x7dd45b92)
    {
        if (_0xba63b086 == null)
            return;
        _0xba63b086.type = Image.Type.Sliced;
        _0xba63b086.pixelsPerUnitMultiplier = Mathf.Max(0.05f, _0x7dd45b92);
        _0x0ad0d1fe _0xfd10c793 = _0xba63b086.gameObject.GetComponent<_0x0ad0d1fe>();
        if (_0xfd10c793 == null)
            _0xfd10c793 = _0xba63b086.gameObject.AddComponent<_0x0ad0d1fe>();
        _0xfd10c793._0xaa77dc98(_0xba63b086, _0x7dd45b92);
    }

    /// <summary>Sets a bar built by <see cref = "Bar"/> to a 0..1 ratio.</summary>
    public static void SetBar(RectTransform _0xd06867e3, float _0x808fc6db, float _0x19e07f20)
    {
        if (_0xd06867e3 == null)
            return;
        float _0x196e4d83 = Mathf.Max(6f, (_0x808fc6db - 8f) * Mathf.Clamp01(_0x19e07f20));
        _0xd06867e3.sizeDelta = new Vector2(_0x196e4d83, _0xd06867e3.sizeDelta.y);
    }

    /// <summary>
    /// A vertical band between two edge offsets: the top cluster and the bottom cluster keep
    /// their pixel heights on every screen shape and the band in the middle absorbs the rest.
    /// </summary>
    public static RectTransform Band(Transform _0x46cc8076, string _0x6d011210, float _0xd6e6b5f1, float _0xec29e2b1, float width)
    {
        GameObject _0x40206308 = new GameObject(_0x6d011210, typeof(RectTransform));
        RectTransform _0x804ee548 = _0x40206308.GetComponent<RectTransform>();
        _0x804ee548.SetParent(_0x46cc8076, false);
        _0x804ee548.anchorMin = new Vector2(0.5f, 0f);
        _0x804ee548.anchorMax = new Vector2(0.5f, 1f);
        _0x804ee548.pivot = new Vector2(0.5f, 0.5f);
        _0x804ee548.anchoredPosition = new Vector2(0f, (_0xd6e6b5f1 - _0xec29e2b1) * 0.5f);
        _0x804ee548.sizeDelta = new Vector2(width, -(_0xd6e6b5f1 + _0xec29e2b1));
        _0x804ee548.localScale = Vector3.one;
        return _0x804ee548;
    }

    /// <summary>A bare rect anchored to a point, sized in canvas units.</summary>
    public static RectTransform Node(Transform _0x73598ad3, string _0x9a3acb1e, Vector2 _0xa7368299, Vector2 _0xa259291d, Vector2 _0xac515977)
    {
        GameObject _0xa455180e = new GameObject(_0x9a3acb1e, typeof(RectTransform));
        RectTransform _0x6dffee5f = _0xa455180e.GetComponent<RectTransform>();
        _0x6dffee5f.SetParent(_0x73598ad3, false);
        _0x6dffee5f.anchorMin = _0xa7368299;
        _0x6dffee5f.anchorMax = _0xa7368299;
        _0x6dffee5f.pivot = new Vector2(0.5f, 0.5f);
        _0x6dffee5f.anchoredPosition = _0xa259291d;
        _0x6dffee5f.sizeDelta = _0xac515977;
        _0x6dffee5f.localScale = Vector3.one;
        return _0x6dffee5f;
    }

    /// <summary>
    /// A screen backdrop: a fade over the scene background plus an ember glow from below, so
    /// no screen is ever a flat single colour and every one has three depth layers.
    /// </summary>
    public static void Backdrop(Transform _0x20c0639b, _0x4831bce5 _0xd6d38c21, float _0x657521d0)
    {
        RectTransform _0xb7a4963c = Stretch(_0x20c0639b, _0x12e72f00._0x8a1706d8(new byte[8] { 190, 189, 191, 183, 184, 174, 179, 172 }, 220), 0f);
        _0xb7a4963c.SetAsFirstSibling();
        Image _0x60d7c975 = _0xb7a4963c.gameObject.AddComponent<Image>();
        _0x60d7c975.sprite = _0xd6d38c21._0x6b00fe61;
        _0x60d7c975.type = Image.Type.Sliced; // a 9-slice plate, never aspect-preserved
        Slice(_0x60d7c975, 1f);
        _0x60d7c975.color = _0x82ba3493.Fade(_0x82ba3493.Ink, _0x657521d0);
        _0x60d7c975.raycastTarget = false;
        Plate(_0xb7a4963c, _0x12e72f00._0x8a1706d8(new byte[9] { 170, 162, 173, 170, 189, 157, 166, 188, 170 }, 207), _0xd6d38c21._0x6b00fe61, _0x82ba3493.Fade(_0x82ba3493.EmberGlow, 0.10f), new Vector2(0.5f, 0f), new Vector2(0f, 300f), new Vector2(1240f, 820f), 0.7f);
    }

    /// <summary>A chevron pointing left, drawn from two rotated bars (no arrow glyph, C.15).</summary>
    public static void Chevron(Transform _0x9848bf1a, Sprite _0xc9318f16, float _0x39387419, float _0x6a8d3d2e, Color _0xf33ea696)
    {
        RectTransform _0x06f6a5f4 = Node(_0x9848bf1a, _0x12e72f00._0x8a1706d8(new byte[4] { 115, 96, 127, 83 }, 18), new Vector2(0.5f, 0.5f), new Vector2(0f, _0x39387419 * 0.35f), new Vector2(_0x39387419, _0x6a8d3d2e));
        Image _0x60f90f4d = _0x06f6a5f4.gameObject.AddComponent<Image>();
        _0x60f90f4d.sprite = _0xc9318f16;
        _0x60f90f4d.type = Image.Type.Sliced; // a 9-slice plate, never aspect-preserved
        _0x60f90f4d.color = _0xf33ea696;
        Slice(_0x60f90f4d, 2.5f);
        _0x60f90f4d.raycastTarget = false;
        _0x06f6a5f4.localRotation = Quaternion.Euler(0f, 0f, 45f);
        RectTransform _0x15ca0e08 = Node(_0x9848bf1a, _0x12e72f00._0x8a1706d8(new byte[4] { 75, 88, 71, 104 }, 42), new Vector2(0.5f, 0.5f), new Vector2(0f, -_0x39387419 * 0.35f), new Vector2(_0x39387419, _0x6a8d3d2e));
        Image _0x1fcd5d67 = _0x15ca0e08.gameObject.AddComponent<Image>();
        _0x1fcd5d67.sprite = _0xc9318f16;
        _0x1fcd5d67.type = Image.Type.Sliced; // a 9-slice plate, never aspect-preserved
        _0x1fcd5d67.color = _0xf33ea696;
        Slice(_0x1fcd5d67, 2.5f);
        _0x1fcd5d67.raycastTarget = false;
        _0x15ca0e08.localRotation = Quaternion.Euler(0f, 0f, -45f);
    }

    public static Image PlateFill(Transform _0x77b4753d, string _0x93adc56c, Sprite _0xae5daece, Color _0x74d7044e, float _0x04c85388, float _0x90d313dd)
    {
        RectTransform _0xdd9e64c4 = Stretch(_0x77b4753d, _0x93adc56c, _0x04c85388);
        Image _0x487e068d = _0xdd9e64c4.gameObject.AddComponent<Image>();
        _0x487e068d.sprite = _0xae5daece;
        _0x487e068d.type = Image.Type.Sliced; // a 9-slice plate, never aspect-preserved
        _0x487e068d.color = _0x74d7044e;
        Slice(_0x487e068d, _0x90d313dd);
        _0x487e068d.raycastTarget = false;
        return _0x487e068d;
    }

    /// <summary>A bar: dark track, then the fill on top of it. Returns the fill rect.</summary>
    public static RectTransform Bar(Transform _0x06279bd2, string _0x0f2f3f7d, Sprite _0x0c3a2ba7, Vector2 _0x54d92565, Vector2 _0x2859fd12, Vector2 _0x1fbf5228, Color _0x1723049d, Color _0x64bf7fa5, float _0x3665489c)
    {
        RectTransform _0x5a2ea4cc = Node(_0x06279bd2, _0x0f2f3f7d, _0x54d92565, _0x2859fd12, _0x1fbf5228);
        PlateFill(_0x5a2ea4cc, _0x12e72f00._0x8a1706d8(new byte[5] { 17, 23, 4, 6, 14 }, 101), _0x0c3a2ba7, _0x1723049d, 0f, _0x3665489c);
        RectTransform _0xb015ccf7 = Node(_0x5a2ea4cc, _0x12e72f00._0x8a1706d8(new byte[4] { 196, 203, 206, 206 }, 162), new Vector2(0f, 0.5f), new Vector2(4f, 0f), new Vector2(_0x1fbf5228.x - 8f, _0x1fbf5228.y - 8f));
        _0xb015ccf7.pivot = new Vector2(0f, 0.5f);
        Image _0x80e4eb5c = _0xb015ccf7.gameObject.AddComponent<Image>();
        _0x80e4eb5c.sprite = _0x0c3a2ba7;
        _0x80e4eb5c.color = _0x64bf7fa5;
        Slice(_0x80e4eb5c, _0x3665489c);
        _0x80e4eb5c.raycastTarget = false;
        return _0xb015ccf7;
    }

    /// <summary>The same hit area, placed explicitly.</summary>
    public static Button HitButton(Transform _0xec9a9e7e, string _0xc0aa4566, Sprite _0xe9b1eb13, Vector2 _0x2d81df19, Vector2 _0x3f9437d2, Vector2 _0xd3614687)
    {
        RectTransform _0x1d8491db = Node(_0xec9a9e7e, _0xc0aa4566, _0x2d81df19, _0x3f9437d2, _0xd3614687);
        Image _0x4024df97 = _0x1d8491db.gameObject.AddComponent<Image>();
        _0x4024df97.sprite = _0xe9b1eb13;
        _0x4024df97.type = Image.Type.Sliced; // a 9-slice plate, never aspect-preserved
        Slice(_0x4024df97, 2f);
        _0x4024df97.color = new Color(1f, 1f, 1f, 0f);
        KeepHittable(_0x4024df97);
        Button _0x9b0d6ccf = _0x1d8491db.gameObject.AddComponent<Button>();
        _0x9b0d6ccf.targetGraphic = _0x4024df97;
        ColorBlock _0x53e3da95 = _0x9b0d6ccf.colors;
        _0x53e3da95.normalColor = new Color(1f, 1f, 1f, 0f);
        _0x53e3da95.highlightedColor = _0x82ba3493.Fade(_0x82ba3493.GoldLight, 0.12f);
        _0x53e3da95.pressedColor = _0x82ba3493.Fade(_0x82ba3493.EmberGlow, 0.30f);
        _0x53e3da95.selectedColor = new Color(1f, 1f, 1f, 0f);
        _0x53e3da95.disabledColor = _0x82ba3493.Fade(_0x82ba3493.TextMuted, 0.25f);
        _0x53e3da95.fadeDuration = 0.08f;
        _0x9b0d6ccf.colors = _0x53e3da95;
        return _0x9b0d6ccf;
    }

    /// <summary>
    /// A sub-view header: back chevron on the left, title centred. Returns the back button so
    /// the view wires it with its own lambda (C.1).
    /// </summary>
    public static Button Header(Transform _0x2cd022ec, _0x4831bce5 _0xfd47dd04, string _0xda313cb1)
    {
        Button _0xf7202e2e = Cta(_0x2cd022ec, _0x12e72f00._0x8a1706d8(new byte[4] { 148, 151, 149, 157 }, 246), _0xfd47dd04, string.Empty, 32f, new Vector2(0.5f, 1f), new Vector2(-470f, -108f), new Vector2(104f, 104f), _0x82ba3493.Fade(_0x82ba3493.SurfaceAlt, 0.95f), _0x82ba3493.Fade(_0x82ba3493.Gold, 0.55f), _0x82ba3493.TextPrimary, 0.9f);
        Chevron(_0xf7202e2e.transform, _0xfd47dd04._0x6b00fe61, 44f, 12f, _0x82ba3493.GoldLight);
        Label(_0x2cd022ec, _0x12e72f00._0x8a1706d8(new byte[5] { 178, 175, 178, 170, 163 }, 198), _0xfd47dd04._0xb210014d, _0xda313cb1, 60f, _0x82ba3493.TextPrimary, TextAlignmentOptions.Center, new Vector2(0.5f, 1f), new Vector2(30f, -108f), new Vector2(760f, 92f));
        Plate(_0x2cd022ec, _0x12e72f00._0x8a1706d8(new byte[9] { 0, 29, 0, 24, 17, 38, 1, 24, 17 }, 116), _0xfd47dd04._0x6b00fe61, _0x82ba3493.Fade(_0x82ba3493.Ember, 0.65f), new Vector2(0.5f, 1f), new Vector2(0f, -182f), new Vector2(1040f, 5f), 1.2f);
        return _0xf7202e2e;
    }

    /// <summary>A small accent dot - the semantics carrier on stat cards, never a raster icon.</summary>
    public static Image Dot(Transform _0xa61bd49a, Sprite _0x5d2e9269, Vector2 _0x9f5d380e, Vector2 _0x01f43b92, float _0x31847297, Color _0x6cfc5c98)
    {
        return Plate(_0xa61bd49a, _0x12e72f00._0x8a1706d8(new byte[3] { 105, 98, 121 }, 13), _0x5d2e9269, _0x6cfc5c98, _0x9f5d380e, _0x01f43b92, new Vector2(_0x31847297, _0x31847297), 0.18f);
    }

    /// <summary>A rect that fills its parent, optionally inset on every side.</summary>
    public static RectTransform Stretch(Transform _0x4680dda9, string _0x3d990a1b, float _0x965e7d1c)
    {
        GameObject _0xc2ed4ca7 = new GameObject(_0x3d990a1b, typeof(RectTransform));
        RectTransform _0x1069a125 = _0xc2ed4ca7.GetComponent<RectTransform>();
        _0x1069a125.SetParent(_0x4680dda9, false);
        _0x1069a125.anchorMin = Vector2.zero;
        _0x1069a125.anchorMax = Vector2.one;
        _0x1069a125.pivot = new Vector2(0.5f, 0.5f);
        _0x1069a125.offsetMin = new Vector2(_0x965e7d1c, _0x965e7d1c);
        _0x1069a125.offsetMax = new Vector2(-_0x965e7d1c, -_0x965e7d1c);
        _0x1069a125.localScale = Vector3.one;
        return _0x1069a125;
    }
}

internal static class _0x12e72f00
{
    internal static string _0x8a1706d8(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}
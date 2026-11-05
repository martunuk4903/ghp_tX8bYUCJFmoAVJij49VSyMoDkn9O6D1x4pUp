using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Themes the splash: a darker overlay than the menu uses, the abstract ember mark, one
/// functional line, and the loading bar in the palette.
///
/// C.69 / C.64: this NEVER moves the menu off the splash. There is no timer here, no
/// watchdog, no SwitchSplash, no panel change, and the splash object's own active state,
/// alpha and scale are left exactly as the template set them. The template owns the
/// hand-off; all this does is paint.
/// C.68: the loading bar's rects are not touched at all - no fillRect.parent anywhere - so
/// the fill keeps whatever room the template and stage 5d2c give it.
/// </summary>
public sealed class _0xc8c98db1 : MonoBehaviour
{
    public void _0x248eb4ff(_0xd75e45b3 _0x93428817, _0x4831bce5 _0xdec346ea)
    {
        if (_0x93428817 == null || _0x93428817.Content == null || _0xdec346ea == null)
            return;
        RectTransform _0x8b491eb9 = _0x93428817.Content.transform as RectTransform;
        if (_0x8b491eb9 == null)
            return;
        // Our decoration goes UNDER the template's own content, so the loading bar it ships
        // keeps drawing on top of us.
        RectTransform _0x4ec5d6ef = _0xa9abda03.Stretch(_0x8b491eb9, _0xad151da5._0xa6ad503d(new byte[15] { 98, 100, 119, 127, 122, 69, 102, 122, 119, 101, 126, 84, 119, 117, 125 }, 22), 0f);
        _0x4ec5d6ef.SetAsFirstSibling();
        // A heavier overlay than the menu's 0.30, so splash and menu never read as one frame.
        Image _0xfc250d0d = _0x4ec5d6ef.gameObject.AddComponent<Image>();
        _0xfc250d0d.sprite = _0xdec346ea._0x6b00fe61;
        _0xfc250d0d.type = Image.Type.Sliced; // a 9-slice plate, never aspect-preserved
        _0xa9abda03.Slice(_0xfc250d0d, 1f);
        _0xfc250d0d.color = _0x82ba3493.Fade(_0x82ba3493.Ink, 0.62f);
        _0xfc250d0d.raycastTarget = false;
        _0xa9abda03.Plate(_0x4ec5d6ef, _0xad151da5._0xa6ad503d(new byte[9] { 27, 19, 28, 27, 12, 46, 17, 17, 18 }, 126), _0xdec346ea._0x6b00fe61, _0x82ba3493.Fade(_0x82ba3493.Ember, 0.16f), new Vector2(0.5f, 0f), new Vector2(0f, 240f), new Vector2(1180f, 640f), 0.8f);
        RectTransform _0x0d45c276 = _0xa9abda03.Node(_0x4ec5d6ef, _0xad151da5._0xa6ad503d(new byte[4] { 100, 104, 123, 98 }, 9), new Vector2(0.5f, 0.5f), new Vector2(0f, 260f), new Vector2(420f, 420f));
        _0xa9abda03.PlateFill(_0x0d45c276, _0xad151da5._0xa6ad503d(new byte[8] { 4, 8, 27, 2, 46, 5, 6, 30 }, 105), _0xdec346ea._0x6b00fe61, _0x82ba3493.Fade(_0x82ba3493.EmberGlow, 0.14f), -40f, 0.2f);
        Image _0x07da9f86 = _0x0d45c276.gameObject.AddComponent<Image>();
        _0x07da9f86.sprite = _0xdec346ea._0x4f9e69a6;
        _0x07da9f86.color = Color.white;
        _0x07da9f86.preserveAspect = true;
        _0x07da9f86.raycastTarget = false;
        TextMeshProUGUI _0x14845622 = _0xa9abda03.Label(_0x4ec5d6ef, _0xad151da5._0xa6ad503d(new byte[10] { 163, 160, 188, 177, 163, 184, 156, 185, 190, 181 }, 208), _0xdec346ea._0xb210014d, _0xad151da5._0xa6ad503d(new byte[19] { 238, 236, 251, 238, 255, 236, 247, 240, 249, 158, 234, 246, 251, 158, 234, 236, 255, 247, 242 }, 190), 36f, _0x82ba3493.TextMuted, TextAlignmentOptions.Center, new Vector2(0.5f, 0.5f), new Vector2(0f, -40f), new Vector2(900f, 90f));
        _0x14845622.characterSpacing = 12f;
        _0x0d45c276.DOScale(1.04f, 1.6f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine).SetLink(_0x0d45c276.gameObject);
        this._0x96e1d244(_0x93428817, _0xdec346ea);
    }

    /// <summary>
    /// Colour only. The bar's geometry belongs to the template and to stage 5d2c; we never
    /// re-anchor the fill area, so a thick frame can never swallow the fill.
    /// </summary>
    private void _0x96e1d244(_0xd75e45b3 _0x502c307b, _0x4831bce5 _0x00d12ef9)
    {
        Slider _0xd6e50523 = _0x502c307b.GetComponentInChildren<Slider>(true);
        if (_0xd6e50523 == null)
            return;
        if (_0xd6e50523.fillRect != null)
        {
            Image _0x5b6fd018 = _0xd6e50523.fillRect.GetComponent<Image>();
            if (_0x5b6fd018 != null)
            {
                _0x5b6fd018.sprite = _0x00d12ef9._0x6b00fe61;
                _0x5b6fd018.type = Image.Type.Sliced; // a 9-slice plate, never aspect-preserved
                // The bar is short, and sliced_solid_round carries a 127 px border: a fixed
                // multiplier would make the border wider than the fill and draw a sliver in a
                // gold frame, which is the ANDROID-4041 failure. PlateRound measures the rect
                // the fill really gets and keeps a real middle in it.
                _0xa9abda03.Slice(_0x5b6fd018, 2f);
                _0x5b6fd018.color = _0x82ba3493.EmberGlow; // opaque accent against a dark track
                _0x5b6fd018.raycastTarget = false;
            }
        }

        // The TRACK is the Image on "Fill Area", the fill's own parent. The template ships it
        // at alpha 0.004 - invisible - so without this the bar reads as an empty gold frame
        // with nothing moving in it (rule G / C.68). Its COLOUR only: the geometry of that
        // rect belongs to the template and to stage 5d2c, and an inset written from here is
        // exactly what swallowed the fill on ANDROID-4041.
        if (_0xd6e50523.fillRect != null)
        {
            RectTransform _0xe3f375cb = _0xd6e50523.fillRect.parent as RectTransform;
            if (_0xe3f375cb != null)
            {
                Image _0x76df2ba5 = _0xe3f375cb.GetComponent<Image>();
                if (_0x76df2ba5 != null)
                {
                    _0x76df2ba5.sprite = _0x00d12ef9._0x6b00fe61;
                    _0x76df2ba5.type = Image.Type.Sliced; // a 9-slice plate, never aspect-preserved
                    _0xa9abda03.Slice(_0x76df2ba5, 2f);
                    _0x76df2ba5.color = _0x82ba3493.Fade(_0x82ba3493.SurfaceAlt, 0.95f);
                    _0x76df2ba5.raycastTarget = false;
                }
            }
        }

        // Everything else: only ALREADY VISIBLE layers are recoloured. The panel's rounding
        // layers sit at alpha 1/255 on purpose - they write the stencil the visible layers
        // draw inside, and making one of them opaque would paint a slab over the fill.
        Image[] _0x1dc2d8e9 = _0xd6e50523.GetComponentsInChildren<Image>(true);
        for (int _0x7911427a = 0; _0x7911427a < _0x1dc2d8e9.Length; _0x7911427a++)
        {
            Image _0x8fd885c2 = _0x1dc2d8e9[_0x7911427a];
            if (_0x8fd885c2 == null || _0x8fd885c2.color.a < 0.2f)
                continue;
            if (_0xd6e50523.fillRect != null && _0x8fd885c2.transform.IsChildOf(_0xd6e50523.fillRect))
                continue;
            if (_0xd6e50523.handleRect != null && _0x8fd885c2.transform.IsChildOf(_0xd6e50523.handleRect))
                continue;
            if (_0xd6e50523.fillRect != null && _0x8fd885c2.transform == _0xd6e50523.fillRect.parent)
                continue;
            _0x8fd885c2.color = _0x82ba3493.Fade(_0x82ba3493.SurfaceAlt, 0.95f);
        }
    }
}

internal static class _0xad151da5
{
    internal static string _0xa6ad503d(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}
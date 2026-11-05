using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Every row here does something real. There is deliberately NO sound or music row: this
/// build ships without audio (C.20), so a speaker toggle would change nothing when tapped
/// and that is exactly the dead control C.7 forbids.
///
/// The reset confirmation is INLINE rather than a popup: in the menu scene the template's
/// pop list is empty (every entry is null), so asking PopsController for one would be a
/// null reference, not a dialog.
/// </summary>
public sealed class _0xf38bd294 : MonoBehaviour
{
    private void _0xad2ceed3()
    {
        _0x49c993d5._0x8622cacd = !_0x49c993d5._0x8622cacd;
        if (this._0xb533a679 != null)
            this._0xb533a679.color = this._0x2c6f326f(_0x49c993d5._0x8622cacd);
        if (this._0xdf79fcdf != null)
            this._0xdf79fcdf.DOAnchorPosX(this._0x827239aa(_0x49c993d5._0x8622cacd), 0.16f).SetLink(this._0xdf79fcdf.gameObject);
        if (this._0x49ab1475 != null)
        {
            this._0x49ab1475.text = this._0x57ea922c();
            this._0x49ab1475.transform.DOPunchScale(Vector3.one * 0.1f, 0.3f, 6, 0.6f).SetLink(this._0x49ab1475.gameObject);
        }
    }

    private void _0xb60773ca()
    {
        if (this._0xbec20081 == null)
            return;
        this._0xbec20081.gameObject.SetActive(true);
        this._0xbec20081.localScale = new Vector3(1f, 0.6f, 1f);
        this._0xbec20081.DOScale(1f, 0.25f).SetEase(Ease.OutBack).SetLink(this._0xbec20081.gameObject);
    }

    private RectTransform _0xbec20081;
    private void _0xa421fb7f()
    {
        _0x49c993d5.ResetAll();
        this._0xd555fc9f();
        if (this._0xb3c814c0 != null)
        {
            this._0xb3c814c0._0xeecb2631();
            this._0xb3c814c0._0x07e58f96();
        }

        if (this._0x0ea3edce != null)
            this._0x0ea3edce._0x848b1f13(_0x5681a043.ViewHome);
    }

    private TextMeshProUGUI _0x49ab1475;
    private RectTransform _0xbfd7482b;
    private Color _0x2c6f326f(bool _0x14a123e8)
    {
        return _0x14a123e8 ? _0x82ba3493.Fade(_0x82ba3493.Ember, 0.9f) : _0x82ba3493.Fade(_0x82ba3493.Ink, 0.85f);
    }

    private void OnDestroy()
    {
        if (this._0xbec20081 != null)
            DOTween.Kill(this._0xbec20081);
        if (this._0xbfd7482b != null)
            DOTween.Kill(this._0xbfd7482b);
        if (this._0xdf79fcdf != null)
            DOTween.Kill(this._0xdf79fcdf);
    }

    private void _0x9c48e437()
    {
        _0x49c993d5._0xa7ffe30d = !_0x49c993d5._0xa7ffe30d;
        if (this._0x3c720038 != null)
            this._0x3c720038.color = this._0x2c6f326f(_0x49c993d5._0xa7ffe30d);
        if (this._0xbfd7482b != null)
            this._0xbfd7482b.DOAnchorPosX(this._0x827239aa(_0x49c993d5._0xa7ffe30d), 0.16f).SetLink(this._0xbfd7482b.gameObject);
        if (_0x49c993d5._0xa7ffe30d)
            Handheld.Vibrate();
    }

    private string _0x57ea922c()
    {
        return _0x49c993d5._0x8622cacd ? _0xe9d118a5._0xb0d61db3(new byte[32] { 117, 114, 105, 7, 111, 114, 99, 29, 7, 119, 102, 114, 116, 98, 7, 107, 98, 97, 115, 7, 10, 7, 101, 102, 100, 108, 7, 117, 110, 96, 111, 115 }, 39) : _0xe9d118a5._0xb0d61db3(new byte[32] { 2, 5, 30, 112, 24, 5, 20, 106, 112, 18, 17, 19, 27, 112, 28, 21, 22, 4, 112, 125, 112, 0, 17, 5, 3, 21, 112, 2, 25, 23, 24, 4 }, 80);
    }

    private Image _0xb533a679;
    private void _0xd555fc9f()
    {
        if (this._0xbec20081 != null)
            this._0xbec20081.gameObject.SetActive(false);
    }

    private void _0x935b014c(RectTransform _0x5f518dff, float _0x4642dbb3)
    {
        RectTransform _0xfa7c0f7b = this._0x481e0a7e(_0x5f518dff, _0xe9d118a5._0xb0d61db3(new byte[14] { 164, 179, 165, 179, 162, 214, 166, 164, 185, 177, 164, 179, 165, 165 }, 246), _0xe9d118a5._0xb0d61db3(new byte[31] { 236, 243, 228, 249, 243, 229, 150, 245, 249, 255, 248, 229, 154, 150, 229, 254, 247, 228, 242, 229, 150, 247, 248, 242, 150, 229, 226, 247, 241, 243, 229 }, 182), _0x4642dbb3, _0x82ba3493.Ember);
        Button _0x0156c58b = _0xa9abda03.Cta(_0xfa7c0f7b, _0xe9d118a5._0xb0d61db3(new byte[9] { 7, 16, 6, 16, 1, 58, 5, 16, 27 }, 117), this._0x4d4d74e3, _0xe9d118a5._0xb0d61db3(new byte[5] { 211, 196, 210, 196, 213 }, 129), 30f, new Vector2(1f, 0.5f), new Vector2(-120f, 0f), new Vector2(200f, 84f), _0x82ba3493.Fade(_0x82ba3493.Ember, 0.9f), _0x82ba3493.Fade(_0x82ba3493.GoldLight, 0.8f), _0x82ba3493.TextPrimary, 1.4f);
        _0x0156c58b.onClick.AddListener(() => this._0xb60773ca());
        this._0xbec20081 = _0xa9abda03.Card(_0x5f518dff, _0xe9d118a5._0xb0d61db3(new byte[10] { 139, 135, 134, 142, 129, 154, 133, 186, 135, 159 }, 232), this._0x4d4d74e3._0x6b00fe61, new Vector2(0.5f, 1f), new Vector2(0f, _0x4642dbb3 - RowHeight - 24f), new Vector2(RowWidth, 180f), _0x82ba3493.Fade(_0x82ba3493.SurfaceWarm, 0.97f), _0x82ba3493.Fade(_0x82ba3493.Ember, 0.95f), 2.2f);
        _0xa9abda03.Label(this._0xbec20081, _0xe9d118a5._0xb0d61db3(new byte[11] { 31, 19, 18, 26, 21, 14, 17, 40, 25, 4, 8 }, 124), this._0x4d4d74e3._0xb210014d, _0xe9d118a5._0xb0d61db3(new byte[48] { 42, 54, 55, 45, 94, 61, 50, 59, 63, 44, 45, 94, 59, 40, 59, 44, 39, 42, 54, 55, 48, 57, 94, 39, 49, 43, 94, 59, 63, 44, 48, 59, 58, 80, 116, 63, 44, 59, 94, 39, 49, 43, 94, 45, 43, 44, 59, 65 }, 126), 32f, _0x82ba3493.TextPrimary, TextAlignmentOptions.Center, new Vector2(0.5f, 1f), new Vector2(0f, -56f), new Vector2(920f, 80f));
        Button _0x561b3dbc = _0xa9abda03.Cta(this._0xbec20081, _0xe9d118a5._0xb0d61db3(new byte[10] { 90, 86, 87, 95, 80, 75, 84, 96, 92, 74 }, 57), this._0x4d4d74e3, _0xe9d118a5._0xb0d61db3(new byte[9] { 96, 119, 97, 119, 102, 18, 124, 125, 101 }, 50), 30f, new Vector2(0.5f, 0f), new Vector2(-170f, 46f), new Vector2(300f, 76f), _0x82ba3493.Fade(_0x82ba3493.Ember, 0.95f), _0x82ba3493.Fade(_0x82ba3493.GoldLight, 0.8f), _0x82ba3493.TextPrimary, 1.4f);
        _0x561b3dbc.onClick.AddListener(() => this._0xa421fb7f());
        Button _0x0ec04b58 = _0xa9abda03.Cta(this._0xbec20081, _0xe9d118a5._0xb0d61db3(new byte[9] { 245, 249, 248, 240, 255, 228, 251, 216, 249 }, 150), this._0x4d4d74e3, _0xe9d118a5._0xb0d61db3(new byte[7] { 81, 95, 95, 74, 58, 83, 78 }, 26), 30f, new Vector2(0.5f, 0f), new Vector2(170f, 46f), new Vector2(300f, 76f), _0x82ba3493.Fade(_0x82ba3493.SurfaceAlt, 0.95f), _0x82ba3493.Fade(_0x82ba3493.Gold, 0.6f), _0x82ba3493.TextPrimary, 1.4f);
        _0x0ec04b58.onClick.AddListener(() => this._0xd555fc9f());
        this._0xbec20081.gameObject.SetActive(false);
    }

    private void _0xb62709df(RectTransform _0xd00f4f50, float _0xf745a03b)
    {
        RectTransform _0x6e9ba61d = this._0x481e0a7e(_0xd00f4f50, _0xe9d118a5._0xb0d61db3(new byte[7] { 143, 134, 151, 147, 142, 132, 148 }, 199), _0xe9d118a5._0xb0d61db3(new byte[31] { 20, 117, 6, 29, 26, 7, 1, 117, 23, 0, 15, 15, 117, 26, 27, 117, 16, 3, 16, 7, 12, 117, 1, 7, 20, 28, 25, 117, 29, 26, 5 }, 85), _0xf745a03b, _0x82ba3493.Gold);
        RectTransform _0xf016dd13 = _0xa9abda03.Node(_0x6e9ba61d, _0xe9d118a5._0xb0d61db3(new byte[12] { 162, 171, 186, 190, 163, 169, 185, 158, 184, 171, 169, 161 }, 202), new Vector2(1f, 0.5f), new Vector2(-120f, 0f), new Vector2(170f, 84f));
        this._0x3c720038 = _0xa9abda03.PlateFill(_0xf016dd13, _0xe9d118a5._0xb0d61db3(new byte[11] { 170, 163, 178, 182, 171, 161, 177, 132, 171, 174, 174 }, 194), this._0x4d4d74e3._0x6b00fe61, this._0x2c6f326f(_0x49c993d5._0xa7ffe30d), 0f, 0.6f);
        this._0xbfd7482b = _0xa9abda03.Plate(_0xf016dd13, _0xe9d118a5._0xb0d61db3(new byte[11] { 127, 118, 103, 99, 126, 116, 100, 92, 121, 120, 117 }, 23), this._0x4d4d74e3._0x6b00fe61, _0x82ba3493.TextPrimary, new Vector2(0.5f, 0.5f), new Vector2(this._0x827239aa(_0x49c993d5._0xa7ffe30d), 0f), new Vector2(64f, 64f), 0.2f).rectTransform;
        Button _0xedb5e053 = _0xa9abda03.HitButton(_0x6e9ba61d, _0xe9d118a5._0xb0d61db3(new byte[10] { 22, 31, 14, 10, 23, 29, 13, 42, 31, 14 }, 126), this._0x4d4d74e3._0x6b00fe61, new Vector2(RowWidth, RowHeight));
        _0xedb5e053.onClick.AddListener(() => this._0x9c48e437());
    }

    private Image _0x3c720038;
    private const float RowWidth = 1040f;
    private RectTransform _0xdf79fcdf;
    private void _0xc7fb2f95(RectTransform _0xe1bc9ed1, float _0x9bad89ca)
    {
        RectTransform _0xfa15f87f = this._0x481e0a7e(_0xe1bc9ed1, _0xe9d118a5._0xb0d61db3(new byte[18] { 23, 30, 29, 15, 118, 19, 26, 21, 31, 30, 31, 123, 23, 26, 2, 20, 14, 15 }, 91), _0xe9d118a5._0xb0d61db3(new byte[19] { 149, 145, 138, 138, 151, 138, 139, 248, 140, 144, 157, 248, 138, 141, 150, 248, 144, 141, 156 }, 216), _0x9bad89ca, _0x82ba3493.Gold);
        this._0x49ab1475 = _0xa9abda03.Label(_0xfa15f87f, _0xe9d118a5._0xb0d61db3(new byte[11] { 85, 92, 83, 89, 109, 79, 88, 75, 84, 88, 74 }, 61), this._0x4d4d74e3._0xb210014d, this._0x57ea922c(), 26f, _0x82ba3493.EmberGlow, TextAlignmentOptions.Left, new Vector2(0f, 0.5f), new Vector2(56f + 560f * 0.5f, -72f), new Vector2(560f, 38f));
        RectTransform _0x208e0f69 = _0xa9abda03.Node(_0xfa15f87f, _0xe9d118a5._0xb0d61db3(new byte[9] { 236, 229, 234, 224, 208, 246, 229, 231, 239 }, 132), new Vector2(1f, 0.5f), new Vector2(-120f, 0f), new Vector2(170f, 84f));
        this._0xb533a679 = _0xa9abda03.PlateFill(_0x208e0f69, _0xe9d118a5._0xb0d61db3(new byte[8] { 140, 133, 138, 128, 162, 141, 136, 136 }, 228), this._0x4d4d74e3._0x6b00fe61, this._0x2c6f326f(_0x49c993d5._0x8622cacd), 0f, 0.6f);
        this._0xdf79fcdf = _0xa9abda03.Plate(_0x208e0f69, _0xe9d118a5._0xb0d61db3(new byte[8] { 86, 95, 80, 90, 117, 80, 81, 92 }, 62), this._0x4d4d74e3._0x6b00fe61, _0x82ba3493.TextPrimary, new Vector2(0.5f, 0.5f), new Vector2(this._0x827239aa(_0x49c993d5._0x8622cacd), 0f), new Vector2(64f, 64f), 0.2f).rectTransform;
        Button _0x0636ed4a = _0xa9abda03.HitButton(_0xfa15f87f, _0xe9d118a5._0xb0d61db3(new byte[7] { 147, 154, 149, 159, 175, 154, 139 }, 251), this._0x4d4d74e3._0x6b00fe61, new Vector2(RowWidth, RowHeight));
        _0x0636ed4a.onClick.AddListener(() => this._0xad2ceed3());
    }

    private _0x21abdfb6 _0xb3c814c0;
    private _0x4831bce5 _0x4d4d74e3;
    private float _0x827239aa(bool _0x955ce10f)
    {
        return _0x955ce10f ? 44f : -44f;
    }

    private RectTransform _0x481e0a7e(RectTransform _0x46776a8d, string _0xe15ce465, string _0x42389d10, float _0x100337c8, Color _0x2240b36f)
    {
        RectTransform _0x88e59cba = _0xa9abda03.Card(_0x46776a8d, _0xe9d118a5._0xb0d61db3(new byte[11] { 245, 227, 242, 242, 239, 232, 225, 245, 212, 233, 241 }, 134), this._0x4d4d74e3._0x6b00fe61, new Vector2(0.5f, 1f), new Vector2(0f, _0x100337c8), new Vector2(RowWidth, RowHeight), _0x82ba3493.Fade(_0x82ba3493.Surface, 0.95f), _0x82ba3493.Fade(_0x2240b36f, 0.7f), 2.2f);
        _0xa9abda03.Label(_0x88e59cba, _0xe9d118a5._0xb0d61db3(new byte[8] { 156, 129, 153, 186, 135, 154, 130, 139 }, 238), this._0x4d4d74e3._0xb210014d, _0xe15ce465, 40f, _0x82ba3493.TextPrimary, TextAlignmentOptions.Left, new Vector2(0f, 0.5f), new Vector2(56f + 560f * 0.5f, 32f), new Vector2(560f, 52f));
        _0xa9abda03.Label(_0x88e59cba, _0xe9d118a5._0xb0d61db3(new byte[6] { 250, 231, 255, 219, 253, 234 }, 136), this._0x4d4d74e3._0xb210014d, _0x42389d10, 28f, _0x82ba3493.TextMuted, TextAlignmentOptions.Left, new Vector2(0f, 0.5f), new Vector2(56f + 560f * 0.5f, -30f), new Vector2(560f, 42f));
        return _0x88e59cba;
    }

    private _0xee14bec2 _0x0ea3edce;
    private const float RowHeight = 180f;
    public void _0x000832b1(_0x4831bce5 _0xfe942a99, _0xee14bec2 _0x4bc96c64, _0x21abdfb6 _0xb66a2aa2)
    {
        this._0x4d4d74e3 = _0xfe942a99;
        this._0x0ea3edce = _0x4bc96c64;
        this._0xb3c814c0 = _0xb66a2aa2;
        RectTransform _0x806dc903 = this.transform as RectTransform;
        _0xa9abda03.Backdrop(_0x806dc903, _0xfe942a99, 0.72f);
        Button _0xf7e1c4ff = _0xa9abda03.Header(_0x806dc903, _0xfe942a99, _0xe9d118a5._0xb0d61db3(new byte[8] { 68, 82, 67, 67, 94, 89, 80, 68 }, 23));
        _0xf7e1c4ff.onClick.AddListener(() => this._0x0ea3edce._0x848b1f13(_0x5681a043.ViewHome));
        this._0xb62709df(_0x806dc903, -330f);
        this._0xc7fb2f95(_0x806dc903, -330f - (RowHeight + 24f));
        this._0x935b014c(_0x806dc903, -330f - 2f * (RowHeight + 24f));
        _0xa9abda03.Label(_0x806dc903, _0xe9d118a5._0xb0d61db3(new byte[7] { 111, 124, 107, 106, 112, 118, 119 }, 25), _0xfe942a99._0xb210014d, _0xe9d118a5._0xb0d61db3(new byte[8] { 156, 143, 152, 153, 131, 133, 132, 234 }, 202) + Application.version, 26f, _0x82ba3493.TextMuted, TextAlignmentOptions.Center, new Vector2(0.5f, 0f), new Vector2(0f, 150f), new Vector2(700f, 44f));
    }
}

internal static class _0xe9d118a5
{
    internal static string _0xb0d61db3(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}
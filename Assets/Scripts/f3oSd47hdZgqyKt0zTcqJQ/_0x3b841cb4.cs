using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The eight stages rising up the cone. Each row keeps the pip gutter and the text column in
/// two x-bands that never overlap (C.25), and every tap is confirmed on screen (C.7): an
/// open row lights its border and the Home stage card updates, a locked row answers with an
/// inline line instead of doing nothing.
/// </summary>
public sealed class _0x3b841cb4 : MonoBehaviour
{
    private _0x21abdfb6 _0xd70cea28;
    private const float RowHeight = 180f;
    private const float GutterWidth = 42f;
    private const float TextWidth = 700f;
    private _0xee14bec2 _0xa869d9b6;
    private void _0xed159c97(int _0xfc7d15d8, bool _0xe25e563f)
    {
        if (_0xe25e563f)
        {
            if (this._0xce1239c5 != null)
            {
                this._0xce1239c5.text = _0x686b1199._0x90c037f3(new byte[12] { 21, 26, 19, 23, 4, 118, 5, 2, 23, 17, 19, 118 }, 86) + (_0x49c993d5._0xb40476b1 + 1) + _0x686b1199._0x90c037f3(new byte[8] { 94, 42, 49, 94, 49, 46, 59, 48 }, 126);
                this._0xce1239c5.transform.DOPunchScale(Vector3.one * 0.08f, 0.3f, 6, 0.6f).SetLink(this._0xce1239c5.gameObject);
            }

            return;
        }

        _0x49c993d5._0x7566d207 = _0xfc7d15d8;
        if (this._0xce1239c5 != null)
            this._0xce1239c5.text = string.Empty;
        for (int _0x61234bd2 = 0; _0x61234bd2 < this._0x0fdfce80.Count; _0x61234bd2++)
        {
            if (this._0x0fdfce80[_0x61234bd2] == null)
                continue;
            bool _0x7fdea4e5 = _0x61234bd2 == _0xfc7d15d8;
            this._0x0fdfce80[_0x61234bd2].color = _0x7fdea4e5 ? _0x82ba3493.EmberGlow : _0x82ba3493.Fade(_0x61234bd2 < _0x49c993d5._0xb40476b1 ? _0x82ba3493.Gold : _0x82ba3493.TextMuted, 0.4f);
        }

        if (this._0xd70cea28 != null)
            this._0xd70cea28._0x07e58f96();
        if (this._0xa869d9b6 != null)
            this._0xa869d9b6._0x848b1f13(_0x5681a043.ViewHome);
    }

    private void _0x12f84d57(RectTransform _0xfb205d99, int _0x9f03ae80, int _0x4249d616, float _0x866c29f8)
    {
        bool _0xfae978c4 = _0x9f03ae80 < _0x4249d616;
        bool _0xba3a1bae = _0x9f03ae80 == _0x4249d616;
        bool _0x49db4623 = _0x9f03ae80 > _0x4249d616;
        Color _0x36292609 = _0xfae978c4 ? _0x82ba3493.Gold : (_0xba3a1bae ? _0x82ba3493.Ember : _0x82ba3493.TextMuted);
        Image _0xa1e9a825;
        RectTransform _0x0a8ee1d7 = _0xa9abda03.Card(_0xfb205d99, _0x686b1199._0x90c037f3(new byte[8] { 124, 123, 110, 104, 106, 93, 96, 120 }, 15), this._0xae3b7eb8._0x6b00fe61, new Vector2(0.5f, 1f), new Vector2(0f, _0x866c29f8), new Vector2(RowWidth, RowHeight), _0x82ba3493.Fade(_0x82ba3493.Surface, _0x49db4623 ? 0.55f : 0.95f), _0x82ba3493.Fade(_0x36292609, _0x49db4623 ? 0.25f : 0.8f), 2.2f, out _0xa1e9a825);
        this._0x0fdfce80.Add(_0xa1e9a825);
        // The indicator gutter: pips only, never a glyph that could collide with the text.
        _0xa9abda03.Plate(_0x0a8ee1d7, _0x686b1199._0x90c037f3(new byte[8] { 182, 175, 182, 146, 180, 167, 165, 173 }, 198), this._0xae3b7eb8._0x6b00fe61, _0x82ba3493.Fade(_0x82ba3493.Ink, 0.75f), new Vector2(0f, 0.5f), new Vector2(GutterCentre, 0f), new Vector2(GutterWidth, 108f), 0.9f);
        for (int _0x62135ed3 = 0; _0x62135ed3 < 3; _0x62135ed3++)
        {
            Color _0x130a0ecd = _0x62135ed3 <= _0x9f03ae80 % 3 && !_0x49db4623 ? _0x36292609 : _0x82ba3493.Fade(_0x82ba3493.TextMuted, 0.35f);
            _0xa9abda03.Plate(_0x0a8ee1d7, _0x686b1199._0x90c037f3(new byte[3] { 35, 58, 35 }, 83), this._0xae3b7eb8._0x6b00fe61, _0x130a0ecd, new Vector2(0f, 0.5f), new Vector2(GutterCentre, 30f - _0x62135ed3 * 30f), new Vector2(20f, 20f), 0.2f);
        }

        // The text column. left edge = TextLeft = 129 >= gutter right edge (83) + 24.
        float _0x439a8ac6 = TextLeft + TextWidth * 0.5f;
        _0xa9abda03.Label(_0x0a8ee1d7, _0x686b1199._0x90c037f3(new byte[9] { 98, 101, 112, 118, 116, 95, 112, 124, 116 }, 17), this._0xae3b7eb8._0xb210014d, _0x686b1199._0x90c037f3(new byte[6] { 110, 105, 124, 122, 120, 29 }, 61) + (_0x9f03ae80 + 1) + _0x686b1199._0x90c037f3(new byte[3] { 98, 111, 98 }, 66) + _0x46df03e4.Name(_0x9f03ae80), 44f, _0x49db4623 ? _0x82ba3493.TextMuted : _0x82ba3493.TextPrimary, TextAlignmentOptions.Left, new Vector2(0f, 0.5f), new Vector2(_0x439a8ac6, 36f), new Vector2(TextWidth, 56f));
        _0xa9abda03.Label(_0x0a8ee1d7, _0x686b1199._0x90c037f3(new byte[10] { 71, 64, 85, 83, 81, 101, 65, 91, 64, 85 }, 52), this._0xae3b7eb8._0xb210014d, _0x686b1199._0x90c037f3(new byte[6] { 158, 154, 128, 155, 142, 239 }, 207) + _0x46df03e4.Quota(_0x9f03ae80, false) + _0x686b1199._0x90c037f3(new byte[6] { 68, 39, 43, 45, 42, 55 }, 100), 30f, _0x82ba3493.TextMuted, TextAlignmentOptions.Left, new Vector2(0f, 0.5f), new Vector2(_0x439a8ac6, -22f), new Vector2(TextWidth, 44f));
        string _0x02537d0b = _0xfae978c4 ? _0x686b1199._0x90c037f3(new byte[7] { 122, 117, 124, 120, 107, 124, 125 }, 57) : (_0xba3a1bae ? _0x686b1199._0x90c037f3(new byte[4] { 150, 137, 156, 151 }, 217) : _0x686b1199._0x90c037f3(new byte[6] { 71, 68, 72, 64, 78, 79 }, 11));
        TextMeshProUGUI _0x25e9d7d6 = _0xa9abda03.Label(_0x0a8ee1d7, _0x686b1199._0x90c037f3(new byte[10] { 124, 123, 110, 104, 106, 92, 123, 110, 123, 106 }, 15), this._0xae3b7eb8._0xb210014d, _0x02537d0b, 28f, _0x36292609, TextAlignmentOptions.Center, new Vector2(1f, 0.5f), new Vector2(-96f, 0f), new Vector2(170f, 48f));
        this._0x7826e6c8.Add(_0x25e9d7d6);
        Button _0xc32122fc = _0xa9abda03.HitButton(_0x0a8ee1d7, _0x686b1199._0x90c037f3(new byte[8] { 221, 218, 207, 201, 203, 250, 207, 222 }, 174), this._0xae3b7eb8._0x6b00fe61, new Vector2(RowWidth, RowHeight));
        int _0x83332e85 = _0x9f03ae80;
        bool _0x05cc245c = _0x49db4623;
        _0xc32122fc.onClick.AddListener(() => this._0xed159c97(_0x83332e85, _0x05cc245c));
    }

    private _0x4831bce5 _0xae3b7eb8;
    private const float GutterCentre = 62f;
    private TextMeshProUGUI _0xce1239c5;
    private readonly List<TextMeshProUGUI> _0x7826e6c8 = new List<TextMeshProUGUI>();
    public void _0xba79e93f(_0x4831bce5 _0x0f57d51f, _0xee14bec2 _0x8d1c7b76, _0x21abdfb6 _0xc48e9214)
    {
        this._0xae3b7eb8 = _0x0f57d51f;
        this._0xa869d9b6 = _0x8d1c7b76;
        this._0xd70cea28 = _0xc48e9214;
        RectTransform _0x76f34768 = this.transform as RectTransform;
        _0xa9abda03.Backdrop(_0x76f34768, _0x0f57d51f, 0.72f);
        Button _0x6912add7 = _0xa9abda03.Header(_0x76f34768, _0x0f57d51f, _0x686b1199._0x90c037f3(new byte[9] { 173, 171, 184, 176, 181, 217, 180, 184, 169 }, 249));
        _0x6912add7.onClick.AddListener(() => this._0xa869d9b6._0x848b1f13(_0x5681a043.ViewHome));
        int _0x436e5879 = _0x49c993d5._0xb40476b1;
        float _0xeb73a0f8 = -250f;
        for (int _0x8a92f84a = 0; _0x8a92f84a < _0x46df03e4.StageCount; _0x8a92f84a++)
            this._0x12f84d57(_0x76f34768, _0x8a92f84a, _0x436e5879, _0xeb73a0f8 - _0x8a92f84a * (RowHeight + 14f));
        this._0xce1239c5 = _0xa9abda03.Label(_0x76f34768, _0x686b1199._0x90c037f3(new byte[8] { 42, 41, 37, 45, 14, 47, 40, 50 }, 70), _0x0f57d51f._0xb210014d, string.Empty, 30f, _0x82ba3493.EmberGlow, TextAlignmentOptions.Center, new Vector2(0.5f, 0f), new Vector2(0f, 150f), new Vector2(1000f, 60f));
        if (_0x46df03e4.StageCount == 0)
            _0xa9abda03.EmptyState(_0x76f34768, _0x0f57d51f._0xb210014d, _0x686b1199._0x90c037f3(new byte[32] { 202, 203, 164, 208, 214, 197, 205, 200, 164, 203, 212, 193, 202, 164, 221, 193, 208, 142, 212, 200, 197, 221, 164, 208, 203, 164, 209, 202, 200, 203, 199, 207 }, 132));
    }

    private const float RowWidth = 1040f;
    private readonly List<Image> _0x0fdfce80 = new List<Image>();
    private const float TextLeft = GutterCentre + GutterWidth * 0.5f + 46f; // 129
}

internal static class _0x686b1199
{
    internal static string _0x90c037f3(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}
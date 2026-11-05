using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Ember Trail skins and badges. Everything here is cosmetic and earned by climbing - there
/// is no price in money, no purchase button, no ad button and no cash-out anywhere.
/// Unlocking is confirmed on screen (C.7): the tile border lights gold, the state chip flips
/// to OWNED, and the shard balance counts down with a punch.
/// </summary>
public sealed class _0x741d0e0e : MonoBehaviour
{
    private _0xee14bec2 _0xd16f83a5;
    private _0x21abdfb6 _0xafb4d531;
    private void _0x63e96be5()
    {
        if (this._0x15b3aead != null)
        {
            this._0x15b3aead.text = this._0xffc6acff();
            this._0x15b3aead.transform.DOPunchScale(Vector3.one * 0.12f, 0.3f, 6, 0.6f).SetLink(this._0x15b3aead.gameObject);
        }

        for (int _0xe8e236a2 = 0; _0xe8e236a2 < this._0xfc4b9448.Count; _0xe8e236a2++)
        {
            bool _0x2ea6ab58 = _0x49c993d5.IsRewardOwned(_0xe8e236a2);
            bool _0x3a189591 = _0xe8e236a2 < 4 && _0x49c993d5._0xe868e869 == _0xe8e236a2 && _0x2ea6ab58;
            Color _0xa9755821 = _0x3a189591 ? _0x82ba3493.EmberGlow : (_0x2ea6ab58 ? _0x82ba3493.Gold : _0x82ba3493.TextMuted);
            if (this._0xfc4b9448[_0xe8e236a2] != null)
            {
                this._0xfc4b9448[_0xe8e236a2].text = this._0x7699ed4c(_0xe8e236a2);
                this._0xfc4b9448[_0xe8e236a2].color = _0xa9755821;
            }

            if (this._0x68d49907[_0xe8e236a2] != null)
                this._0x68d49907[_0xe8e236a2].color = _0x82ba3493.Fade(_0xa9755821, _0x2ea6ab58 ? 0.8f : 0.3f);
        }

        if (this._0xafb4d531 != null)
            this._0xafb4d531._0xeecb2631();
    }

    public void _0xf87c15f5(_0x4831bce5 _0xd693076a, _0xee14bec2 _0x8d7a9c8d, _0x21abdfb6 _0x3df9e0d5)
    {
        this._0x29d98a81 = _0xd693076a;
        this._0xd16f83a5 = _0x8d7a9c8d;
        this._0xafb4d531 = _0x3df9e0d5;
        RectTransform _0x57cf59ff = this.transform as RectTransform;
        _0xa9abda03.Backdrop(_0x57cf59ff, _0xd693076a, 0.72f);
        Button _0xa4967c9a = _0xa9abda03.Header(_0x57cf59ff, _0xd693076a, _0xb8023591._0xe04610e2(new byte[13] { 142, 136, 155, 147, 150, 250, 136, 159, 141, 155, 136, 158, 137 }, 218));
        _0xa4967c9a.onClick.AddListener(() => this._0xd16f83a5._0x848b1f13(_0x5681a043.ViewHome));
        this._0x15b3aead = _0xa9abda03.Label(_0x57cf59ff, _0xb8023591._0xe04610e2(new byte[6] { 202, 209, 216, 203, 221, 202 }, 185), _0xd693076a._0xb210014d, this._0xffc6acff(), 44f, _0x82ba3493.GoldLight, TextAlignmentOptions.Right, new Vector2(0.5f, 1f), new Vector2(400f, -250f), new Vector2(240f, 56f));
        _0xa9abda03.Label(_0x57cf59ff, _0xb8023591._0xe04610e2(new byte[8] { 6, 2, 17, 13, 6, 7, 33, 26 }, 99), _0xd693076a._0xb210014d, _0xb8023591._0xe04610e2(new byte[32] { 246, 242, 225, 253, 246, 247, 147, 241, 234, 147, 227, 255, 242, 234, 250, 253, 244, 147, 158, 147, 253, 252, 231, 147, 245, 252, 225, 147, 224, 242, 255, 246 }, 179), 28f, _0x82ba3493.TextMuted, TextAlignmentOptions.Left, new Vector2(0.5f, 1f), new Vector2(-250f, -250f), new Vector2(540f, 48f));
        int _0x71fbffec = 0;
        for (int _0x933eff28 = 0; _0x933eff28 < TileCount; _0x933eff28++)
        {
            if (_0x49c993d5.IsRewardOwned(_0x933eff28))
                _0x71fbffec++;
            int _0x2d7340f8 = _0x933eff28 % 2;
            int _0x929dec00 = _0x933eff28 / 2;
            this._0x3a0b0c95(_0x57cf59ff, _0x933eff28, new Vector2(_0x2d7340f8 == 0 ? -262f : 262f, -420f - _0x929dec00 * 262f));
        }

        if (_0x71fbffec == 0)
            _0xa9abda03.EmptyState(_0x57cf59ff, _0xd693076a._0xb210014d, _0xb8023591._0xe04610e2(new byte[41] { 122, 123, 96, 124, 125, 122, 115, 20, 97, 122, 120, 123, 119, 127, 113, 112, 20, 109, 113, 96, 62, 119, 120, 125, 121, 118, 20, 96, 123, 20, 113, 117, 102, 122, 20, 103, 124, 117, 102, 112, 103 }, 52));
    }

    private readonly List<Image> _0x68d49907 = new List<Image>();
    private string _0x7699ed4c(int _0xf444f98d)
    {
        if (_0xf444f98d < 4 && _0x49c993d5._0xe868e869 == _0xf444f98d && _0x49c993d5.IsRewardOwned(_0xf444f98d))
            return _0xb8023591._0xe04610e2(new byte[8] { 74, 94, 90, 70, 95, 95, 74, 75 }, 15);
        if (_0x49c993d5.IsRewardOwned(_0xf444f98d))
            return _0xb8023591._0xe04610e2(new byte[5] { 206, 214, 207, 196, 197 }, 129);
        return _0xb8023591._0xe04610e2(new byte[7] { 226, 249, 240, 227, 245, 226, 145 }, 177) + _0x264ae37a[_0xf444f98d];
    }

    private readonly List<TextMeshProUGUI> _0xfc4b9448 = new List<TextMeshProUGUI>();
    private void _0x22e089e8(int _0x1df9e745)
    {
        if (!_0x49c993d5.IsRewardOwned(_0x1df9e745))
        {
            if (_0x49c993d5._0xf5f133cb < _0x264ae37a[_0x1df9e745])
            {
                if (this._0x15b3aead != null)
                    this._0x15b3aead.transform.DOPunchScale(Vector3.one * 0.1f, 0.3f, 6, 0.6f).SetLink(this._0x15b3aead.gameObject);
                return;
            }

            _0x49c993d5._0xf5f133cb = _0x49c993d5._0xf5f133cb - _0x264ae37a[_0x1df9e745];
            _0x49c993d5.OwnReward(_0x1df9e745);
        }
        else if (_0x1df9e745 < 4)
        {
            _0x49c993d5._0xe868e869 = _0x1df9e745;
        }

        this._0x63e96be5();
    }

    private static readonly int[] _0x264ae37a =
    {
        0,
        12,
        18,
        26,
        0,
        10,
        16,
        24
    };
    private static readonly string[] _0x8d493592 =
    {
        _0xb8023591._0xe04610e2(new byte[12] { 223, 213, 210, 216, 217, 206, 188, 200, 206, 221, 213, 208 }, 156),
        _0xb8023591._0xe04610e2(new byte[9] { 11, 3, 0, 8, 108, 31, 9, 13, 1 }, 76),
        _0xb8023591._0xe04610e2(new byte[7] { 185, 171, 176, 190, 185, 180, 180 }, 248),
        _0xb8023591._0xe04610e2(new byte[11] { 182, 180, 183, 175, 190, 181, 219, 172, 186, 176, 190 }, 251),
        _0xb8023591._0xe04610e2(new byte[10] { 31, 16, 11, 10, 13, 121, 10, 13, 28, 9 }, 89),
        _0xb8023591._0xe04610e2(new byte[12] { 80, 91, 82, 90, 93, 51, 91, 92, 95, 87, 86, 65 }, 19),
        _0xb8023591._0xe04610e2(new byte[11] { 115, 96, 107, 113, 5, 97, 106, 97, 98, 96, 119 }, 37),
        _0xb8023591._0xe04610e2(new byte[11] { 0, 6, 30, 30, 26, 7, 115, 30, 18, 1, 24 }, 83),
    };
    private void _0x3a0b0c95(RectTransform _0xcad3df00, int _0xc1c6f897, Vector2 _0xec7ae670)
    {
        bool _0x81a3ae27 = _0x49c993d5.IsRewardOwned(_0xc1c6f897);
        bool _0x3dcc77b9 = _0xc1c6f897 < 4 && _0x49c993d5._0xe868e869 == _0xc1c6f897 && _0x81a3ae27;
        Color _0x953393a4 = _0x3dcc77b9 ? _0x82ba3493.EmberGlow : (_0x81a3ae27 ? _0x82ba3493.Gold : _0x82ba3493.TextMuted);
        Image _0xb28dd91f;
        RectTransform _0xe846f609 = _0xa9abda03.Card(_0xcad3df00, _0xb8023591._0xe04610e2(new byte[10] { 30, 9, 27, 13, 30, 8, 56, 5, 0, 9 }, 108), this._0x29d98a81._0x6b00fe61, new Vector2(0.5f, 1f), _0xec7ae670, new Vector2(500f, 240f), _0x82ba3493.Fade(_0x82ba3493.Surface, _0x81a3ae27 ? 0.95f : 0.6f), _0x82ba3493.Fade(_0x953393a4, _0x81a3ae27 ? 0.8f : 0.3f), 2.2f, out _0xb28dd91f);
        this._0x68d49907.Add(_0xb28dd91f);
        _0xa9abda03.Dot(_0xe846f609, this._0x29d98a81._0x6b00fe61, new Vector2(0.5f, 1f), new Vector2(0f, -30f), 16f, _0x953393a4);
        _0xa9abda03.Label(_0xe846f609, _0xb8023591._0xe04610e2(new byte[10] { 217, 206, 220, 202, 217, 207, 229, 202, 198, 206 }, 171), this._0x29d98a81._0xb210014d, _0x8d493592[_0xc1c6f897], 34f, _0x81a3ae27 ? _0x82ba3493.TextPrimary : _0x82ba3493.TextMuted, TextAlignmentOptions.Center, new Vector2(0.5f, 0.5f), new Vector2(0f, 14f), new Vector2(440f, 52f));
        _0xa9abda03.Label(_0xe846f609, _0xb8023591._0xe04610e2(new byte[10] { 81, 70, 84, 66, 81, 71, 104, 74, 77, 71 }, 35), this._0x29d98a81._0xb210014d, _0xc1c6f897 < 4 ? _0xb8023591._0xe04610e2(new byte[10] { 208, 214, 197, 205, 200, 164, 215, 207, 205, 202 }, 132) : _0xb8023591._0xe04610e2(new byte[5] { 215, 212, 209, 210, 208 }, 149), 26f, _0x82ba3493.TextMuted, TextAlignmentOptions.Center, new Vector2(0.5f, 0.5f), new Vector2(0f, -28f), new Vector2(440f, 40f));
        TextMeshProUGUI _0x8feb66a0 = _0xa9abda03.Label(_0xe846f609, _0xb8023591._0xe04610e2(new byte[11] { 9, 30, 12, 26, 9, 31, 40, 15, 26, 15, 30 }, 123), this._0x29d98a81._0xb210014d, this._0x7699ed4c(_0xc1c6f897), 28f, _0x953393a4, TextAlignmentOptions.Center, new Vector2(0.5f, 0f), new Vector2(0f, 34f), new Vector2(300f, 44f));
        this._0xfc4b9448.Add(_0x8feb66a0);
        Button _0xa7b2cd0f = _0xa9abda03.HitButton(_0xe846f609, _0xb8023591._0xe04610e2(new byte[9] { 40, 63, 45, 59, 40, 62, 14, 59, 42 }, 90), this._0x29d98a81._0x6b00fe61, new Vector2(500f, 240f));
        int _0x1022de23 = _0xc1c6f897;
        _0xa7b2cd0f.onClick.AddListener(() => this._0x22e089e8(_0x1022de23));
    }

    private string _0xffc6acff()
    {
        return _0xb8023591._0xe04610e2(new byte[7] { 127, 100, 109, 126, 104, 127, 12 }, 44) + _0x49c993d5._0xf5f133cb;
    }

    private const int TileCount = 8;
    private TextMeshProUGUI _0x15b3aead;
    private _0x4831bce5 _0x29d98a81;
}

internal static class _0xb8023591
{
    internal static string _0xe04610e2(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}
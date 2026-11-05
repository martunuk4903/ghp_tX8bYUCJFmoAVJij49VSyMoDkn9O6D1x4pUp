using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Rank, four stat cards and the badge strip. The stat cards carry an accent dot rather
/// than a raster icon, so four cards in a 2x2 grid line up exactly - a row of generated
/// PNGs never would.
/// </summary>
public sealed class _0x7beb7f58 : MonoBehaviour
{
    public void _0x2de7a4b3(_0x4831bce5 _0xf02f291f, _0xee14bec2 _0x5913fe89)
    {
        this._0x84964e9d = _0x5913fe89;
        RectTransform _0x82721440 = this.transform as RectTransform;
        _0xa9abda03.Backdrop(_0x82721440, _0xf02f291f, 0.72f);
        Button _0x52c5bc13 = _0xa9abda03.Header(_0x82721440, _0xf02f291f, _0x3b8db393._0x04e49e09(new byte[7] { 171, 169, 180, 189, 178, 183, 190 }, 251));
        _0x52c5bc13.onClick.AddListener(() => this._0x84964e9d._0x848b1f13(_0x5681a043.ViewHome));
        // Rank block.
        RectTransform _0x9772e817 = _0xa9abda03.Card(_0x82721440, _0x3b8db393._0x04e49e09(new byte[8] { 129, 146, 157, 152, 176, 146, 129, 151 }, 243), _0xf02f291f._0x6b00fe61, new Vector2(0.5f, 1f), new Vector2(0f, -330f), new Vector2(1040f, 230f), _0x82ba3493.Fade(_0x82ba3493.Surface, 0.95f), _0x82ba3493.Fade(_0x82ba3493.Gold, 0.7f), 2.2f);
        _0xa9abda03.Dot(_0x9772e817, _0xf02f291f._0x6b00fe61, new Vector2(0f, 0.5f), new Vector2(86f, 36f), 26f, _0x82ba3493.Gold);
        _0xa9abda03.Label(_0x9772e817, _0x3b8db393._0x04e49e09(new byte[8] { 151, 132, 139, 142, 171, 132, 136, 128 }, 229), _0xf02f291f._0xb210014d, _0x3b8db393._0x04e49e09(new byte[5] { 185, 170, 165, 160, 203 }, 235) + _0x49c993d5._0x1dccfdfc + _0x3b8db393._0x04e49e09(new byte[3] { 62, 51, 62 }, 30) + _0x49c993d5._0x6100a2f1, 44f, _0x82ba3493.TextPrimary, TextAlignmentOptions.Left, new Vector2(0f, 0.5f), new Vector2(129f + 700f * 0.5f, 36f), new Vector2(700f, 56f));
        float _0x37087b3d = Mathf.Clamp01(_0x49c993d5._0x1dccfdfc / 10f);
        RectTransform _0xfe8173b4 = _0xa9abda03.Bar(_0x9772e817, _0x3b8db393._0x04e49e09(new byte[7] { 245, 230, 233, 236, 197, 230, 245 }, 135), _0xf02f291f._0x6b00fe61, new Vector2(0f, 0.5f), new Vector2(129f + 760f * 0.5f, -38f), new Vector2(760f, 24f), _0x82ba3493.Fade(_0x82ba3493.Ink, 0.8f), _0x82ba3493.Gold, 0.8f);
        _0xa9abda03.SetBar(_0xfe8173b4, 760f, _0x37087b3d);
        // Four stat cards, 2x2.
        string[] _0x6c3a66e3 =
        {
            _0xec7175f7._0x05354bf3._0x2869e359.ToString(),
            _0x49c993d5._0xd231b447 + _0x3b8db393._0x04e49e09(new byte[1] { 228 }, 156),
            _0x49c993d5._0xb40476b1 + _0x3b8db393._0x04e49e09(new byte[3] { 23, 24, 23 }, 55) + _0x46df03e4.StageCount,
            _0x49c993d5._0xaff2bc43.ToString(),
        };
        string[] _0x17410f69 =
        {
            _0x3b8db393._0x04e49e09(new byte[11] { 250, 225, 250, 239, 226, 142, 237, 225, 231, 224, 253 }, 174),
            _0x3b8db393._0x04e49e09(new byte[10] { 138, 141, 155, 156, 232, 139, 128, 137, 129, 134 }, 200),
            _0x3b8db393._0x04e49e09(new byte[14] { 243, 244, 225, 231, 229, 243, 128, 227, 236, 229, 225, 242, 229, 228 }, 160),
            _0x3b8db393._0x04e49e09(new byte[4] { 160, 167, 188, 161 }, 242)
        };
        Color[] _0xb984d523 =
        {
            _0x82ba3493.Gold,
            _0x82ba3493.EmberGlow,
            _0x82ba3493.GoldLight,
            _0x82ba3493.TextPrimary
        };
        for (int _0x98f7e950 = 0; _0x98f7e950 < 4; _0x98f7e950++)
        {
            float _0x6e5bd1b6 = _0x98f7e950 % 2 == 0 ? -262f : 262f;
            float _0x36091c89 = -640f - (_0x98f7e950 / 2) * 232f;
            _0x5bd33973.Build(_0x82721440, _0xf02f291f, _0x6c3a66e3[_0x98f7e950], _0x17410f69[_0x98f7e950], _0xb984d523[_0x98f7e950], new Vector2(0.5f, 1f), new Vector2(_0x6e5bd1b6, _0x36091c89), new Vector2(500f, 210f));
        }

        // Badge strip: earned badges first, muted placeholders for the rest.
        RectTransform _0x190841fb = _0xa9abda03.Card(_0x82721440, _0x3b8db393._0x04e49e09(new byte[10] { 85, 86, 83, 80, 82, 100, 67, 69, 94, 71 }, 55), _0xf02f291f._0x6b00fe61, new Vector2(0.5f, 0f), new Vector2(0f, 420f), new Vector2(1040f, 200f), _0x82ba3493.Fade(_0x82ba3493.Surface, 0.9f), _0x82ba3493.Fade(_0x82ba3493.Ember, 0.55f), 2.2f);
        _0xa9abda03.Label(_0x190841fb, _0x3b8db393._0x04e49e09(new byte[10] { 51, 48, 53, 54, 52, 5, 56, 37, 61, 52 }, 81), _0xf02f291f._0xb210014d, _0x3b8db393._0x04e49e09(new byte[6] { 198, 197, 192, 195, 193, 215 }, 132), 30f, _0x82ba3493.TextMuted, TextAlignmentOptions.Center, new Vector2(0.5f, 1f), new Vector2(0f, -36f), new Vector2(600f, 44f));
        int _0x3ab80002 = 0;
        for (int _0xbd4e4544 = 4; _0xbd4e4544 < 8; _0xbd4e4544++)
            if (_0x49c993d5.IsRewardOwned(_0xbd4e4544))
                _0x3ab80002++;
        for (int _0x8ba2d3c6 = 0; _0x8ba2d3c6 < 8; _0x8ba2d3c6++)
        {
            bool _0xa00e375f = _0x8ba2d3c6 < _0x3ab80002;
            _0xa9abda03.Plate(_0x190841fb, _0x3b8db393._0x04e49e09(new byte[5] { 129, 130, 135, 132, 134 }, 227), _0xf02f291f._0x6b00fe61, _0xa00e375f ? _0x82ba3493.Gold : _0x82ba3493.Fade(_0x82ba3493.TextMuted, 0.25f), new Vector2(0.5f, 0f), new Vector2(-420f + _0x8ba2d3c6 * 120f, 58f), new Vector2(74f, 74f), 0.9f);
        }

        if (_0x3ab80002 == 0)
            _0xa9abda03.Label(_0x190841fb, _0x3b8db393._0x04e49e09(new byte[9] { 92, 95, 90, 89, 91, 118, 87, 80, 74 }, 62), _0xf02f291f._0xb210014d, _0x3b8db393._0x04e49e09(new byte[25] { 13, 9, 26, 6, 104, 10, 9, 12, 15, 13, 27, 104, 1, 6, 104, 7, 10, 2, 13, 11, 28, 1, 30, 13, 27 }, 72), 28f, _0x82ba3493.TextMuted, TextAlignmentOptions.Center, new Vector2(0.5f, 0f), new Vector2(0f, 20f), new Vector2(840f, 40f));
    }

    private _0xee14bec2 _0x84964e9d;
}

internal static class _0x3b8db393
{
    internal static string _0x04e49e09(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}
using TMPro;
using UnityEngine;

/// <summary>
/// One stat card, built the same way on every screen so the menu reads as one system.
/// There is deliberately NO raster icon inside: every generated PNG carries its own object
/// aspect, so a row of them lines up at visibly different sizes. An 8px accent dot carries
/// the semantics instead - gold for earned, ember for pressure, cream for neutral.
/// </summary>
public static class _0x5bd33973
{
    /// <summary>
    /// A row of pills. Never renders a LONE pill: one chip on its own reads as a leftover,
    /// so a row with fewer than two entries is not drawn at all.
    /// </summary>
    public static void Row(Transform _0x0de0c0d1, _0x4831bce5 _0x9ff9bda6, string[] _0x8ec68466, string[] _0x6c590ec7, Color[] _0x49ca352a, Vector2 _0xbaae3f83, Vector2 _0x3e634056, float _0x21395da5, float height)
    {
        int _0x5c5733c1 = _0x8ec68466.Length;
        if (_0x5c5733c1 < 2)
            return;
        float _0xdbfc13cd = 20f;
        float _0xd02bc2f6 = (_0x21395da5 - _0xdbfc13cd * (_0x5c5733c1 - 1)) / _0x5c5733c1;
        float _0x9d9ba523 = -_0x21395da5 * 0.5f + _0xd02bc2f6 * 0.5f;
        for (int _0xa37247c8 = 0; _0xa37247c8 < _0x5c5733c1; _0xa37247c8++)
        {
            Build(_0x0de0c0d1, _0x9ff9bda6, _0x8ec68466[_0xa37247c8], _0x6c590ec7[_0xa37247c8], _0x49ca352a[_0xa37247c8], _0xbaae3f83, new Vector2(_0x3e634056.x + _0x9d9ba523 + _0xa37247c8 * (_0xd02bc2f6 + _0xdbfc13cd), _0x3e634056.y), new Vector2(_0xd02bc2f6, height));
        }
    }

    public static RectTransform Build(Transform _0x9ff178ac, _0x4831bce5 _0x45a45500, string _0xaa491d98, string _0x97fa7470, Color _0x3a83e03f, Vector2 _0x5bc34189, Vector2 _0x5732f7b4, Vector2 _0x002929d9)
    {
        RectTransform _0x84a477e3 = _0xa9abda03.Card(_0x9ff178ac, _0x4b6c8f10._0xdf74952a(new byte[4] { 53, 50, 39, 50 }, 70), _0x45a45500._0x6b00fe61, _0x5bc34189, _0x5732f7b4, _0x002929d9, _0x82ba3493.Fade(_0x82ba3493.Surface, 0.92f), _0x82ba3493.Fade(_0x3a83e03f, 0.45f), 2.2f);
        _0xa9abda03.Dot(_0x84a477e3, _0x45a45500._0x6b00fe61, new Vector2(0.5f, 1f), new Vector2(0f, -26f), 14f, _0x3a83e03f);
        _0xa9abda03.Label(_0x84a477e3, _0x4b6c8f10._0xdf74952a(new byte[5] { 77, 90, 87, 78, 94 }, 59), _0x45a45500._0xb210014d, _0xaa491d98, 60f, _0x3a83e03f, TextAlignmentOptions.Center, new Vector2(0.5f, 0.5f), new Vector2(0f, 10f), new Vector2(_0x002929d9.x - 36f, _0x002929d9.y * 0.46f));
        _0xa9abda03.Label(_0x84a477e3, _0x4b6c8f10._0xdf74952a(new byte[5] { 200, 197, 198, 193, 200 }, 164), _0x45a45500._0xb210014d, _0x97fa7470, 28f, _0x82ba3493.TextMuted, TextAlignmentOptions.Center, new Vector2(0.5f, 0f), new Vector2(0f, 34f), new Vector2(_0x002929d9.x - 24f, 42f));
        return _0x84a477e3;
    }
}

internal static class _0x4b6c8f10
{
    internal static string _0xdf74952a(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}
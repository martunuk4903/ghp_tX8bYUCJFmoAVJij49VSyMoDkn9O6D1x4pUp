using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Dresses Win (7), Lose (8) and Pause (6) to the same standard - Pause included, because it
/// is the one the player sees most often and the one most often left template-default (C.3).
///
/// What the template leaves behind is switched off rather than patched: its action buttons,
/// its "Score:" / "Reward:" labels and its empty close Image, which Unity would otherwise
/// paint as a solid WHITE SQUARE (B.1). The card, the captions and the close cross are all
/// ours, the cross is drawn from the template's own 9-slice plate, and every button gets its
/// OWN caption - the cross gets none at all (C.17).
/// </summary>
public sealed class _0xb8ce66dd : MonoBehaviour
{
    private Button _0x545b6ed9(RectTransform _0xdba78d81, string _0x6af63c19, float _0x9384e38e, Color _0xd26a3717, Color _0xc827f8a1)
    {
        return _0xa9abda03.Cta(_0xdba78d81, _0x3cb1af77._0x7c849bb5(new byte[9] { 20, 11, 20, 37, 7, 16, 13, 11, 10 }, 100), this._0xa67e6492, _0x6af63c19, 36f, new Vector2(0.5f, 0f), new Vector2(_0x9384e38e, 150f), new Vector2(440f, 116f), _0xd26a3717, _0xc827f8a1, _0x82ba3493.TextPrimary, 1.4f);
    }

    private void _0xf405f254()
    {
        _0x4751f1e9 _0x8e97d21c = _0x4751f1e9.Instance;
        if (_0x8e97d21c == null || _0x8e97d21c.Pops == null || _0xec7175f7._0x5d5037c6.PAUSE >= _0x8e97d21c.Pops.Count)
            return;
        RectTransform _0x84d35135 = this._0x824a37d2(_0x8e97d21c._0x3b81ecb8(_0xec7175f7._0x5d5037c6.PAUSE), _0x82ba3493.Fade(_0x82ba3493.Gold, 0.9f));
        if (_0x84d35135 == null)
            return;
        this._0x599b5363(_0x84d35135, _0x82ba3493.GoldLight, out this._0xf2c8081a, out this._0x6ecdcd65, out this._0x2bd445d2);
        Button _0xca30fa4c = this._0x545b6ed9(_0x84d35135, _0x3cb1af77._0x7c849bb5(new byte[6] { 212, 195, 213, 211, 203, 195 }, 134), -240f, _0x82ba3493.Fade(_0x82ba3493.Ember, 0.92f), _0x82ba3493.Fade(_0x82ba3493.GoldLight, 0.85f));
        _0xca30fa4c.onClick.AddListener(() => this._0xcd95ae0e._0xdcc8b75e());
        Button _0x23dbf108 = this._0x545b6ed9(_0x84d35135, _0x3cb1af77._0x7c849bb5(new byte[11] { 63, 54, 50, 37, 54, 83, 39, 33, 50, 58, 63 }, 115), 240f, _0x82ba3493.Fade(_0x82ba3493.SurfaceAlt, 0.95f), _0x82ba3493.Fade(_0x82ba3493.Gold, 0.6f));
        _0x23dbf108.onClick.AddListener(() => this._0xcd95ae0e._0x31c29b33());
        Button _0x440b6465 = this._0x1af93722(_0x84d35135);
        _0x440b6465.onClick.AddListener(() => this._0xcd95ae0e._0xdcc8b75e());
    }

    private const float CardWidth = 1060f;
    private TextMeshProUGUI _0xdb7483f1;
    public void _0x5ad68b08(int _0xa42d9ff7, int _0x27d4ef71, int _0xef8ab292, float _0xe74d68e1)
    {
        if (this._0xf2c8081a != null)
            this._0xf2c8081a.text = _0x3cb1af77._0x7c849bb5(new byte[10] { 153, 159, 140, 132, 129, 237, 133, 136, 129, 137 }, 205);
        if (this._0x6ecdcd65 != null)
            this._0x6ecdcd65.text = _0x3cb1af77._0x7c849bb5(new byte[6] { 41, 46, 59, 61, 63, 90 }, 122) + (_0xa42d9ff7 + 1) + _0x3cb1af77._0x7c849bb5(new byte[3] { 36, 41, 36 }, 4) + _0x46df03e4.Name(_0xa42d9ff7) + _0x3cb1af77._0x7c849bb5(new byte[1] { 178 }, 184) + _0x27d4ef71 + _0x3cb1af77._0x7c849bb5(new byte[3] { 163, 172, 163 }, 131) + _0xef8ab292 + _0x3cb1af77._0x7c849bb5(new byte[6] { 48, 83, 95, 89, 94, 67 }, 16);
        if (this._0x2bd445d2 != null)
            this._0x2bd445d2.text = _0x3cb1af77._0x7c849bb5(new byte[7] { 53, 46, 47, 35, 42, 34, 70 }, 102) + Mathf.RoundToInt(_0xe74d68e1 * 100f) + _0x3cb1af77._0x7c849bb5(new byte[1] { 209 }, 244);
    }

    private TextMeshProUGUI _0x0051bd64;
    private _0x00711191 _0xcd95ae0e;
    private void _0x599b5363(RectTransform _0x65dfe190, Color _0xf435a548, out TextMeshProUGUI _0xb8424d9d, out TextMeshProUGUI _0xa0879f59, out TextMeshProUGUI _0x6f1b984b)
    {
        _0xb8424d9d = _0xa9abda03.Label(_0x65dfe190, _0x3cb1af77._0x7c849bb5(new byte[9] { 205, 210, 205, 245, 216, 220, 217, 216, 207 }, 189), this._0xa67e6492._0xb210014d, string.Empty, 64f, _0xf435a548, TextAlignmentOptions.Center, new Vector2(0.5f, 1f), new Vector2(0f, -150f), new Vector2(900f, 90f));
        _0xa9abda03.Plate(_0x65dfe190, _0x3cb1af77._0x7c849bb5(new byte[7] { 126, 97, 126, 92, 123, 98, 107 }, 14), this._0xa67e6492._0x6b00fe61, _0x82ba3493.Fade(_0xf435a548, 0.7f), new Vector2(0.5f, 1f), new Vector2(0f, -220f), new Vector2(680f, 5f), 1.2f);
        _0xa0879f59 = _0xa9abda03.Label(_0x65dfe190, _0x3cb1af77._0x7c849bb5(new byte[7] { 125, 98, 125, 79, 98, 105, 116 }, 13), this._0xa67e6492._0xb210014d, string.Empty, 44f, _0x82ba3493.TextPrimary, TextAlignmentOptions.Center, new Vector2(0.5f, 1f), new Vector2(0f, -340f), new Vector2(900f, 150f));
        _0x6f1b984b = _0xa9abda03.Label(_0x65dfe190, _0x3cb1af77._0x7c849bb5(new byte[8] { 195, 220, 195, 246, 203, 199, 193, 210 }, 179), this._0xa67e6492._0xb210014d, string.Empty, 34f, _0x82ba3493.TextMuted, TextAlignmentOptions.Center, new Vector2(0.5f, 1f), new Vector2(0f, -490f), new Vector2(900f, 60f));
    }

    private TextMeshProUGUI _0xf2c8081a;
    private void _0xebfdaace()
    {
        _0x4751f1e9 _0x8b069a58 = _0x4751f1e9.Instance;
        if (_0x8b069a58 == null || _0x8b069a58.Pops == null || _0xec7175f7._0x5d5037c6.LOSE >= _0x8b069a58.Pops.Count)
            return;
        RectTransform _0x14c732ec = this._0x824a37d2(_0x8b069a58._0x3b81ecb8(_0xec7175f7._0x5d5037c6.LOSE), _0x82ba3493.Fade(_0x82ba3493.Ember, 0.95f));
        if (_0x14c732ec == null)
            return;
        this._0x599b5363(_0x14c732ec, _0x82ba3493.EmberGlow, out this._0x240a5651, out this._0xfb7dcbb1, out this._0x0051bd64);
        Button _0xde5465c6 = this._0x545b6ed9(_0x14c732ec, _0x3cb1af77._0x7c849bb5(new byte[11] { 94, 81, 84, 80, 95, 61, 92, 90, 92, 84, 83 }, 29), -240f, _0x82ba3493.Fade(_0x82ba3493.Ember, 0.92f), _0x82ba3493.Fade(_0x82ba3493.GoldLight, 0.85f));
        _0xde5465c6.onClick.AddListener(() => this._0xcd95ae0e._0x60fd8665());
        Button _0x1ffdd51b = this._0x545b6ed9(_0x14c732ec, _0x3cb1af77._0x7c849bb5(new byte[9] { 73, 79, 92, 84, 81, 61, 80, 92, 77 }, 29), 240f, _0x82ba3493.Fade(_0x82ba3493.SurfaceAlt, 0.95f), _0x82ba3493.Fade(_0x82ba3493.Gold, 0.6f));
        _0x1ffdd51b.onClick.AddListener(() => this._0xcd95ae0e._0x31c29b33());
        Button _0xdcec1c4b = this._0x1af93722(_0x14c732ec);
        _0xdcec1c4b.onClick.AddListener(() => this._0xcd95ae0e._0x31c29b33());
    }

    public void _0x859f818c(_0x4831bce5 _0x93eb3e95, _0x00711191 _0x42fabf9f)
    {
        this._0xa67e6492 = _0x93eb3e95;
        this._0xcd95ae0e = _0x42fabf9f;
        this._0xf405f254();
        this._0x2134333b();
        this._0xebfdaace();
    }

    private TextMeshProUGUI _0x3c725dd4;
    private TextMeshProUGUI _0x240a5651;
    private void _0x2134333b()
    {
        _0x4751f1e9 _0x31eed941 = _0x4751f1e9.Instance;
        if (_0x31eed941 == null || _0x31eed941.Pops == null || _0xec7175f7._0x5d5037c6.WIN >= _0x31eed941.Pops.Count)
            return;
        RectTransform _0xae775f32 = this._0x824a37d2(_0x31eed941._0x3b81ecb8(_0xec7175f7._0x5d5037c6.WIN), _0x82ba3493.Fade(_0x82ba3493.Gold, 0.95f));
        if (_0xae775f32 == null)
            return;
        this._0x599b5363(_0xae775f32, _0x82ba3493.GoldLight, out this._0xdb7483f1, out this._0x1d246190, out this._0x3c725dd4);
        Button _0xe742f492 = this._0x545b6ed9(_0xae775f32, _0x3cb1af77._0x7c849bb5(new byte[10] { 125, 118, 107, 103, 19, 96, 103, 114, 116, 118 }, 51), -240f, _0x82ba3493.Fade(_0x82ba3493.Ember, 0.92f), _0x82ba3493.Fade(_0x82ba3493.GoldLight, 0.85f));
        _0xe742f492.onClick.AddListener(() => this._0xcd95ae0e._0xffa3d232());
        Button _0xb00be883 = this._0x545b6ed9(_0xae775f32, _0x3cb1af77._0x7c849bb5(new byte[9] { 196, 194, 209, 217, 220, 176, 221, 209, 192 }, 144), 240f, _0x82ba3493.Fade(_0x82ba3493.SurfaceAlt, 0.95f), _0x82ba3493.Fade(_0x82ba3493.Gold, 0.6f));
        _0xb00be883.onClick.AddListener(() => this._0xcd95ae0e._0x31c29b33());
        Button _0xcb37010d = this._0x1af93722(_0xae775f32);
        _0xcb37010d.onClick.AddListener(() => this._0xcd95ae0e._0x31c29b33());
    }

    private TextMeshProUGUI _0xfb7dcbb1;
    public void _0xe0a59b8f(int _0xf228fb10, int _0xe722cf72, int _0x49ab4ab4, int _0x3717db2b, int _0x0242aacc)
    {
        if (this._0xdb7483f1 != null)
            this._0xdb7483f1.text = _0x3cb1af77._0x7c849bb5(new byte[14] { 85, 83, 75, 75, 79, 82, 38, 84, 67, 71, 69, 78, 67, 66 }, 6);
        if (this._0x1d246190 != null)
            this._0x1d246190.text = _0x3cb1af77._0x7c849bb5(new byte[6] { 66, 69, 80, 86, 84, 49 }, 17) + (_0xf228fb10 + 1) + _0x3cb1af77._0x7c849bb5(new byte[9] { 210, 177, 190, 183, 179, 160, 183, 182, 248 }, 242) + _0xe722cf72 + _0x3cb1af77._0x7c849bb5(new byte[3] { 94, 81, 94 }, 126) + _0x49ab4ab4 + _0x3cb1af77._0x7c849bb5(new byte[6] { 153, 250, 246, 240, 247, 234 }, 185);
        if (this._0x3c725dd4 != null)
            this._0x3c725dd4.text = _0x3cb1af77._0x7c849bb5(new byte[11] { 185, 190, 168, 175, 219, 184, 179, 186, 178, 181, 219 }, 251) + _0x3717db2b + _0x3cb1af77._0x7c849bb5(new byte[8] { 77, 21, 21, 21, 24, 21, 21, 21 }, 53) + _0x0242aacc + _0x3cb1af77._0x7c849bb5(new byte[14] { 48, 67, 88, 81, 66, 84, 67, 48, 85, 81, 66, 94, 85, 84 }, 16);
    }

    /// <summary>The close cross: our own sprite-free glyph, and it carries no caption (C.17).</summary>
    private Button _0x1af93722(RectTransform _0xe5ccd354)
    {
        Button _0xe7201888 = _0xa9abda03.Cta(_0xe5ccd354, _0x3cb1af77._0x7c849bb5(new byte[8] { 237, 242, 237, 222, 241, 242, 238, 248 }, 157), this._0xa67e6492, string.Empty, 32f, new Vector2(1f, 1f), new Vector2(-82f, -82f), new Vector2(96f, 96f), _0x82ba3493.Fade(_0x82ba3493.SurfaceAlt, 0.95f), _0x82ba3493.Fade(_0x82ba3493.Ember, 0.8f), _0x82ba3493.TextPrimary, 0.22f);
        _0xa9abda03.Cross(_0xe7201888.transform, this._0xa67e6492._0x6b00fe61, 52f, 11f, _0x82ba3493.TextPrimary);
        return _0xe7201888;
    }

    private const float CardHeight = 1180f;
    private TextMeshProUGUI _0x6ecdcd65;
    private _0x4831bce5 _0xa67e6492;
    private TextMeshProUGUI _0x2bd445d2;
    /// <summary>
    /// Strips the pop back to its panel chrome and returns a card rect to fill. The chrome is
    /// the one child that carries neither a Button nor a live caption; everything else -
    /// template buttons, template metrics, the empty close Image - goes dark.
    /// </summary>
    private RectTransform _0x824a37d2(_0x42700195 _0x507174cc, Color _0x3cbadcc7)
    {
        if (_0x507174cc == null || _0x507174cc.Content == null)
            return null;
        Transform _0x813d1ee2 = _0x507174cc.Content.transform;
        RectTransform _0x5310772c = null;
        for (int _0xd50c017a = 0; _0xd50c017a < _0x813d1ee2.childCount; _0xd50c017a++)
        {
            Transform _0xfc18d8a5 = _0x813d1ee2.GetChild(_0xd50c017a);
            bool _0xf6bce9a1 = _0xfc18d8a5.GetComponentInChildren<Button>(true) != null;
            bool _0xcf5de5f5 = false;
            TMP_Text[] _0x38536911 = _0xfc18d8a5.GetComponentsInChildren<TMP_Text>(false);
            for (int _0x329d6de7 = 0; _0x329d6de7 < _0x38536911.Length; _0x329d6de7++)
            {
                if (_0x38536911[_0x329d6de7] != null && !string.IsNullOrEmpty(_0x38536911[_0x329d6de7].text))
                {
                    _0xcf5de5f5 = true;
                    break;
                }
            }

            if (_0xf6bce9a1 || _0xcf5de5f5)
            {
                _0xfc18d8a5.gameObject.SetActive(false);
                continue;
            }

            if (_0x5310772c == null)
                _0x5310772c = _0xfc18d8a5 as RectTransform;
        }

        // Pull the template's full-bleed chrome in to a real card.
        if (_0x5310772c != null)
        {
            _0x5310772c.anchorMin = new Vector2(0.5f, 0.5f);
            _0x5310772c.anchorMax = new Vector2(0.5f, 0.5f);
            _0x5310772c.pivot = new Vector2(0.5f, 0.5f);
            _0x5310772c.anchoredPosition = Vector2.zero;
            _0x5310772c.sizeDelta = new Vector2(CardWidth + 20f, CardHeight + 20f);
        }

        RectTransform _0x35aa6f8d = _0xa9abda03.Node(_0x813d1ee2, _0x3cb1af77._0x7c849bb5(new byte[7] { 162, 189, 162, 145, 179, 160, 182 }, 210), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(CardWidth, CardHeight));
        _0x35aa6f8d.SetAsLastSibling();
        _0xa9abda03.PlateFill(_0x35aa6f8d, _0x3cb1af77._0x7c849bb5(new byte[10] { 42, 40, 59, 45, 11, 38, 59, 45, 44, 59 }, 73), this._0xa67e6492._0x6b00fe61, _0x3cbadcc7, 0f, 1.4f);
        _0xa9abda03.PlateFill(_0x35aa6f8d, _0x3cb1af77._0x7c849bb5(new byte[8] { 73, 75, 88, 78, 104, 69, 78, 83 }, 42), this._0xa67e6492._0x6b00fe61, _0x82ba3493.Fade(_0x82ba3493.Surface, 0.97f), 4f, 1.4f);
        _0xa9abda03.PlateFill(_0x35aa6f8d, _0x3cb1af77._0x7c849bb5(new byte[9] { 136, 138, 153, 143, 184, 131, 142, 142, 133 }, 235), this._0xa67e6492._0x6b00fe61, _0x82ba3493.Fade(_0x82ba3493.Gold, 0.08f), 4f, 1.4f);
        return _0x35aa6f8d;
    }

    private TextMeshProUGUI _0x1d246190;
    public void _0x0db9f5d7(int _0x22a9b75f, int _0x17f243bb, int _0xf0b45d23)
    {
        if (this._0x240a5651 != null)
            this._0x240a5651.text = _0x3cb1af77._0x7c849bb5(new byte[13] { 176, 171, 170, 166, 175, 167, 195, 160, 172, 172, 175, 166, 167 }, 227);
        if (this._0xfb7dcbb1 != null)
            this._0xfb7dcbb1.text = _0x22a9b75f + _0x3cb1af77._0x7c849bb5(new byte[3] { 108, 99, 108 }, 76) + _0x17f243bb + _0x3cb1af77._0x7c849bb5(new byte[26] { 38, 69, 73, 79, 72, 85, 12, 82, 78, 67, 38, 82, 84, 71, 79, 74, 38, 81, 67, 72, 82, 38, 66, 71, 84, 77 }, 6);
        if (this._0x0051bd64 != null)
            this._0x0051bd64.text = _0xf0b45d23 + _0x3cb1af77._0x7c849bb5(new byte[12] { 1, 114, 105, 96, 115, 101, 114, 1, 106, 100, 113, 117 }, 33);
    }
}

internal static class _0x3cb1af77
{
    internal static string _0x7c849bb5(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}
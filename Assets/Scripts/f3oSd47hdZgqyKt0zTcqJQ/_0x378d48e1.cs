using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The run HUD, built from our OWN objects into the game scene's DEFAULT panel (C.2). The
/// template's TopPanel is not instantiated at all: every slot in it belongs to a different
/// game, so none of our content hangs off it and nothing of ours references it.
///
/// Back and Pause are the only two buttons, and there is no template pair beside them to
/// clash with - the game scene ships no TopPanel instance at all (H).
/// </summary>
public sealed class _0x378d48e1 : MonoBehaviour
{
    private _0x4831bce5 _0x1229ff6a;
    /// <summary>A bright pulse on the bar when an ember core goes in.</summary>
    public void _0x9973b21d()
    {
        if (this._0xc0ec1e8b == null)
            return;
        DOTween.Kill(this._0xc0ec1e8b, true);
        Color _0x46dd7600 = this._0xc0ec1e8b.color;
        this._0xc0ec1e8b.color = _0x82ba3493.GoldLight;
        this._0xc0ec1e8b.DOColor(_0x46dd7600, 0.3f).SetLink(this._0xc0ec1e8b.gameObject);
    }

    private void _0xc2ce21cc(RectTransform _0x68610a78, string _0x974729b8, float _0x8bd85261, float _0x33af3c5b, int _0xbfe97af1)
    {
        GameObject _0x6830839c = new GameObject(_0x974729b8, typeof(RectTransform));
        RectTransform _0x1ed0ee0e = _0x6830839c.GetComponent<RectTransform>();
        _0x1ed0ee0e.SetParent(_0x68610a78, false);
        _0x1ed0ee0e.anchorMin = new Vector2(_0x8bd85261, 0f);
        _0x1ed0ee0e.anchorMax = new Vector2(_0x33af3c5b, 1f);
        _0x1ed0ee0e.offsetMin = Vector2.zero;
        _0x1ed0ee0e.offsetMax = new Vector2(0f, -420f); // clear of the HUD strip at the top
        _0x1ed0ee0e.localScale = Vector3.one;
        Image _0xcd87a2d6 = _0x6830839c.AddComponent<Image>();
        _0xcd87a2d6.color = new Color(1f, 1f, 1f, 0f);
        _0xa9abda03.KeepHittable(_0xcd87a2d6); // an alpha-0 raycast target is culled, and a culled mesh is never hit
        _0x6830839c.AddComponent<_0x78508bf7>()._0x23f5a2a3(this._0x9edba126, _0xbfe97af1);
    }

    private Image _0x328ec061;
    private TextMeshProUGUI _0xc99f7469;
    /// <summary>
    /// After HintHoldSeconds the hint fades to a quiet 0.35 and stays there, so the controls
    /// are still legible in a review frame but never in the way.
    /// </summary>
    public void _0x32bd0b51()
    {
        if (this._0xde116a41 == null)
            return;
        CanvasGroup _0x604b40cf = this._0xde116a41.gameObject.GetComponent<CanvasGroup>();
        if (_0x604b40cf == null)
            _0x604b40cf = this._0xde116a41.gameObject.AddComponent<CanvasGroup>();
        _0x604b40cf.DOFade(0.35f, 0.6f).SetLink(this._0xde116a41.gameObject);
    }

    public void _0xf7ccbdc7(int _0x12e13060, bool _0x5b7efd45)
    {
        if (this._0xd5a60f8f == null)
            return;
        this._0xd5a60f8f.text = _0x12e13060 + _0x58d69cbd._0xd07d5900(new byte[1] { 79 }, 55);
        if (_0x5b7efd45)
            this._0xd5a60f8f.transform.DOPunchScale(Vector3.one * 0.12f, 0.3f, 6, 0.6f).SetLink(this._0xd5a60f8f.gameObject);
    }

    private RectTransform _0xbc8beb54;
    public void _0xb35e6bb8(float _0x56b69f39)
    {
        if (this._0xbc8beb54 != null)
        {
            float _0x37807f78 = Mathf.Clamp01(_0x56b69f39);
            _0xa9abda03.SetBar(this._0xbc8beb54, this._0x4d85cc4d, _0x37807f78);
        }

        if (this._0x4241c43f != null)
            this._0x4241c43f.text = Mathf.RoundToInt(Mathf.Clamp01(_0x56b69f39) * 100f) + _0x58d69cbd._0xd07d5900(new byte[1] { 155 }, 190);
    }

    private _0x00711191 _0x9edba126;
    private Image _0xc0ec1e8b;
    private float _0x4d85cc4d = 620f;
    public void _0xbe0599e7(RectTransform _0x69db28ca, _0x4831bce5 _0xf714d02a, _0x00711191 _0x368c8618, bool _0xd6f28f61, int _0x2b253fd4)
    {
        this._0x1229ff6a = _0xf714d02a;
        this._0x9edba126 = _0x368c8618;
        RectTransform _0x588702e5 = _0xa9abda03.Stretch(_0x69db28ca, _0x58d69cbd._0xd07d5900(new byte[6] { 225, 230, 253, 219, 230, 247 }, 147), 0f);
        // Tap areas FIRST, so every HUD button added afterwards is a later sibling and wins
        // the raycast over them.
        this._0xc2ce21cc(_0x588702e5, _0x58d69cbd._0xd07d5900(new byte[7] { 222, 217, 198, 250, 211, 208, 194 }, 182), 0f, 0.5f, -1);
        this._0xc2ce21cc(_0x588702e5, _0x58d69cbd._0xd07d5900(new byte[8] { 36, 35, 60, 30, 37, 43, 36, 56 }, 76), 0.5f, 1f, 1);
        // The ember edge flash for a vent hit - transparent until it is needed.
        this._0x328ec061 = _0xa9abda03.PlateFill(_0x588702e5, _0x58d69cbd._0xd07d5900(new byte[9] { 123, 122, 121, 123, 88, 114, 127, 109, 118 }, 30), _0xf714d02a._0x6b00fe61, new Color(_0x82ba3493.Ember.r, _0x82ba3493.Ember.g, _0x82ba3493.Ember.b, 0f), 0f, 1f);
        bool _0x50beba99 = _0x49c993d5._0x8622cacd;
        float _0x207623ba = _0x50beba99 ? 500f : -500f;
        float _0xa9bc860d = _0x50beba99 ? -500f : 500f;
        Button _0x2e198316 = _0xa9abda03.IconButton(_0x588702e5, _0x58d69cbd._0xd07d5900(new byte[7] { 222, 221, 223, 215, 254, 200, 210 }, 188), _0xf714d02a, _0xf714d02a._0x6cfe7978, new Vector2(0.5f, 1f), new Vector2(_0x207623ba, -100f), 120f, _0x82ba3493.Fade(_0x82ba3493.SurfaceAlt, 0.92f), _0x82ba3493.Fade(_0x82ba3493.Gold, 0.65f));
        _0x2e198316.onClick.AddListener(() => this._0x9edba126._0x31c29b33());
        Button _0x2472e302 = _0xa9abda03.IconButton(_0x588702e5, _0x58d69cbd._0xd07d5900(new byte[8] { 142, 159, 139, 141, 155, 188, 138, 144 }, 254), _0xf714d02a, _0xf714d02a._0x8a934fbe, new Vector2(0.5f, 1f), new Vector2(_0xa9bc860d, -100f), 120f, _0x82ba3493.Fade(_0x82ba3493.SurfaceAlt, 0.92f), _0x82ba3493.Fade(_0x82ba3493.Ember, 0.75f));
        _0x2472e302.onClick.AddListener(() => this._0x9edba126._0x5275085d());
        this._0x6878b335 = _0xa9abda03.Label(_0x588702e5, _0x58d69cbd._0xd07d5900(new byte[9] { 165, 167, 172, 173, 138, 169, 172, 175, 173 }, 200), _0xf714d02a._0xb210014d, _0xd6f28f61 ? _0x58d69cbd._0xd07d5900(new byte[9] { 0, 11, 2, 15, 15, 6, 13, 4, 6 }, 67) : _0x58d69cbd._0xd07d5900(new byte[8] { 237, 225, 231, 224, 142, 252, 251, 224 }, 174), 30f, _0xd6f28f61 ? _0x82ba3493.EmberGlow : _0x82ba3493.GoldLight, TextAlignmentOptions.Center, new Vector2(0.5f, 1f), new Vector2(0f, -100f), new Vector2(380f, 52f));
        // The shield strip. Caption, bar and percent each keep their own x-band (C.25).
        _0xa9abda03.Label(_0x588702e5, _0x58d69cbd._0xd07d5900(new byte[13] { 239, 244, 245, 249, 240, 248, 223, 253, 236, 232, 245, 243, 242 }, 156), _0xf714d02a._0xb210014d, _0x58d69cbd._0xd07d5900(new byte[6] { 9, 18, 19, 31, 22, 30 }, 90), 30f, _0x82ba3493.TextMuted, TextAlignmentOptions.Right, new Vector2(0.5f, 1f), new Vector2(-480f, -214f), new Vector2(200f, 46f));
        this._0xbc8beb54 = _0xa9abda03.Bar(_0x588702e5, _0x58d69cbd._0xd07d5900(new byte[9] { 161, 186, 187, 183, 190, 182, 144, 179, 160 }, 210), _0xf714d02a._0x6b00fe61, new Vector2(0.5f, 1f), new Vector2(40f, -214f), new Vector2(this._0x4d85cc4d, 44f), _0x82ba3493.Fade(_0x82ba3493.SurfaceAlt, 0.95f), _0xd6f28f61 ? _0x82ba3493.Ember : _0x82ba3493.EmberGlow, 0.8f);
        this._0xc0ec1e8b = this._0xbc8beb54.GetComponent<Image>();
        this._0x4241c43f = _0xa9abda03.Label(_0x588702e5, _0x58d69cbd._0xd07d5900(new byte[13] { 146, 137, 136, 132, 141, 133, 177, 132, 147, 130, 132, 143, 149 }, 225), _0xf714d02a._0xb210014d, _0x58d69cbd._0xd07d5900(new byte[4] { 169, 168, 168, 189 }, 152), 32f, _0x82ba3493.TextPrimary, TextAlignmentOptions.Left, new Vector2(0.5f, 1f), new Vector2(460f, -214f), new Vector2(170f, 46f));
        this._0xc99f7469 = _0xa9abda03.Label(_0x588702e5, _0x58d69cbd._0xd07d5900(new byte[9] { 127, 115, 117, 114, 95, 115, 105, 114, 104 }, 28), _0xf714d02a._0xb210014d, _0x58d69cbd._0xd07d5900(new byte[4] { 47, 63, 48, 63 }, 31) + _0x2b253fd4, 64f, _0x82ba3493.Gold, TextAlignmentOptions.Left, new Vector2(0.5f, 1f), new Vector2(-330f, -336f), new Vector2(460f, 100f));
        this._0xd5a60f8f = _0xa9abda03.Label(_0x588702e5, _0x58d69cbd._0xd07d5900(new byte[10] { 176, 168, 177, 169, 180, 173, 177, 180, 184, 175 }, 221), _0xf714d02a._0xb210014d, _0x58d69cbd._0xd07d5900(new byte[2] { 166, 239 }, 151), 56f, _0x82ba3493.EmberGlow, TextAlignmentOptions.Right, new Vector2(0.5f, 1f), new Vector2(330f, -336f), new Vector2(260f, 100f));
        // C.6: the gesture hint names the gesture AND what it does, and it stays on screen.
        this._0xde116a41 = _0xa9abda03.Card(_0x588702e5, _0x58d69cbd._0xd07d5900(new byte[9] { 99, 98, 101, 127, 91, 103, 106, 127, 110 }, 11), _0xf714d02a._0x6b00fe61, new Vector2(0.5f, 0f), new Vector2(0f, 806f), new Vector2(980f, 130f), _0x82ba3493.Fade(_0x82ba3493.Ink, 0.60f), _0x82ba3493.Fade(_0x82ba3493.Gold, 0.45f), 1.6f);
        _0xa9abda03.Label(this._0xde116a41, _0x58d69cbd._0xd07d5900(new byte[8] { 4, 5, 2, 24, 56, 9, 20, 24 }, 108), _0xf714d02a._0xb210014d, _0x58d69cbd._0xd07d5900(new byte[35] { 174, 187, 170, 218, 182, 191, 188, 174, 218, 181, 168, 218, 168, 179, 189, 178, 174, 218, 169, 179, 190, 191, 240, 174, 181, 218, 178, 181, 170, 218, 174, 168, 187, 179, 182 }, 250), 38f, _0x82ba3493.TextPrimary, TextAlignmentOptions.Center, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(900f, 110f));
    }

    private RectTransform _0xde116a41;
    private TextMeshProUGUI _0x6878b335;
    public void _0xc051b3d6(int _0x58ec3886, int _0x57d6e26e)
    {
        if (this._0xc99f7469 == null)
            return;
        this._0xc99f7469.text = _0x58ec3886 + _0x58d69cbd._0xd07d5900(new byte[3] { 92, 83, 92 }, 124) + _0x57d6e26e;
        this._0xc99f7469.transform.DOPunchScale(Vector3.one * 0.06f, 0.2f, 6, 0.6f).SetLink(this._0xc99f7469.gameObject);
    }

    public void _0xa8ac437a(Color _0xc1d25cd8)
    {
        if (this._0x6878b335 != null)
            this._0x6878b335.color = _0xc1d25cd8;
    }

    private TextMeshProUGUI _0xd5a60f8f;
    public void _0x723a23c4()
    {
        if (this._0x328ec061 == null)
            return;
        DOTween.Kill(this._0x328ec061, true);
        this._0x328ec061.color = _0x82ba3493.Fade(_0x82ba3493.Ember, 0.45f);
        this._0x328ec061.DOFade(0f, 0.18f).SetLink(this._0x328ec061.gameObject);
    }

    private void OnDestroy()
    {
        if (this._0x328ec061 != null)
            DOTween.Kill(this._0x328ec061);
        if (this._0xc0ec1e8b != null)
            DOTween.Kill(this._0xc0ec1e8b);
        if (this._0xde116a41 != null)
            DOTween.Kill(this._0xde116a41);
    }

    private TextMeshProUGUI _0x4241c43f;
}

internal static class _0x58d69cbd
{
    internal static string _0xd07d5900(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}
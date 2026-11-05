using System.Collections;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Builds the menu. It owns NO splash logic of any kind (C.69): the template's own startup
/// flow decides when SPLASH gives way to DEFAULT, and all this does is WAIT for that to have
/// happened and then fill the DEFAULT panel's content.
///
/// The brief's nine screens become views inside that one panel, switched by MenuViewRouter
/// on plain int ids. No new panel index is invented, nothing is addressed by name.
/// </summary>
public sealed class _0x21abdfb6 : MonoBehaviour
{
    private _0xdc9b1f64 _0x4a8aaca3;
    private Image _0xb3b80aac;
    private TextMeshProUGUI _0x985192e5;
    public void _0xeecb2631()
    {
        if (this._0x481023b5 != null)
            this._0x481023b5.text = _0xec7175f7._0x05354bf3._0x2869e359.ToString();
        if (this._0xb796ef3d != null)
            this._0xb796ef3d.text = _0x2a41a57d._0x9b56ea76(new byte[7] { 91, 64, 73, 90, 76, 91, 40 }, 8) + _0x49c993d5._0xf5f133cb;
    }

    private IEnumerator _0x016fef8e()
    {
        yield return new WaitUntil(() => _0x3cddbc40.Instance != null && _0x3cddbc40.Instance.Panels != null);
        // Theme the splash while the template is still showing it. No timer, no hand-off.
        _0xd75e45b3 _0x09d811e8 = this._0x386ba18b(_0xec7175f7._0xd6f8c568.SPLASH);
        if (_0x09d811e8 != null)
        {
            _0xc8c98db1 _0x0a531722 = this.gameObject.AddComponent<_0xc8c98db1>();
            _0x0a531722._0x248eb4ff(_0x09d811e8, this._skin);
        }

        _0xd20544d3 _0x854d3016 = this.gameObject.AddComponent<_0xd20544d3>();
        _0x854d3016._0x2b310f53();
        // WAIT for the template's own switch. We never make it happen.
        yield return new WaitUntil(() => _0x3cddbc40.Instance.CurrentPanelIndex == _0xec7175f7._0xd6f8c568.DEFAULT);
        _0xd75e45b3 _0x872c77a5 = this._0x386ba18b(_0xec7175f7._0xd6f8c568.DEFAULT);
        if (_0x872c77a5 == null || _0x872c77a5.Content == null)
            yield break;
        this._0x11938ba3(_0x872c77a5);
    }

    private const float StageCardWidth = 1040f;
    private const float StageCardHeight = 520f;
    private RectTransform _0x17a56472;
    private TextMeshProUGUI _0x481023b5;
    private Image _0xd4163a22;
    private void _0xb4120138()
    {
        if (this._0x2bf3ecd7 != null)
        {
            Vector2 _0x0268f85e = this._0x2bf3ecd7.anchoredPosition;
            this._0x2bf3ecd7.anchoredPosition = _0x0268f85e + new Vector2(0f, -24f);
            this._0x2bf3ecd7.DOAnchorPos(_0x0268f85e, 0.35f).SetEase(Ease.OutCubic).SetLink(this._0x2bf3ecd7.gameObject);
        }

        if (this._0x17a56472 != null)
        {
            Vector2 _0xa7020c01 = this._0x17a56472.anchoredPosition;
            this._0x17a56472.anchoredPosition = _0xa7020c01 + new Vector2(0f, -24f);
            this._0x17a56472.DOAnchorPos(_0xa7020c01, 0.35f).SetDelay(0.07f).SetEase(Ease.OutCubic).SetLink(this._0x17a56472.gameObject);
        }
    }

    private const float GutterCentre = 62f;
    private void Start()
    {
        this.StartCoroutine(this._0x016fef8e());
    }

    private RectTransform _0x9c9ecef8;
    private TextMeshProUGUI _0xb796ef3d;
    private void _0x462ec837()
    {
        // One attempt counter, so the generator seed differs on every run (C.11).
        _0x49c993d5._0x472a9861 = _0x49c993d5._0x472a9861 + 1;
    }

    private void _0xbbe41602<T>(RectTransform _0x594b3eee, int _0xf2a970c0)
        where T : MonoBehaviour
    {
        RectTransform _0x9bfd6982 = _0xa9abda03.Stretch(_0x594b3eee, _0x2a41a57d._0x9b56ea76(new byte[4] { 229, 250, 246, 228 }, 147), 0f);
        this._0x471886fc._0xafef2a18(_0xf2a970c0, _0x9bfd6982);
        T _0x18f4a196 = _0x9bfd6982.gameObject.AddComponent<T>();
        _0x3b841cb4 _0x258099fa = _0x18f4a196 as _0x3b841cb4;
        if (_0x258099fa != null)
            _0x258099fa._0xba79e93f(this._skin, this._0x471886fc, this);
        _0x741d0e0e _0x30e9ecd4 = _0x18f4a196 as _0x741d0e0e;
        if (_0x30e9ecd4 != null)
            _0x30e9ecd4._0xf87c15f5(this._skin, this._0x471886fc, this);
        _0xe5156c1c _0x864f0c56 = _0x18f4a196 as _0xe5156c1c;
        if (_0x864f0c56 != null)
            _0x864f0c56._0x7e3955ed(this._skin, this._0x471886fc, this);
        _0x7beb7f58 _0xbb3573e8 = _0x18f4a196 as _0x7beb7f58;
        if (_0xbb3573e8 != null)
            _0xbb3573e8._0x2de7a4b3(this._skin, this._0x471886fc);
        _0xf38bd294 _0x2d0b261a = _0x18f4a196 as _0xf38bd294;
        if (_0x2d0b261a != null)
            _0x2d0b261a._0x000832b1(this._skin, this._0x471886fc, this);
        _0x9bfd6982.gameObject.SetActive(false);
    }

    private RectTransform _0xd47b7b19;
    private void _0x5f5059fd(RectTransform _0x345e73f0, Button _0xabf8f4ca)
    {
        _0xa9abda03.Backdrop(_0x345e73f0, this._skin, 0.30f);
        this._0x89b1034b(_0x345e73f0);
        // The abstract ember mark. No letters anywhere on it, and no title beside it.
        RectTransform _0xcf096cbc = _0xa9abda03.Node(_0x345e73f0, _0x2a41a57d._0x9b56ea76(new byte[8] { 106, 98, 105, 114, 74, 102, 117, 108 }, 7), new Vector2(0.5f, 1f), new Vector2(0f, -320f), new Vector2(300f, 300f));
        _0xa9abda03.PlateFill(_0xcf096cbc, _0x2a41a57d._0x9b56ea76(new byte[8] { 196, 200, 219, 194, 238, 197, 198, 222 }, 169), this._skin._0x6b00fe61, _0x82ba3493.Fade(_0x82ba3493.EmberGlow, 0.12f), -36f, 0.2f);
        Image _0xf44b0dab = _0xcf096cbc.gameObject.AddComponent<Image>();
        _0xf44b0dab.sprite = this._skin._0x4f9e69a6;
        _0xf44b0dab.color = Color.white;
        _0xf44b0dab.preserveAspect = true;
        _0xf44b0dab.raycastTarget = false;
        _0xa9abda03.Label(_0x345e73f0, _0x2a41a57d._0x9b56ea76(new byte[9] { 105, 100, 108, 99, 101, 114, 111, 112, 99 }, 6), this._skin._0xb210014d, _0x2a41a57d._0x9b56ea76(new byte[54] { 182, 185, 188, 184, 183, 213, 161, 189, 176, 213, 161, 167, 180, 188, 185, 255, 179, 188, 185, 185, 213, 161, 189, 176, 213, 164, 160, 186, 161, 180, 213, 183, 176, 179, 186, 167, 176, 213, 161, 189, 176, 213, 166, 189, 188, 176, 185, 177, 213, 182, 186, 186, 185, 166 }, 245), 34f, _0x82ba3493.TextMuted, TextAlignmentOptions.Center, new Vector2(0.5f, 1f), new Vector2(0f, -560f), new Vector2(1000f, 120f));
        RectTransform _0x5fbe79b8 = _0xa9abda03.Band(_0x345e73f0, _0x2a41a57d._0x9b56ea76(new byte[8] { 255, 247, 252, 231, 208, 243, 252, 246 }, 146), 940f, 680f, 1100f);
        this._0x2acad4f8(_0x5fbe79b8);
        this._0x4a22fb3b(_0x345e73f0);
        // The CTA face: our own node, drawn after the template button and with raycasts off,
        // so the tap still reaches the template driver that loads SCENE_1.
        this._0x4a8aaca3 = this.gameObject.AddComponent<_0xdc9b1f64>();
        this._0x4a8aaca3._0xfde7350a(_0xabf8f4ca, _0x345e73f0, this._skin, this._0xb7afc672());
        if (_0xabf8f4ca != null)
        {
            _0xabf8f4ca.onClick.AddListener(() => this._0x462ec837());
            // The template parents this button into the panel Content, not into our HOME
            // view, so the router has to switch it off by hand on every other view.
            this._0x471886fc._0x4cb32886(_0xabf8f4ca.gameObject);
        }

        this._0x470a85a1(_0x345e73f0);
        this._0x07e58f96();
    }

    [SerializeField]
    private _0x4831bce5 _skin;
    private Image _0x698075cf;
    private void _0x2acad4f8(RectTransform _0x6cc1ff40)
    {
        RectTransform _0x55c7d7af = _0xa9abda03.Card(_0x6cc1ff40, _0x2a41a57d._0x9b56ea76(new byte[9] { 11, 12, 25, 31, 29, 59, 25, 10, 28 }, 120), this._skin._0x6b00fe61, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(StageCardWidth, StageCardHeight), _0x82ba3493.Fade(_0x82ba3493.Surface, 0.94f), _0x82ba3493.Fade(_0x82ba3493.Gold, 0.8f), 1.4f, out this._0xb3b80aac);
        this._0x2bf3ecd7 = _0x55c7d7af;
        // Stage pip gutter, alone in its x-band.
        _0xa9abda03.Plate(_0x55c7d7af, _0x2a41a57d._0x9b56ea76(new byte[8] { 246, 239, 246, 210, 244, 231, 229, 237 }, 134), this._skin._0x6b00fe61, _0x82ba3493.Fade(_0x82ba3493.Ink, 0.7f), new Vector2(0f, 1f), new Vector2(GutterCentre, -200f), new Vector2(GutterWidth, 320f), 0.9f);
        for (int _0x3085e3df = 0; _0x3085e3df < _0x46df03e4.StageCount; _0x3085e3df++)
        {
            Color _0x94ca12bc = _0x3085e3df <= _0x49c993d5._0x7566d207 ? _0x82ba3493.Gold : _0x82ba3493.Fade(_0x82ba3493.TextMuted, 0.3f);
            _0xa9abda03.Plate(_0x55c7d7af, _0x2a41a57d._0x9b56ea76(new byte[3] { 145, 136, 145 }, 225), this._skin._0x6b00fe61, _0x94ca12bc, new Vector2(0f, 1f), new Vector2(GutterCentre, -70f - _0x3085e3df * 37f), new Vector2(22f, 22f), 0.2f);
        }

        float _0xf62951f3 = TextLeft + TextWidth * 0.5f;
        this._0x985192e5 = _0xa9abda03.Label(_0x55c7d7af, _0x2a41a57d._0x9b56ea76(new byte[12] { 33, 38, 51, 53, 55, 26, 55, 51, 54, 59, 60, 53 }, 82), this._skin._0xb210014d, string.Empty, 48f, _0x82ba3493.TextPrimary, TextAlignmentOptions.Left, new Vector2(0f, 1f), new Vector2(_0xf62951f3, -70f), new Vector2(TextWidth, 62f));
        this._0x5c899942 = _0xa9abda03.Label(_0x55c7d7af, _0x2a41a57d._0x9b56ea76(new byte[10] { 151, 144, 133, 131, 129, 181, 145, 139, 144, 133 }, 228), this._skin._0xb210014d, string.Empty, 34f, _0x82ba3493.Gold, TextAlignmentOptions.Left, new Vector2(0f, 1f), new Vector2(_0xf62951f3, -150f), new Vector2(TextWidth, 48f));
        this._0x9c9ecef8 = _0xa9abda03.Bar(_0x55c7d7af, _0x2a41a57d._0x9b56ea76(new byte[8] { 22, 17, 4, 2, 0, 39, 4, 23 }, 101), this._skin._0x6b00fe61, new Vector2(0f, 1f), new Vector2(_0xf62951f3, -212f), new Vector2(TextWidth, 22f), _0x82ba3493.Fade(_0x82ba3493.Ink, 0.8f), _0x82ba3493.Gold, 0.8f);
        this._0xf2daf83a = _0xa9abda03.Label(_0x55c7d7af, _0x2a41a57d._0x9b56ea76(new byte[9] { 76, 75, 94, 88, 90, 125, 90, 76, 75 }, 63), this._skin._0xb210014d, string.Empty, 44f, _0x82ba3493.GoldLight, TextAlignmentOptions.Right, new Vector2(1f, 1f), new Vector2(-130f, -70f), new Vector2(200f, 58f));
        string[] _0x59151494 =
        {
            _0x49c993d5._0x924ddf27.ToString(),
            _0x49c993d5._0xd231b447 + _0x2a41a57d._0x9b56ea76(new byte[1] { 86 }, 46),
            _0x49c993d5._0xaff2bc43.ToString()
        };
        string[] _0x9718644e =
        {
            _0x2a41a57d._0x9b56ea76(new byte[8] { 82, 85, 67, 68, 48, 66, 69, 94 }, 16),
            _0x2a41a57d._0x9b56ea76(new byte[10] { 255, 248, 238, 233, 157, 254, 245, 252, 244, 243 }, 189),
            _0x2a41a57d._0x9b56ea76(new byte[6] { 32, 47, 42, 46, 33, 48 }, 99)
        };
        Color[] _0x7714c49c =
        {
            _0x82ba3493.Gold,
            _0x82ba3493.EmberGlow,
            _0x82ba3493.TextPrimary
        };
        _0x5bd33973.Row(_0x55c7d7af, this._skin, _0x59151494, _0x9718644e, _0x7714c49c, new Vector2(0.5f, 0f), new Vector2(0f, 104f), 940f, 160f);
    }

    private _0xd75e45b3 _0x386ba18b(int _0xec4e41f2)
    {
        _0x3cddbc40 _0x8e014449 = _0x3cddbc40.Instance;
        if (_0x8e014449 == null || _0x8e014449.Panels == null || _0xec4e41f2 < 0 || _0xec4e41f2 >= _0x8e014449.Panels.Count)
            return null;
        return _0x8e014449.Panels[_0xec4e41f2];
    }

    private const float TextLeft = GutterCentre + GutterWidth * 0.5f + 46f; // 129
    private TextMeshProUGUI _0x5c899942;
    public void _0x07e58f96()
    {
        bool _0x76555d20 = _0x49c993d5._0x66e15572;
        int _0x1d36fb49 = _0x49c993d5._0x7566d207;
        int _0x276ecfb9 = _0x46df03e4.Quota(_0x1d36fb49, _0x76555d20);
        Color _0xc1c463e9 = _0x76555d20 ? _0x82ba3493.EmberGlow : _0x82ba3493.Gold;
        if (this._0x985192e5 != null)
            this._0x985192e5.text = _0x2a41a57d._0x9b56ea76(new byte[6] { 48, 55, 34, 36, 38, 67 }, 99) + (_0x1d36fb49 + 1) + _0x2a41a57d._0x9b56ea76(new byte[3] { 243, 254, 243 }, 211) + _0x46df03e4.Name(_0x1d36fb49);
        if (this._0x5c899942 != null)
        {
            this._0x5c899942.text = _0x2a41a57d._0x9b56ea76(new byte[6] { 247, 243, 233, 242, 231, 134 }, 166) + _0x276ecfb9 + _0x2a41a57d._0x9b56ea76(new byte[6] { 180, 215, 219, 221, 218, 199 }, 148);
            this._0x5c899942.color = _0xc1c463e9;
        }

        if (this._0xf2daf83a != null)
            this._0xf2daf83a.text = _0x2a41a57d._0x9b56ea76(new byte[5] { 88, 95, 73, 78, 58 }, 26) + _0x49c993d5._0x924ddf27;
        if (this._0xb3b80aac != null)
            this._0xb3b80aac.color = _0x82ba3493.Fade(_0xc1c463e9, 0.85f);
        if (this._0x9c9ecef8 != null)
        {
            float _0xd65c031d = _0x276ecfb9 > 0 ? Mathf.Clamp01((float)_0x49c993d5._0x924ddf27 / _0x276ecfb9) : 0f;
            _0xa9abda03.SetBar(this._0x9c9ecef8, TextWidth, _0xd65c031d);
            Image _0x0eace91f = this._0x9c9ecef8.GetComponent<Image>();
            if (_0x0eace91f != null)
                _0x0eace91f.color = _0xc1c463e9;
        }
    }

    private const float GutterWidth = 42f;
    private string _0xb7afc672()
    {
        return _0x49c993d5._0x66e15572 ? _0x2a41a57d._0x9b56ea76(new byte[15] { 13, 10, 31, 12, 10, 126, 29, 22, 31, 18, 18, 27, 16, 25, 27 }, 94) : _0x2a41a57d._0x9b56ea76(new byte[11] { 242, 245, 224, 243, 245, 129, 226, 237, 232, 236, 227 }, 161);
    }

    private void _0x470a85a1(RectTransform _0x78d721ed)
    {
        float[] _0xcb1517a5 =
        {
            -391f,
            -130f,
            130f,
            391f
        };
        string[] _0xe7984614 =
        {
            _0x2a41a57d._0x9b56ea76(new byte[9] { 179, 181, 166, 174, 171, 199, 170, 166, 183 }, 231),
            _0x2a41a57d._0x9b56ea76(new byte[10] { 234, 231, 239, 224, 230, 241, 236, 243, 224, 246 }, 165),
            _0x2a41a57d._0x9b56ea76(new byte[7] { 5, 18, 0, 22, 5, 19, 4 }, 87),
            _0x2a41a57d._0x9b56ea76(new byte[7] { 182, 180, 169, 160, 175, 170, 163 }, 230)
        };
        int[] _0xc46d9fa1 =
        {
            _0x5681a043.ViewStageMap,
            _0x5681a043.ViewMissions,
            _0x5681a043.ViewRewards,
            _0x5681a043.ViewProfile
        };
        for (int _0xdf56bd62 = 0; _0xdf56bd62 < 4; _0xdf56bd62++)
        {
            Button _0x84228096 = _0xa9abda03.IconButton(_0x78d721ed, _0x2a41a57d._0x9b56ea76(new byte[6] { 200, 199, 208, 228, 210, 200 }, 166), this._skin, this._skin._0x8aa46131, new Vector2(0.5f, 0f), new Vector2(_0xcb1517a5[_0xdf56bd62], 330f), 150f, _0x82ba3493.Fade(_0x82ba3493.SurfaceAlt, 0.92f), _0x82ba3493.Fade(_0x82ba3493.Gold, 0.6f));
            this._0x134748d7(_0x84228096.transform, _0xdf56bd62);
            _0xa9abda03.Label(_0x78d721ed, _0x2a41a57d._0x9b56ea76(new byte[10] { 49, 62, 41, 28, 62, 47, 43, 54, 48, 49 }, 95), this._skin._0xb210014d, _0xe7984614[_0xdf56bd62], 26f, _0x82ba3493.TextMuted, TextAlignmentOptions.Center, new Vector2(0.5f, 0f), new Vector2(_0xcb1517a5[_0xdf56bd62], 222f), new Vector2(240f, 40f));
            int _0x756b6c6a = _0xc46d9fa1[_0xdf56bd62];
            _0x84228096.onClick.AddListener(() => this._0x471886fc._0x848b1f13(_0x756b6c6a));
        }
    }

    private TextMeshProUGUI _0xf2daf83a;
    private void _0x89b1034b(RectTransform _0xe5e02f10)
    {
        RectTransform _0x228c9da5 = _0xa9abda03.Card(_0xe5e02f10, _0x2a41a57d._0x9b56ea76(new byte[6] { 43, 48, 47, 29, 62, 45 }, 95), this._skin._0x6b00fe61, new Vector2(0.5f, 1f), new Vector2(0f, -96f), new Vector2(1130f, 120f), _0x82ba3493.Fade(_0x82ba3493.Ink, 0.55f), _0x82ba3493.Fade(_0x82ba3493.Gold, 0.35f), 2.6f);
        // Rank chip, left. Its own x-band, far from the counters on the right.
        _0xa9abda03.Dot(_0x228c9da5, this._skin._0x6b00fe61, new Vector2(0f, 0.5f), new Vector2(44f, 0f), 18f, _0x82ba3493.Gold);
        _0xa9abda03.Label(_0x228c9da5, _0x2a41a57d._0x9b56ea76(new byte[8] { 79, 92, 83, 86, 126, 85, 84, 77 }, 61), this._skin._0xb210014d, _0x2a41a57d._0x9b56ea76(new byte[5] { 66, 81, 94, 91, 48 }, 16) + _0x49c993d5._0x1dccfdfc + _0x2a41a57d._0x9b56ea76(new byte[3] { 232, 229, 232 }, 200) + _0x49c993d5._0x6100a2f1, 28f, _0x82ba3493.TextMuted, TextAlignmentOptions.Left, new Vector2(0f, 0.5f), new Vector2(80f + 380f * 0.5f, 0f), new Vector2(380f, 48f));
        Button _0xaeca29cc = _0xa9abda03.HitButton(_0x228c9da5, _0x2a41a57d._0x9b56ea76(new byte[7] { 174, 189, 178, 183, 136, 189, 172 }, 220), this._skin._0x6b00fe61, new Vector2(0f, 0.5f), new Vector2(240f, 0f), new Vector2(470f, 110f));
        _0xaeca29cc.onClick.AddListener(() => this._0x471886fc._0x848b1f13(_0x5681a043.ViewProfile));
        this._0x481023b5 = _0xa9abda03.Label(_0x228c9da5, _0x2a41a57d._0x9b56ea76(new byte[5] { 223, 211, 213, 210, 207 }, 188), this._skin._0xb210014d, _0xec7175f7._0x05354bf3._0x2869e359.ToString(), 38f, _0x82ba3493.Gold, TextAlignmentOptions.Right, new Vector2(1f, 0.5f), new Vector2(-320f, 24f), new Vector2(300f, 48f));
        this._0xb796ef3d = _0xa9abda03.Label(_0x228c9da5, _0x2a41a57d._0x9b56ea76(new byte[6] { 147, 136, 129, 146, 132, 147 }, 224), this._skin._0xb210014d, _0x2a41a57d._0x9b56ea76(new byte[7] { 147, 136, 129, 146, 132, 147, 224 }, 192) + _0x49c993d5._0xf5f133cb, 28f, _0x82ba3493.TextMuted, TextAlignmentOptions.Right, new Vector2(1f, 0.5f), new Vector2(-320f, -26f), new Vector2(300f, 42f));
        Button _0xd2b7b465 = _0xa9abda03.IconButton(_0x228c9da5, _0x2a41a57d._0x9b56ea76(new byte[11] { 224, 246, 231, 231, 250, 253, 244, 224, 209, 231, 253 }, 147), this._skin, this._skin._0x8aa46131, new Vector2(1f, 0.5f), new Vector2(-72f, 0f), 100f, _0x82ba3493.Fade(_0x82ba3493.SurfaceAlt, 0.9f), _0x82ba3493.Fade(_0x82ba3493.Gold, 0.6f));
        // A gear drawn from rotated bars plus a ring: no emoji, no high-codepoint glyph (C.15/16).
        for (int _0x9285b320 = 0; _0x9285b320 < 4; _0x9285b320++)
        {
            RectTransform _0x744db884 = _0xa9abda03.Node(_0xd2b7b465.transform, _0x2a41a57d._0x9b56ea76(new byte[5] { 9, 18, 18, 9, 21 }, 125), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(56f, 14f));
            Image _0x900c142d = _0x744db884.gameObject.AddComponent<Image>();
            _0x900c142d.sprite = this._skin._0x6b00fe61;
            _0x900c142d.type = Image.Type.Sliced; // a 9-slice plate, never aspect-preserved
            _0xa9abda03.Slice(_0x900c142d, 2.5f);
            _0x900c142d.color = _0x82ba3493.GoldLight;
            _0x900c142d.raycastTarget = false;
            _0x744db884.localRotation = Quaternion.Euler(0f, 0f, _0x9285b320 * 45f);
        }

        _0xa9abda03.Plate(_0xd2b7b465.transform, _0x2a41a57d._0x9b56ea76(new byte[7] { 74, 72, 76, 95, 101, 88, 79 }, 45), this._skin._0x6b00fe61, _0x82ba3493.Fade(_0x82ba3493.SurfaceAlt, 1f), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(26f, 26f), 0.2f);
        _0xd2b7b465.onClick.AddListener(() => this._0x471886fc._0x848b1f13(_0x5681a043.ViewSettings));
    }

    private const float TextWidth = 640f;
    private void _0x4a22fb3b(RectTransform _0xbd9db38f)
    {
        RectTransform _0x51a4ae04 = _0xa9abda03.Node(_0xbd9db38f, _0x2a41a57d._0x9b56ea76(new byte[7] { 132, 134, 141, 140, 187, 134, 158 }, 233), new Vector2(0.5f, 0f), new Vector2(0f, 846f), new Vector2(1040f, 130f));
        this._0x17a56472 = _0x51a4ae04;
        RectTransform _0xbfc8a41b = _0xa9abda03.Card(_0x51a4ae04, _0x2a41a57d._0x9b56ea76(new byte[9] { 72, 74, 65, 64, 113, 87, 68, 76, 73 }, 37), this._skin._0x6b00fe61, new Vector2(0.5f, 0.5f), new Vector2(-262f, 0f), new Vector2(500f, 130f), _0x82ba3493.Fade(_0x82ba3493.SurfaceWarm, 0.95f), _0x82ba3493.Fade(_0x82ba3493.Ember, 0.9f), 1.4f, out this._0x56505b5b, out this._0xe115b39b);
        _0xa9abda03.Label(_0xbfc8a41b, _0x2a41a57d._0x9b56ea76(new byte[14] { 11, 9, 2, 3, 50, 20, 7, 15, 10, 42, 7, 4, 3, 10 }, 102), this._skin._0xb210014d, _0x2a41a57d._0x9b56ea76(new byte[8] { 169, 165, 163, 164, 202, 184, 191, 164 }, 234), 36f, _0x82ba3493.TextPrimary, TextAlignmentOptions.Center, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(440f, 56f));
        Button _0xadb1c0f8 = _0xa9abda03.HitButton(_0xbfc8a41b, _0x2a41a57d._0x9b56ea76(new byte[12] { 178, 176, 187, 186, 139, 173, 190, 182, 179, 139, 190, 175 }, 223), this._skin._0x6b00fe61, new Vector2(500f, 130f));
        _0xadb1c0f8.onClick.AddListener(() => this._0x78e31adc(false));
        RectTransform _0xef6240bd = _0xa9abda03.Card(_0x51a4ae04, _0x2a41a57d._0x9b56ea76(new byte[13] { 217, 219, 208, 209, 247, 220, 213, 216, 216, 209, 218, 211, 209 }, 180), this._skin._0x6b00fe61, new Vector2(0.5f, 0.5f), new Vector2(262f, 0f), new Vector2(500f, 130f), _0x82ba3493.Fade(_0x82ba3493.Surface, 0.5f), _0x82ba3493.Fade(_0x82ba3493.TextMuted, 0.35f), 1.4f, out this._0xd4163a22, out this._0x698075cf);
        _0xa9abda03.Label(_0xef6240bd, _0x2a41a57d._0x9b56ea76(new byte[18] { 129, 131, 136, 137, 175, 132, 141, 128, 128, 137, 130, 139, 137, 160, 141, 142, 137, 128 }, 236), this._skin._0xb210014d, _0x2a41a57d._0x9b56ea76(new byte[9] { 227, 232, 225, 236, 236, 229, 238, 231, 229 }, 160), 36f, _0x82ba3493.TextPrimary, TextAlignmentOptions.Center, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(440f, 56f));
        Button _0x9b953fb0 = _0xa9abda03.HitButton(_0xef6240bd, _0x2a41a57d._0x9b56ea76(new byte[16] { 101, 103, 108, 109, 75, 96, 105, 100, 100, 109, 102, 111, 109, 92, 105, 120 }, 8), this._skin._0x6b00fe61, new Vector2(500f, 130f));
        _0x9b953fb0.onClick.AddListener(() => this._0x78e31adc(true));
    }

    private void OnDestroy()
    {
        if (this._0x2bf3ecd7 != null)
            DOTween.Kill(this._0x2bf3ecd7);
        if (this._0x17a56472 != null)
            DOTween.Kill(this._0x17a56472);
    }

    /// <summary>
    /// Four visible changes on one tap (C.7): the chips swap fill and border, the stage card
    /// border and quota recolour gold to ember, the quota NUMBER changes, and the CTA caption
    /// changes with it.
    /// </summary>
    private void _0x78e31adc(bool _0xdd329bfc)
    {
        _0x49c993d5._0x66e15572 = _0xdd329bfc;
        if (this._0x56505b5b != null)
            this._0x56505b5b.color = _0xdd329bfc ? _0x82ba3493.Fade(_0x82ba3493.TextMuted, 0.35f) : _0x82ba3493.Fade(_0x82ba3493.Ember, 0.9f);
        if (this._0xe115b39b != null)
            this._0xe115b39b.color = _0xdd329bfc ? _0x82ba3493.Fade(_0x82ba3493.Surface, 0.5f) : _0x82ba3493.Fade(_0x82ba3493.SurfaceWarm, 0.95f);
        if (this._0xd4163a22 != null)
            this._0xd4163a22.color = _0xdd329bfc ? _0x82ba3493.Fade(_0x82ba3493.Ember, 0.9f) : _0x82ba3493.Fade(_0x82ba3493.TextMuted, 0.35f);
        if (this._0x698075cf != null)
            this._0x698075cf.color = _0xdd329bfc ? _0x82ba3493.Fade(_0x82ba3493.SurfaceWarm, 0.95f) : _0x82ba3493.Fade(_0x82ba3493.Surface, 0.5f);
        RectTransform _0x29311756 = _0xdd329bfc ? this._0xd4163a22.rectTransform.parent as RectTransform : this._0x56505b5b.rectTransform.parent as RectTransform;
        if (_0x29311756 != null)
            _0x29311756.DOPunchScale(Vector3.one * 0.06f, 0.25f, 6, 0.6f).SetLink(_0x29311756.gameObject);
        if (this._0x4a8aaca3 != null)
            this._0x4a8aaca3._0x92c3cda8(this._0xb7afc672());
        this._0x07e58f96();
    }

    private RectTransform _0x2bf3ecd7;
    private void _0x11938ba3(_0xd75e45b3 _0x9aa2b020)
    {
        RectTransform _0x73a16db1 = _0x9aa2b020.Content.transform as RectTransform;
        if (_0x73a16db1 == null)
            return;
        // The Play button is the template's own instance, found by TYPE - at this point it is
        // the only Button under the DEFAULT panel, because nothing of ours is there yet.
        Button _0x29e303a9 = _0x73a16db1.GetComponentInChildren<Button>(true);
        RectTransform _0xe6322dcc = _0xa9abda03.Stretch(_0x73a16db1, _0x2a41a57d._0x9b56ea76(new byte[9] { 172, 170, 185, 177, 180, 149, 189, 182, 173 }, 216), 0f);
        this._0x471886fc = _0xe6322dcc.gameObject.AddComponent<_0xee14bec2>();
        this._0xd47b7b19 = _0xa9abda03.Stretch(_0xe6322dcc, _0x2a41a57d._0x9b56ea76(new byte[8] { 211, 204, 192, 210, 237, 202, 200, 192 }, 165), 0f);
        this._0x471886fc._0xafef2a18(_0x5681a043.ViewHome, this._0xd47b7b19);
        this._0x5f5059fd(this._0xd47b7b19, _0x29e303a9);
        this._0xbbe41602<_0x3b841cb4>(_0xe6322dcc, _0x5681a043.ViewStageMap);
        this._0xbbe41602<_0x741d0e0e>(_0xe6322dcc, _0x5681a043.ViewRewards);
        this._0xbbe41602<_0xe5156c1c>(_0xe6322dcc, _0x5681a043.ViewMissions);
        this._0xbbe41602<_0x7beb7f58>(_0xe6322dcc, _0x5681a043.ViewProfile);
        this._0xbbe41602<_0xf38bd294>(_0xe6322dcc, _0x5681a043.ViewSettings);
        this._0x471886fc._0x848b1f13(_0x5681a043.ViewHome);
        this._0xb4120138();
    }

    private Image _0xe115b39b;
    private Image _0x56505b5b;
    /// <summary>Glyphs drawn from 9-slice bars and rings - never an emoji, never a raster icon.</summary>
    private void _0x134748d7(Transform _0xb90bcd39, int _0xb199e865)
    {
        Color _0x4a0d284c = _0x82ba3493.GoldLight;
        if (_0xb199e865 == 0)
        {
            for (int _0x24d2388a = 0; _0x24d2388a < 3; _0x24d2388a++)
                _0xa9abda03.Plate(_0xb90bcd39, _0x2a41a57d._0x9b56ea76(new byte[8] { 97, 106, 127, 118, 110, 68, 103, 116 }, 6), this._skin._0x6b00fe61, _0x4a0d284c, new Vector2(0.5f, 0.5f), new Vector2(0f, 22f - _0x24d2388a * 22f), new Vector2(54f - _0x24d2388a * 10f, 10f), 2.5f);
            return;
        }

        if (_0xb199e865 == 1)
        {
            for (int _0x0518a833 = 0; _0x0518a833 < 3; _0x0518a833++)
            {
                _0xa9abda03.Plate(_0xb90bcd39, _0x2a41a57d._0x9b56ea76(new byte[8] { 124, 119, 98, 107, 115, 95, 116, 111 }, 27), this._skin._0x6b00fe61, _0x4a0d284c, new Vector2(0.5f, 0.5f), new Vector2(-26f, 22f - _0x0518a833 * 22f), new Vector2(12f, 12f), 0.2f);
                _0xa9abda03.Plate(_0xb90bcd39, _0x2a41a57d._0x9b56ea76(new byte[9] { 20, 31, 10, 3, 27, 63, 26, 29, 22 }, 115), this._skin._0x6b00fe61, _0x4a0d284c, new Vector2(0.5f, 0.5f), new Vector2(8f, 22f - _0x0518a833 * 22f), new Vector2(44f, 8f), 2.5f);
            }

            return;
        }

        if (_0xb199e865 == 2)
        {
            _0xa9abda03.Plate(_0xb90bcd39, _0x2a41a57d._0x9b56ea76(new byte[9] { 29, 22, 3, 10, 18, 40, 19, 20, 29 }, 122), this._skin._0x6b00fe61, _0x4a0d284c, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(56f, 56f), 0.2f);
            _0xa9abda03.Plate(_0xb90bcd39, _0x2a41a57d._0x9b56ea76(new byte[9] { 207, 196, 209, 216, 192, 235, 199, 218, 205 }, 168), this._skin._0x6b00fe61, _0x82ba3493.SurfaceAlt, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(30f, 30f), 0.2f);
            _0xa9abda03.Plate(_0xb90bcd39, _0x2a41a57d._0x9b56ea76(new byte[10] { 111, 100, 113, 120, 96, 91, 120, 105, 122, 99 }, 8), this._skin._0x6b00fe61, _0x82ba3493.Ember, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(14f, 14f), 0.2f);
            return;
        }

        _0xa9abda03.Plate(_0xb90bcd39, _0x2a41a57d._0x9b56ea76(new byte[9] { 121, 114, 103, 110, 118, 86, 123, 127, 122 }, 30), this._skin._0x6b00fe61, _0x4a0d284c, new Vector2(0.5f, 0.5f), new Vector2(0f, 18f), new Vector2(30f, 30f), 0.2f);
        _0xa9abda03.Plate(_0xb90bcd39, _0x2a41a57d._0x9b56ea76(new byte[9] { 55, 60, 41, 32, 56, 18, 63, 52, 41 }, 80), this._skin._0x6b00fe61, _0x4a0d284c, new Vector2(0.5f, 0.5f), new Vector2(0f, -20f), new Vector2(58f, 30f), 0.7f);
    }

    private _0xee14bec2 _0x471886fc;
}

internal static class _0x2a41a57d
{
    internal static string _0x9b56ea76(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}
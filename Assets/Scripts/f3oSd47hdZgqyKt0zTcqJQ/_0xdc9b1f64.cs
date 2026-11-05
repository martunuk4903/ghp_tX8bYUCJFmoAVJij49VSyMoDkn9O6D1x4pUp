using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

/// <summary>
/// The menu's Play button is the template's own EMPTY_BASE_BUTTON instance, which already
/// carries the LoadSceneButton driver to SCENE_1 - so it is wired and we never add a second
/// one next to it (H). Two things are missing and both are ours:
///
///  * SIZE (G.3). The template ships it stretched 0..0.93 with sizeDelta 0x0, i.e. a slab
///    over the whole menu. The scene sets collapsed point anchors and a real sizeDelta; this
///    re-asserts the same numbers at runtime so the visible face and the hit rect coincide.
///  * A FACE. That variant renders nothing: its decorative layers are switched off and the
///    survivors paint through a stencil whose writers are switched off with them. So the
///    face is our OWN node, drawn after the button and with raycastTarget off, and the
///    template's own caption is blanked so exactly one PLAY/START literal is on screen.
/// </summary>
public sealed class _0xdc9b1f64 : MonoBehaviour
{
    /// <summary>A visible press, so a tap is never a guess (C.7).</summary>
    private void _0x3a7b5060(Button _0x6b494bb0)
    {
        EventTrigger _0x7655a3af = _0x6b494bb0.gameObject.GetComponent<EventTrigger>();
        if (_0x7655a3af == null)
            _0x7655a3af = _0x6b494bb0.gameObject.AddComponent<EventTrigger>();
        EventTrigger.Entry _0x2831ff04 = new EventTrigger.Entry();
        _0x2831ff04.eventID = EventTriggerType.PointerDown;
        _0x2831ff04.callback.AddListener((BaseEventData _0x65c2cc23) => this._0xa354d89a());
        _0x7655a3af.triggers.Add(_0x2831ff04);
        EventTrigger.Entry _0x667b4bd8 = new EventTrigger.Entry();
        _0x667b4bd8.eventID = EventTriggerType.PointerUp;
        _0x667b4bd8.callback.AddListener((BaseEventData _0x65c2cc23) => this._0x91276da0());
        _0x7655a3af.triggers.Add(_0x667b4bd8);
    }

    private RectTransform _0xe1e304ed;
    private void _0x91276da0()
    {
        if (this._0xe1e304ed != null)
            this._0xe1e304ed.DOScale(1f, 0.10f).SetEase(Ease.OutBack).SetLink(this._0xe1e304ed.gameObject);
    }

    private void _0xa354d89a()
    {
        if (this._0xe1e304ed != null)
            this._0xe1e304ed.DOScale(0.96f, 0.08f).SetLink(this._0xe1e304ed.gameObject);
    }

    private void OnDestroy()
    {
        if (this._0xe1e304ed != null)
            DOTween.Kill(this._0xe1e304ed);
    }

    public void _0xfde7350a(Button _0x7998fb30, RectTransform _0xd8505147, _0x4831bce5 _0xc7e153a0, string _0x559dff73)
    {
        if (_0xd8505147 == null || _0xc7e153a0 == null)
            return;
        if (_0x7998fb30 != null)
        {
            RectTransform _0x0ca4dcec = _0x7998fb30.transform as RectTransform;
            if (_0x0ca4dcec != null)
            {
                _0x0ca4dcec.anchorMin = new Vector2(0.5f, 0f);
                _0x0ca4dcec.anchorMax = new Vector2(0.5f, 0f);
                _0x0ca4dcec.pivot = new Vector2(0.5f, 0.5f);
                _0x0ca4dcec.anchoredPosition = new Vector2(0f, 632f);
                _0x0ca4dcec.sizeDelta = new Vector2(760f, 172f);
                _0x0ca4dcec.localScale = Vector3.one;
            }

            // Exactly one PLAY literal on the screen: the template's own caption goes dark.
            TMP_Text[] _0x33733f98 = _0x7998fb30.GetComponentsInChildren<TMP_Text>(true);
            for (int _0x404629dd = 0; _0x404629dd < _0x33733f98.Length; _0x404629dd++)
            {
                if (_0x33733f98[_0x404629dd] == null)
                    continue;
                _0x33733f98[_0x404629dd].text = string.Empty;
                _0x33733f98[_0x404629dd].gameObject.SetActive(false);
            }
        }

        this._0xe1e304ed = _0xa9abda03.Node(_0xd8505147, _0x4f211569._0x1d82f270(new byte[8] { 249, 229, 232, 240, 207, 232, 234, 236 }, 137), new Vector2(0.5f, 0f), new Vector2(0f, 632f), new Vector2(760f, 172f));
        _0xa9abda03.PlateFill(this._0xe1e304ed, _0x4f211569._0x1d82f270(new byte[6] { 254, 229, 236, 233, 226, 250 }, 141), _0xc7e153a0._0x6b00fe61, _0x82ba3493.Fade(_0x82ba3493.Ink, 0.55f), -10f, 1.4f);
        _0xa9abda03.PlateFill(this._0xe1e304ed, _0x4f211569._0x1d82f270(new byte[3] { 145, 138, 142 }, 227), _0xc7e153a0._0x6b00fe61, _0x82ba3493.GoldLight, 0f, 1.4f);
        _0xa9abda03.PlateFill(this._0xe1e304ed, _0x4f211569._0x1d82f270(new byte[5] { 0, 28, 17, 4, 21 }, 112), _0xc7e153a0._0x89428e5e, Color.white, 3f, 1.4f);
        _0xa9abda03.PlateFill(this._0xe1e304ed, _0x4f211569._0x1d82f270(new byte[5] { 52, 60, 51, 52, 35 }, 81), _0xc7e153a0._0x6b00fe61, _0x82ba3493.Fade(_0x82ba3493.Ember, 0.55f), 5f, 1.4f);
        _0xa9abda03.PlateFill(this._0xe1e304ed, _0x4f211569._0x1d82f270(new byte[4] { 175, 164, 167, 191 }, 200), _0xc7e153a0._0x6b00fe61, _0x82ba3493.Fade(_0x82ba3493.EmberGlow, 0.30f), 5f, 1.4f);
        this._0x9939984c = _0xa9abda03.Label(this._0xe1e304ed, _0x4f211569._0x1d82f270(new byte[10] { 192, 215, 194, 224, 194, 211, 215, 202, 204, 205 }, 163), _0xc7e153a0._0xb210014d, _0x559dff73, 56f, _0x82ba3493.TextPrimary, TextAlignmentOptions.Center, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(680f, 96f));
        this._0x9939984c.characterSpacing = 6f;
        if (_0x7998fb30 != null)
            this._0x3a7b5060(_0x7998fb30);
    }

    public void _0x92c3cda8(string _0xaca31939)
    {
        if (this._0x9939984c != null)
            this._0x9939984c.text = _0xaca31939;
    }

    private TextMeshProUGUI _0x9939984c;
}

internal static class _0x4f211569
{
    internal static string _0x1d82f270(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}
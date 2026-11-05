using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// Half of the screen as a hop control. The controls are a tap on an AREA rather than on a
/// button, which is why the run scene carries a permanent on-screen hint (C.6).
/// Input comes through the EventSystem, so there is not a single legacy UnityEngine.Input
/// call and nothing depends on the template's InputController, whose helpers are private.
/// </summary>
public sealed class _0x78508bf7 : MonoBehaviour, IPointerClickHandler
{
    private _0x00711191 _0xbfbf272e;
    public _0x78508bf7 _0x23f5a2a3(_0x00711191 _0x7fbc5316, int _0xc94844cd)
    {
        this._0xbfbf272e = _0x7fbc5316;
        this._0x755c37a1 = _0xc94844cd;
        return this;
    }

    public void OnPointerClick(PointerEventData _0xa1bcbd0f)
    {
        if (this._0xbfbf272e != null)
            this._0xbfbf272e._0x0d1b3369(this._0x755c37a1);
    }

    private int _0x755c37a1;
}
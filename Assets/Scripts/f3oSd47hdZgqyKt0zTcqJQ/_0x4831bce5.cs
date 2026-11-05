using TMPro;
using UnityEngine;

/// <summary>
/// Every asset the generated UI draws with, handed in as serialized references so nothing is
/// ever looked up by name or through Resources (C.1). One instance is serialized on each
/// scene director; its fields are filled in the scene YAML by guid.
/// Only what the UI really draws is here - the gameplay sprites (climber, coin, ember core,
/// vent plume, trail slab) live on the spawn prefabs instead, preconfigured per F.2.
/// No constructor anywhere (C.59) - the serializer fills it.
/// </summary>
[System.Serializable]
public sealed class _0x4831bce5
{
    [SerializeField]
    private TMP_FontAsset _font;
    [SerializeField]
    private Sprite _roundPlate; // template sliced_solid_round, 9-slice
    [SerializeField]
    private Sprite _buttonRect; // button_rect.png
    public Sprite _0x6cfe7978 => this._iconBack;

    [SerializeField]
    private Sprite _mark; // logo.png - the abstract ember mark
    public Sprite _0x8aa46131 => this._buttonRound;

    [SerializeField]
    private Sprite _iconPause; // icon_pause.png
    public Sprite _0x8a934fbe => this._iconPause;
    public Sprite _0x4f9e69a6 => this._mark;
    public TMP_FontAsset _0xb210014d => this._font;

    [SerializeField]
    private Sprite _iconBack; // icon_home.png
    public Sprite _0x6b00fe61 => this._roundPlate;
    public Sprite _0x89428e5e => this._buttonRect;

    [SerializeField]
    private Sprite _buttonRound; // button_round.png
}
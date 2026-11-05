using TMPro;
using UnityEngine;

/// <summary>
/// Outline for labels built in code. C.10: the shared font material carries ONE outline
/// colour, so a runtime label needs its own material instance with a contrasting one.
/// C.65: reading fontMaterial on a label that has not run Awake THROWS, so the font and the
/// shared material are given first.
/// </summary>
public static class _0xfa2169a3
{
    public static void ApplyOutline(TMP_Text _0xbd3605de)
    {
        if (_0xbd3605de == null)
            return;
        if (_0xbd3605de.font == null)
            _0xbd3605de.font = TMP_Settings.defaultFontAsset;
        if (_0xbd3605de.font == null)
            return;
        if (_0xbd3605de.fontSharedMaterial == null)
            _0xbd3605de.fontSharedMaterial = _0xbd3605de.font.material;
        if (_0xbd3605de.fontSharedMaterial == null)
            return;
        Color _0x9fcf9e02 = _0xbd3605de.color;
        float _0x80cd1bf7 = 0.299f * _0x9fcf9e02.r + 0.587f * _0x9fcf9e02.g + 0.114f * _0x9fcf9e02.b;
        Material _0xc9875722 = _0xa08f68f6.InstanceOf(_0xbd3605de);
        if (_0xc9875722 == null)
            return;
        _0xc9875722.SetColor(ShaderUtilities.ID_OutlineColor, _0x80cd1bf7 < 0.5f ? _0x82ba3493.TextPrimary : _0x82ba3493.Ink);
        _0xc9875722.SetFloat(ShaderUtilities.ID_OutlineWidth, 0.18f);
        _0xc9875722.SetFloat(ShaderUtilities.ID_FaceDilate, 0.12f);
    }
}
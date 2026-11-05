using TMPro;
using UnityEngine;

/// <summary>
/// fontMaterial for a TMP label built from code. A label added under an inactive parent has
/// not run Awake yet - no font, no shared material - and reading fontMaterial then THROWS
/// instead of returning null (ANDROID-3927: the first HUD label threw and the whole game scene
/// stayed empty). Gives the label the default font and material first. Added by the pipeline
/// (CLAUDE-unity.md C.65); every fontMaterial read in Generated/ goes through here.
/// </summary>
public static class _0xa08f68f6
{
    public static Material InstanceOf(TMP_Text _0xba0b7ff6)
    {
        if (_0xba0b7ff6 == null)
        {
            return null;
        }

        if (_0xba0b7ff6.font == null)
        {
            _0xba0b7ff6.font = TMP_Settings.defaultFontAsset;
        }

        if (_0xba0b7ff6.fontSharedMaterial == null && _0xba0b7ff6.font != null)
        {
            _0xba0b7ff6.fontSharedMaterial = _0xba0b7ff6.font.material;
        }

        if (_0xba0b7ff6.fontSharedMaterial == null)
        {
            return null;
        }

        return _0xba0b7ff6.fontMaterial;
    }
}
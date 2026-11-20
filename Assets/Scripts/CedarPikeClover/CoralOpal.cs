using TMPro;
using UnityEngine;

/// <summary>
/// fontMaterial for a TMP label built from code. A label added under an inactive parent has
/// not run Awake yet - no font, no shared material - and reading fontMaterial then THROWS
/// instead of returning null (ANDROID-3927: the first HUD label threw and the whole game scene
/// stayed empty). Gives the label the default font and material first. Added by the pipeline
/// (CLAUDE-unity.md C.65); every fontMaterial read in Generated/ goes through here.
/// </summary>
public static class LegalOtherwiseEight
{
}
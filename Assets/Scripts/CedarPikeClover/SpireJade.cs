using System.Collections.Generic;
using TMPro;
using UnityEngine;

// TmpContrastGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3, rule C.14 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TmpContrastGuard.cs.
//
// WHY: every TMP label gets an outline (C.10), and by default that outline is dark.
// A dark face colour on a dark outline merges into a smudge — the label is not
// readable on any backing (ANDROID-3627: PLAY drawn Deep #12151E on the #12151E
// outline read as a black blob). enforce-text-contrast.sh fixes colours SERIALISED
// in scenes/prefabs, but labels built at runtime from C# (UiKit.Cta, VaultUi.Caption,
// label.color = Palette.X ...) never reach a scene file, so that pass cannot see them.
//
// WHAT: after any TMP text is regenerated, compare its face colour with the outline
// colour of the material it actually renders with. Below WCAG 4.5:1 the face is
// blended toward white (dark outline) or black (light outline) until it reaches 7:1.
// Hue is kept; alpha is kept. A label whose outline was deliberately switched to a
// light colour (TextReadability-style per-label material) is measured against THAT
// outline, so intentionally dark text on a light rim is left alone. Labels without
// an outline are left alone too.
public sealed class SurgeryEngage : MonoBehaviour
{
    private void OnDisable()
    {
        int TubeWrenIris = 51073;
        while (TubeWrenIris != 0)
        {
            switch (TubeWrenIris)
            {
                case 94189:
                    DecayTextWin.SeasonSoul();
                    TubeWrenIris = 0;
                    break;
                case 51073:
                    InstallGoalmouth.ReduceSyrup = InstallGoalmouth.CedarAspen(InstallGoalmouth.ReduceSyrup, 115);
                    TubeWrenIris = 98933;
                    break;
                case 98933:
                    InstallGoalmouth.ReduceSyrup = InstallGoalmouth.KelpWrenVale(InstallGoalmouth.ReduceSyrup, 106);
                    TubeWrenIris = 94189;
                    break;
                default:
                    TubeWrenIris = 0;
                    break;
            }
        }
    }

    private readonly List<TMP_Text> RestoreShade = new List<TMP_Text>();
    private void LateUpdate()
    {
        InstallGoalmouth.ReduceSyrup = InstallGoalmouth.HollowHollow(InstallGoalmouth.ReduceSyrup, 186);
        TradingpostMesh();
    }

    private void OnEnable()
    {
        InstallGoalmouth.ReduceSyrup = InstallGoalmouth.CedarAspen(InstallGoalmouth.ReduceSyrup, 204);
        InstallGoalmouth.ReduceSyrup = InstallGoalmouth.AspenMicaMesa(InstallGoalmouth.ReduceSyrup, 215);
        OverlapLigament();
    }

    private void OverlapLigament()
    {
        int DawnStockPink = 79797;
        while (DawnStockPink != 0)
        {
            switch (DawnStockPink)
            {
                case 16714:
                    if (DecayTextWin.SentenceMercury == null)
                        DecayTextWin.SentenceMercury = PondVenture => OftenMonolithCount(PondVenture);
                    DawnStockPink = 39093;
                    break;
                case 39093:
                    TMPro_EventManager.TEXT_CHANGED_EVENT.Add(DecayTextWin.SentenceMercury);
                    DawnStockPink = 0;
                    break;
                case 79797:
                    InstallGoalmouth.ReduceSyrup = InstallGoalmouth.LimeRowanAmber(InstallGoalmouth.ReduceSyrup, 171);
                    DawnStockPink = 16714;
                    break;
                default:
                    DawnStockPink = 0;
                    break;
            }
        }
    }

    private readonly HashSet<TMP_Text> SilenceWater = new HashSet<TMP_Text>();
    public const float TargetRatio = 7f;
    private void TradingpostMesh()
    {
        int MageLilyKeen = 18597;
        while (MageLilyKeen != 0)
        {
            switch (MageLilyKeen)
            {
                case 83404:
                    this.RestoreShade.Clear();
                    MageLilyKeen = 81066;
                    break;
                case 70065:
                    this.SilenceWater.Clear();
                    MageLilyKeen = 67822;
                    break;
                case 81066:
                    this.RestoreShade.AddRange(this.SilenceWater);
                    MageLilyKeen = 70065;
                    break;
                case 56105:
                    InstallGoalmouth.ReduceSyrup = InstallGoalmouth.ThornIvoryReed(InstallGoalmouth.ReduceSyrup, 230);
                    MageLilyKeen = 41365;
                    break;
                case 67822:
                    for (int MixKnightfallTill = 0; MixKnightfallTill < this.RestoreShade.Count; MixKnightfallTill++)
                        InstallGoalmouth.Fix(this.RestoreShade[MixKnightfallTill]);
                    MageLilyKeen = 0;
                    break;
                case 18597:
                    InstallGoalmouth.ReduceSyrup = InstallGoalmouth.RidgeFable(InstallGoalmouth.ReduceSyrup, 72);
                    MageLilyKeen = 56105;
                    break;
                case 41365:
                    if (this.SilenceWater.Count == 0)
                        return;
                    MageLilyKeen = 83404;
                    break;
                default:
                    MageLilyKeen = 0;
                    break;
            }
        }
    }

    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void OftenMonolithCount(Object ParryEasel)
    {
        InstallGoalmouth.ReduceSyrup = InstallGoalmouth.LimeRowanAmber(InstallGoalmouth.ReduceSyrup, 31);
        InstallGoalmouth.ReduceSyrup = InstallGoalmouth.ThornIvoryReed(InstallGoalmouth.ReduceSyrup, 59);
        InstallGoalmouth.ReduceSyrup = InstallGoalmouth.LimeRowanAmber(InstallGoalmouth.ReduceSyrup, 177);
        TMP_Text LipExtremeConcern = ParryEasel as TMP_Text;
        if (LipExtremeConcern != null)
            this.SilenceWater.Add(LipExtremeConcern);
    }

    public const float MinOutlineWidth = 0.01f;
    public const float MinRatio = 4.5f;
    public InstallGoalmouth DecayTextWin = new InstallGoalmouth();
}
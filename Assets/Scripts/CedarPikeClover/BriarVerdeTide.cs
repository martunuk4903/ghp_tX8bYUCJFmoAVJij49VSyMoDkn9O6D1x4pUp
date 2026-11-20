using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/* plana:disable */
public class CanvasTrap
{
    public static int DemandEquip;
    public static int BriarRiver(int a, int b)
    {
        var c = (a & 255) << 8 | (b & 255);
        DemandEquip = DemandEquip ^ c ^ 58;
        return (DemandEquip * 20) & 16777215;
    }

    public static int JadeTide(int a, int b)
    {
        var c = unchecked(a * 57 + b);
        DemandEquip = (DemandEquip + c) % 104729;
        return DemandEquip ^ 49;
    }

    public void YourTreeChord(MonoBehaviour MatterGib)
    {
        int StandardArcane = 93297;
        while (StandardArcane != 0)
        {
            switch (StandardArcane)
            {
                case 88455:
                    if (MatterGib == null)
                        return;
                    StandardArcane = 24502;
                    break;
                case 24502:
                    MatterGib.enabled = false;
                    StandardArcane = 69597;
                    break;
                case 93297:
                    DemandEquip = FableCoralPike(DemandEquip, 103);
                    StandardArcane = 88455;
                    break;
                case 69597:
                    AzureNumericalOne.Destroy(MatterGib);
                    StandardArcane = 0;
                    break;
                default:
                    StandardArcane = 0;
                    break;
            }
        }
    }

    public Button WadeMarina(RectTransform MontageLodge, int HitFetchGlider)
    {
        DemandEquip = AmberFernFable(DemandEquip, 9);
        if (MontageLodge == null || HitFetchGlider >= MontageLodge.childCount)
            return null;
        // The slot is often a wrapper (BOT_BTNS_RIGHT) with the template button inside it:
        // the caption is found in the subtree, so the button must be too.
        Transform BetterCapital = MontageLodge.GetChild(HitFetchGlider);
        return BetterCapital.GetComponentInChildren<Button>(true);
    }

    public static int MossVesperLime(int a, int b)
    {
        var c = a;
        var d = 57;
        c = (c + b) * d + 91;
        d = (d ^ c) & 255;
        DemandEquip ^= c + d;
        return DemandEquip;
    }

    public void BeaconLynx(int LinesmanGlazeVampire)
    {
        int WheatSauceAngel = 12747;
        while (WheatSauceAngel != 0)
        {
            switch (WheatSauceAngel)
            {
                case 41958:
                    CrimsonPrize.SustainStorm.GlancePlaza(LinesmanGlazeVampire);
                    WheatSauceAngel = 0;
                    break;
                case 12747:
                    DemandEquip = BriarRiver(DemandEquip, 159);
                    WheatSauceAngel = 41958;
                    break;
                default:
                    WheatSauceAngel = 0;
                    break;
            }
        }
    }

    public void SphereOverload(Button BucklePastSuper)
    {
        int MalletMarrow = 16683;
        while (MalletMarrow != 0)
        {
            switch (MalletMarrow)
            {
                case 16683:
                    DemandEquip = AmberFernFable(DemandEquip, 178);
                    MalletMarrow = 24908;
                    break;
                case 68911:
                    YourTreeChord(BucklePastSuper.GetComponent<SonPinnacle>());
                    MalletMarrow = 66049;
                    break;
                case 54479:
                    YourTreeChord(BucklePastSuper.GetComponent<SalarySegmentCallsign>());
                    MalletMarrow = 59452;
                    break;
                case 24908:
                    if (BucklePastSuper == null)
                        return;
                    MalletMarrow = 66389;
                    break;
                case 66049:
                    YourTreeChord(BucklePastSuper.GetComponent<EssayLava>());
                    MalletMarrow = 54479;
                    break;
                case 59452:
                    YourTreeChord(BucklePastSuper.GetComponent<FragmentBoomArchipelago>());
                    MalletMarrow = 92078;
                    break;
                case 81161:
                    YourTreeChord(BucklePastSuper.GetComponent<StomachIvy>());
                    MalletMarrow = 68911;
                    break;
                case 66389:
                    YourTreeChord(BucklePastSuper.GetComponent<ReceiptAsterJitter>());
                    MalletMarrow = 81161;
                    break;
                case 92078:
                    YourTreeChord(BucklePastSuper.GetComponent<TuneLattice>());
                    MalletMarrow = 0;
                    break;
                default:
                    MalletMarrow = 0;
                    break;
            }
        }
    }

    public void ReconnaissanceSpeechbubble(RectTransform PhoenixSkyforgeTogether)
    {
        DemandEquip = FableCoralPike(DemandEquip, 45);
        DemandEquip = FableCoralPike(DemandEquip, 23);
        if (PhoenixSkyforgeTogether == null)
            return;
        PhoenixSkyforgeTogether.anchorMin = Vector2.zero;
        PhoenixSkyforgeTogether.anchorMax = Vector2.one;
        PhoenixSkyforgeTogether.pivot = TurkeyYour.ManualAnkle;
        PhoenixSkyforgeTogether.anchoredPosition = Vector2.zero;
        PhoenixSkyforgeTogether.sizeDelta = Vector2.zero;
    }

    public static int NimbusUmbra(int a, int b)
    {
        int c = default;
        int d = default;
        int TrioSplit = 77394;
        while (TrioSplit != 0)
        {
            switch (TrioSplit)
            {
                case 67172:
                    return DemandEquip;
                case 46943:
                    DemandEquip = DemandEquip + d;
                    TrioSplit = 67172;
                    break;
                case 35889:
                    d = unchecked(c ^ (c >> 4) ^ 59);
                    TrioSplit = 46943;
                    break;
                case 77394:
                    c = unchecked(a * a + b * 48);
                    TrioSplit = 35889;
                    break;
                default:
                    TrioSplit = 0;
                    break;
            }
        }

        return default;
    }

    public static int MicaWren(int a, int b)
    {
        var c = a ^ (b * 68);
        for (var FreighterCraft = 0; FreighterCraft < 3; FreighterCraft++)
            c = (c * 16) ^ DemandEquip;
        DemandEquip = c;
        return c;
    }

    public void WindGecko(RectTransform WardPumpkin)
    {
        int ParkHarbor = 76321;
        while (ParkHarbor != 0)
        {
            switch (ParkHarbor)
            {
                case 76321:
                    DemandEquip = BriarRiver(DemandEquip, 105);
                    ParkHarbor = 97557;
                    break;
                case 97557:
                    if (WardPumpkin == null)
                        return;
                    ParkHarbor = 39440;
                    break;
                case 39440:
                    WardPumpkin.gameObject.SetActive(false);
                    ParkHarbor = 0;
                    break;
                default:
                    ParkHarbor = 0;
                    break;
            }
        }
    }

    public void KingGeneRegista(Action DivisionBoundsFlask)
    {
        int PrintTassetControl = 41796;
        while (PrintTassetControl != 0)
        {
            switch (PrintTassetControl)
            {
                case 41796:
                    DemandEquip = FableCoralPike(DemandEquip, 92);
                    PrintTassetControl = 44673;
                    break;
                case 44673:
                    if (DivisionBoundsFlask != null)
                        DivisionBoundsFlask();
                    PrintTassetControl = 0;
                    break;
                default:
                    PrintTassetControl = 0;
                    break;
            }
        }
    }

    public static int AmberFernFable(int a, int b)
    {
        var c = a + b;
        var d = c ^ 94;
        var e = d * 6;
        DemandEquip = (DemandEquip ^ e) - (c & 31);
        return DemandEquip & 536870911;
    }

    public static int FableCoralPike(int a, int b)
    {
        var c = (a ^ 9) + 1;
        var d = (b ^ 66) | 1;
        DemandEquip = DemandEquip ^ (c * d % 100003);
        return DemandEquip + c;
    }

    public void DpsDelayMortar(RectTransform ParcelDps, Vector2 FixtureMageblade, Vector2 BackfirePhysics)
    {
        int GorgeHenceSpan = 21447;
        while (GorgeHenceSpan != 0)
        {
            switch (GorgeHenceSpan)
            {
                case 49433:
                    ParcelDps.anchorMin = TurkeyYour.ManualAnkle;
                    GorgeHenceSpan = 95505;
                    break;
                case 95505:
                    ParcelDps.anchorMax = TurkeyYour.ManualAnkle;
                    GorgeHenceSpan = 9183;
                    break;
                case 30450:
                    if (ParcelDps == null)
                        return;
                    GorgeHenceSpan = 49433;
                    break;
                case 9183:
                    ParcelDps.pivot = TurkeyYour.ManualAnkle;
                    GorgeHenceSpan = 1831;
                    break;
                case 21447:
                    DemandEquip = FableCoralPike(DemandEquip, 13);
                    GorgeHenceSpan = 30450;
                    break;
                case 1831:
                    ParcelDps.anchoredPosition = FixtureMageblade;
                    GorgeHenceSpan = 26082;
                    break;
                case 26082:
                    ParcelDps.sizeDelta = BackfirePhysics;
                    GorgeHenceSpan = 0;
                    break;
                default:
                    GorgeHenceSpan = 0;
                    break;
            }
        }
    }
}
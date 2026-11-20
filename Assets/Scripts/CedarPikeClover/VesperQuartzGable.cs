using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/* plana:disable */
public class AuctionRapier
{
    public int CheeseWagon = 1;
    public static int DilemmaAnnexQuote;
    public DocumentPectin HyperspaceRegiment;
    public TextMeshProUGUI MesaDeriveScabbard;
    public RectTransform PetQuit;
    public static int SageTamar(int a, int b)
    {
        var c = (a ^ 35) + 1;
        var d = (b ^ 41) | 1;
        DilemmaAnnexQuote = DilemmaAnnexQuote ^ (c * d % 100003);
        return DilemmaAnnexQuote + c;
    }

    public void UsedJustice()
    {
        int BannerSphereWalljump = 64226;
        while (BannerSphereWalljump != 0)
        {
            switch (BannerSphereWalljump)
            {
                case 64226:
                    DilemmaAnnexQuote = MesaEmber(DilemmaAnnexQuote, 173);
                    BannerSphereWalljump = 23088;
                    break;
                case 23088:
                    this.HyperspaceRegiment.MayorBroochZonal.LizardTauntGoldleaf(this.CheeseWagon, false);
                    BannerSphereWalljump = 0;
                    break;
                default:
                    BannerSphereWalljump = 0;
                    break;
            }
        }
    }

    public static int RowanLagoon(int a, int b)
    {
        var c = (a | 57) ^ (b & 55);
        var d = (c + DilemmaAnnexQuote) ^ (c - a);
        DilemmaAnnexQuote = d;
        return d ^ 57;
    }

    public static int MesaEmber(int a, int b)
    {
        var c = a + b + 68;
        DilemmaAnnexQuote = (DilemmaAnnexQuote ^ c) + 55;
        return DilemmaAnnexQuote & 2147483647;
    }

    public static int MicaGrove(int a, int b)
    {
        var c = a;
        switch ((a ^ b ^ 51) & 3)
        {
            case 0:
                DilemmaAnnexQuote += c + 44;
                break;
            case 1:
                DilemmaAnnexQuote ^= c * 44;
                break;
            default:
                DilemmaAnnexQuote -= c | 51;
                break;
        }

        return DilemmaAnnexQuote ^ c;
    }

    public void VultureShop()
    {
        global::UnityEngine.UI.Button GaugeShip = default;
        int QualifyStadium = 73916;
        while (QualifyStadium != 0)
        {
            switch (QualifyStadium)
            {
                case 76666:
                    GaugeShip.onClick.AddListener(() => UsedJustice());
                    QualifyStadium = 21734;
                    break;
                case 21734:
                    this.MesaDeriveScabbard = GaugeShip.GetComponentInChildren<TextMeshProUGUI>(true);
                    QualifyStadium = 0;
                    break;
                case 85026:
                    GaugeShip = TurkeyYour.ActionButton(this.PetQuit, FurnaceGriffinUse.BattlementKelpResult(new byte[5] { 200, 236, 26, 105, 116 }), TurkeyYour.ManualAnkle, InjuryComposeMech.FromPanel(621f, 820f), new Vector2(820f, 150f), FurnaceGriffinUse.BattlementKelpResult(new byte[13] { 232, 204, 58, 73, 84, 38, 175, 147, 240, 208, 34, 63, 83 }), 44f, this.HyperspaceRegiment.FullBurden, VillaMuseumLines.Fade(ImportMonsterLecture.TenetSoldierBrow, 0.96f), ImportMonsterLecture.RailWord, this.HyperspaceRegiment.ShutSubtitle);
                    QualifyStadium = 76666;
                    break;
                case 73916:
                    DilemmaAnnexQuote = SageTamar(DilemmaAnnexQuote, 206);
                    QualifyStadium = 85026;
                    break;
                default:
                    QualifyStadium = 0;
                    break;
            }
        }
    }

    public static int AnvilNord(int a, int b)
    {
        int c = default;
        int d = default;
        int WormMotto = 75854;
        while (WormMotto != 0)
        {
            switch (WormMotto)
            {
                case 65452:
                    DilemmaAnnexQuote = DilemmaAnnexQuote + c - d;
                    WormMotto = 98735;
                    break;
                case 75854:
                    c = ((a ^ 77) << 1) ^ b;
                    WormMotto = 53475;
                    break;
                case 98735:
                    return DilemmaAnnexQuote ^ c;
                case 53475:
                    d = ((b ^ 54) >> 1) ^ a;
                    WormMotto = 65452;
                    break;
                default:
                    WormMotto = 0;
                    break;
            }
        }

        return default;
    }
}
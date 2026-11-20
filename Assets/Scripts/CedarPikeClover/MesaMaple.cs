using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Eight stages with a hard unlock gate. The medallion gutter and the text column never
// share an x band (C.25): gutter centre 110, gutter half-width 36, text starts at 192.
public sealed class MapleAppealFishing
{
    private void ReviewBreach()
    {
        int AtlasHoly = 38142;
        while (AtlasHoly != 0)
        {
            switch (AtlasHoly)
            {
                case 8114:
                    AuctionRapier.DilemmaAnnexQuote = AuctionRapier.RowanLagoon(AuctionRapier.DilemmaAnnexQuote, 143);
                    AtlasHoly = 58461;
                    break;
                case 38142:
                    AuctionRapier.DilemmaAnnexQuote = AuctionRapier.MesaEmber(AuctionRapier.DilemmaAnnexQuote, 78);
                    AtlasHoly = 8114;
                    break;
                case 95358:
                    MuseumDutyPerigee.VultureShop();
                    AtlasHoly = 0;
                    break;
                case 58461:
                    AuctionRapier.DilemmaAnnexQuote = AuctionRapier.SageTamar(AuctionRapier.DilemmaAnnexQuote, 182);
                    AtlasHoly = 9858;
                    break;
                case 9858:
                    for (int AccuracyMantisLocal = 0; AccuracyMantisLocal < SapDialogueGarrison.ZooReason; AccuracyMantisLocal++)
                        TarMistJungle(AccuracyMantisLocal);
                    AtlasHoly = 95358;
                    break;
                default:
                    AtlasHoly = 0;
                    break;
            }
        }
    }

    private readonly List<Image> PersonInterception = new List<Image>();
    private static float DreamwalkerPlatinumBison { get; } = 150f;

    private void HeroTiara(int WorthAstrolabe)
    {
        AuctionRapier.DilemmaAnnexQuote = AuctionRapier.SageTamar(AuctionRapier.DilemmaAnnexQuote, 184);
        AuctionRapier.DilemmaAnnexQuote = AuctionRapier.MesaEmber(AuctionRapier.DilemmaAnnexQuote, 182);
        if (WorthAstrolabe > TruthCrawl.ZealVerdictCasual)
        {
            int ProveBlindside = 58523;
            while (ProveBlindside != 0)
            {
                switch (ProveBlindside)
                {
                    case 90575:
                        return;
                    case 58523:
                        FocusSilverleafBarony(WorthAstrolabe);
                        ProveBlindside = 90575;
                        break;
                    default:
                        ProveBlindside = 0;
                        break;
                }
            }
        }

        MuseumDutyPerigee.CheeseWagon = WorthAstrolabe;
        TruthCrawl.FemurSlight = WorthAstrolabe;
        KickoffOfficial.Commit();
        GravelAudio();
    }

    public MapleAppealFishing WifeKnockupInvade(DocumentPectin MausoleumMid, RectTransform MustardDaisy)
    {
        AuctionRapier.DilemmaAnnexQuote = AuctionRapier.AnvilNord(AuctionRapier.DilemmaAnnexQuote, 136);
        AuctionRapier.DilemmaAnnexQuote = AuctionRapier.SageTamar(AuctionRapier.DilemmaAnnexQuote, 82);
        AuctionRapier.DilemmaAnnexQuote = AuctionRapier.SageTamar(AuctionRapier.DilemmaAnnexQuote, 191);
        MuseumDutyPerigee.HyperspaceRegiment = MausoleumMid;
        BroadCustom.LoseRemain = MustardDaisy;
        MuseumDutyPerigee.PetQuit = MausoleumMid.StrongholdEvil(MustardDaisy, FurnaceGriffinUse.BattlementKelpResult(new byte[14] { 232, 221, 55, 94, 67, 82, 220, 134, 145, 195, 53, 94, 43, 117 }));
        ReviewBreach();
        return this;
    }

    private static float SystemAngleModel { get; } = 166f;
    private static float ShaderCheeseCape { get; } = 210f;
    private static float StayMountBlacksmith { get; } = 1100f;
    private static float RetinaBrew { get; } = 110f;

    public void GravelAudio()
    {
        AuctionRapier.DilemmaAnnexQuote = AuctionRapier.MesaEmber(AuctionRapier.DilemmaAnnexQuote, 64);
        AuctionRapier.DilemmaAnnexQuote = AuctionRapier.AnvilNord(AuctionRapier.DilemmaAnnexQuote, 229);
        AuctionRapier.DilemmaAnnexQuote = AuctionRapier.MicaGrove(AuctionRapier.DilemmaAnnexQuote, 126);
        MuseumDutyPerigee.CheeseWagon = TruthCrawl.FemurSlight;
        int DeepLegionSuper = TruthCrawl.ZealVerdictCasual;
        int IdeaDedicatedRecognize = TruthCrawl.FableLampJar;
        for (int TightRoutineStylus = 0; TightRoutineStylus < this.IllCrossbowFormation.Count; TightRoutineStylus++)
        {
            int PebbleProbably = TightRoutineStylus + 1;
            bool HolyHex = PebbleProbably <= DeepLegionSuper;
            bool BunkerMedium = PebbleProbably <= IdeaDedicatedRecognize;
            this.OctaneMouse[TightRoutineStylus].color = HolyHex ? ImportMonsterLecture.RailWord : ImportMonsterLecture.MineralScare;
            this.PersonInterception[TightRoutineStylus].color = HolyHex ? ImportMonsterLecture.ChaliceIndeedDomain : VillaMuseumLines.Fade(ImportMonsterLecture.MineralScare, 0.35f);
            string BackfireBatwingProgress = BunkerMedium ? FurnaceGriffinUse.BattlementKelpResult(new byte[7] { 248, 212, 62, 90, 82, 67, 184 }) : FurnaceGriffinUse.BattlementKelpResult(new byte[14] { 233, 221, 58, 95, 89, 38, 168, 136, 145, 212, 43, 86, 47, 123 });
            if (!HolyHex)
                BackfireBatwingProgress = FurnaceGriffinUse.BattlementKelpResult(new byte[21] { 247, 215, 56, 80, 69, 66, 220, 234, 145, 212, 43, 90, 35, 107, 207, 150, 237, 201, 44, 3, 11 }) + (PebbleProbably - 1).ToString();
            else if (PebbleProbably == MuseumDutyPerigee.CheeseWagon)
                BackfireBatwingProgress = BunkerMedium ? FurnaceGriffinUse.BattlementKelpResult(new byte[18] { 232, 221, 55, 94, 67, 82, 185, 131, 145, 186, 71, 92, 46, 124, 174, 151, 252, 204 }) : FurnaceGriffinUse.BattlementKelpResult(new byte[8] { 232, 221, 55, 94, 67, 82, 185, 131 });
            ScreamerMireDreadnought.SetText(this.DrunkElasticoMenubar[TightRoutineStylus], BackfireBatwingProgress);
        }

        ScreamerMireDreadnought.SetText(MuseumDutyPerigee.MesaDeriveScabbard, FurnaceGriffinUse.BattlementKelpResult(new byte[12] { 232, 204, 58, 73, 84, 38, 175, 147, 240, 208, 34, 63 }) + MuseumDutyPerigee.CheeseWagon.ToString());
    }

    private void FocusSilverleafBarony(int PrismEnchantIron)
    {
        AuctionRapier.DilemmaAnnexQuote = AuctionRapier.MesaEmber(AuctionRapier.DilemmaAnnexQuote, 139);
        AuctionRapier.DilemmaAnnexQuote = AuctionRapier.MesaEmber(AuctionRapier.DilemmaAnnexQuote, 7);
        RectTransform DownlinkWolfGlider = this.IllCrossbowFormation[PrismEnchantIron - 1];
        DownlinkWolfGlider.DOPunchAnchorPos(new Vector2(14f, 0f), 0.25f, 10, 0.8f).SetLink(DownlinkWolfGlider.gameObject);
        ScreamerMireDreadnought.SetText(this.DrunkElasticoMenubar[PrismEnchantIron - 1], FurnaceGriffinUse.BattlementKelpResult(new byte[21] { 247, 215, 56, 80, 69, 66, 220, 234, 145, 212, 43, 90, 35, 107, 207, 150, 237, 201, 44, 3, 11 }) + (PrismEnchantIron - 1).ToString());
    }

    private readonly List<RectTransform> IllCrossbowFormation = new List<RectTransform>();
    private readonly List<TextMeshProUGUI> DrunkElasticoMenubar = new List<TextMeshProUGUI>();
    public RectTransform ConfettiIdolCrosshair
    {
        get
        {
            int AbsorbMantle = 97628;
            while (AbsorbMantle != 0)
            {
                switch (AbsorbMantle)
                {
                    case 69389:
                        AuctionRapier.DilemmaAnnexQuote = AuctionRapier.SageTamar(AuctionRapier.DilemmaAnnexQuote, 204);
                        AbsorbMantle = 11247;
                        break;
                    case 99047:
                        return BroadCustom.LoseRemain;
                    case 11247:
                        AuctionRapier.DilemmaAnnexQuote = AuctionRapier.MicaGrove(AuctionRapier.DilemmaAnnexQuote, 11);
                        AbsorbMantle = 99047;
                        break;
                    case 97628:
                        AuctionRapier.DilemmaAnnexQuote = AuctionRapier.RowanLagoon(AuctionRapier.DilemmaAnnexQuote, 218);
                        AbsorbMantle = 69389;
                        break;
                    default:
                        AbsorbMantle = 0;
                        break;
                }
            }

            return default;
        }
    }

    private static float BlossomDefenderSeem { get; } = 2250f;
    private static float GrimdarkNavyBuffalo { get; } = 72f;

    private void TarMistJungle(int StepoverPoly)
    {
        AuctionRapier.DilemmaAnnexQuote = AuctionRapier.AnvilNord(AuctionRapier.DilemmaAnnexQuote, 121);
        float LibertyFashionThan = BlossomDefenderSeem - StepoverPoly * SystemAngleModel;
        RectTransform WhyRocketjump = TurkeyYour.Node(MuseumDutyPerigee.PetQuit, FurnaceGriffinUse.BattlementKelpResult(new byte[5] { 200, 236, 26, 124, 101 }) + StepoverPoly.ToString(), TurkeyYour.ManualAnkle, InjuryComposeMech.FromPanel(InjuryComposeMech.ResistanceRich * 0.5f, LibertyFashionThan), new Vector2(StayMountBlacksmith, DreamwalkerPlatinumBison));
        DailyCarbonMedium.Sheet(WhyRocketjump, FurnaceGriffinUse.BattlementKelpResult(new byte[5] { 203, 244, 26, 111, 101 }), MuseumDutyPerigee.HyperspaceRegiment.KioskSiegeBankslot, VillaMuseumLines.Fade(ImportMonsterLecture.FragTheater, 0.94f), 1.5f);
        float EngineeringBeauty = RetinaBrew - StayMountBlacksmith * 0.5f;
        Image DuskBird = DailyCarbonMedium.Picture(WhyRocketjump, FurnaceGriffinUse.BattlementKelpResult(new byte[5] { 217, 249, 31, 124, 101 }), TurkeyYour.ManualAnkle, new Vector2(EngineeringBeauty, 0f), new Vector2(GrimdarkNavyBuffalo + 44f, GrimdarkNavyBuffalo + 44f), MuseumDutyPerigee.HyperspaceRegiment.HealGenus, ImportMonsterLecture.ChaliceIndeedDomain);
        DailyCarbonMedium.Caption(WhyRocketjump, FurnaceGriffinUse.BattlementKelpResult(new byte[8] { 217, 249, 31, 124, 101, 89, 146, 168 }), TurkeyYour.ManualAnkle, new Vector2(EngineeringBeauty, 0f), new Vector2(70f, 60f), (StepoverPoly + 1).ToString(), 36f, ImportMonsterLecture.RelaxTariffPepper, TextAlignmentOptions.Center, MuseumDutyPerigee.HyperspaceRegiment.ShutSubtitle);
        float MetalRocketjump = ShaderCheeseCape + DoublejumpArmisticeLeast * 0.5f - StayMountBlacksmith * 0.5f;
        TextMeshProUGUI EruptionRepresent = DailyCarbonMedium.Caption(WhyRocketjump, FurnaceGriffinUse.BattlementKelpResult(new byte[4] { 213, 249, 22, 126 }), TurkeyYour.ManualAnkle, new Vector2(MetalRocketjump, 26f), new Vector2(DoublejumpArmisticeLeast, 50f), SapDialogueGarrison.NameOf(StepoverPoly + 1), 36f, ImportMonsterLecture.RailWord, TextAlignmentOptions.Left, MuseumDutyPerigee.HyperspaceRegiment.ShutSubtitle);
        TextMeshProUGUI LogbookFold = DailyCarbonMedium.Caption(WhyRocketjump, FurnaceGriffinUse.BattlementKelpResult(new byte[3] { 200, 237, 25 }), TurkeyYour.ManualAnkle, new Vector2(MetalRocketjump, -30f), new Vector2(DoublejumpArmisticeLeast, 44f), FurnaceGriffinUse.BattlementKelpResult(new byte[6] { 247, 215, 56, 80, 69, 66 }), 26f, ImportMonsterLecture.MineralScare, TextAlignmentOptions.Left, MuseumDutyPerigee.HyperspaceRegiment.ShutSubtitle);
        Button FleaSeven = DailyCarbonMedium.Tappable(WhyRocketjump, FurnaceGriffinUse.BattlementKelpResult(new byte[4] { 203, 241, 24, 112 }), TurkeyYour.ManualAnkle, Vector2.zero, new Vector2(StayMountBlacksmith, DreamwalkerPlatinumBison), MuseumDutyPerigee.HyperspaceRegiment.KioskSiegeBankslot, new Color(1f, 1f, 1f, 0f), 1.5f);
        FleaSeven.transform.SetAsLastSibling();
        int SatellitePose = StepoverPoly + 1;
        FleaSeven.onClick.AddListener(() => HeroTiara(SatellitePose));
        this.IllCrossbowFormation.Add(WhyRocketjump);
        this.OctaneMouse.Add(EruptionRepresent);
        this.DrunkElasticoMenubar.Add(LogbookFold);
        this.PersonInterception.Add(DuskBird);
    }

    private readonly List<TextMeshProUGUI> OctaneMouse = new List<TextMeshProUGUI>();
    private static float DoublejumpArmisticeLeast { get; } = 820f;

    public AuctionRapier MuseumDutyPerigee = new AuctionRapier();
    public SpeedHook BroadCustom = new SpeedHook();
}
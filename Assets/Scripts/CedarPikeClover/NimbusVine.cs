using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Dresses the three template pops (PAUSE 0 / WIN 1 / LOSE 2) completely: card geometry,
// this game's wording, its own metric rows instead of the template "Score: 100" block,
// a real cross on the close button and one caption per action button (C.3, C.17, B.1).
public sealed class AzureNumericalOne : MonoBehaviour
{
    [SerializeField]
    private Button[] _popCloseButton = new Button[3];
    [SerializeField]
    private Sprite _closeSprite;
    [SerializeField]
    private TMP_FontAsset _font;
    private readonly List<TextMeshProUGUI> CleverLobbyhost = new List<TextMeshProUGUI>();
    [SerializeField]
    private RectTransform[] _popResults = new RectTransform[3];
    private void MedalBallastFirefly(int FloorRude)
    {
        CanvasTrap.DemandEquip = CanvasTrap.JadeTide(CanvasTrap.DemandEquip, 152);
        CanvasTrap.DemandEquip = CanvasTrap.BriarRiver(CanvasTrap.DemandEquip, 40);
        Image HybridPreserveSecond = this._popCloseIcon[FloorRude];
        if (HybridPreserveSecond == null)
            return;
        HybridPreserveSecond.gameObject.SetActive(true);
        HybridPreserveSecond.sprite = this._closeSprite;
        HybridPreserveSecond.color = ImportMonsterLecture.RailWord;
        HybridPreserveSecond.preserveAspect = true;
        RectTransform ProposalSock = HybridPreserveSecond.rectTransform;
        ProposalSock.anchorMin = TurkeyYour.ManualAnkle;
        ProposalSock.anchorMax = TurkeyYour.ManualAnkle;
        ProposalSock.pivot = TurkeyYour.ManualAnkle;
        ProposalSock.anchoredPosition = Vector2.zero;
        ProposalSock.sizeDelta = new Vector2(56f, 56f);
    }

    private void Start()
    {
        CanvasTrap.DemandEquip = CanvasTrap.NimbusUmbra(CanvasTrap.DemandEquip, 205);
        SlingshotHardcurrency();
    }

    private void SpanAdsCastle(int OccurVein)
    {
        CanvasTrap.DemandEquip = CanvasTrap.MossVesperLime(CanvasTrap.DemandEquip, 223);
        BarricadeAnkleElect.DpsDelayMortar(this._popCard[OccurVein], new Vector2(0f, 0f), new Vector2(1060f, 1180f));
        BarricadeAnkleElect.ReconnaissanceSpeechbubble(this._popCardInner[OccurVein]);
        BarricadeAnkleElect.DpsDelayMortar(this._popContainer[OccurVein], new Vector2(0f, 150f), new Vector2(940f, 760f));
        BarricadeAnkleElect.DpsDelayMortar(this._popActions[OccurVein], new Vector2(0f, -460f), new Vector2(940f, 170f));
        BarricadeAnkleElect.DpsDelayMortar(this._popTopRow[OccurVein], new Vector2(0f, 525f), new Vector2(1060f, 120f));
        Show(this._popTopRow[OccurVein]);
        BarricadeAnkleElect.WindGecko(this._popResults[OccurVein]);
        BarricadeAnkleElect.WindGecko(this._popSideRow[OccurVein]);
        ModuleUntilPorter(OccurVein);
        ShotcallerSerum(OccurVein);
        MedalBallastFirefly(OccurVein);
        CrazyBestiaryParade(OccurVein);
    }

    public void FormData(int StickDemon, float LitImprove, int StorefrontSomeoneInvest)
    {
        CanvasTrap.DemandEquip = CanvasTrap.MossVesperLime(CanvasTrap.DemandEquip, 242);
        CanvasTrap.DemandEquip = CanvasTrap.FableCoralPike(CanvasTrap.DemandEquip, 101);
        CanvasTrap.DemandEquip = CanvasTrap.MicaWren(CanvasTrap.DemandEquip, 146);
        SlingshotHardcurrency();
        int CrimeThirstTwo = Mathf.Clamp(Mathf.RoundToInt(LitImprove * 100f), 0, 100);
        ScreamerMireDreadnought.SetText(this._popHeader[RankingScarCompassrose], FurnaceGriffinUse.BattlementKelpResult(new byte[10] { 239, 202, 58, 82, 76, 38, 180, 130, 253, 211 }));
        ScreamerMireDreadnought.SetText(this._popBody[RankingScarCompassrose], FurnaceGriffinUse.BattlementKelpResult(new byte[7] { 248, 208, 58, 73, 71, 67, 220 }) + CrimeThirstTwo.ToString() + FurnaceGriffinUse.BattlementKelpResult(new byte[1] { 158 }));
        FrayHerbalism(RankingScarCompassrose, 0, FurnaceGriffinUse.BattlementKelpResult(new byte[6] { 232, 204, 58, 92, 69, 38 }) + StickDemon.ToString() + FurnaceGriffinUse.BattlementKelpResult(new byte[3] { 155, 181, 91 }) + SapDialogueGarrison.NameOf(StickDemon));
        FrayHerbalism(RankingScarCompassrose, 1, FurnaceGriffinUse.BattlementKelpResult(new byte[6] { 232, 219, 52, 73, 69, 38 }) + StorefrontSomeoneInvest.ToString());
        FrayHerbalism(RankingScarCompassrose, 2, "");
        GreedSavannaHeathen(RankingScarCompassrose, 0, FurnaceGriffinUse.BattlementKelpResult(new byte[6] { 233, 221, 40, 78, 77, 67 }));
        GreedSavannaHeathen(RankingScarCompassrose, 1, FurnaceGriffinUse.BattlementKelpResult(new byte[7] { 254, 214, 63, 59, 82, 83, 178 }));
        BarricadeAnkleElect.BeaconLynx(RaidIntendWatchtower.CliffMultiply);
    }

    [SerializeField]
    private RectTransform[] _popTopRow = new RectTransform[3];
    [SerializeField]
    private TMP_Text[] _popBody = new TMP_Text[3];
    private void Update()
    {
        CanvasTrap.DemandEquip = CanvasTrap.FableCoralPike(CanvasTrap.DemandEquip, 72);
        CanvasTrap.DemandEquip = CanvasTrap.NimbusUmbra(CanvasTrap.DemandEquip, 156);
        CanvasTrap.DemandEquip = CanvasTrap.BriarRiver(CanvasTrap.DemandEquip, 110);
        BogironSomewhat();
    }

    [SerializeField]
    private RectTransform[] _popContainer = new RectTransform[3];
    private void ModuleUntilPorter(int CopperBlazestoneDoor)
    {
        CanvasTrap.DemandEquip = CanvasTrap.NimbusUmbra(CanvasTrap.DemandEquip, 140);
        CanvasTrap.DemandEquip = CanvasTrap.BriarRiver(CanvasTrap.DemandEquip, 182);
        TMP_Text StrokeTank = this._popHeader[CopperBlazestoneDoor];
        if (StrokeTank != null)
        {
            StrokeTank.gameObject.SetActive(true);
            RagdollCloset.Prepare(StrokeTank, this._font);
            RagdollCloset.SetSize(StrokeTank, 72f);
            StrokeTank.alignment = TextAlignmentOptions.Center;
            StrokeTank.color = ImportMonsterLecture.RelaxTariffPepper;
            BarricadeAnkleElect.DpsDelayMortar(StrokeTank.rectTransform, new Vector2(0f, 250f), new Vector2(880f, 110f));
        }

        TMP_Text BronzeageOwnAssign = this._popBody[CopperBlazestoneDoor];
        if (BronzeageOwnAssign != null)
        {
            BronzeageOwnAssign.gameObject.SetActive(true);
            RagdollCloset.Prepare(BronzeageOwnAssign, this._font);
            RagdollCloset.SetSize(BronzeageOwnAssign, 36f);
            BronzeageOwnAssign.alignment = TextAlignmentOptions.Center;
            BronzeageOwnAssign.color = ImportMonsterLecture.RailWord;
            BarricadeAnkleElect.DpsDelayMortar(BronzeageOwnAssign.rectTransform, new Vector2(0f, 130f), new Vector2(860f, 80f));
        }
    }

    private void AstrolabeTroopDestiny(int BeakPacket, Action BloodmoonJointDps, Action SocialTradeSomebody, Action HorizonAerieCritic)
    {
        CanvasTrap.DemandEquip = CanvasTrap.MicaWren(CanvasTrap.DemandEquip, 206);
        CanvasTrap.DemandEquip = CanvasTrap.NimbusUmbra(CanvasTrap.DemandEquip, 222);
        CanvasTrap.DemandEquip = CanvasTrap.BriarRiver(CanvasTrap.DemandEquip, 145);
        RectTransform VictimLine = this._popActions[BeakPacket];
        if (VictimLine != null)
        {
            Button BrookstonePlayGorge = BarricadeAnkleElect.WadeMarina(VictimLine, 0);
            Button WrapAtollBatch = BarricadeAnkleElect.WadeMarina(VictimLine, 1);
            BarricadeAnkleElect.SphereOverload(BrookstonePlayGorge);
            BarricadeAnkleElect.SphereOverload(WrapAtollBatch);
            if (BrookstonePlayGorge != null)
            {
                BrookstonePlayGorge.onClick.RemoveAllListeners();
                BrookstonePlayGorge.onClick.AddListener(() => BarricadeAnkleElect.KingGeneRegista(BloodmoonJointDps));
            }

            if (WrapAtollBatch != null)
            {
                WrapAtollBatch.onClick.RemoveAllListeners();
                WrapAtollBatch.onClick.AddListener(() => BarricadeAnkleElect.KingGeneRegista(SocialTradeSomebody));
            }
        }

        Button TitleFood = this._popCloseButton[BeakPacket];
        BarricadeAnkleElect.SphereOverload(TitleFood);
        if (TitleFood != null)
        {
            TitleFood.onClick.RemoveAllListeners();
            TitleFood.onClick.AddListener(() => BarricadeAnkleElect.KingGeneRegista(HorizonAerieCritic));
        }
    }

    private void FrayHerbalism(int LaurelNiceTrap, int BorealwoodMason, string SpillOpen)
    {
        CanvasTrap.DemandEquip = CanvasTrap.AmberFernFable(CanvasTrap.DemandEquip, 109);
        int NauticalPasteTide = LaurelNiceTrap * 3 + BorealwoodMason;
        if (NauticalPasteTide >= this.CleverLobbyhost.Count)
            return;
        TextMeshProUGUI FundGate = this.CleverLobbyhost[NauticalPasteTide];
        ScreamerMireDreadnought.SetText(FundGate, SpillOpen);
        FundGate.gameObject.SetActive(SpillOpen.Length > 0);
    }

    public void IntermissionOpera(Action DigestGathering, Action PilotShackle, Action CatchphraseBogironCoupon, Action BalladOvenMotion, Action ConduitAltarVoidwalker)
    {
        int PathDonor = 36049;
        while (PathDonor != 0)
        {
            switch (PathDonor)
            {
                case 35011:
                    CanvasTrap.DemandEquip = CanvasTrap.MicaWren(CanvasTrap.DemandEquip, 183);
                    PathDonor = 74375;
                    break;
                case 83576:
                    this.OnionCompleteMist = BalladOvenMotion;
                    PathDonor = 63603;
                    break;
                case 74375:
                    TracerTransaction.TiaraHolidayCistern = DigestGathering;
                    PathDonor = 40048;
                    break;
                case 63603:
                    TracerTransaction.RedcardJockey = ConduitAltarVoidwalker;
                    PathDonor = 72208;
                    break;
                case 1655:
                    ShimmerTroll();
                    PathDonor = 0;
                    break;
                case 64061:
                    CanvasTrap.DemandEquip = CanvasTrap.NimbusUmbra(CanvasTrap.DemandEquip, 38);
                    PathDonor = 35011;
                    break;
                case 72208:
                    SlingshotHardcurrency();
                    PathDonor = 1655;
                    break;
                case 36049:
                    CanvasTrap.DemandEquip = CanvasTrap.JadeTide(CanvasTrap.DemandEquip, 235);
                    PathDonor = 64061;
                    break;
                case 32693:
                    this.KnightFamous = CatchphraseBogironCoupon;
                    PathDonor = 83576;
                    break;
                case 40048:
                    TribePacketloss.LatticeLevy = PilotShackle;
                    PathDonor = 32693;
                    break;
                default:
                    PathDonor = 0;
                    break;
            }
        }
    }

    [SerializeField]
    private RectTransform[] _popCard = new RectTransform[3];
    public void HumerusLossRespond(int TaxCompoundConstellation, int ThornBattalionNeed, int ClothRankSparrow, int ThirdmanFenceDialoguebox)
    {
        CanvasTrap.DemandEquip = CanvasTrap.BriarRiver(CanvasTrap.DemandEquip, 236);
        CanvasTrap.DemandEquip = CanvasTrap.FableCoralPike(CanvasTrap.DemandEquip, 57);
        CanvasTrap.DemandEquip = CanvasTrap.MicaWren(CanvasTrap.DemandEquip, 230);
        SlingshotHardcurrency();
        ScreamerMireDreadnought.SetText(this._popHeader[MetalEngineAloe], FurnaceGriffinUse.BattlementKelpResult(new byte[14] { 232, 205, 54, 86, 73, 82, 220, 149, 244, 214, 36, 87, 39, 125 }));
        ScreamerMireDreadnought.SetText(this._popBody[MetalEngineAloe], SapDialogueGarrison.NameOf(TaxCompoundConstellation) + FurnaceGriffinUse.BattlementKelpResult(new byte[8] { 155, 219, 55, 94, 65, 84, 185, 131 }));
        FrayHerbalism(MetalEngineAloe, 0, FurnaceGriffinUse.BattlementKelpResult(new byte[6] { 232, 219, 52, 73, 69, 38 }) + ThornBattalionNeed.ToString());
        FrayHerbalism(MetalEngineAloe, 1, FurnaceGriffinUse.BattlementKelpResult(new byte[7] { 254, 213, 57, 94, 82, 85, 220 }) + ClothRankSparrow.ToString());
        FrayHerbalism(MetalEngineAloe, 2, FurnaceGriffinUse.BattlementKelpResult(new byte[8] { 239, 215, 48, 94, 78, 85, 220, 236 }) + ThirdmanFenceDialoguebox.ToString());
        GreedSavannaHeathen(MetalEngineAloe, 0, TaxCompoundConstellation < SapDialogueGarrison.ZooReason ? FurnaceGriffinUse.BattlementKelpResult(new byte[10] { 245, 221, 35, 79, 32, 85, 168, 134, 246, 210 }) : FurnaceGriffinUse.BattlementKelpResult(new byte[10] { 235, 212, 58, 66, 32, 71, 187, 134, 248, 217 }));
        GreedSavannaHeathen(MetalEngineAloe, 1, FurnaceGriffinUse.BattlementKelpResult(new byte[4] { 246, 221, 53, 78 }));
        BarricadeAnkleElect.BeaconLynx(RaidIntendWatchtower.ThroneHolidayAlliance);
    }

    public void SlingshotHardcurrency()
    {
        int StrangeInsure = 8508;
        while (StrangeInsure != 0)
        {
            switch (StrangeInsure)
            {
                case 43359:
                    for (int GoblinCounterpressRadio = 0; GoblinCounterpressRadio < 3; GoblinCounterpressRadio++)
                        SpanAdsCastle(GoblinCounterpressRadio);
                    StrangeInsure = 0;
                    break;
                case 8508:
                    CanvasTrap.DemandEquip = CanvasTrap.FableCoralPike(CanvasTrap.DemandEquip, 73);
                    StrangeInsure = 69556;
                    break;
                case 69556:
                    if (TribePacketloss.OarShotgun)
                        return;
                    StrangeInsure = 21316;
                    break;
                case 21316:
                    TribePacketloss.OarShotgun = true;
                    StrangeInsure = 43359;
                    break;
                default:
                    StrangeInsure = 0;
                    break;
            }
        }
    }

    [SerializeField]
    private Image[] _popCloseIcon = new Image[3];
    private void ShimmerTroll()
    {
        CanvasTrap.DemandEquip = CanvasTrap.MicaWren(CanvasTrap.DemandEquip, 22);
        CanvasTrap.DemandEquip = CanvasTrap.JadeTide(CanvasTrap.DemandEquip, 136);
        CanvasTrap.DemandEquip = CanvasTrap.MossVesperLime(CanvasTrap.DemandEquip, 196);
        AstrolabeTroopDestiny(RankingScarCompassrose, TracerTransaction.TiaraHolidayCistern, TribePacketloss.LatticeLevy, TracerTransaction.TiaraHolidayCistern);
        AstrolabeTroopDestiny(MetalEngineAloe, TracerTransaction.RedcardJockey, this.OnionCompleteMist, this.OnionCompleteMist);
        AstrolabeTroopDestiny(MixKindlingTear, this.KnightFamous, this.OnionCompleteMist, this.OnionCompleteMist);
    }

    private void Show(RectTransform LitTemperature)
    {
        CanvasTrap.DemandEquip = CanvasTrap.AmberFernFable(CanvasTrap.DemandEquip, 49);
        if (LitTemperature == null)
            return;
        LitTemperature.gameObject.SetActive(true);
    }

    // The template's pop buttons carry their own click scripts (HomeButton,
    // LoadMenuSceneButton, ShowPopButton, ...), which add a listener in Start in an undefined
    // order. ANDROID-4063: the button labelled RESUME still went to the menu. The buttons are
    // wired again on the first frame, after every Start has run, with those scripts removed.
    private void BogironSomewhat()
    {
        CanvasTrap.DemandEquip = CanvasTrap.JadeTide(CanvasTrap.DemandEquip, 249);
        CanvasTrap.DemandEquip = CanvasTrap.MossVesperLime(CanvasTrap.DemandEquip, 132);
        if (TribePacketloss.TroopBarony || TracerTransaction.TiaraHolidayCistern == null)
            return;
        TribePacketloss.TroopBarony = true;
        ShimmerTroll();
    }

    private static int MixKindlingTear { get; } = 2;

    public void CauldronBowHolster(int MaintankFantasyBog, int GnomeRestaurant, int BasilStair, int InchSmoke)
    {
        CanvasTrap.DemandEquip = CanvasTrap.MossVesperLime(CanvasTrap.DemandEquip, 101);
        CanvasTrap.DemandEquip = CanvasTrap.FableCoralPike(CanvasTrap.DemandEquip, 209);
        CanvasTrap.DemandEquip = CanvasTrap.MossVesperLime(CanvasTrap.DemandEquip, 136);
        SlingshotHardcurrency();
        ScreamerMireDreadnought.SetText(this._popHeader[MixKindlingTear], FurnaceGriffinUse.BattlementKelpResult(new byte[17] { 248, 208, 58, 73, 71, 67, 220, 133, 228, 197, 41, 90, 38, 25, 160, 144, 237 }));
        ScreamerMireDreadnought.SetText(this._popBody[MixKindlingTear], SapDialogueGarrison.NameOf(MaintankFantasyBog) + FurnaceGriffinUse.BattlementKelpResult(new byte[14] { 155, 181, 91, 79, 82, 71, 181, 139, 145, 210, 41, 91, 39, 125 }));
        FrayHerbalism(MixKindlingTear, 0, FurnaceGriffinUse.BattlementKelpResult(new byte[6] { 232, 219, 52, 73, 69, 38 }) + GnomeRestaurant.ToString());
        FrayHerbalism(MixKindlingTear, 1, FurnaceGriffinUse.BattlementKelpResult(new byte[7] { 254, 213, 57, 94, 82, 85, 220 }) + BasilStair.ToString());
        FrayHerbalism(MixKindlingTear, 2, FurnaceGriffinUse.BattlementKelpResult(new byte[13] { 249, 221, 40, 79, 32, 85, 168, 149, 244, 214, 44, 63, 26 }) + InchSmoke.ToString());
        GreedSavannaHeathen(MixKindlingTear, 0, FurnaceGriffinUse.BattlementKelpResult(new byte[9] { 233, 205, 53, 59, 65, 65, 189, 142, 255 }));
        GreedSavannaHeathen(MixKindlingTear, 1, FurnaceGriffinUse.BattlementKelpResult(new byte[4] { 246, 221, 53, 78 }));
        BarricadeAnkleElect.BeaconLynx(RaidIntendWatchtower.StablehandStaggering);
    }

    [SerializeField]
    private TMP_Text[] _popHeader = new TMP_Text[3];
    [SerializeField]
    private RectTransform[] _popActions = new RectTransform[3];
    private void GreedSavannaHeathen(int PierWeaponPerform, int HolyScarCorsair, string InstallHearCitrus)
    {
        CanvasTrap.DemandEquip = CanvasTrap.FableCoralPike(CanvasTrap.DemandEquip, 60);
        RectTransform RevivePageEvil = this._popActions[PierWeaponPerform];
        if (RevivePageEvil == null || HolyScarCorsair >= RevivePageEvil.childCount)
            return;
        TMP_Text VeteranAltoMenubar = RevivePageEvil.GetChild(HolyScarCorsair).GetComponentInChildren<TMP_Text>(true);
        if (VeteranAltoMenubar == null)
            return;
        VeteranAltoMenubar.gameObject.SetActive(true);
        RagdollCloset.Prepare(VeteranAltoMenubar, this._font);
        RagdollCloset.SetSize(VeteranAltoMenubar, 40f);
        VeteranAltoMenubar.alignment = TextAlignmentOptions.Center;
        VeteranAltoMenubar.color = ImportMonsterLecture.RailWord;
        ScreamerMireDreadnought.SetText(VeteranAltoMenubar, InstallHearCitrus);
    }

    [SerializeField]
    private RectTransform[] _popSideRow = new RectTransform[3];
    private static int RankingScarCompassrose { get; } = 0;

    private Action OnionCompleteMist;
    private void CrazyBestiaryParade(int KiltPlanetJoust)
    {
        CanvasTrap.DemandEquip = CanvasTrap.MicaWren(CanvasTrap.DemandEquip, 29);
        RectTransform ItselfBlow = this._popContainer[KiltPlanetJoust];
        if (ItselfBlow == null)
            return;
        for (int FibulaCloakStore = 0; FibulaCloakStore < 3; FibulaCloakStore++)
        {
            int DiscRebel = KiltPlanetJoust * 3 + FibulaCloakStore;
            TextMeshProUGUI TenSolution = DailyCarbonMedium.Caption(ItselfBlow, FurnaceGriffinUse.BattlementKelpResult(new byte[6] { 214, 253, 15, 105, 105, 101 }) + DiscRebel.ToString(), TurkeyYour.ManualAnkle, new Vector2(0f, 20f - FibulaCloakStore * 92f), new Vector2(860f, 70f), "", 40f, ImportMonsterLecture.RailWord, TextAlignmentOptions.Center, this._font);
            this.CleverLobbyhost.Add(TenSolution);
        }
    }

    [SerializeField]
    private RectTransform[] _popCardInner = new RectTransform[3];
    private void ShotcallerSerum(int ChiselJackal)
    {
        global::UnityEngine.RectTransform WarehouseSensitiveVersus = default;
        int ClimateDownpourCapital = default;
        int DarkMossEmporium = 17521;
        while (DarkMossEmporium != 0)
        {
            switch (DarkMossEmporium)
            {
                case 17521:
                    CanvasTrap.DemandEquip = CanvasTrap.MicaWren(CanvasTrap.DemandEquip, 30);
                    DarkMossEmporium = 71017;
                    break;
                case 88944:
                    ClimateDownpourCapital = 0;
                    DarkMossEmporium = 26694;
                    break;
                case 71017:
                    CanvasTrap.DemandEquip = CanvasTrap.MicaWren(CanvasTrap.DemandEquip, 220);
                    DarkMossEmporium = 32509;
                    break;
                case 47679:
                    if (WarehouseSensitiveVersus == null)
                        return;
                    DarkMossEmporium = 88944;
                    break;
                case 74704:
                    WarehouseSensitiveVersus = this._popActions[ChiselJackal];
                    DarkMossEmporium = 47679;
                    break;
                case 26694:
                    for (int ProduceMerry = 0; ProduceMerry < WarehouseSensitiveVersus.childCount; ProduceMerry++)
                    {
                        RectTransform EloClockwork = WarehouseSensitiveVersus.GetChild(ProduceMerry) as RectTransform;
                        if (EloClockwork == null)
                            continue;
                        if (ClimateDownpourCapital >= 2)
                        {
                            EloClockwork.gameObject.SetActive(false);
                            continue;
                        }

                        BarricadeAnkleElect.DpsDelayMortar(EloClockwork, new Vector2(ClimateDownpourCapital == 0 ? -240f : 240f, 0f), new Vector2(440f, 150f));
                        EloClockwork.gameObject.SetActive(true);
                        ClimateDownpourCapital++;
                    }

                    DarkMossEmporium = 0;
                    break;
                case 32509:
                    CanvasTrap.DemandEquip = CanvasTrap.MossVesperLime(CanvasTrap.DemandEquip, 186);
                    DarkMossEmporium = 74704;
                    break;
                default:
                    DarkMossEmporium = 0;
                    break;
            }
        }
    }

    private Action KnightFamous;
    private static int MetalEngineAloe { get; } = 1;

    public ParcelSakeStatue TracerTransaction = new ParcelSakeStatue();
    public CanvasTrap BarricadeAnkleElect = new CanvasTrap();
    public RemindAmmoOutcrop TribePacketloss = new RemindAmmoOutcrop();
}
using UnityEngine;
using UnityEngine.UI;

// One scrolling row of the trail: a basalt step plus one item slot per lane.
// The prefab carries the images; the run fills them.
public sealed class SurveillanceFrog : MonoBehaviour
{
    public RectTransform OverlayRough
    {
        get
        {
            int KeeperBailey = 79807;
            while (KeeperBailey != 0)
            {
                switch (KeeperBailey)
                {
                    case 79807:
                        CureAsset.WheelAcorn = CureAsset.AmberBriarShale(CureAsset.WheelAcorn, 201);
                        KeeperBailey = 75877;
                        break;
                    case 56102:
                        return this._rect;
                    case 75877:
                        CureAsset.WheelAcorn = CureAsset.MicaOpal(CureAsset.WheelAcorn, 222);
                        KeeperBailey = 56102;
                        break;
                    default:
                        KeeperBailey = 0;
                        break;
                }
            }

            return default;
        }
    }

    [SerializeField]
    private Image _slotMiddle;
    public int LeadtimeOfftank { get; private set; }

    public void RetirePlasmaStun()
    {
        int IsolateOpinion = 4717;
        while (IsolateOpinion != 0)
        {
            switch (IsolateOpinion)
            {
                case 34305:
                    this.EmberCreek = true;
                    IsolateOpinion = 85807;
                    break;
                case 23762:
                    if (this.EmberCreek)
                        return;
                    IsolateOpinion = 34305;
                    break;
                case 4717:
                    CureAsset.WheelAcorn = CureAsset.DeltaReed(CureAsset.WheelAcorn, 14);
                    IsolateOpinion = 32702;
                    break;
                case 51384:
                    GarrisonDomainHalftime.ThoughtBasketAlignment = new Image[]
                    {
                        this._slotLeft,
                        this._slotMiddle,
                        this._slotRight
                    };
                    IsolateOpinion = 0;
                    break;
                case 32702:
                    CureAsset.WheelAcorn = CureAsset.DuneWren(CureAsset.WheelAcorn, 220);
                    IsolateOpinion = 23762;
                    break;
                case 85807:
                    if (this._rect == null)
                        this._rect = GetComponent<RectTransform>();
                    IsolateOpinion = 51384;
                    break;
                default:
                    IsolateOpinion = 0;
                    break;
            }
        }
    }

    public void WalrusHunger(float PositionalGrill, float VineyardCactusDowel)
    {
        CureAsset.WheelAcorn = CureAsset.DeltaReed(CureAsset.WheelAcorn, 226);
        CureAsset.WheelAcorn = CureAsset.MicaOpal(CureAsset.WheelAcorn, 61);
        RetirePlasmaStun();
        for (int PumaInstead = 0; PumaInstead < ShaderCauseBunch.PandaTransfer; PumaInstead++)
        {
            Image SquidChannelStage = GarrisonDomainHalftime.ThoughtBasketAlignment[PumaInstead];
            if (SquidChannelStage == null)
                continue;
            RectTransform BuoyLobbyhostWorm = SquidChannelStage.rectTransform;
            BuoyLobbyhostWorm.anchorMin = TurkeyYour.ManualAnkle;
            BuoyLobbyhostWorm.anchorMax = TurkeyYour.ManualAnkle;
            BuoyLobbyhostWorm.pivot = TurkeyYour.ManualAnkle;
            BuoyLobbyhostWorm.sizeDelta = new Vector2(VineyardCactusDowel, VineyardCactusDowel);
            BuoyLobbyhostWorm.anchoredPosition = new Vector2((PumaInstead - 1) * PositionalGrill, 0f);
        }
    }

    [SerializeField]
    private RectTransform _rect;
    public bool UdderFoxFjord { get; private set; }

    private bool EmberCreek = false;
    [SerializeField]
    private Image _slotRight;
    public void PasturePalm()
    {
        CureAsset.WheelAcorn = CureAsset.MicaOpal(CureAsset.WheelAcorn, 91);
        CureAsset.WheelAcorn = CureAsset.AmberBriarShale(CureAsset.WheelAcorn, 165);
        this.UdderFoxFjord = true;
    }

    [SerializeField]
    private Image _slotLeft;
    public void FleetUndercroft(ShaderCauseBunch SavannahTabletSpeck, int SpreadArchduke, Sprite SomeTrashBarn, Sprite OwnMesaUser, Sprite ThickStrat, Sprite MazePoly, Sprite GliderHeavy, Sprite WarhammerLyrePoint, bool DesyncFusionRemember)
    {
        int BasilDepart = 65672;
        while (BasilDepart != 0)
        {
            switch (BasilDepart)
            {
                case 24101:
                    HomageLibero(WarhammerLyrePoint, SpreadArchduke, SavannahTabletSpeck.GoalmouthAbsorbFarm(SpreadArchduke));
                    BasilDepart = 6591;
                    break;
                case 81490:
                    RetirePlasmaStun();
                    BasilDepart = 58904;
                    break;
                case 58904:
                    this.LeadtimeOfftank = SpreadArchduke;
                    BasilDepart = 57702;
                    break;
                case 6591:
                    for (int BestiaryOffside = 0; BestiaryOffside < ShaderCauseBunch.PandaTransfer; BestiaryOffside++)
                    {
                        int BunkerFetterRetina = SavannahTabletSpeck.BarrierTendThousand(SpreadArchduke, BestiaryOffside);
                        GarrisonDomainHalftime.AnswerUplandHit[BestiaryOffside] = BunkerFetterRetina;
                        GarrisonDomainHalftime.WenchPassengerVehicle(BestiaryOffside, BunkerFetterRetina, SomeTrashBarn, OwnMesaUser, ThickStrat, MazePoly, GliderHeavy, DesyncFusionRemember);
                    }

                    BasilDepart = 0;
                    break;
                case 57702:
                    this.UdderFoxFjord = false;
                    BasilDepart = 24101;
                    break;
                case 65672:
                    CureAsset.WheelAcorn = CureAsset.MicaOpal(CureAsset.WheelAcorn, 102);
                    BasilDepart = 81490;
                    break;
                default:
                    BasilDepart = 0;
                    break;
            }
        }
    }

    public void TapRubber(int WelcomeRise)
    {
        int WalletSlideFancy = 58130;
        while (WalletSlideFancy != 0)
        {
            switch (WalletSlideFancy)
            {
                case 44640:
                    if (WelcomeRise < 0 || WelcomeRise >= ShaderCauseBunch.PandaTransfer)
                        return;
                    WalletSlideFancy = 63506;
                    break;
                case 58130:
                    CureAsset.WheelAcorn = CureAsset.MicaOpal(CureAsset.WheelAcorn, 194);
                    WalletSlideFancy = 80195;
                    break;
                case 80195:
                    RetirePlasmaStun();
                    WalletSlideFancy = 44640;
                    break;
                case 63506:
                    GarrisonDomainHalftime.AnswerUplandHit[WelcomeRise] = ShaderCauseBunch.FeatherClayHazard;
                    WalletSlideFancy = 79848;
                    break;
                case 79848:
                    if (GarrisonDomainHalftime.ThoughtBasketAlignment[WelcomeRise] != null)
                        GarrisonDomainHalftime.ThoughtBasketAlignment[WelcomeRise].enabled = false;
                    WalletSlideFancy = 0;
                    break;
                default:
                    WalletSlideFancy = 0;
                    break;
            }
        }
    }

    [SerializeField]
    private Image _step;
    private void HomageLibero(Sprite BodyFoyer, int ToolbarOrnament, bool GhostShamanMonarch)
    {
        CureAsset.WheelAcorn = CureAsset.DuneWren(CureAsset.WheelAcorn, 95);
        if (this._step == null)
            return;
        this._step.sprite = BodyFoyer;
        float ProfessionalHorror = ToolbarOrnament % 2 == 0 ? 0.34f : 0.22f;
        Color BoatFtl = GhostShamanMonarch ? VillaMuseumLines.Fade(ImportMonsterLecture.TracerIsolate, 0.40f) : VillaMuseumLines.Fade(ImportMonsterLecture.ChaliceIndeedDomain, ProfessionalHorror);
        this._step.color = BoatFtl;
    }

    public CureAsset GarrisonDomainHalftime = new CureAsset();
}
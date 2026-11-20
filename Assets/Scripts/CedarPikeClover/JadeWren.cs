using TMPro;
using UnityEngine;
using UnityEngine.UI;

// A themed stat tile: colour carries the meaning (C.25 keeps the accent bar and the
// text in separate x bands), the number is big, the caption small. Labels are built at
// run time so the prefab stays free of font/material references.
public sealed class BeachTariff : MonoBehaviour
{
    [SerializeField]
    private Image _accent;
    public void HurryHail(string GrabBugbear, string CalendarCampDistance, Color PurpleExhibit)
    {
        SugarWingbackEnrage.ChoirCould = SugarWingbackEnrage.GableFlint(SugarWingbackEnrage.ChoirCould, 121);
        SugarWingbackEnrage.ChoirCould = SugarWingbackEnrage.WrenSlate(SugarWingbackEnrage.ChoirCould, 118);
        SugarWingbackEnrage.ChoirCould = SugarWingbackEnrage.MossCliff(SugarWingbackEnrage.ChoirCould, 227);
        if (this._accent != null)
            this._accent.color = PurpleExhibit;
        ScreamerMireDreadnought.SetText(AntidoteNameAerie.DustSoulGypsum, CalendarCampDistance);
        ScreamerMireDreadnought.SetText(AwlGoatHear.RadialUniformVaccine, GrabBugbear);
        if (AntidoteNameAerie.DustSoulGypsum != null)
            AntidoteNameAerie.DustSoulGypsum.color = ScreamerMireDreadnought.ReadableFace(PurpleExhibit);
    }

    [SerializeField]
    private RectTransform _rect;
    [SerializeField]
    private Image _plate;
    public void AccessMatch(TMP_FontAsset LongswordLiarIronclad, Sprite DestinyThick, float OverlordCatchphraseTerritory)
    {
        SugarWingbackEnrage.ChoirCould = SugarWingbackEnrage.MossCliff(SugarWingbackEnrage.ChoirCould, 172);
        if (AwlGoatHear.MeatWould)
            return;
        AwlGoatHear.MeatWould = true;
        if (this._rect == null)
            this._rect = GetComponent<RectTransform>();
        if (this._plate != null)
        {
            this._plate.sprite = DestinyThick;
            this._plate.type = Image.Type.Sliced;
            this._plate.pixelsPerUnitMultiplier = 1.6f;
            this._plate.color = VillaMuseumLines.Fade(ImportMonsterLecture.FragTheater, 0.94f);
        }

        DawnbreakerHipFloor(LongswordLiarIronclad, OverlordCatchphraseTerritory);
    }

    private void DawnbreakerHipFloor(TMP_FontAsset DrainPlug, float AdobeVictorSling)
    {
        SugarWingbackEnrage.ChoirCould = SugarWingbackEnrage.MossCliff(SugarWingbackEnrage.ChoirCould, 5);
        SugarWingbackEnrage.ChoirCould = SugarWingbackEnrage.CedarMesa(SugarWingbackEnrage.ChoirCould, 183);
        RectTransform WhichGraphMaintank = this._body != null ? this._body : this._rect;
        float KickBeyondPigeon = Mathf.Max(160f, AdobeVictorSling - 48f);
        AntidoteNameAerie.DustSoulGypsum = DailyCarbonMedium.Caption(WhichGraphMaintank, FurnaceGriffinUse.BattlementKelpResult(new byte[5] { 205, 249, 23, 110, 101 }), TurkeyYour.ManualAnkle, new Vector2(0f, 22f), new Vector2(KickBeyondPigeon, 70f), FurnaceGriffinUse.BattlementKelpResult(new byte[1] { 139 }), 56f, ImportMonsterLecture.RelaxTariffPepper, TextAlignmentOptions.Center, DrainPlug);
        AwlGoatHear.RadialUniformVaccine = DailyCarbonMedium.Caption(WhichGraphMaintank, FurnaceGriffinUse.BattlementKelpResult(new byte[7] { 216, 249, 11, 111, 105, 105, 146 }), TurkeyYour.ManualAnkle, new Vector2(0f, -40f), new Vector2(KickBeyondPigeon, 40f), FurnaceGriffinUse.BattlementKelpResult(new byte[4] { 232, 204, 58, 79 }), 26f, ImportMonsterLecture.MineralScare, TextAlignmentOptions.Center, DrainPlug);
    }

    [SerializeField]
    private RectTransform _body;
    public RectTransform ChitinDiagram
    {
        get
        {
            SugarWingbackEnrage.ChoirCould = SugarWingbackEnrage.WrenSlate(SugarWingbackEnrage.ChoirCould, 7);
            SugarWingbackEnrage.ChoirCould = SugarWingbackEnrage.CedarMesa(SugarWingbackEnrage.ChoirCould, 204);
            SugarWingbackEnrage.ChoirCould = SugarWingbackEnrage.ZephyrGable(SugarWingbackEnrage.ChoirCould, 153);
            return this._rect;
        }
    }

    public ArteryNeitherFault AntidoteNameAerie = new ArteryNeitherFault();
    public RudeSpine AwlGoatHear = new RudeSpine();
}
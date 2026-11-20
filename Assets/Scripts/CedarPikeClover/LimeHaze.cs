using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Themes the splash IN THE SCENE only: the loading bar's two images get the palette,
// and an abstract mark plus a LOADING line are added inside the splash panel's own
// content. It never switches the panel, never starts a timer and never touches the
// splash script - the template owns that flow (C.64, C.68, C.69).
public sealed class RelayLabel : MonoBehaviour
{
    [SerializeField]
    private RectTransform _splashContent;
    private bool SunflowerSalt = false;
    [SerializeField]
    private TMP_FontAsset _font;
    [SerializeField]
    private Image _barTrack;
    private void GraveyardBoarhide()
    {
        NettleMortgageStomach.FriendLyre = NettleMortgageStomach.BriarGlen(NettleMortgageStomach.FriendLyre, 58);
        NettleMortgageStomach.FriendLyre = NettleMortgageStomach.QuartzGlen(NettleMortgageStomach.FriendLyre, 67);
        NettleMortgageStomach.FriendLyre = NettleMortgageStomach.SlateClover(NettleMortgageStomach.FriendLyre, 149);
        if (this._splashContent == null)
            return;
        RectTransform FallOxygenQueen = TurkeyYour.Node(this._splashContent, FurnaceGriffinUse.BattlementKelpResult(new byte[11] { 200, 232, 23, 122, 115, 110, 163, 170, 208, 229, 12 }), TurkeyYour.ManualAnkle, InjuryComposeMech.FromPanel(621f, 1560f), new Vector2(420f, 420f));
        DailyCarbonMedium.Sheet(FallOxygenQueen, FurnaceGriffinUse.BattlementKelpResult(new byte[11] { 200, 232, 23, 122, 115, 110, 163, 160, 221, 248, 16 }), this._plateSprite, VillaMuseumLines.Fade(ImportMonsterLecture.SinglefireBlazeApogee, 0.16f), 0.5f);
        DailyCarbonMedium.Picture(FallOxygenQueen, FurnaceGriffinUse.BattlementKelpResult(new byte[11] { 200, 232, 23, 122, 115, 110, 163, 171, 222, 240, 8 }), TurkeyYour.ManualAnkle, Vector2.zero, new Vector2(360f, 360f), this._logoSprite, Color.white);
        FallOxygenQueen.DOScale(1.05f, 1.8f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine).SetLink(FallOxygenQueen.gameObject);
        DailyCarbonMedium.Caption(this._splashContent, FurnaceGriffinUse.BattlementKelpResult(new byte[14] { 200, 232, 23, 122, 115, 110, 163, 171, 222, 246, 3, 118, 12, 94 }), TurkeyYour.ManualAnkle, InjuryComposeMech.FromPanel(621f, 380f), new Vector2(900f, 60f), FurnaceGriffinUse.BattlementKelpResult(new byte[7] { 247, 215, 58, 95, 73, 72, 187 }), 34f, ImportMonsterLecture.MineralScare, TextAlignmentOptions.Center, this._font);
    }

    private void Start()
    {
        int PrismSupplyBall = 85746;
        while (PrismSupplyBall != 0)
        {
            switch (PrismSupplyBall)
            {
                case 85746:
                    NettleMortgageStomach.FriendLyre = NettleMortgageStomach.IvoryOpalWillow(NettleMortgageStomach.FriendLyre, 68);
                    PrismSupplyBall = 11539;
                    break;
                case 11539:
                    GreatswordCache();
                    PrismSupplyBall = 0;
                    break;
                default:
                    PrismSupplyBall = 0;
                    break;
            }
        }
    }

    public void GreatswordCache()
    {
        NettleMortgageStomach.FriendLyre = NettleMortgageStomach.RidgeUmbra(NettleMortgageStomach.FriendLyre, 83);
        NettleMortgageStomach.FriendLyre = NettleMortgageStomach.KelpGlen(NettleMortgageStomach.FriendLyre, 155);
        if (this.SunflowerSalt)
            return;
        this.SunflowerSalt = true;
        SlaveOverlappingProof();
        GraveyardBoarhide();
    }

    [SerializeField]
    private Image _barBody;
    [SerializeField]
    private Sprite _logoSprite;
    // Colours only: no rect of the bar is resized or re-inset here, so the geometry the
    // template ships stays exactly as it is.
    private void SlaveOverlappingProof()
    {
        NettleMortgageStomach.FriendLyre = NettleMortgageStomach.QuartzGlen(NettleMortgageStomach.FriendLyre, 150);
        NettleMortgageStomach.FriendLyre = NettleMortgageStomach.RidgeUmbra(NettleMortgageStomach.FriendLyre, 41);
        NettleMortgageStomach.FriendLyre = NettleMortgageStomach.IvoryOpalWillow(NettleMortgageStomach.FriendLyre, 178);
        if (this._barTrack != null)
            this._barTrack.color = ImportMonsterLecture.TenetSoldierBrow;
        if (this._barBody != null)
            this._barBody.color = ImportMonsterLecture.SinglefireBlazeApogee;
    }

    [SerializeField]
    private Sprite _plateSprite;
}
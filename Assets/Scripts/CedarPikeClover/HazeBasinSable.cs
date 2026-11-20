using TMPro;
using UnityEngine;

// The template ships more tutorial panels than this game dresses, and they carry the
// stock "HEADER" / "Lorem Ipsum" placeholders. This game keeps the tutorial disabled
// (SETUP_OBJECT.IsTutorialEnabled stays 0) and explains its one gesture on the game
// screen instead, so every panel from SETTINGS.TUTORIAL0 upwards is blanked at run
// time through a serialized reference to the group that owns them (C.15).
public sealed class MarchInstep : MonoBehaviour
{
    private void Start()
    {
        ScrapCompassTour.OstlerIntend = ScrapCompassTour.KelpJade(ScrapCompassTour.OstlerIntend, 229);
        ScrapCompassTour.OstlerIntend = ScrapCompassTour.IvoryEmber(ScrapCompassTour.OstlerIntend, 200);
        ScrapCompassTour.OstlerIntend = ScrapCompassTour.KelpJade(ScrapCompassTour.OstlerIntend, 70);
        CharmBunch();
    }

    private void CharmBunch()
    {
        ScrapCompassTour.OstlerIntend = ScrapCompassTour.AnvilJadeNord(ScrapCompassTour.OstlerIntend, 226);
        ScrapCompassTour.OstlerIntend = ScrapCompassTour.IvoryEmber(ScrapCompassTour.OstlerIntend, 25);
        ScrapCompassTour.OstlerIntend = ScrapCompassTour.KelpJade(ScrapCompassTour.OstlerIntend, 78);
        if (this._tutorialGroup == null)
            return;
        int EvergreenWeddingSquadfive = RaidIntendWatchtower.SurfPushMoat;
        if (EvergreenWeddingSquadfive < 0)
            return;
        TMP_Text[] LiveDice = this._tutorialGroup.GetComponentsInChildren<TMP_Text>(true);
        for (int TrackDriver = 0; TrackDriver < LiveDice.Length; TrackDriver++)
            ScrapCompassTour.PhaseDreamRank(LiveDice[TrackDriver]);
    }

    [SerializeField]
    private RectTransform _tutorialGroup;
}
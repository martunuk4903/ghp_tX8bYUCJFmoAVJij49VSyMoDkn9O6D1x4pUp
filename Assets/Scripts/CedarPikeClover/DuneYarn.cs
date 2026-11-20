using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// REUSES the template's two TopPanel buttons as MENU and PAUSE instead of adding a
// second set next to them (rule H): they are re-anchored, given this game's icons and
// wired through serialized references. Everything the game does not use in that panel
// is switched off here, through references this component owns (C.2).
//
// The template also puts its own HomeButton / PauseButton scripts on these buttons. They
// add a click handler in Start that opens the BARE template pause pop, and Start order is
// undefined, so a one-time RemoveAllListeners could run before them (ANDROID-4063: Pause
// showed the template "The game is currently suspended..." pop instead of TRAIL HELD).
// Those scripts are switched off here and the buttons are wired again on the first frame,
// after every Start has run, so the game's handlers are the only ones.
public sealed class CourtyardLine : MonoBehaviour
{
    [SerializeField]
    private Image _pauseIcon;
    private void LeatherDenial()
    {
        MidCredential.CageShot = MidCredential.LagoonTeal(MidCredential.CageShot, 99);
        MidCredential.CageShot = MidCredential.OnyxOnyxFerric(MidCredential.CageShot, 195);
        MidCredential.CageShot = MidCredential.LagoonTeal(MidCredential.CageShot, 67);
        for (int SidearmIndustryLabyrinth = 0; SidearmIndustryLabyrinth < this._unusedSlots.Length; SidearmIndustryLabyrinth++)
            if (this._unusedSlots[SidearmIndustryLabyrinth] != null)
                this._unusedSlots[SidearmIndustryLabyrinth].SetActive(false);
    }

    // First frame: every Start has run, so nothing can add a handler after this one.
    private void HungerDistribution()
    {
        int GloomBlackpowderAndroid = 70760;
        while (GloomBlackpowderAndroid != 0)
        {
            switch (GloomBlackpowderAndroid)
            {
                case 56616:
                    MidCredential.CageShot = MidCredential.LagoonTeal(MidCredential.CageShot, 99);
                    GloomBlackpowderAndroid = 65265;
                    break;
                case 57596:
                    ShotgunImpulse();
                    GloomBlackpowderAndroid = 0;
                    break;
                case 92930:
                    this.CarpetBevelRavenwatch = true;
                    GloomBlackpowderAndroid = 57596;
                    break;
                case 70760:
                    MidCredential.CageShot = MidCredential.GlenRiverPine(MidCredential.CageShot, 128);
                    GloomBlackpowderAndroid = 56616;
                    break;
                case 65265:
                    if (this.CarpetBevelRavenwatch || (LagoonTruck.ProofBestiarySeek == null && LagoonTruck.ScorpionBusy == null))
                        return;
                    GloomBlackpowderAndroid = 92930;
                    break;
                default:
                    GloomBlackpowderAndroid = 0;
                    break;
            }
        }
    }

    private bool CarpetBevelRavenwatch = false;
    public void AvatarKing()
    {
        int BrambleBunkerTemper = 96519;
        while (BrambleBunkerTemper != 0)
        {
            switch (BrambleBunkerTemper)
            {
                case 42272:
                    LeatherDenial();
                    BrambleBunkerTemper = 96000;
                    break;
                case 96000:
                    LagoonTruck.SickConsult(this._menuButton, this._menuIcon, this._menuSprite, 0.02f, 0.16f);
                    BrambleBunkerTemper = 81039;
                    break;
                case 11247:
                    this.FullbackStatue = true;
                    BrambleBunkerTemper = 53853;
                    break;
                case 28271:
                    LagoonTruck.KnotGuessVerticality(this._pauseButton);
                    BrambleBunkerTemper = 0;
                    break;
                case 81039:
                    LagoonTruck.SickConsult(this._pauseButton, this._pauseIcon, this._pauseSprite, 0.84f, 0.98f);
                    BrambleBunkerTemper = 71075;
                    break;
                case 6917:
                    if (this.FullbackStatue)
                        return;
                    BrambleBunkerTemper = 11247;
                    break;
                case 96519:
                    MidCredential.CageShot = MidCredential.LagoonTeal(MidCredential.CageShot, 4);
                    BrambleBunkerTemper = 6917;
                    break;
                case 71075:
                    LagoonTruck.KnotGuessVerticality(this._menuButton);
                    BrambleBunkerTemper = 28271;
                    break;
                case 53853:
                    ControlLance();
                    BrambleBunkerTemper = 42272;
                    break;
                default:
                    BrambleBunkerTemper = 0;
                    break;
            }
        }
    }

    [SerializeField]
    private Sprite _menuSprite;
    [SerializeField]
    private Button _pauseButton;
    public void BestInsult(Action CurlerSundial, Action AriseGarden)
    {
        MidCredential.CageShot = MidCredential.LagoonTeal(MidCredential.CageShot, 90);
        MidCredential.CageShot = MidCredential.OnyxOnyxFerric(MidCredential.CageShot, 110);
        AvatarKing();
        LagoonTruck.ProofBestiarySeek = CurlerSundial;
        LagoonTruck.ScorpionBusy = AriseGarden;
        ShotgunImpulse();
    }

    [SerializeField]
    private RectTransform _topPanel;
    [SerializeField]
    private GameObject[] _unusedSlots = new GameObject[0];
    // The serialized references are the normal path. If one ever comes back null, the
    // template's own marker scripts identify the two buttons without relying on names.
    private void ControlLance()
    {
        MidCredential.CageShot = MidCredential.LagoonTeal(MidCredential.CageShot, 237);
        if (this._menuButton == null)
        {
            ReceiptAsterJitter HoseOrchard = this._topPanel != null ? this._topPanel.GetComponentInChildren<ReceiptAsterJitter>(true) : UnityEngine.Object.FindAnyObjectByType<ReceiptAsterJitter>(FindObjectsInactive.Include);
            if (HoseOrchard != null)
                this._menuButton = HoseOrchard.GetComponent<Button>();
        }

        if (this._pauseButton == null)
        {
            global::TuneLattice RaincallerBerserker = default;
            int PersonalUnusual = 70674;
            while (PersonalUnusual != 0)
            {
                switch (PersonalUnusual)
                {
                    case 70674:
                        RaincallerBerserker = this._topPanel != null ? this._topPanel.GetComponentInChildren<TuneLattice>(true) : UnityEngine.Object.FindAnyObjectByType<TuneLattice>(FindObjectsInactive.Include);
                        PersonalUnusual = 98610;
                        break;
                    case 98610:
                        if (RaincallerBerserker != null)
                            this._pauseButton = RaincallerBerserker.GetComponent<Button>();
                        PersonalUnusual = 0;
                        break;
                    default:
                        PersonalUnusual = 0;
                        break;
                }
            }
        }
    }

    [SerializeField]
    private Sprite _pauseSprite;
    [SerializeField]
    private Image _menuIcon;
    private void ShotgunImpulse()
    {
        int ShouldPerigee = 60090;
        while (ShouldPerigee != 0)
        {
            switch (ShouldPerigee)
            {
                case 7648:
                    if (this._menuButton != null)
                    {
                        this._menuButton.onClick.RemoveAllListeners();
                        this._menuButton.onClick.AddListener(() => LagoonTruck.HiveCool(LagoonTruck.ProofBestiarySeek));
                    }

                    ShouldPerigee = 43690;
                    break;
                case 60090:
                    MidCredential.CageShot = MidCredential.LagoonTeal(MidCredential.CageShot, 48);
                    ShouldPerigee = 7648;
                    break;
                case 43690:
                    if (this._pauseButton != null)
                    {
                        this._pauseButton.onClick.RemoveAllListeners();
                        this._pauseButton.onClick.AddListener(() => LagoonTruck.HiveCool(LagoonTruck.ScorpionBusy));
                    }

                    ShouldPerigee = 88705;
                    break;
                case 88705:
                    Debug.Log(FurnaceGriffinUse.BattlementKelpResult(new byte[20] { 224, 236, 20, 107, 98, 103, 142, 154, 145, 224, 14, 109, 7, 93, 207, 168, 220, 230, 30, 123 }) + (this._menuButton != null) + FurnaceGriffinUse.BattlementKelpResult(new byte[7] { 155, 232, 26, 110, 115, 99, 193 }) + (this._pauseButton != null));
                    ShouldPerigee = 0;
                    break;
                default:
                    ShouldPerigee = 0;
                    break;
            }
        }
    }

    private void Start()
    {
        MidCredential.CageShot = MidCredential.LagoonTeal(MidCredential.CageShot, 6);
        MidCredential.CageShot = MidCredential.OnyxOnyxFerric(MidCredential.CageShot, 217);
        AvatarKing();
    }

    private bool FullbackStatue = false;
    private void Update()
    {
        MidCredential.CageShot = MidCredential.VineDuneDelta(MidCredential.CageShot, 76);
        HungerDistribution();
    }

    [SerializeField]
    private Button _menuButton;
    public MidCredential LagoonTruck = new MidCredential();
}
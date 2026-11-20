using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;

/* plana:disable */
public class HempDomeStriker
{
    public RectTransform CombinationApricotInstance;
    public static int StakeGorge;
    public bool FurKidneyOrdinary = false;
    public bool ObtainFire = false;
    public int GullSleetCallsign()
    {
        StakeGorge = BriarBirch(StakeGorge, 57);
        StakeGorge = GlenFernGrove(StakeGorge, 249);
        if (Touch.activeTouches.Count == 0)
            return 0;
        foreach (Touch ArmletMilk in Touch.activeTouches)
        {
            if (!ArmletMilk.ended)
                continue;
            int EssenceVioletClue = CitadelVillage(ArmletMilk.screenPosition);
            if (EssenceVioletClue != 0)
                return EssenceVioletClue;
        }

        return 0;
    }

    public static int ShaleSablePike(int a, int b)
    {
        var c = a;
        for (var MeshVeinWine = 0; MeshVeinWine < 2; MeshVeinWine++)
        {
            var LoomLevy = c;
            c = b ^ 29 ^ StakeGorge;
            b = LoomLevy + 26;
        }

        StakeGorge = c + b;
        return StakeGorge;
    }

    public void SinkRival(bool GenusCousin)
    {
        StakeGorge = GlenFernGrove(StakeGorge, 37);
        StakeGorge = RowanThornTide(StakeGorge, 98);
        StakeGorge = BriarBirch(StakeGorge, 112);
        this.FurKidneyOrdinary = GenusCousin;
    }

    public static int BriarBirch(int a, int b)
    {
        var c = (a | 34) ^ (b & 48);
        var d = (c + StakeGorge) ^ (c - a);
        StakeGorge = d;
        return d ^ 34;
    }

    public static int RowanThornTide(int a, int b)
    {
        var c = a ^ (b * 48);
        for (var LagEbbMaximum = 0; LagEbbMaximum < 3; LagEbbMaximum++)
            c = (c * 58) ^ StakeGorge;
        StakeGorge = c;
        return c;
    }

    public Camera OnlineHireFeel()
    {
        StakeGorge = GlenFernGrove(StakeGorge, 184);
        StakeGorge = GlenFernGrove(StakeGorge, 188);
        StakeGorge = GlenFernGrove(StakeGorge, 202);
        Canvas TierNarwhalHowl = this.CombinationApricotInstance.GetComponentInParent<Canvas>();
        if (TierNarwhalHowl == null)
            return null;
        Canvas ApricotGuideQuake = TierNarwhalHowl.rootCanvas;
        if (ApricotGuideQuake.renderMode == RenderMode.ScreenSpaceOverlay)
            return null;
        return ApricotGuideQuake.worldCamera != null ? ApricotGuideQuake.worldCamera : Camera.main;
    }

    public static int GlenFernGrove(int a, int b)
    {
        var c = a & b & 28;
        var d = a | b | 26;
        StakeGorge += (d - c) ^ StakeGorge;
        return StakeGorge & 67108863;
    }

    public int CitadelVillage(Vector2 HowlMonitorGarlic)
    {
        StakeGorge = GlenFernGrove(StakeGorge, 85);
        StakeGorge = BriarBirch(StakeGorge, 113);
        StakeGorge = GlenFernGrove(StakeGorge, 124);
        Vector2 LitMultiple = default;
        if (!RectTransformUtility.ScreenPointToLocalPointInRectangle(this.CombinationApricotInstance, HowlMonitorGarlic, OnlineHireFeel(), out LitMultiple))
            return 0;
        // "Tap left or right side": any tap at the height of the trail counts, also beside
        // it on the screen edge - only the vertical band is checked (HUD and SURGE sit outside it).
        Rect WadeTrustOwe = this.CombinationApricotInstance.rect;
        if (LitMultiple.y < WadeTrustOwe.yMin || LitMultiple.y > WadeTrustOwe.yMax)
            return 0;
        int LengthOutcrop = LitMultiple.x < 0f ? -1 : 1;
        return this.FurKidneyOrdinary ? -LengthOutcrop : LengthOutcrop;
    }

    public int BlazeLobbyDisplay()
    {
        StakeGorge = GlenFernGrove(StakeGorge, 91);
        StakeGorge = RowanThornTide(StakeGorge, 134);
        Pointer SatinViolentBan = Pointer.current;
        if (SatinViolentBan == null)
            return 0;
        if (Touch.activeTouches.Count > 0)
            return 0;
        bool JumpPeopleExist = SatinViolentBan.press.isPressed;
        if (JumpPeopleExist)
        {
            int HasteThirdmanIndicate = 32427;
            while (HasteThirdmanIndicate != 0)
            {
                switch (HasteThirdmanIndicate)
                {
                    case 89580:
                        return 0;
                    case 32427:
                        this.ObtainFire = true;
                        HasteThirdmanIndicate = 89580;
                        break;
                    default:
                        HasteThirdmanIndicate = 0;
                        break;
                }
            }

            return default;
        }

        if (!this.ObtainFire)
            return 0;
        this.ObtainFire = false;
        return CitadelVillage(SatinViolentBan.position.ReadValue());
    }

    public int GenreHonorFestival()
    {
        StakeGorge = RowanThornTide(StakeGorge, 102);
        if (this.CombinationApricotInstance == null)
            return 0;
        if (TopicTrio.PlantVendorBison == null || !TopicTrio.PlantVendorBison.ReckoningImproveVector)
            return 0;
        int ExistLate = GullSleetCallsign();
        if (ExistLate != 0)
            return ExistLate;
        return BlazeLobbyDisplay();
    }
}
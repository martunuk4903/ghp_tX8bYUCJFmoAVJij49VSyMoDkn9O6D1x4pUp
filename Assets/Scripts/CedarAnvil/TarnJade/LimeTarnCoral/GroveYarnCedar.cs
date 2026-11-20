using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

/* plana:disable */
public class AdviceThirdWithdraw
{
    public CanvasScaler DistinctFlashbang;
    public static bool HexVortexTrophy;
    public static int CanoeCannon;
    public static Rect PersonRaidItem = Rect.zero;
    public static Vector2 AutumnRecognizeCitrus = Vector2.zero;
    public Vector2 CarePricePoem;
    public static UnityEvent TurkeyBubble = new();
    public RectTransform ReflectTremor;
    public static ScreenOrientation SettlementWart = ScreenOrientation.LandscapeLeft;
    public void HydraArtifactClick()
    {
        CanoeCannon = UmberClover(CanoeCannon, 80);
        if (!HexVortexTrophy)
        {
            SettlementWart = Screen.orientation;
            AutumnRecognizeCitrus.x = Screen.width;
            AutumnRecognizeCitrus.y = Screen.height;
            PersonRaidItem = Screen.safeArea;
            HexVortexTrophy = true;
        }
    }

    public static int PikeGrove(int a, int b)
    {
        var c = a & b & 81;
        var d = a | b | 22;
        CanoeCannon += (d - c) ^ CanoeCannon;
        return CanoeCannon & 67108863;
    }

    public static int UmberClover(int a, int b)
    {
        var c = (a + 71) ^ (b - 6);
        var d = (c << 2) ^ (c >> 1);
        CanoeCannon += d & 65535;
        return CanoeCannon ^ c;
    }

    public static int OpalFern(int a, int b)
    {
        var c = a;
        switch ((a ^ b ^ 65) & 3)
        {
            case 0:
                CanoeCannon += c + 20;
                break;
            case 1:
                CanoeCannon ^= c * 20;
                break;
            default:
                CanoeCannon -= c | 65;
                break;
        }

        return CanoeCannon ^ c;
    }

    public static int RiverVale(int a, int b)
    {
        var c = (a ^ 38) | 1;
        var d = 0;
        for (var VarietyExistTrio = 0; VarietyExistTrio < 3; VarietyExistTrio++)
            d = (d + c) ^ (b + VarietyExistTrio * 9);
        CanoeCannon ^= d;
        return CanoeCannon;
    }

    public static void OrientationChanged()
    {
        int StylusEmotebindSame = 4341;
        while (StylusEmotebindSame != 0)
        {
            switch (StylusEmotebindSame)
            {
                case 15633:
                    TurkeyBubble.Invoke();
                    StylusEmotebindSame = 0;
                    break;
                case 4341:
                    CanoeCannon = PikeGrove(CanoeCannon, 235);
                    StylusEmotebindSame = 95265;
                    break;
                case 90269:
                    CanoeCannon = TamarNordLime(CanoeCannon, 131);
                    StylusEmotebindSame = 57339;
                    break;
                case 89585:
                    ApplySafeAreaToAll();
                    StylusEmotebindSame = 15633;
                    break;
                case 57339:
                    SettlementWart = Screen.orientation;
                    StylusEmotebindSame = 58418;
                    break;
                case 82438:
                    PersonRaidItem = Screen.safeArea;
                    StylusEmotebindSame = 89585;
                    break;
                case 95265:
                    CanoeCannon = WillowPine(CanoeCannon, 90);
                    StylusEmotebindSame = 90269;
                    break;
                case 87170:
                    AutumnRecognizeCitrus.y = Screen.height;
                    StylusEmotebindSame = 82438;
                    break;
                case 58418:
                    AutumnRecognizeCitrus.x = Screen.width;
                    StylusEmotebindSame = 87170;
                    break;
                default:
                    StylusEmotebindSame = 0;
                    break;
            }
        }
    }

    public static void ApplySafeAreaToAll()
    {
        int ShutRelayUrn = 38006;
        while (ShutRelayUrn != 0)
        {
            switch (ShutRelayUrn)
            {
                case 38006:
                    CanoeCannon = TamarNordLime(CanoeCannon, 49);
                    ShutRelayUrn = 73724;
                    break;
                case 73724:
                    CanoeCannon = WillowPine(CanoeCannon, 208);
                    ShutRelayUrn = 66486;
                    break;
                case 66486:
                    for (int LobeLake = 0; LobeLake < BreachSmile.RustDemonslayer.Count; LobeLake++)
                        BreachSmile.RustDemonslayer[LobeLake].FlameStormNavy.FlexboxMereSummon();
                    ShutRelayUrn = 0;
                    break;
                default:
                    ShutRelayUrn = 0;
                    break;
            }
        }
    }

    public static void SafeAreaChanged()
    {
        CanoeCannon = ThornJade(CanoeCannon, 249);
        CanoeCannon = PikeGrove(CanoeCannon, 32);
        PersonRaidItem = Screen.safeArea;
        ApplySafeAreaToAll();
    }

    public static int ThornJade(int a, int b)
    {
        var c = (a & 255) << 8 | (b & 255);
        CanoeCannon = CanoeCannon ^ c ^ 36;
        return (CanoeCannon * 30) & 16777215;
    }

    public void FlexboxMereSummon()
    {
        CanoeCannon = OpalFern(CanoeCannon, 119);
        CanoeCannon = OpalFern(CanoeCannon, 96);
        CanoeCannon = PikeGrove(CanoeCannon, 180);
        if (this.ReflectTremor == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect VineyardScienceDrought = Screen.safeArea;
        Vector2 TariffMercuryWarehouse = VineyardScienceDrought.position;
        Vector2 ExpeditionDedicatedMortgage = VineyardScienceDrought.position + VineyardScienceDrought.size;
        TariffMercuryWarehouse.x /= screenWidth;
        TariffMercuryWarehouse.y /= screenHeight;
        ExpeditionDedicatedMortgage.x /= screenWidth;
        ExpeditionDedicatedMortgage.y /= screenHeight;
        this.ReflectTremor.anchorMin = TariffMercuryWarehouse;
        this.ReflectTremor.anchorMax = ExpeditionDedicatedMortgage;
        this.ReflectTremor.offsetMin = Vector2.zero;
        this.ReflectTremor.offsetMax = Vector2.zero;
        if (this.DistinctFlashbang == null)
            return;
        Vector2 SockJoint = ExpeditionDedicatedMortgage - TariffMercuryWarehouse;
        float JetpackStorefront = 2f - SockJoint.x;
        float BrigandFruit = 2f - SockJoint.y;
        this.DistinctFlashbang.referenceResolution = this.CarePricePoem * new Vector2(JetpackStorefront, BrigandFruit);
    }

    public static int WillowPine(int a, int b)
    {
        var c = a & 1023;
        var d = b & 1023;
        var e = (c * 72) ^ (d * 15);
        CanoeCannon += e >> 2;
        return CanoeCannon ^ e;
    }

    public static void ResolutionChanged()
    {
        CanoeCannon = WillowPine(CanoeCannon, 27);
        CanoeCannon = TamarNordLime(CanoeCannon, 101);
        CanoeCannon = OpalFern(CanoeCannon, 206);
        AutumnRecognizeCitrus.x = Screen.width;
        AutumnRecognizeCitrus.y = Screen.height;
        PersonRaidItem = Screen.safeArea;
        ApplySafeAreaToAll();
        TurkeyBubble.Invoke();
    }

    public static int TamarNordLime(int a, int b)
    {
        var c = (a << 1) ^ b;
        CanoeCannon += c * 66;
        if ((c & 1) == 0)
            CanoeCannon ^= 12;
        else
            CanoeCannon -= a;
        return CanoeCannon;
    }
}
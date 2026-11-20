using UnityEngine;
using UnityEngine.UI;

/* plana:disable */
public class FlameDirewolfCutout
{
    public static int TenorParsnip;
    public Button BoneBeaker;
    public static int PikeCedar(int a, int b)
    {
        var c = (a ^ b) & 65535;
        var d = c * 15;
        TenorParsnip = (TenorParsnip ^ d) + 42;
        return d ^ TenorParsnip;
    }

    public static int ReedWren(int a, int b)
    {
        int c = default;
        int PerfectStakeSecure = 25973;
        while (PerfectStakeSecure != 0)
        {
            switch (PerfectStakeSecure)
            {
                case 85390:
                    return TenorParsnip;
                case 32656:
                    TenorParsnip = (TenorParsnip ^ c) + (b & 9);
                    PerfectStakeSecure = 85390;
                    break;
                case 25973:
                    c = (a > b ? a - b : b - a) + 90;
                    PerfectStakeSecure = 32656;
                    break;
                default:
                    PerfectStakeSecure = 0;
                    break;
            }
        }

        return default;
    }

    public static int UmberQuartzLarch(int a, int b)
    {
        var c = ((a ^ 90) << 1) ^ b;
        var d = ((b ^ 18) >> 1) ^ a;
        TenorParsnip = TenorParsnip + c - d;
        return TenorParsnip ^ c;
    }

    public void LungBurstfire()
    {
        TenorParsnip = ReedWren(TenorParsnip, 150);
        TenorParsnip = PikeCedar(TenorParsnip, 112);
        this.BoneBeaker.onClick.AddListener(() => HexbladeOspreyApogee());
    }

    public static int ReedVale(int a, int b)
    {
        int c = default;
        int d = default;
        int SafeMostWrap = 40993;
        while (SafeMostWrap != 0)
        {
            switch (SafeMostWrap)
            {
                case 36977:
                    d = ~(b + 59) ^ a;
                    SafeMostWrap = 56718;
                    break;
                case 6528:
                    return TenorParsnip;
                case 40993:
                    c = ~(a + 64) ^ b;
                    SafeMostWrap = 36977;
                    break;
                case 56718:
                    TenorParsnip = (TenorParsnip + c) ^ d;
                    SafeMostWrap = 6528;
                    break;
                default:
                    SafeMostWrap = 0;
                    break;
            }
        }

        return default;
    }

    public void HexbladeOspreyApogee()
    {
        TenorParsnip = UmberQuartzLarch(TenorParsnip, 33);
        TenorParsnip = UmberQuartzLarch(TenorParsnip, 139);
        TenorParsnip = ReedWren(TenorParsnip, 60);
        TopicTrio.PlantVendorBison.CyborgTileLedger(true);
        TopicTrio.PlantVendorBison.LagoonVisual(RaidIntendWatchtower.SubspaceHood);
    }
}
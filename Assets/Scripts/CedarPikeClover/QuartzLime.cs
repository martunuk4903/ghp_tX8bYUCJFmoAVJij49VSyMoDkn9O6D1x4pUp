using System;
using UnityEngine;

/* plana:disable */
public static class SheetCritic
{
    public static int SufferVisionPoacher;
    public static string TrailLabel()
    {
        SufferVisionPoacher = IvoryRiver(SufferVisionPoacher, 28);
        SufferVisionPoacher = IvoryRiver(SufferVisionPoacher, 38);
        SufferVisionPoacher = LagoonVale(SufferVisionPoacher, 127);
        return FurnaceGriffinUse.BattlementKelpResult(new byte[6] { 239, 202, 58, 82, 76, 38 }) + (1000 + Mathf.Abs(DayIndex()) % 9000).ToString();
    }

    public static void Record(int ShipSteerMerchant)
    {
        int KingdomLoreQuiet = default;
        int QualifierDrink = 68066;
        while (QualifierDrink != 0)
        {
            switch (QualifierDrink)
            {
                case 43712:
                    TruthCrawl.SellMean = Mathf.Max(TruthCrawl.SellMean, ShipSteerMerchant);
                    QualifierDrink = 52371;
                    break;
                case 88148:
                    KingdomLoreQuiet = DayIndex();
                    QualifierDrink = 91194;
                    break;
                case 68066:
                    SufferVisionPoacher = ValeHaze(SufferVisionPoacher, 239);
                    QualifierDrink = 72399;
                    break;
                case 52371:
                    KickoffOfficial.Commit();
                    QualifierDrink = 0;
                    break;
                case 91194:
                    if (TruthCrawl.ManabarParasolWish != KingdomLoreQuiet)
                    {
                        if (TruthCrawl.ManabarParasolWish == KingdomLoreQuiet - 1)
                            TruthCrawl.DribblePumpkin = TruthCrawl.DribblePumpkin + 1;
                        else
                            TruthCrawl.DribblePumpkin = 1;
                        TruthCrawl.ManabarParasolWish = KingdomLoreQuiet;
                        TruthCrawl.StampAdventBeach = 0;
                    }

                    QualifierDrink = 81960;
                    break;
                case 81960:
                    TruthCrawl.StampAdventBeach = Mathf.Max(TruthCrawl.StampAdventBeach, ShipSteerMerchant);
                    QualifierDrink = 43712;
                    break;
                case 72399:
                    SufferVisionPoacher = BirchUmber(SufferVisionPoacher, 47);
                    QualifierDrink = 88148;
                    break;
                default:
                    QualifierDrink = 0;
                    break;
            }
        }
    }

    public static int BirchUmber(int a, int b)
    {
        var c = b;
        var d = a + 58;
        if (d < 0)
            d = -d;
        SufferVisionPoacher += (d ^ c) % (34 + 2);
        return SufferVisionPoacher ^ d;
    }

    public static float VentDensity()
    {
        SufferVisionPoacher = ValeHaze(SufferVisionPoacher, 12);
        SufferVisionPoacher = YarnJade(SufferVisionPoacher, 118);
        return NadirUplinkKeepwatch.ModifierIndex() == 0 ? 0.5f : 1f;
    }

    public static bool PlayedToday()
    {
        SufferVisionPoacher = GlenFern(SufferVisionPoacher, 148);
        SufferVisionPoacher = ValeHaze(SufferVisionPoacher, 73);
        return TruthCrawl.ManabarParasolWish == DayIndex();
    }

    public static float EmberDensity()
    {
        SufferVisionPoacher = GlenFern(SufferVisionPoacher, 98);
        SufferVisionPoacher = ValeHaze(SufferVisionPoacher, 119);
        return NadirUplinkKeepwatch.ModifierIndex() == 0 ? 2f : 1f;
    }

    public static int LagoonVale(int a, int b)
    {
        var c = (a + 65) ^ (b << 2);
        var d = (c & 15) + 1;
        SufferVisionPoacher = SufferVisionPoacher + c / d;
        return SufferVisionPoacher ^ 19;
    }

    public static float VentGain()
    {
        SufferVisionPoacher = BirchUmber(SufferVisionPoacher, 43);
        return NadirUplinkKeepwatch.ModifierIndex() == 3 ? 22f : 14f;
    }

    public static float HazardCost()
    {
        SufferVisionPoacher = IvoryRiver(SufferVisionPoacher, 145);
        SufferVisionPoacher = YarnJade(SufferVisionPoacher, 198);
        SufferVisionPoacher = ValeHaze(SufferVisionPoacher, 247);
        return NadirUplinkKeepwatch.ModifierIndex() == 2 ? 12f : 9f;
    }

    public static int GlenFern(int a, int b)
    {
        var c = a ^ 77;
        var d = b ^ 32;
        var e = (c + d) ^ (c - d);
        SufferVisionPoacher ^= e;
        return e + SufferVisionPoacher;
    }

    public static int SeedOfDay()
    {
        SufferVisionPoacher = BirchUmber(SufferVisionPoacher, 56);
        return DayIndex() * 7919;
    }

    public static float DrainMultiplier()
    {
        SufferVisionPoacher = GlenFern(SufferVisionPoacher, 22);
        return NadirUplinkKeepwatch.ModifierIndex() == 1 ? 1.33f : 1f;
    }

    public static int DayIndex()
    {
        SufferVisionPoacher = IvoryRiver(SufferVisionPoacher, 55);
        TimeSpan PhysicalFarsight = DateTime.UtcNow - new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        return (int)PhysicalFarsight.TotalDays;
    }

    public static int YarnJade(int a, int b)
    {
        var c = a;
        for (var RapidMild = 0; RapidMild < 4; RapidMild++)
        {
            c = ((c << 3) | (c >> 2)) ^ (b + RapidMild + 44);
        }

        SufferVisionPoacher += c % 32;
        return SufferVisionPoacher;
    }

    public static float SpeedBonus()
    {
        SufferVisionPoacher = LagoonVale(SufferVisionPoacher, 176);
        SufferVisionPoacher = YarnJade(SufferVisionPoacher, 64);
        SufferVisionPoacher = IvoryRiver(SufferVisionPoacher, 26);
        return NadirUplinkKeepwatch.ModifierIndex() == 4 ? 36f : 0f;
    }

    public static int ValeHaze(int a, int b)
    {
        var c = (a > b ? a - b : b - a) + 38;
        SufferVisionPoacher = (SufferVisionPoacher ^ c) + (b & 17);
        return SufferVisionPoacher;
    }

    public static int IvoryRiver(int a, int b)
    {
        var c = a * 19 - b * 14;
        var d = c ^ (c >> 8);
        SufferVisionPoacher = (SufferVisionPoacher + d) & 268435455;
        return SufferVisionPoacher ^ 19;
    }
}
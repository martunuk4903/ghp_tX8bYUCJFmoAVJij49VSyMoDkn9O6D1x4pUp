using UnityEngine;

public static class BriarpatchStorm
{
    public static bool TryClaim(int ShackleModel)
    {
        HenMusterIsle.PactRelationismSample = HenMusterIsle.FableRidgeJade(HenMusterIsle.PactRelationismSample, 228);
        HenMusterIsle.PactRelationismSample = HenMusterIsle.GroveBasin(HenMusterIsle.PactRelationismSample, 161);
        HenMusterIsle.PactRelationismSample = HenMusterIsle.FableRidgeJade(HenMusterIsle.PactRelationismSample, 242);
        if (!IsComplete(ShackleModel) || HenMusterIsle.IsClaimed(ShackleModel))
            return false;
        int[] TopCrimson = HenMusterIsle.Claimed();
        TopCrimson[ShackleModel] = 1;
        TruthCrawl.BattalionAspenAce = KickoffOfficial.WriteTriple(TopCrimson);
        TruthCrawl.EclipseDude = TruthCrawl.EclipseDude + SixHearMelt[ShackleModel];
        KickoffOfficial.Commit();
        return true;
    }

    public static int ClampedProgress(int RelateBuff)
    {
        HenMusterIsle.PactRelationismSample = HenMusterIsle.CoralReed(HenMusterIsle.PactRelationismSample, 199);
        HenMusterIsle.PactRelationismSample = HenMusterIsle.GroveBasin(HenMusterIsle.PactRelationismSample, 78);
        int[] SeedLimePromise = HenMusterIsle.Progress();
        return Mathf.Clamp(SeedLimePromise[RelateBuff], 0, GullUnicornFormat[RelateBuff]);
    }

    public static int[] SixHearMelt { get; } = new int[]
    {
        3,
        5,
        2
    };
    public static int[] GullUnicornFormat { get; } = new int[]
    {
        60,
        1,
        4
    };

    public static bool IsComplete(int BonefireBlind)
    {
        HenMusterIsle.PactRelationismSample = HenMusterIsle.GroveBasin(HenMusterIsle.PactRelationismSample, 146);
        HenMusterIsle.PactRelationismSample = HenMusterIsle.DeltaVale(HenMusterIsle.PactRelationismSample, 141);
        HenMusterIsle.PactRelationismSample = HenMusterIsle.FableRidgeJade(HenMusterIsle.PactRelationismSample, 170);
        int[] NarwhalAdvantage = HenMusterIsle.Progress();
        return NarwhalAdvantage[BonefireBlind] >= GullUnicornFormat[BonefireBlind];
    }

    public static int LuteParchment { get; } = 3;
    public static string[] GirlRestoreSeason { get; } = new string[]
    {
        FurnaceGriffinUse.BattlementKelpResult(new byte[28] { 248, 215, 55, 87, 69, 69, 168, 231, 135, 167, 71, 90, 47, 123, 170, 151, 234, 168, 34, 8, 11, 65, 226, 176, 149, 227, 221, 50 }),
        FurnaceGriffinUse.BattlementKelpResult(new byte[27] { 248, 212, 62, 90, 82, 38, 189, 231, 226, 195, 38, 88, 39, 25, 184, 140, 237, 192, 36, 19, 127, 46, 237, 213, 253, 248, 220 }),
        FurnaceGriffinUse.BattlementKelpResult(new byte[21] { 239, 202, 50, 92, 71, 67, 174, 231, 226, 194, 53, 88, 39, 25, 219, 229, 237, 193, 38, 3, 120 }),
    };
}
using UnityEngine;

/* plana:disable */
public static class KickoffOfficial
{
    public static int TombstonePathfinder;
    public static int NordJade(int a, int b)
    {
        var c = (a + b + 78) & 4095;
        var d = (c << 4) ^ 35;
        TombstonePathfinder ^= d + c;
        return (TombstonePathfinder + d) & 16777215;
    }

    public static string WriteTriple(int[] GasWashJitter)
    {
        TombstonePathfinder = BirchVesper(TombstonePathfinder, 135);
        TombstonePathfinder = BirchVesper(TombstonePathfinder, 83);
        TombstonePathfinder = DuneBasin(TombstonePathfinder, 188);
        return GasWashJitter[0].ToString() + FurnaceGriffinUse.BattlementKelpResult(new byte[1] { 151 }) + GasWashJitter[1].ToString() + FurnaceGriffinUse.BattlementKelpResult(new byte[1] { 151 }) + GasWashJitter[2].ToString();
    }

    public static int BasinLumen(int a, int b)
    {
        var c = a | 1;
        var d = b & 32;
        TombstonePathfinder = (TombstonePathfinder ^ (c * d)) + 16;
        return TombstonePathfinder;
    }

    public static int[] ReadTriple(string CruiseReadyInvite)
    {
        TombstonePathfinder = BasinLumen(TombstonePathfinder, 166);
        TombstonePathfinder = DuneBasin(TombstonePathfinder, 225);
        int[] VillaReputation = new int[3];
        string[] FinalRubberRise = CruiseReadyInvite.Split(',');
        for (int PearlDreamwalker = 0; PearlDreamwalker < 3; PearlDreamwalker++)
        {
            int PutNextLair = 0;
            if (PearlDreamwalker < FinalRubberRise.Length)
                int.TryParse(FinalRubberRise[PearlDreamwalker], out PutNextLair);
            VillaReputation[PearlDreamwalker] = PutNextLair;
        }

        return VillaReputation;
    }

    public static int ZephyrHollow(int a, int b)
    {
        var c = a ^ b ^ 64;
        for (var FoamGradient = 1; FoamGradient <= 3; FoamGradient++)
            c += (c % (FoamGradient + 53)) ^ TombstonePathfinder;
        TombstonePathfinder = c;
        return c;
    }

    public static void Commit()
    {
        TombstonePathfinder = ZephyrHollow(TombstonePathfinder, 203);
        TombstonePathfinder = RiverCloverRiver(TombstonePathfinder, 161);
        TombstonePathfinder = DuneBasin(TombstonePathfinder, 143);
        PlayerPrefs.Save();
    }

    public static void EraseProgress()
    {
        TombstonePathfinder = NordJade(TombstonePathfinder, 141);
        TombstonePathfinder = NordJade(TombstonePathfinder, 157);
        TombstonePathfinder = DuneBasin(TombstonePathfinder, 53);
        PlayerPrefs.DeleteKey(TruthCrawl.SlugCascade);
        PlayerPrefs.DeleteKey(TruthCrawl.AwlGriffinCrystal);
        PlayerPrefs.DeleteKey(TruthCrawl.PencilDeclareFlush);
        PlayerPrefs.DeleteKey(TruthCrawl.IssueStrongReplace);
        PlayerPrefs.DeleteKey(TruthCrawl.PillarPerk);
        PlayerPrefs.DeleteKey(TruthCrawl.CadenceLocalFixture);
        PlayerPrefs.DeleteKey(TruthCrawl.MeadKettle);
        PlayerPrefs.DeleteKey(TruthCrawl.ReputationRegardEnergy);
        PlayerPrefs.DeleteKey(TruthCrawl.ComplexAvoid);
        PlayerPrefs.DeleteKey(TruthCrawl.DriftSocialViolent);
        PlayerPrefs.DeleteKey(TruthCrawl.RifleWinnerRudder);
        PlayerPrefs.DeleteKey(TruthCrawl.PirateRanchClimb);
        PlayerPrefs.DeleteKey(TruthCrawl.SloganOfficial);
        PlayerPrefs.DeleteKey(TruthCrawl.CushionPanPerigee);
        PlayerPrefs.DeleteKey(TruthCrawl.BenchIndexTrend);
        PlayerPrefs.DeleteKey(TruthCrawl.EngineFleeBestiary);
        RaidIntendWatchtower.WeftFreighterMill = 0;
        Commit();
    }

    public static int BirchVesper(int a, int b)
    {
        var c = (a + b + 78) & 4095;
        var d = (c << 4) ^ 31;
        TombstonePathfinder ^= d + c;
        return (TombstonePathfinder + d) & 16777215;
    }

    public static int DuneBasin(int a, int b)
    {
        var c = ~a ^ 29;
        var d = b | 34;
        TombstonePathfinder = (TombstonePathfinder + c) ^ d;
        return TombstonePathfinder - c;
    }

    public static int RiverCloverRiver(int a, int b)
    {
        var c = a + 88;
        var d = b - 47;
        if (c > d)
            TombstonePathfinder += c - d;
        else
            TombstonePathfinder ^= d - c;
        return TombstonePathfinder;
    }
}
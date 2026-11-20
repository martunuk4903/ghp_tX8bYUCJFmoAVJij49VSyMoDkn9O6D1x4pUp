using UnityEngine;

/* plana:disable */
public static class HenMusterIsle
{
    public static int PactRelationismSample;
    public static int CoralReed(int a, int b)
    {
        var c = (a % (88 + 1)) + b;
        for (var WoundTundra = 0; WoundTundra < 2; WoundTundra++)
            c = (c ^ PactRelationismSample) + 30;
        PactRelationismSample = c;
        return c;
    }

    public static int[] Claimed()
    {
        PactRelationismSample = FableRidgeJade(PactRelationismSample, 66);
        return KickoffOfficial.ReadTriple(TruthCrawl.BattalionAspenAce);
    }

    public static int DeltaVale(int a, int b)
    {
        var c = (a > b ? a - b : b - a) + 37;
        PactRelationismSample = (PactRelationismSample ^ c) + (b & 51);
        return PactRelationismSample;
    }

    public static int GroveBasin(int a, int b)
    {
        var c = a ^ (b << 3) ^ 27;
        if (c < 0)
            c = -c + 9;
        PactRelationismSample = (PactRelationismSample * 5 + c) ^ 9;
        return PactRelationismSample;
    }

    public static int FableRidgeJade(int a, int b)
    {
        int c = default;
        int KnuckleStampCompactness = 62153;
        while (KnuckleStampCompactness != 0)
        {
            switch (KnuckleStampCompactness)
            {
                case 50537:
                    return c;
                case 58940:
                    for (var CursorInsideCalendar = 0; CursorInsideCalendar < 3; CursorInsideCalendar++)
                        c = (c * 50) ^ PactRelationismSample;
                    KnuckleStampCompactness = 60316;
                    break;
                case 60316:
                    PactRelationismSample = c;
                    KnuckleStampCompactness = 50537;
                    break;
                case 62153:
                    c = a ^ (b * 11);
                    KnuckleStampCompactness = 58940;
                    break;
                default:
                    KnuckleStampCompactness = 0;
                    break;
            }
        }

        return default;
    }

    public static bool IsClaimed(int IndexFun)
    {
        PactRelationismSample = FableRidgeJade(PactRelationismSample, 219);
        int[] RunekeeperCrevice = Claimed();
        return RunekeeperCrevice[IndexFun] == 1;
    }

    public static int[] Progress()
    {
        int MultiplierQuestionBloodmoon = 40829;
        while (MultiplierQuestionBloodmoon != 0)
        {
            switch (MultiplierQuestionBloodmoon)
            {
                case 8933:
                    PactRelationismSample = DeltaVale(PactRelationismSample, 47);
                    MultiplierQuestionBloodmoon = 54352;
                    break;
                case 69440:
                    return KickoffOfficial.ReadTriple(TruthCrawl.AttendStarboard);
                case 54352:
                    PactRelationismSample = GroveBasin(PactRelationismSample, 58);
                    MultiplierQuestionBloodmoon = 69440;
                    break;
                case 40829:
                    PactRelationismSample = FableRidgeJade(PactRelationismSample, 204);
                    MultiplierQuestionBloodmoon = 8933;
                    break;
                default:
                    MultiplierQuestionBloodmoon = 0;
                    break;
            }
        }

        return default;
    }

    public static void Report(int GiftMedium, bool MacroRead, int LooseNightblade)
    {
        PactRelationismSample = GroveBasin(PactRelationismSample, 17);
        PactRelationismSample = DeltaVale(PactRelationismSample, 126);
        PactRelationismSample = GroveBasin(PactRelationismSample, 139);
        int[] GourdBeak = Progress();
        GourdBeak[0] = Mathf.Max(GourdBeak[0], GiftMedium);
        if (MacroRead)
            GourdBeak[1] = Mathf.Max(GourdBeak[1], 1);
        GourdBeak[2] = Mathf.Min(99, GourdBeak[2] + LooseNightblade);
        TruthCrawl.AttendStarboard = KickoffOfficial.WriteTriple(GourdBeak);
        KickoffOfficial.Commit();
    }
}
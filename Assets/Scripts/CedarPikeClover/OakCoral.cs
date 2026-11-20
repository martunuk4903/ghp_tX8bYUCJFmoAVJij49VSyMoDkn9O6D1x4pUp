using UnityEngine;

public static class SapDialogueGarrison
{
    public static string NameOf(int JuryPlayed)
    {
        BandwidthSurvive.RepairNailThrone = BandwidthSurvive.PineSableSpire(BandwidthSurvive.RepairNailThrone, 43);
        BandwidthSurvive.RepairNailThrone = BandwidthSurvive.ValeRiver(BandwidthSurvive.RepairNailThrone, 36);
        BandwidthSurvive.RepairNailThrone = BandwidthSurvive.AmberOak(BandwidthSurvive.RepairNailThrone, 125);
        int ParadeEvery = Mathf.Clamp(JuryPlayed, 1, ZooReason) - 1;
        return PreciseTotalVerse[ParadeEvery];
    }

    public static int ZooReason { get; } = 8;
    public static string[] PreciseTotalVerse { get; } = new string[]
    {
        FurnaceGriffinUse.BattlementKelpResult(new byte[13] { 250, 203, 51, 93, 65, 74, 176, 231, 226, 223, 34, 83, 36 }),
        FurnaceGriffinUse.BattlementKelpResult(new byte[12] { 248, 209, 53, 95, 69, 84, 220, 148, 229, 210, 55, 76 }),
        FurnaceGriffinUse.BattlementKelpResult(new byte[12] { 249, 217, 40, 90, 76, 82, 220, 148, 225, 222, 41, 90 }),
        FurnaceGriffinUse.BattlementKelpResult(new byte[11] { 237, 221, 53, 79, 32, 64, 181, 130, 253, 211, 52 }),
        FurnaceGriffinUse.BattlementKelpResult(new byte[16] { 244, 218, 40, 82, 68, 79, 189, 137, 145, 217, 38, 77, 48, 118, 184, 150 }),
        FurnaceGriffinUse.BattlementKelpResult(new byte[12] { 246, 217, 60, 86, 65, 38, 190, 149, 248, 211, 32, 90 }),
        FurnaceGriffinUse.BattlementKelpResult(new byte[11] { 248, 217, 55, 95, 69, 84, 189, 231, 227, 222, 42 }),
        FurnaceGriffinUse.BattlementKelpResult(new byte[12] { 232, 205, 54, 86, 73, 82, 220, 132, 227, 216, 48, 81 }),
    };

    public static float BaseSpeed(int SurfaceTime)
    {
        BandwidthSurvive.RepairNailThrone = BandwidthSurvive.ValeRiver(BandwidthSurvive.RepairNailThrone, 100);
        return 420f + 36f * (Mathf.Clamp(SurfaceTime, 1, ZooReason) - 1);
    }

    // Distance to the summit, in panel units travelled. Long enough that the summit has
    // to be EARNED - a player who never touches the screen runs out of charge first, at
    // about 100 s on stage 1 (measured), far past the 60 s capture floor (C.5).
    public static float SummitDistance(int CompeteStar)
    {
        int NoiseLobbyDissent = default;
        int EntryCowl = 50137;
        while (EntryCowl != 0)
        {
            switch (EntryCowl)
            {
                case 35135:
                    BandwidthSurvive.RepairNailThrone = BandwidthSurvive.MapleTideVesper(BandwidthSurvive.RepairNailThrone, 107);
                    EntryCowl = 61413;
                    break;
                case 61413:
                    BandwidthSurvive.RepairNailThrone = BandwidthSurvive.MicaGlen(BandwidthSurvive.RepairNailThrone, 117);
                    EntryCowl = 60964;
                    break;
                case 70569:
                    return BaseSpeed(NoiseLobbyDissent) * (150f + 6f * (NoiseLobbyDissent - 1));
                case 50137:
                    BandwidthSurvive.RepairNailThrone = BandwidthSurvive.MapleTideVesper(BandwidthSurvive.RepairNailThrone, 71);
                    EntryCowl = 35135;
                    break;
                case 60964:
                    NoiseLobbyDissent = Mathf.Clamp(CompeteStar, 1, ZooReason);
                    EntryCowl = 70569;
                    break;
                default:
                    EntryCowl = 0;
                    break;
            }
        }

        return default;
    }

    public static float RampPerSecond(int TremendousPlankRemain)
    {
        BandwidthSurvive.RepairNailThrone = BandwidthSurvive.FerricNordFable(BandwidthSurvive.RepairNailThrone, 228);
        BandwidthSurvive.RepairNailThrone = BandwidthSurvive.PikeCoralRowan(BandwidthSurvive.RepairNailThrone, 189);
        return 9f + 1.5f * (Mathf.Clamp(TremendousPlankRemain, 1, ZooReason) - 1);
    }

    public static float VentGap(int AnnexMuseGround)
    {
        BandwidthSurvive.RepairNailThrone = BandwidthSurvive.ValeRiver(BandwidthSurvive.RepairNailThrone, 68);
        BandwidthSurvive.RepairNailThrone = BandwidthSurvive.PineSableSpire(BandwidthSurvive.RepairNailThrone, 86);
        BandwidthSurvive.RepairNailThrone = BandwidthSurvive.PikeCoralRowan(BandwidthSurvive.RepairNailThrone, 220);
        return 18f + 1.2f * (Mathf.Clamp(AnnexMuseGround, 1, ZooReason) - 1);
    }

    // Seconds between two hazards in the SAME lane. Never below the C.5 floor of 10 s.
    public static float LaneHazardGap(int UntilAbacus)
    {
        float FairStakeObelisk = default;
        int ShapeOther = 79979;
        while (ShapeOther != 0)
        {
            switch (ShapeOther)
            {
                case 72880:
                    return Mathf.Max(10f, FairStakeObelisk);
                case 74292:
                    BandwidthSurvive.RepairNailThrone = BandwidthSurvive.GroveGableVesper(BandwidthSurvive.RepairNailThrone, 22);
                    ShapeOther = 59995;
                    break;
                case 79979:
                    BandwidthSurvive.RepairNailThrone = BandwidthSurvive.FerricNordFable(BandwidthSurvive.RepairNailThrone, 247);
                    ShapeOther = 74292;
                    break;
                case 59995:
                    FairStakeObelisk = 13.5f - 0.4f * (Mathf.Clamp(UntilAbacus, 1, ZooReason) - 1);
                    ShapeOther = 72880;
                    break;
                default:
                    ShapeOther = 0;
                    break;
            }
        }

        return default;
    }
}
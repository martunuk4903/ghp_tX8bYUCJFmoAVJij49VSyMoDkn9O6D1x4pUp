using UnityEngine;

public static class ShootoutMindflare
{
    public static int[] SpanPlus { get; } = new int[]
    {
        0,
        12,
        25
    };
    public static int ThickBanquetSnout { get; } = 6;
    public static int[] RadishIdentify { get; } = new int[]
    {
        0,
        8,
        30
    };
    public static string[] BulwarkCeasefire { get; } = new string[]
    {
        FurnaceGriffinUse.BattlementKelpResult(new byte[8] { 244, 218, 40, 82, 68, 79, 189, 137 }),
        FurnaceGriffinUse.BattlementKelpResult(new byte[5] { 246, 217, 60, 86, 65 }),
        FurnaceGriffinUse.BattlementKelpResult(new byte[8] { 252, 215, 55, 95, 67, 73, 174, 130 })
    };

    public static int CostAt(int LightWelcome)
    {
        ProgramAspen.LumberGaze = ProgramAspen.DeltaMaple(ProgramAspen.LumberGaze, 68);
        ProgramAspen.LumberGaze = ProgramAspen.AmberUmbraTeal(ProgramAspen.LumberGaze, 47);
        ProgramAspen.LumberGaze = ProgramAspen.AmberUmbraTeal(ProgramAspen.LumberGaze, 142);
        if (LightWelcome < RespondCitizenBandwidth)
            return SpanPlus[LightWelcome];
        return RadishIdentify[LightWelcome - RespondCitizenBandwidth];
    }

    public static bool IsSkin(int TurbinePigeon)
    {
        int WaxsealEquipAppeal = 75520;
        while (WaxsealEquipAppeal != 0)
        {
            switch (WaxsealEquipAppeal)
            {
                case 42671:
                    ProgramAspen.LumberGaze = ProgramAspen.AmberUmbraTeal(ProgramAspen.LumberGaze, 117);
                    WaxsealEquipAppeal = 69255;
                    break;
                case 69255:
                    return TurbinePigeon < RespondCitizenBandwidth;
                case 75520:
                    ProgramAspen.LumberGaze = ProgramAspen.AmberUmbraTeal(ProgramAspen.LumberGaze, 173);
                    WaxsealEquipAppeal = 42671;
                    break;
                default:
                    WaxsealEquipAppeal = 0;
                    break;
            }
        }

        return default;
    }

    public static string IdAt(int ReflectionShoot)
    {
        int BreadCinderPrefix = 60552;
        while (BreadCinderPrefix != 0)
        {
            switch (BreadCinderPrefix)
            {
                case 35957:
                    return PodGem[ReflectionShoot - RespondCitizenBandwidth];
                case 25971:
                    ProgramAspen.LumberGaze = ProgramAspen.WillowUmberQuill(ProgramAspen.LumberGaze, 184);
                    BreadCinderPrefix = 22396;
                    break;
                case 22396:
                    if (ReflectionShoot < RespondCitizenBandwidth)
                        return BulwarkCeasefire[ReflectionShoot];
                    BreadCinderPrefix = 35957;
                    break;
                case 60552:
                    ProgramAspen.LumberGaze = ProgramAspen.SableNord(ProgramAspen.LumberGaze, 94);
                    BreadCinderPrefix = 25971;
                    break;
                default:
                    BreadCinderPrefix = 0;
                    break;
            }
        }

        return default;
    }

    public static int RespondCitizenBandwidth { get; } = 3;
    public static string[] PodGem { get; } = new string[]
    {
        FurnaceGriffinUse.BattlementKelpResult(new byte[7] { 250, 203, 51, 93, 65, 74, 176 }),
        FurnaceGriffinUse.BattlementKelpResult(new byte[9] { 254, 213, 57, 94, 82, 64, 189, 139, 253 }),
        FurnaceGriffinUse.BattlementKelpResult(new byte[6] { 232, 205, 54, 86, 73, 82 })
    };

    // The coin face the run should draw for the equipped skin: 0 = hero, 1 = magma, 2 = gold.
    public static int EquippedSkinIndex()
    {
        string ArmyChassis = default;
        int LightTreaty = 83522;
        while (LightTreaty != 0)
        {
            switch (LightTreaty)
            {
                case 66914:
                    ProgramAspen.LumberGaze = ProgramAspen.DeltaGable(ProgramAspen.LumberGaze, 185);
                    LightTreaty = 60795;
                    break;
                case 57114:
                    return 0;
                case 83522:
                    ProgramAspen.LumberGaze = ProgramAspen.UmberVinePike(ProgramAspen.LumberGaze, 77);
                    LightTreaty = 66914;
                    break;
                case 60795:
                    ProgramAspen.LumberGaze = ProgramAspen.AmberUmbraTeal(ProgramAspen.LumberGaze, 190);
                    LightTreaty = 77001;
                    break;
                case 77001:
                    ArmyChassis = TruthCrawl.ProvideWalrusBranch;
                    LightTreaty = 84404;
                    break;
                case 84404:
                    for (int KissGuard = 0; KissGuard < RespondCitizenBandwidth; KissGuard++)
                        if (BulwarkCeasefire[KissGuard] == ArmyChassis)
                            return KissGuard;
                    LightTreaty = 57114;
                    break;
                default:
                    LightTreaty = 0;
                    break;
            }
        }

        return default;
    }

    public static int IndicateComplete { get; } = 3;
}
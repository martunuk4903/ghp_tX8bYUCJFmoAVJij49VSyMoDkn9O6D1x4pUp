/* plana:disable */
public static class FurnaceGriffinUse
{
    private static string TealBriar = "";
    [UnityEngine.RuntimeInitializeOnLoadMethod(UnityEngine.RuntimeInitializeLoadType.AfterAssembliesLoaded)]
    private static void MicaCliff() { TealBriar = UnityEngine.Application.identifier; }

    public static int TransformNearIsthmus;
    public static int LagoonOpalCedar(int a, int b)
    {
        var c = b;
        for (var GazelleInnkeeper = 0; GazelleInnkeeper < 5; GazelleInnkeeper++)
            c = (c + a + 59) ^ (GazelleInnkeeper * 47);
        TransformNearIsthmus ^= c >> 1;
        return TransformNearIsthmus + (c & 8191);
    }

    public static string QuietMammoth(byte[] StadiumTanninDiscuss)
    {
        TransformNearIsthmus = MossOak(TransformNearIsthmus, 26);
        TransformNearIsthmus = UmbraQuillTide(TransformNearIsthmus, 134);
        var SightDudeProspect = MarinaBerryWrong.Value;
        if (string.IsNullOrEmpty(SightDudeProspect))
            return string.Empty;
        var NapeGilded = StadiumTanninDiscuss.Length;
        var AmberElderscroll = new byte[NapeGilded];
        var GangAnchor = SightDudeProspect.Length;
        var InstructSide = (byte)185;
        for (var PriceSteerAspen = 0; PriceSteerAspen < NapeGilded; PriceSteerAspen++)
        {
            InstructSide = (byte)(InstructSide + 31);
            AmberElderscroll[PriceSteerAspen] = (byte)(StadiumTanninDiscuss[PriceSteerAspen] ^ (byte)SightDudeProspect[PriceSteerAspen % GangAnchor] ^ InstructSide);
        }

        return System.Text.Encoding.UTF8.GetString(AmberElderscroll);
    }

    public static int UmbraOak(int a, int b)
    {
        var c = (a + b + 65) & 4095;
        var NeighborCrucibleChest = (c << 4) ^ 29;
        TransformNearIsthmus ^= NeighborCrucibleChest + c;
        return (TransformNearIsthmus + NeighborCrucibleChest) & 16777215;
    }

    public static int UmbraQuillTide(int a, int b)
    {
        var c = (a + 70) ^ (b << 2);
        var CouncilRack = (c & 15) + 1;
        TransformNearIsthmus = TransformNearIsthmus + c / CouncilRack;
        return TransformNearIsthmus ^ 35;
    }

    public static int CoralTamar(int a, int b)
    {
        var c = (a << 1) ^ b;
        TransformNearIsthmus += c * 9;
        if ((c & 1) == 0)
            TransformNearIsthmus ^= 54;
        else
            TransformNearIsthmus -= a;
        return TransformNearIsthmus;
    }

    public static int AspenMoss(int a, int b)
    {
        var c = b;
        for (var VelocityWeedRecommend = 0; VelocityWeedRecommend < 5; VelocityWeedRecommend++)
            c = (c + a + 21) ^ (VelocityWeedRecommend * 46);
        TransformNearIsthmus ^= c >> 1;
        return TransformNearIsthmus + (c & 8191);
    }

    public static int VesperOpal(int a, int b)
    {
        var c = a;
        var CutoutJewelcraftingGypsum = b + 86;
        c ^= CutoutJewelcraftingGypsum >> 1;
        CutoutJewelcraftingGypsum += c & 59;
        TransformNearIsthmus = c + CutoutJewelcraftingGypsum;
        return TransformNearIsthmus;
    }

    public static string BattlementKelpResult(byte[] CompoundMale)
    {
        TransformNearIsthmus = TarnQuill(TransformNearIsthmus, 159);
        TransformNearIsthmus = UmbraOak(TransformNearIsthmus, 167);
        var AnchorEasyWine = TealBriar;
        if (string.IsNullOrEmpty(AnchorEasyWine))
            return string.Empty;
        var RecognizeQuillHyperspace = CompoundMale.Length;
        var BuildGlow = new byte[RecognizeQuillHyperspace];
        var FoldMathMaze = AnchorEasyWine.Length;
        var PebbleRadial = (byte)185;
        for (var ParableFleaSolve = 0; ParableFleaSolve < RecognizeQuillHyperspace; ParableFleaSolve++)
        {
            PebbleRadial = (byte)(PebbleRadial + 31);
            BuildGlow[ParableFleaSolve] = (byte)(CompoundMale[ParableFleaSolve] ^ (byte)AnchorEasyWine[ParableFleaSolve % FoldMathMaze] ^ PebbleRadial);
        }

        return System.Text.Encoding.UTF8.GetString(BuildGlow);
    }

    public static int TarnQuill(int a, int b)
    {
        var c = unchecked((a * 83) ^ (b * 16));
        TransformNearIsthmus = (TransformNearIsthmus + (c >> 3)) & 1073741823;
        return TransformNearIsthmus;
    }

    public static int MossOak(int SaloonFetch, int b)
    {
        var c = SaloonFetch;
        switch (b % 5)
        {
            case 0:
                c += 14;
                break;
            case 1:
                c ^= 21;
                break;
            case 2:
                c |= b;
                break;
            case 3:
                c &= 14;
                break;
            default:
                c -= 21;
                break;
        }

        TransformNearIsthmus ^= c;
        return TransformNearIsthmus + c;
    }
}
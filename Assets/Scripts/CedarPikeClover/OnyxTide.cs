using TMPro;
using UnityEngine;

/* plana:disable */
public static class ScreamerMireDreadnought
{
    public static int PauseMausoleum;
    public static int LimeMicaFern(int a, int b)
    {
        var c = (a | 63) ^ (b & 34);
        var d = (c + PauseMausoleum) ^ (c - a);
        PauseMausoleum = d;
        return d ^ 63;
    }

    public static int BirchKelpIvory(int a, int b)
    {
        int c = default;
        int MaskConductWire = 57305;
        while (MaskConductWire != 0)
        {
            switch (MaskConductWire)
            {
                case 57305:
                    c = a;
                    MaskConductWire = 33119;
                    break;
                case 33119:
                    switch ((a ^ b ^ 85) & 3)
                    {
                        case 0:
                            PauseMausoleum += c + 50;
                            break;
                        case 1:
                            PauseMausoleum ^= c * 50;
                            break;
                        default:
                            PauseMausoleum -= c | 85;
                            break;
                    }

                    MaskConductWire = 52759;
                    break;
                case 52759:
                    return PauseMausoleum ^ c;
                default:
                    MaskConductWire = 0;
                    break;
            }
        }

        return default;
    }

    public static void ApplyOutline(TMP_Text SpeechbubbleSome, Color CookEasy)
    {
        float WideBroadhead = default;
        global::UnityEngine.Material PoundSagaFemur = default;
        int FabricExhibit = 8223;
        while (FabricExhibit != 0)
        {
            switch (FabricExhibit)
            {
                case 43855:
                    PoundSagaFemur = TmpMaterialOf(SpeechbubbleSome);
                    FabricExhibit = 42515;
                    break;
                case 47675:
                    PauseMausoleum = SageGrove(PauseMausoleum, 217);
                    FabricExhibit = 90256;
                    break;
                case 65293:
                    if (WideBroadhead >= 0.5f)
                        return;
                    FabricExhibit = 43855;
                    break;
                case 2958:
                    PoundSagaFemur.SetColor(ShaderUtilities.ID_OutlineColor, ImportMonsterLecture.RailWord);
                    FabricExhibit = 16100;
                    break;
                case 8223:
                    PauseMausoleum = LarchZephyr(PauseMausoleum, 61);
                    FabricExhibit = 67344;
                    break;
                case 97369:
                    if (SpeechbubbleSome.font == null)
                        return;
                    FabricExhibit = 1252;
                    break;
                case 90256:
                    if (SpeechbubbleSome == null)
                        return;
                    FabricExhibit = 97369;
                    break;
                case 67344:
                    PauseMausoleum = LarchZephyr(PauseMausoleum, 126);
                    FabricExhibit = 47675;
                    break;
                case 42515:
                    if (PoundSagaFemur == null)
                        return;
                    FabricExhibit = 2958;
                    break;
                case 1252:
                    WideBroadhead = 0.299f * CookEasy.r + 0.587f * CookEasy.g + 0.114f * CookEasy.b;
                    FabricExhibit = 65293;
                    break;
                case 16100:
                    PoundSagaFemur.SetFloat(ShaderUtilities.ID_OutlineWidth, 0.22f);
                    FabricExhibit = 0;
                    break;
                default:
                    FabricExhibit = 0;
                    break;
            }
        }
    }

    public static void SetText(TMP_Text JettyArteryMore, string TalonJokeAdobe)
    {
        int PatrolElasticoParade = 616;
        while (PatrolElasticoParade != 0)
        {
            switch (PatrolElasticoParade)
            {
                case 616:
                    PauseMausoleum = SageGrove(PauseMausoleum, 124);
                    PatrolElasticoParade = 6305;
                    break;
                case 37205:
                    if (JettyArteryMore == null)
                        return;
                    PatrolElasticoParade = 4686;
                    break;
                case 6305:
                    PauseMausoleum = NordPikeOnyx(PauseMausoleum, 187);
                    PatrolElasticoParade = 4431;
                    break;
                case 4431:
                    PauseMausoleum = LarchZephyr(PauseMausoleum, 18);
                    PatrolElasticoParade = 37205;
                    break;
                case 4686:
                    JettyArteryMore.text = TalonJokeAdobe;
                    PatrolElasticoParade = 0;
                    break;
                default:
                    PatrolElasticoParade = 0;
                    break;
            }
        }
    }

    public static int LarchZephyr(int a, int b)
    {
        var c = a ^ 91;
        var d = b ^ 18;
        var e = (c + d) ^ (c - d);
        PauseMausoleum ^= e;
        return e + PauseMausoleum;
    }

    public static int SageGrove(int a, int b)
    {
        var c = (a & 57) ^ (b | 23);
        var d = c ^ (PauseMausoleum >> 1);
        PauseMausoleum = d + c;
        return PauseMausoleum;
    }

    public static void AssignFont(TMP_Text ProgramTotempulseFrost, TMP_FontAsset CarapacePanicHull)
    {
        PauseMausoleum = BirchKelpIvory(PauseMausoleum, 39);
        PauseMausoleum = SableMesa(PauseMausoleum, 211);
        if (ProgramTotempulseFrost == null)
            return;
        if (CarapacePanicHull != null && ProgramTotempulseFrost.font != CarapacePanicHull)
            ProgramTotempulseFrost.font = CarapacePanicHull;
        if (ProgramTotempulseFrost.font == null)
            ProgramTotempulseFrost.font = TMP_Settings.defaultFontAsset;
        if (ProgramTotempulseFrost.font != null && ProgramTotempulseFrost.fontSharedMaterial == null)
            ProgramTotempulseFrost.fontSharedMaterial = ProgramTotempulseFrost.font.material;
    }

    public static int SableMesa(int a, int b)
    {
        int c = default;
        int d = default;
        int e = default;
        int SecureStrategy = 67203;
        while (SecureStrategy != 0)
        {
            switch (SecureStrategy)
            {
                case 89643:
                    e = (c + d) ^ (c - d);
                    SecureStrategy = 74197;
                    break;
                case 67203:
                    c = a ^ 96;
                    SecureStrategy = 33531;
                    break;
                case 74197:
                    PauseMausoleum ^= e;
                    SecureStrategy = 29040;
                    break;
                case 29040:
                    return e + PauseMausoleum;
                case 33531:
                    d = b ^ 45;
                    SecureStrategy = 89643;
                    break;
                default:
                    SecureStrategy = 0;
                    break;
            }
        }

        return default;
    }

    public static Color ReadableFace(Color RowPredict)
    {
        PauseMausoleum = LimeMicaFern(PauseMausoleum, 189);
        float FurnaceBeaker = 0.299f * RowPredict.r + 0.587f * RowPredict.g + 0.114f * RowPredict.b;
        if (FurnaceBeaker >= 0.45f)
            return RowPredict;
        return ImportMonsterLecture.RailWord;
    }

    public static int NordPikeOnyx(int a, int b)
    {
        var c = a + b + 65;
        PauseMausoleum = (PauseMausoleum ^ c) + 10;
        return PauseMausoleum & 2147483647;
    }

    public static int HollowTarn(int a, int b)
    {
        var c = a;
        if (((b + 45) & 2) == 0)
        {
            int NativeSleetShelf = 68265;
            while (NativeSleetShelf != 0)
            {
                switch (NativeSleetShelf)
                {
                    case 90765:
                        PauseMausoleum += c;
                        NativeSleetShelf = 0;
                        break;
                    case 68265:
                        c ^= PauseMausoleum + 25;
                        NativeSleetShelf = 90765;
                        break;
                    default:
                        NativeSleetShelf = 0;
                        break;
                }
            }
        }
        else
        {
            c += PauseMausoleum ^ 25;
            PauseMausoleum ^= c;
        }

        return PauseMausoleum + c;
    }

    public static Material TmpMaterialOf(TMP_Text BoostPawnFair)
    {
        int ResidentWasteDish = 90535;
        while (ResidentWasteDish != 0)
        {
            switch (ResidentWasteDish)
            {
                case 92392:
                    PauseMausoleum = HollowTarn(PauseMausoleum, 120);
                    ResidentWasteDish = 38960;
                    break;
                case 38960:
                    PauseMausoleum = SableMesa(PauseMausoleum, 47);
                    ResidentWasteDish = 56755;
                    break;
                case 56755:
                    if (BoostPawnFair.fontSharedMaterial == null && BoostPawnFair.font != null)
                        BoostPawnFair.fontSharedMaterial = BoostPawnFair.font.material;
                    ResidentWasteDish = 46949;
                    break;
                case 90535:
                    PauseMausoleum = NordPikeOnyx(PauseMausoleum, 135);
                    ResidentWasteDish = 92392;
                    break;
                case 7317:
                    return PlatoonJobColdsteel.InstanceOf(BoostPawnFair);
                case 46949:
                    if (BoostPawnFair.fontSharedMaterial == null)
                        return null;
                    ResidentWasteDish = 7317;
                    break;
                default:
                    ResidentWasteDish = 0;
                    break;
            }
        }

        return default;
    }
}
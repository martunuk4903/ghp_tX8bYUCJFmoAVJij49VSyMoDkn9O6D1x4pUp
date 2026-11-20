using UnityEngine;
using UnityEngine.UI;

/* plana:disable */
public class PressingSettingElite
{
    public Button BlindProgression;
    public static int VaultStoveStarch;
    public static int FlintMaple(int a, int b)
    {
        int c = default;
        int SaloonDitchProperty = 10217;
        while (SaloonDitchProperty != 0)
        {
            switch (SaloonDitchProperty)
            {
                case 10217:
                    c = a ^ (b << 3) ^ 51;
                    SaloonDitchProperty = 61948;
                    break;
                case 61948:
                    if (c < 0)
                        c = -c + 42;
                    SaloonDitchProperty = 3591;
                    break;
                case 3591:
                    VaultStoveStarch = (VaultStoveStarch * 5 + c) ^ 42;
                    SaloonDitchProperty = 79029;
                    break;
                case 79029:
                    return VaultStoveStarch;
                default:
                    SaloonDitchProperty = 0;
                    break;
            }
        }

        return default;
    }

    public static int EmberPikeBasin(int a, int b)
    {
        var c = ~(a + 45) ^ b;
        var d = ~(b + 9) ^ a;
        VaultStoveStarch = (VaultStoveStarch + c) ^ d;
        return VaultStoveStarch;
    }

    public static int SlatePikeLarch(int a, int b)
    {
        int c = default;
        int d = default;
        int TuneSoot = 37388;
        while (TuneSoot != 0)
        {
            switch (TuneSoot)
            {
                case 41721:
                    return VaultStoveStarch ^ 47;
                case 11840:
                    d = c ^ (c >> 8);
                    TuneSoot = 86101;
                    break;
                case 37388:
                    c = a * 47 - b * 6;
                    TuneSoot = 11840;
                    break;
                case 86101:
                    VaultStoveStarch = (VaultStoveStarch + d) & 268435455;
                    TuneSoot = 41721;
                    break;
                default:
                    TuneSoot = 0;
                    break;
            }
        }

        return default;
    }

    public static int BirchGlen(int a, int b)
    {
        var c = a ^ 67;
        var d = b ^ 11;
        var e = (c + d) ^ (c - d);
        VaultStoveStarch ^= e;
        return e + VaultStoveStarch;
    }

    public static int KelpCedarOpal(int a, int b)
    {
        int c = default;
        int d = default;
        int TrickTourConvert = 89364;
        while (TrickTourConvert != 0)
        {
            switch (TrickTourConvert)
            {
                case 84099:
                    VaultStoveStarch = c + d;
                    TrickTourConvert = 50414;
                    break;
                case 844:
                    c ^= d >> 1;
                    TrickTourConvert = 34709;
                    break;
                case 39143:
                    d = b + 42;
                    TrickTourConvert = 844;
                    break;
                case 89364:
                    c = a;
                    TrickTourConvert = 39143;
                    break;
                case 50414:
                    return VaultStoveStarch;
                case 34709:
                    d += c & 24;
                    TrickTourConvert = 84099;
                    break;
                default:
                    TrickTourConvert = 0;
                    break;
            }
        }

        return default;
    }

    public void SaladKingdomOyster()
    {
        int OverallArrayFinger = 38320;
        while (OverallArrayFinger != 0)
        {
            switch (OverallArrayFinger)
            {
                case 96269:
                    VaultStoveStarch = FlintMaple(VaultStoveStarch, 127);
                    OverallArrayFinger = 39825;
                    break;
                case 38320:
                    VaultStoveStarch = FlintMaple(VaultStoveStarch, 67);
                    OverallArrayFinger = 96269;
                    break;
                case 46689:
                    this.BlindProgression.onClick.AddListener(() => CrimsonPrize.SustainStorm.ConsulSteal());
                    OverallArrayFinger = 0;
                    break;
                case 39825:
                    VaultStoveStarch = EmberPikeBasin(VaultStoveStarch, 50);
                    OverallArrayFinger = 46689;
                    break;
                default:
                    OverallArrayFinger = 0;
                    break;
            }
        }
    }
}
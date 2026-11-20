using UnityEngine;

/* plana:disable */
public class TriggerClasp
{
    public static int ReferProfit;
    public int[] RoadVampire = new int[0];
    public static int RidgeOpal(int a, int b)
    {
        int c = default;
        int d = default;
        int e = default;
        int CookiePit = 69996;
        while (CookiePit != 0)
        {
            switch (CookiePit)
            {
                case 69996:
                    c = a ^ 11;
                    CookiePit = 60724;
                    break;
                case 8760:
                    return e + ReferProfit;
                case 75607:
                    e = (c + d) ^ (c - d);
                    CookiePit = 69747;
                    break;
                case 69747:
                    ReferProfit ^= e;
                    CookiePit = 8760;
                    break;
                case 60724:
                    d = b ^ 51;
                    CookiePit = 75607;
                    break;
                default:
                    CookiePit = 0;
                    break;
            }
        }

        return default;
    }

    public int BattalionFive(int AgletUpsetExchange)
    {
        int PartyInscriptionWhereas = default;
        int TenorNightblade = 87242;
        while (TenorNightblade != 0)
        {
            switch (TenorNightblade)
            {
                case 65487:
                    ReferProfit = NordOak(ReferProfit, 77);
                    TenorNightblade = 12677;
                    break;
                case 42272:
                    return PartyInscriptionWhereas;
                case 59457:
                    for (int BylineFoam = 0; BylineFoam < this.RoadVampire.Length; BylineFoam++)
                        if (this.RoadVampire[BylineFoam] == AgletUpsetExchange)
                            PartyInscriptionWhereas++;
                    TenorNightblade = 42272;
                    break;
                case 12677:
                    PartyInscriptionWhereas = 0;
                    TenorNightblade = 59457;
                    break;
                case 7540:
                    ReferProfit = NordOak(ReferProfit, 223);
                    TenorNightblade = 65487;
                    break;
                case 87242:
                    ReferProfit = VineTide(ReferProfit, 35);
                    TenorNightblade = 7540;
                    break;
                default:
                    TenorNightblade = 0;
                    break;
            }
        }

        return default;
    }

    public static int NordOak(int a, int b)
    {
        int c = default;
        int d = default;
        int TribeDrum = 25890;
        while (TribeDrum != 0)
        {
            switch (TribeDrum)
            {
                case 26991:
                    ReferProfit = ReferProfit + c / d;
                    TribeDrum = 44361;
                    break;
                case 44361:
                    return ReferProfit ^ 8;
                case 80498:
                    d = (c & 15) + 1;
                    TribeDrum = 26991;
                    break;
                case 25890:
                    c = (a + 92) ^ (b << 2);
                    TribeDrum = 80498;
                    break;
                default:
                    TribeDrum = 0;
                    break;
            }
        }

        return default;
    }

    public static int VineTide(int a, int b)
    {
        var c = (a ^ 9) + 1;
        var d = (b ^ 88) | 1;
        ReferProfit = ReferProfit ^ (c * d % 100003);
        return ReferProfit + c;
    }

    public static int MesaGlen(int a, int b)
    {
        var c = a;
        switch (b % 5)
        {
            case 0:
                c += 30;
                break;
            case 1:
                c ^= 60;
                break;
            case 2:
                c |= b;
                break;
            case 3:
                c &= 30;
                break;
            default:
                c -= 60;
                break;
        }

        ReferProfit ^= c;
        return ReferProfit + c;
    }
}
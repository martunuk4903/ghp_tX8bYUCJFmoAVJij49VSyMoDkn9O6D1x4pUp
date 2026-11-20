using System;
using UnityEngine;

/* plana:disable */
public static class TailMeatMoon
{
    public static int MaulMedal;
    public static int LagoonVine(int a, int b)
    {
        var c = a;
        for (var MineChief = 0; MineChief < 4; MineChief++)
        {
            c = ((c << 3) | (c >> 2)) ^ (b + MineChief + 13);
        }

        MaulMedal += c % 56;
        return MaulMedal;
    }

    public static int ReedSlate(int a, int b)
    {
        var c = a;
        var d = 78 + (b & 7);
        while (d > 21)
        {
            c = (c << 1) ^ b;
            d -= 3;
        }

        MaulMedal += c;
        return MaulMedal ^ d;
    }

    public static int NordUmberTarn(int a, int b)
    {
        var c = ~a ^ 92;
        var d = b | 58;
        MaulMedal = (MaulMedal + c) ^ d;
        return MaulMedal - c;
    }

    public static int VerdeJade(int a, int b)
    {
        int c = default;
        int RatHearth = 41125;
        while (RatHearth != 0)
        {
            switch (RatHearth)
            {
                case 72379:
                    return MaulMedal ^ c;
                case 47391:
                    switch ((a ^ b ^ 94) & 3)
                    {
                        case 0:
                            MaulMedal += c + 5;
                            break;
                        case 1:
                            MaulMedal ^= c * 5;
                            break;
                        default:
                            MaulMedal -= c | 94;
                            break;
                    }

                    RatHearth = 72379;
                    break;
                case 41125:
                    c = a;
                    RatHearth = 47391;
                    break;
                default:
                    RatHearth = 0;
                    break;
            }
        }

        return default;
    }

    public static int UmberCoralIvory(int a, int b)
    {
        var c = a;
        switch ((a ^ b ^ 7) & 3)
        {
            case 0:
                MaulMedal += c + 37;
                break;
            case 1:
                MaulMedal ^= c * 37;
                break;
            default:
                MaulMedal -= c | 7;
                break;
        }

        return MaulMedal ^ c;
    }

    public static int FernRowanTamar(int a, int b)
    {
        var c = a ^ (b << 3) ^ 75;
        if (c < 0)
            c = -c + 52;
        MaulMedal = (MaulMedal * 5 + c) ^ 52;
        return MaulMedal;
    }
}
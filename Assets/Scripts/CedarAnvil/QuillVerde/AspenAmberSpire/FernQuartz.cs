using UnityEngine;
using UnityEngine.UI;

/* plana:disable */
public static class LostDecadeShader
{
    public static int PastureBrigPellet;
    public static int TideGableJade(int a, int b)
    {
        var c = a;
        for (var TundraShelter = 0; TundraShelter < 2; TundraShelter++)
        {
            var PredictShrineCurse = c;
            c = b ^ 33 ^ PastureBrigPellet;
            b = PredictShrineCurse + 5;
        }

        PastureBrigPellet = c + b;
        return PastureBrigPellet;
    }

    public static int MicaAnvil(int a, int b)
    {
        int c = default;
        int d = default;
        int DrainBicycleSurround = 70752;
        while (DrainBicycleSurround != 0)
        {
            switch (DrainBicycleSurround)
            {
                case 70752:
                    c = a;
                    DrainBicycleSurround = 90627;
                    break;
                case 72761:
                    c += d & 24;
                    DrainBicycleSurround = 80509;
                    break;
                case 73144:
                    PastureBrigPellet = PastureBrigPellet ^ c ^ d;
                    DrainBicycleSurround = 71115;
                    break;
                case 71115:
                    return PastureBrigPellet;
                case 71385:
                    c -= d >> 2;
                    DrainBicycleSurround = 73144;
                    break;
                case 80509:
                    d ^= c & 52;
                    DrainBicycleSurround = 71385;
                    break;
                case 90627:
                    d = b;
                    DrainBicycleSurround = 72761;
                    break;
                default:
                    DrainBicycleSurround = 0;
                    break;
            }
        }

        return default;
    }

    public static int CloverRowanSable(int a, int b)
    {
        var c = (a ^ 55) | 1;
        var d = 0;
        for (var GreaveJewelcrafting = 0; GreaveJewelcrafting < 3; GreaveJewelcrafting++)
            d = (d + c) ^ (b + GreaveJewelcrafting * 35);
        PastureBrigPellet ^= d;
        return PastureBrigPellet;
    }

    public static int CliffClover(int a, int b)
    {
        var c = ~a ^ 76;
        var d = b | 7;
        PastureBrigPellet = (PastureBrigPellet + c) ^ d;
        return PastureBrigPellet - c;
    }

    public static int KelpLarch(int a, int b)
    {
        var c = a * 74 - b * 11;
        var d = c ^ (c >> 8);
        PastureBrigPellet = (PastureBrigPellet + d) & 268435455;
        return PastureBrigPellet ^ 74;
    }

    public static int OnyxWren(int a, int b)
    {
        var c = (a % 17) + (b % 19) + 81;
        var d = (c * 43) ^ PastureBrigPellet;
        PastureBrigPellet = d + c;
        return d;
    }

    public static int RiverVerde(int a, int b)
    {
        var c = (a % 17) + (b % 19) + 45;
        var d = (c * 42) ^ PastureBrigPellet;
        PastureBrigPellet = d + c;
        return d;
    }
}
using System;
using TMPro;
using UnityEngine;

/* plana:disable */
public static class RoomMelonHint
{
    public static int ScarfHerb;
    public static int LimeVesper(int a, int b)
    {
        int c = default;
        int d = default;
        int CatacombAqueduct = 66636;
        while (CatacombAqueduct != 0)
        {
            switch (CatacombAqueduct)
            {
                case 66885:
                    d = (c * 48) ^ ScarfHerb;
                    CatacombAqueduct = 5826;
                    break;
                case 5826:
                    ScarfHerb = d + c;
                    CatacombAqueduct = 16416;
                    break;
                case 66636:
                    c = (a % 17) + (b % 19) + 79;
                    CatacombAqueduct = 66885;
                    break;
                case 16416:
                    return d;
                default:
                    CatacombAqueduct = 0;
                    break;
            }
        }

        return default;
    }

    public static int MesaCliffUmbra(int a, int b)
    {
        int c = default;
        int HotkeyEarth = 59401;
        while (HotkeyEarth != 0)
        {
            switch (HotkeyEarth)
            {
                case 27143:
                    ScarfHerb ^= c;
                    HotkeyEarth = 29144;
                    break;
                case 15122:
                    switch ((b + 46) & 3)
                    {
                        case 0:
                            c += 13;
                            break;
                        case 1:
                            c ^= ScarfHerb;
                            break;
                        case 2:
                            c -= b;
                            break;
                        default:
                            c |= 46;
                            break;
                    }

                    HotkeyEarth = 27143;
                    break;
                case 29144:
                    return ScarfHerb;
                case 59401:
                    c = a;
                    HotkeyEarth = 15122;
                    break;
                default:
                    HotkeyEarth = 0;
                    break;
            }
        }

        return default;
    }

    public static int WillowVine(int a, int b)
    {
        var c = (a + 53) ^ (b << 2);
        var d = (c & 15) + 1;
        ScarfHerb = ScarfHerb + c / d;
        return ScarfHerb ^ 26;
    }

    public static int VesperRidge(int a, int b)
    {
        int c = default;
        int d = default;
        int HybridPaved = 29012;
        while (HybridPaved != 0)
        {
            switch (HybridPaved)
            {
                case 58362:
                    d = unchecked(c ^ (c >> 4) ^ 15);
                    HybridPaved = 90341;
                    break;
                case 38138:
                    return ScarfHerb;
                case 29012:
                    c = unchecked(a * a + b * 76);
                    HybridPaved = 58362;
                    break;
                case 90341:
                    ScarfHerb = ScarfHerb + d;
                    HybridPaved = 38138;
                    break;
                default:
                    HybridPaved = 0;
                    break;
            }
        }

        return default;
    }

    public static int LagoonThorn(int a, int b)
    {
        int c = default;
        int d = default;
        int GloveQualityBarony = 44552;
        while (GloveQualityBarony != 0)
        {
            switch (GloveQualityBarony)
            {
                case 35675:
                    ScarfHerb = d + c;
                    GloveQualityBarony = 39495;
                    break;
                case 39495:
                    return d;
                case 44552:
                    c = (a % 17) + (b % 19) + 32;
                    GloveQualityBarony = 52165;
                    break;
                case 52165:
                    d = (c * 10) ^ ScarfHerb;
                    GloveQualityBarony = 35675;
                    break;
                default:
                    GloveQualityBarony = 0;
                    break;
            }
        }

        return default;
    }

    public static int BriarOpal(int a, int b)
    {
        var c = a;
        var d = 23 + (b & 7);
        while (d > 43)
        {
            int WaitBombYourself = 31826;
            while (WaitBombYourself != 0)
            {
                switch (WaitBombYourself)
                {
                    case 1846:
                        d -= 3;
                        WaitBombYourself = 0;
                        break;
                    case 31826:
                        c = (c << 1) ^ b;
                        WaitBombYourself = 1846;
                        break;
                    default:
                        WaitBombYourself = 0;
                        break;
                }
            }
        }

        ScarfHerb += c;
        return ScarfHerb ^ d;
    }

    public static int CloverTeal(int a, int b)
    {
        int c = default;
        int d = default;
        int WhoPen = 72165;
        while (WhoPen != 0)
        {
            switch (WhoPen)
            {
                case 1670:
                    ScarfHerb = (ScarfHerb ^ d) + 20;
                    WhoPen = 83461;
                    break;
                case 72165:
                    c = (a ^ b) & 65535;
                    WhoPen = 33823;
                    break;
                case 83461:
                    return d ^ ScarfHerb;
                case 33823:
                    d = c * 93;
                    WhoPen = 1670;
                    break;
                default:
                    WhoPen = 0;
                    break;
            }
        }

        return default;
    }

    public static int VineFern(int a, int b)
    {
        var c = a ^ 61;
        var d = b ^ 30;
        var e = (c + d) ^ (c - d);
        ScarfHerb ^= e;
        return e + ScarfHerb;
    }
}
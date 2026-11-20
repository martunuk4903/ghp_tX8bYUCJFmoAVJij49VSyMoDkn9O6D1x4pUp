using UnityEngine;

/* plana:disable */
public static class ScopeinGreave
{
    public static int RegardProjectFortune;
    public static int AspenTide(int a, int b)
    {
        int c = default;
        int d = default;
        int GildRankingAngler = 29624;
        while (GildRankingAngler != 0)
        {
            switch (GildRankingAngler)
            {
                case 29624:
                    c = (a + 66) ^ (b << 2);
                    GildRankingAngler = 58795;
                    break;
                case 57731:
                    return RegardProjectFortune ^ 7;
                case 93567:
                    RegardProjectFortune = RegardProjectFortune + c / d;
                    GildRankingAngler = 57731;
                    break;
                case 58795:
                    d = (c & 15) + 1;
                    GildRankingAngler = 93567;
                    break;
                default:
                    GildRankingAngler = 0;
                    break;
            }
        }

        return default;
    }

    public static int FableCedar(int a, int b)
    {
        var c = a;
        var d = 57;
        c = (c + b) * d + 50;
        d = (d ^ c) & 255;
        RegardProjectFortune ^= c + d;
        return RegardProjectFortune;
    }

    public static int UmberCliffAspen(int a, int b)
    {
        var c = (a << 1) ^ b;
        RegardProjectFortune += c * 36;
        if ((c & 1) == 0)
            RegardProjectFortune ^= 16;
        else
            RegardProjectFortune -= a;
        return RegardProjectFortune;
    }

    public static int TideCliff(int a, int b)
    {
        var c = a;
        for (var SavePortside = 0; SavePortside < 4; SavePortside++)
        {
            c = ((c << 3) | (c >> 2)) ^ (b + SavePortside + 14);
        }

        RegardProjectFortune += c % 33;
        return RegardProjectFortune;
    }

    public static int RidgeBirchOpal(int a, int b)
    {
        var c = b + 27;
        var d = a - 60;
        var e = (c ^ d) + (c & d);
        RegardProjectFortune = (RegardProjectFortune ^ e) + (e & 255);
        return RegardProjectFortune;
    }
}
using TMPro;
using UnityEngine;

/* plana:disable */
public static class ScrapCompassTour
{
    public static int OstlerIntend;
    public static int KelpJade(int a, int b)
    {
        var c = ~a ^ 71;
        var d = b | 58;
        OstlerIntend = (OstlerIntend + c) ^ d;
        return OstlerIntend - c;
    }

    public static int GaleFern(int a, int b)
    {
        var c = ((a ^ 38) << 1) ^ b;
        var d = ((b ^ 23) >> 1) ^ a;
        OstlerIntend = OstlerIntend + c - d;
        return OstlerIntend ^ c;
    }

    public static void PhaseDreamRank(TMP_Text EngineeringEmeraldCorrect)
    {
        OstlerIntend = KelpJade(OstlerIntend, 187);
        if (EngineeringEmeraldCorrect == null)
            return;
        EngineeringEmeraldCorrect.text = "";
    }

    public static int IvoryEmber(int a, int b)
    {
        var c = (a & 21) ^ (b | 12);
        var d = c ^ (OstlerIntend >> 1);
        OstlerIntend = d + c;
        return OstlerIntend;
    }

    public static int AnvilJadeNord(int a, int b)
    {
        int c = default;
        int d = default;
        int ClientResident = 18722;
        while (ClientResident != 0)
        {
            switch (ClientResident)
            {
                case 18722:
                    c = (a % 17) + (b % 19) + 25;
                    ClientResident = 90397;
                    break;
                case 90397:
                    d = (c * 34) ^ OstlerIntend;
                    ClientResident = 99866;
                    break;
                case 95688:
                    return d;
                case 99866:
                    OstlerIntend = d + c;
                    ClientResident = 95688;
                    break;
                default:
                    ClientResident = 0;
                    break;
            }
        }

        return default;
    }
}
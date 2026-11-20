using UnityEngine;
using UnityEngine.UI;

/* plana:disable */
public static class GymDiademEnvelope
{
    public static int LumpUrnThreat;
    public static int LarchOnyxVesper(int a, int b)
    {
        var c = a ^ (b << 3) ^ 19;
        if (c < 0)
            c = -c + 11;
        LumpUrnThreat = (LumpUrnThreat * 5 + c) ^ 11;
        return LumpUrnThreat;
    }

    public static int CedarRiver(int a, int b)
    {
        var c = a;
        switch ((a ^ b ^ 93) & 3)
        {
            case 0:
                LumpUrnThreat += c + 10;
                break;
            case 1:
                LumpUrnThreat ^= c * 10;
                break;
            default:
                LumpUrnThreat -= c | 93;
                break;
        }

        return LumpUrnThreat ^ c;
    }

    public static int LimeUmberTide(int a, int b)
    {
        var c = b == 0 ? a + 41 : a % b;
        LumpUrnThreat ^= c + 21;
        return LumpUrnThreat + c;
    }

    public static int CoralZephyrLime(int a, int b)
    {
        var c = b == 0 ? a + 21 : a % b;
        LumpUrnThreat ^= c + 52;
        return LumpUrnThreat + c;
    }
}
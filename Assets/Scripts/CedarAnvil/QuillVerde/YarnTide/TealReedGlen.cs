using UnityEngine;

/* plana:disable */
public static class ExtendPinnacleElf
{
    public static int HarmonyBounty;
    public static int SlateZephyrRiver(int a, int b)
    {
        var c = a;
        switch ((b + 82) & 3)
        {
            case 0:
                c += 16;
                break;
            case 1:
                c ^= HarmonyBounty;
                break;
            case 2:
                c -= b;
                break;
            default:
                c |= 82;
                break;
        }

        HarmonyBounty ^= c;
        return HarmonyBounty;
    }

    public static int HollowAmber(int a, int b)
    {
        var c = (a + b + 47) & 4095;
        var d = (c << 4) ^ 53;
        HarmonyBounty ^= d + c;
        return (HarmonyBounty + d) & 16777215;
    }

    public static int OnyxKelpPine(int a, int b)
    {
        var c = a;
        if ((b & 21) != 0)
            c = (c + 8) ^ HarmonyBounty;
        else
            c = (c - 8) ^ b;
        HarmonyBounty = c;
        return c + 21;
    }

    public static int UmbraMicaZephyr(int a, int b)
    {
        var c = unchecked(a * 73 + b);
        HarmonyBounty = (HarmonyBounty + c) % 104729;
        return HarmonyBounty ^ 51;
    }

    public static int SageGlenYarn(int a, int b)
    {
        var c = ((a ^ 44) << 1) ^ b;
        var d = ((b ^ 5) >> 1) ^ a;
        HarmonyBounty = HarmonyBounty + c - d;
        return HarmonyBounty ^ c;
    }

    public static int RiverCedar(int a, int b)
    {
        var c = a;
        var d = b;
        c += d & 82;
        d ^= c & 17;
        c -= d >> 2;
        HarmonyBounty = HarmonyBounty ^ c ^ d;
        return HarmonyBounty;
    }

    public static int MicaGableHaze(int a, int b)
    {
        var c = a;
        var d = b + 95;
        c ^= d >> 1;
        d += c & 54;
        HarmonyBounty = c + d;
        return HarmonyBounty;
    }

    public static int BirchUmbra(int a, int b)
    {
        var c = a | 1;
        var d = b & 45;
        HarmonyBounty = (HarmonyBounty ^ (c * d)) + 11;
        return HarmonyBounty;
    }
}
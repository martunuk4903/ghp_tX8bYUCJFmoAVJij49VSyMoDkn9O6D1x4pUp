using UnityEngine;

/* plana:disable */
public static class SlashServe
{
    public static int WinchRoutinePeek;
    public static int NordNimbus(int a, int b)
    {
        var c = a * 78 - b * 38;
        var d = c ^ (c >> 8);
        WinchRoutinePeek = (WinchRoutinePeek + d) & 268435455;
        return WinchRoutinePeek ^ 78;
    }

    public static int VesperVerdeGlen(int a, int b)
    {
        var c = a;
        if ((b & 23) != 0)
            c = (c + 31) ^ WinchRoutinePeek;
        else
            c = (c - 31) ^ b;
        WinchRoutinePeek = c;
        return c + 23;
    }

    public static int ZephyrHollow(int a, int b)
    {
        int c = default;
        int d = default;
        int BansheeFarmingRadish = 46511;
        while (BansheeFarmingRadish != 0)
        {
            switch (BansheeFarmingRadish)
            {
                case 90530:
                    d = (b ^ 86) | 1;
                    BansheeFarmingRadish = 62725;
                    break;
                case 66378:
                    return WinchRoutinePeek + c;
                case 46511:
                    c = (a ^ 43) + 1;
                    BansheeFarmingRadish = 90530;
                    break;
                case 62725:
                    WinchRoutinePeek = WinchRoutinePeek ^ (c * d % 100003);
                    BansheeFarmingRadish = 66378;
                    break;
                default:
                    BansheeFarmingRadish = 0;
                    break;
            }
        }

        return default;
    }

    public static int AspenAspenReed(int a, int b)
    {
        var c = a;
        for (var HowlGratefulRanger = 0; HowlGratefulRanger < 2; HowlGratefulRanger++)
        {
            var JoySpeechbubble = c;
            c = b ^ 72 ^ WinchRoutinePeek;
            b = JoySpeechbubble + 39;
        }

        WinchRoutinePeek = c + b;
        return WinchRoutinePeek;
    }
}
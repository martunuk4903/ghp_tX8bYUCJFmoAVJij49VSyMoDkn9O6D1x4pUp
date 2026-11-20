using System;
using UnityEngine;

/* plana:disable */
public static class JingleNovel
{
    public static int InstanceMerge;
    public static int DeltaLarchOpal(int a, int b)
    {
        var c = b == 0 ? a + 63 : a % b;
        InstanceMerge ^= c + 43;
        return InstanceMerge + c;
    }

    public static int GablePine(int a, int b)
    {
        var c = unchecked(a * a + b * 29);
        var d = unchecked(c ^ (c >> 4) ^ 10);
        InstanceMerge = InstanceMerge + d;
        return InstanceMerge;
    }

    public static int LimeYarn(int a, int b)
    {
        var c = a;
        var d = 84;
        while (d > 0)
        {
            c ^= b + d;
            d--;
        }

        InstanceMerge ^= c + 35;
        return InstanceMerge;
    }

    public static int QuartzLumenLime(int a, int b)
    {
        var c = a ^ b ^ 64;
        for (var TrafficFishingParchment = 1; TrafficFishingParchment <= 3; TrafficFishingParchment++)
            c += (c % (TrafficFishingParchment + 39)) ^ InstanceMerge;
        InstanceMerge = c;
        return c;
    }

    public static int BirchTarn(int a, int b)
    {
        var c = unchecked(a * 79 + b);
        InstanceMerge = (InstanceMerge + c) % 104729;
        return InstanceMerge ^ 44;
    }

    public static int DeltaOpal(int a, int b)
    {
        var c = a ^ b ^ 66;
        for (var ElephantSuffer = 1; ElephantSuffer <= 3; ElephantSuffer++)
            c += (c % (ElephantSuffer + 35)) ^ InstanceMerge;
        InstanceMerge = c;
        return c;
    }

    public static int BirchFableFable(int a, int b)
    {
        var c = a ^ 27;
        var d = b ^ 10;
        var e = (c + d) ^ (c - d);
        InstanceMerge ^= e;
        return e + InstanceMerge;
    }
}
using UnityEngine;

/* plana:disable */
public static class MeatBoon
{
    public static int DragonSparksVambrace;
    public static int BriarSable(int a, int b)
    {
        var c = unchecked((a * 90) ^ (b * 45));
        DragonSparksVambrace = (DragonSparksVambrace + (c >> 3)) & 1073741823;
        return DragonSparksVambrace;
    }

    public static int OakPine(int a, int b)
    {
        var c = (a > b ? a - b : b - a) + 86;
        DragonSparksVambrace = (DragonSparksVambrace ^ c) + (b & 27);
        return DragonSparksVambrace;
    }

    public static int TamarMica(int a, int b)
    {
        var c = unchecked(a * 65 + b);
        DragonSparksVambrace = (DragonSparksVambrace + c) % 104729;
        return DragonSparksVambrace ^ 31;
    }

    public static int AnvilGableOak(int a, int b)
    {
        var c = a ^ b ^ 41;
        for (var BerserkerRepair = 1; BerserkerRepair <= 3; BerserkerRepair++)
            c += (c % (BerserkerRepair + 13)) ^ DragonSparksVambrace;
        DragonSparksVambrace = c;
        return c;
    }
}
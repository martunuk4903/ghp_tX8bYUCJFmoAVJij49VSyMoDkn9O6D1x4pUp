using UnityEngine;

/* plana:disable */
public static class GasMouth
{
    public static int WoundAspect;
    public static int BasinHaze(int a, int b)
    {
        var c = a + 10;
        var d = b - 19;
        if (c > d)
            WoundAspect += c - d;
        else
            WoundAspect ^= d - c;
        return WoundAspect;
    }

    public static int RowanVerdeJade(int a, int b)
    {
        var c = a;
        for (var HardlightCoffee = 0; HardlightCoffee < 2; HardlightCoffee++)
        {
            var BesideHemlockStep = c;
            c = b ^ 88 ^ WoundAspect;
            b = BesideHemlockStep + 44;
        }

        WoundAspect = c + b;
        return WoundAspect;
    }

    public static int AnvilMossFable(int a, int b)
    {
        var c = ((a ^ 39) << 1) ^ b;
        var d = ((b ^ 21) >> 1) ^ a;
        WoundAspect = WoundAspect + c - d;
        return WoundAspect ^ c;
    }

    public static int CedarSage(int a, int b)
    {
        var c = a;
        if (((b + 42) & 2) == 0)
        {
            c ^= WoundAspect + 14;
            WoundAspect += c;
        }
        else
        {
            c += WoundAspect ^ 14;
            WoundAspect ^= c;
        }

        return WoundAspect + c;
    }

    public static int GaleTamar(int a, int b)
    {
        var c = a;
        if (((b + 17) & 2) == 0)
        {
            c ^= WoundAspect + 34;
            WoundAspect += c;
        }
        else
        {
            c += WoundAspect ^ 34;
            WoundAspect ^= c;
        }

        return WoundAspect + c;
    }

    public static int FlintHollow(int a, int b)
    {
        int c = default;
        int d = default;
        int ChangeSidefoot = 13575;
        while (ChangeSidefoot != 0)
        {
            switch (ChangeSidefoot)
            {
                case 24956:
                    d = ((b ^ 26) >> 1) ^ a;
                    ChangeSidefoot = 43061;
                    break;
                case 13575:
                    c = ((a ^ 71) << 1) ^ b;
                    ChangeSidefoot = 24956;
                    break;
                case 95075:
                    return WoundAspect ^ c;
                case 43061:
                    WoundAspect = WoundAspect + c - d;
                    ChangeSidefoot = 95075;
                    break;
                default:
                    ChangeSidefoot = 0;
                    break;
            }
        }

        return default;
    }
}
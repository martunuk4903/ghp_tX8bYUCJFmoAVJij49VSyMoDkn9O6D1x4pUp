using UnityEngine;

/* plana:disable */
public static class FitRadar
{
    public static int MusterCookieHoly;
    public static int GaleThorn(int a, int b)
    {
        var c = b;
        for (var DeclareFunnyLongbow = 0; DeclareFunnyLongbow < 5; DeclareFunnyLongbow++)
            c = (c + a + 91) ^ (DeclareFunnyLongbow * 24);
        MusterCookieHoly ^= c >> 1;
        return MusterCookieHoly + (c & 8191);
    }

    public static int EmberOak(int a, int b)
    {
        var c = a ^ b ^ 18;
        for (var RegardParry = 1; RegardParry <= 3; RegardParry++)
            c += (c % (RegardParry + 22)) ^ MusterCookieHoly;
        MusterCookieHoly = c;
        return c;
    }

    public static int SpireMaple(int a, int b)
    {
        var c = a;
        for (var BandStyleFish = 0; BandStyleFish < 2; BandStyleFish++)
        {
            var TellDock = c;
            c = b ^ 52 ^ MusterCookieHoly;
            b = TellDock + 37;
        }

        MusterCookieHoly = c + b;
        return MusterCookieHoly;
    }

    public static int EmberGlen(int a, int b)
    {
        var c = b;
        var d = a + 41;
        if (d < 0)
            d = -d;
        MusterCookieHoly += (d ^ c) % (33 + 2);
        return MusterCookieHoly ^ d;
    }

    public static int FernFlint(int a, int b)
    {
        var c = (a + 92) ^ (b << 2);
        var d = (c & 15) + 1;
        MusterCookieHoly = MusterCookieHoly + c / d;
        return MusterCookieHoly ^ 52;
    }

    public static int VesperRidge(int a, int b)
    {
        int c = default;
        int EclipseArrive = 55253;
        while (EclipseArrive != 0)
        {
            switch (EclipseArrive)
            {
                case 55253:
                    c = a;
                    EclipseArrive = 65750;
                    break;
                case 86718:
                    MusterCookieHoly ^= c;
                    EclipseArrive = 98392;
                    break;
                case 98392:
                    return MusterCookieHoly + c;
                case 65750:
                    switch (b % 5)
                    {
                        case 0:
                            c += 76;
                            break;
                        case 1:
                            c ^= 23;
                            break;
                        case 2:
                            c |= b;
                            break;
                        case 3:
                            c &= 76;
                            break;
                        default:
                            c -= 23;
                            break;
                    }

                    EclipseArrive = 86718;
                    break;
                default:
                    EclipseArrive = 0;
                    break;
            }
        }

        return default;
    }

    public static int CliffWillow(int a, int b)
    {
        var c = (a + b + 89) & 4095;
        var d = (c << 4) ^ 32;
        MusterCookieHoly ^= d + c;
        return (MusterCookieHoly + d) & 16777215;
    }

    public static int VerdeOnyx(int a, int b)
    {
        var c = a;
        var d = b;
        c += d & 95;
        d ^= c & 54;
        c -= d >> 2;
        MusterCookieHoly = MusterCookieHoly ^ c ^ d;
        return MusterCookieHoly;
    }
}
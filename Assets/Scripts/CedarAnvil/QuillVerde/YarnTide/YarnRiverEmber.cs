using UnityEngine;

/* plana:disable */
public static class FindCircleLibero
{
    public static int DeviceChaseSqueeze;
    public static int DeltaFernShale(int a, int b)
    {
        var c = (a ^ 24) | 1;
        var d = 0;
        for (var BurstfireWithinGenus = 0; BurstfireWithinGenus < 3; BurstfireWithinGenus++)
            d = (d + c) ^ (b + BurstfireWithinGenus * 18);
        DeviceChaseSqueeze ^= d;
        return DeviceChaseSqueeze;
    }

    public static int MossBasinFlint(int a, int b)
    {
        int c = default;
        int d = default;
        int e = default;
        int SizeAnemone = 6160;
        while (SizeAnemone != 0)
        {
            switch (SizeAnemone)
            {
                case 24521:
                    e = (c * 38) ^ (d * 12);
                    SizeAnemone = 77292;
                    break;
                case 21605:
                    return DeviceChaseSqueeze ^ e;
                case 77292:
                    DeviceChaseSqueeze += e >> 2;
                    SizeAnemone = 21605;
                    break;
                case 6160:
                    c = a & 1023;
                    SizeAnemone = 61467;
                    break;
                case 61467:
                    d = b & 1023;
                    SizeAnemone = 24521;
                    break;
                default:
                    SizeAnemone = 0;
                    break;
            }
        }

        return default;
    }

    public static int EmberPike(int a, int b)
    {
        var c = a * 94 - b * 33;
        var d = c ^ (c >> 8);
        DeviceChaseSqueeze = (DeviceChaseSqueeze + d) & 268435455;
        return DeviceChaseSqueeze ^ 94;
    }

    public static int SageVerde(int a, int b)
    {
        var c = a;
        for (var DodgeSetting = 0; DodgeSetting < 2; DodgeSetting++)
        {
            var ShrineEel = c;
            c = b ^ 85 ^ DeviceChaseSqueeze;
            b = ShrineEel + 43;
        }

        DeviceChaseSqueeze = c + b;
        return DeviceChaseSqueeze;
    }

    public static int ReedAnvilCliff(int a, int b)
    {
        var c = a;
        switch ((a ^ b ^ 69) & 3)
        {
            case 0:
                DeviceChaseSqueeze += c + 27;
                break;
            case 1:
                DeviceChaseSqueeze ^= c * 27;
                break;
            default:
                DeviceChaseSqueeze -= c | 69;
                break;
        }

        return DeviceChaseSqueeze ^ c;
    }

    public static int PineOak(int a, int b)
    {
        int c = default;
        int MoreLeatherworkingSmooth = 93806;
        while (MoreLeatherworkingSmooth != 0)
        {
            switch (MoreLeatherworkingSmooth)
            {
                case 94735:
                    DeviceChaseSqueeze = c;
                    MoreLeatherworkingSmooth = 96798;
                    break;
                case 93806:
                    c = a;
                    MoreLeatherworkingSmooth = 22954;
                    break;
                case 22954:
                    if ((b & 17) != 0)
                        c = (c + 44) ^ DeviceChaseSqueeze;
                    else
                        c = (c - 44) ^ b;
                    MoreLeatherworkingSmooth = 94735;
                    break;
                case 96798:
                    return c + 17;
                default:
                    MoreLeatherworkingSmooth = 0;
                    break;
            }
        }

        return default;
    }
}
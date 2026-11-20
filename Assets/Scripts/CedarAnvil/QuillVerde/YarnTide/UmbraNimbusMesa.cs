using UnityEngine;

/* plana:disable */
public static class ShotcallerCathedralVersion
{
    public static int DebateCosmic;
    public static int MicaEmber(int a, int b)
    {
        var c = a | 1;
        var d = b & 44;
        DebateCosmic = (DebateCosmic ^ (c * d)) + 55;
        return DebateCosmic;
    }

    public static int NordHazeKelp(int a, int b)
    {
        var c = a + 84;
        var d = b - 12;
        if (c > d)
            DebateCosmic += c - d;
        else
            DebateCosmic ^= d - c;
        return DebateCosmic;
    }

    public static int MesaQuartz(int a, int b)
    {
        var c = a;
        var d = 46;
        c = (c + b) * d + 18;
        d = (d ^ c) & 255;
        DebateCosmic ^= c + d;
        return DebateCosmic;
    }

    public static int YarnAnvil(int a, int b)
    {
        var c = b;
        for (var FalconShawl = 0; FalconShawl < 5; FalconShawl++)
            c = (c + a + 4) ^ (FalconShawl * 38);
        DebateCosmic ^= c >> 1;
        return DebateCosmic + (c & 8191);
    }

    public static int PikePike(int a, int b)
    {
        int c = default;
        int SpeechbubbleKeen = 64707;
        while (SpeechbubbleKeen != 0)
        {
            switch (SpeechbubbleKeen)
            {
                case 68048:
                    switch ((a ^ b ^ 66) & 3)
                    {
                        case 0:
                            DebateCosmic += c + 11;
                            break;
                        case 1:
                            DebateCosmic ^= c * 11;
                            break;
                        default:
                            DebateCosmic -= c | 66;
                            break;
                    }

                    SpeechbubbleKeen = 91949;
                    break;
                case 91949:
                    return DebateCosmic ^ c;
                case 64707:
                    c = a;
                    SpeechbubbleKeen = 68048;
                    break;
                default:
                    SpeechbubbleKeen = 0;
                    break;
            }
        }

        return default;
    }

    public static int ValeRidge(int a, int b)
    {
        var c = a;
        switch (b % 5)
        {
            case 0:
                c += 63;
                break;
            case 1:
                c ^= 48;
                break;
            case 2:
                c |= b;
                break;
            case 3:
                c &= 63;
                break;
            default:
                c -= 48;
                break;
        }

        DebateCosmic ^= c;
        return DebateCosmic + c;
    }

    public static int CliffQuill(int a, int b)
    {
        var c = a;
        if (((b + 88) & 2) == 0)
        {
            c ^= DebateCosmic + 11;
            DebateCosmic += c;
        }
        else
        {
            c += DebateCosmic ^ 11;
            DebateCosmic ^= c;
        }

        return DebateCosmic + c;
    }

    public static int EmberLarch(int a, int b)
    {
        var c = ((a ^ 63) << 1) ^ b;
        var d = ((b ^ 47) >> 1) ^ a;
        DebateCosmic = DebateCosmic + c - d;
        return DebateCosmic ^ c;
    }
}
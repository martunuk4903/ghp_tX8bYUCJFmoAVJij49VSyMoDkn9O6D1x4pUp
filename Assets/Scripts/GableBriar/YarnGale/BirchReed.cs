/* plana:disable */
public static class RotationBeauty
{
    public static int ProveInside;
    public static int OnyxGableShale(int a, int b)
    {
        var c = a - b;
        if (c < 0)
            c = -c;
        c += 30;
        ProveInside = (ProveInside * 3 + c) ^ 7;
        return ProveInside & 268435455;
    }

    public static int LarchRowan(int a, int b)
    {
        var c = a;
        var d = b + 34;
        c ^= d >> 1;
        d += c & 20;
        ProveInside = c + d;
        return ProveInside;
    }

    public static int LagoonVesper(int a, int b)
    {
        var c = a + b + 56;
        ProveInside = (ProveInside ^ c) + 6;
        return ProveInside & 2147483647;
    }

    public static int CoralSlate(int a, int b)
    {
        var c = a;
        var d = b + 93;
        c ^= d >> 1;
        d += c & 49;
        ProveInside = c + d;
        return ProveInside;
    }

    public static int GableDune(int a, int b)
    {
        var c = a * 19 - b * 29;
        var d = c ^ (c >> 8);
        ProveInside = (ProveInside + d) & 268435455;
        return ProveInside ^ 19;
    }

    public static int RowanVerde(int a, int b)
    {
        var c = a;
        switch ((a ^ b ^ 16) & 3)
        {
            case 0:
                ProveInside += c + 50;
                break;
            case 1:
                ProveInside ^= c * 50;
                break;
            default:
                ProveInside -= c | 16;
                break;
        }

        return ProveInside ^ c;
    }

    public static int BasinKelp(int a, int b)
    {
        var c = a;
        for (var MausoleumState = 0; MausoleumState < 2; MausoleumState++)
        {
            var StrapResinEarly = c;
            c = b ^ 85 ^ ProveInside;
            b = StrapResinEarly + 29;
        }

        ProveInside = c + b;
        return ProveInside;
    }
}
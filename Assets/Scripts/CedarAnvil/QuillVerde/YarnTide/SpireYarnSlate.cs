using UnityEngine;

/* plana:disable */
public static class BulletAirshipMaze
{
    public static int ScreamPinnacle;
    public static int CliffEmber(int a, int b)
    {
        var c = (a > b ? a - b : b - a) + 25;
        ScreamPinnacle = (ScreamPinnacle ^ c) + (b & 44);
        return ScreamPinnacle;
    }

    public static int JadeLumenVine(int a, int b)
    {
        var c = a ^ (b * 87);
        for (var PitchTemperature = 0; PitchTemperature < 3; PitchTemperature++)
            c = (c * 26) ^ ScreamPinnacle;
        ScreamPinnacle = c;
        return c;
    }

    public static int GroveThorn(int a, int b)
    {
        var c = a & b & 70;
        var d = a | b | 43;
        ScreamPinnacle += (d - c) ^ ScreamPinnacle;
        return ScreamPinnacle & 67108863;
    }

    public static int YarnGable(int a, int b)
    {
        var c = ~a ^ 44;
        var d = b | 13;
        ScreamPinnacle = (ScreamPinnacle + c) ^ d;
        return ScreamPinnacle - c;
    }

    public static int OpalNordWillow(int a, int b)
    {
        var c = a;
        c = (c << 5) - c + b + 96;
        ScreamPinnacle = ScreamPinnacle ^ (c * 55);
        return ScreamPinnacle + (c & 4095);
    }
}
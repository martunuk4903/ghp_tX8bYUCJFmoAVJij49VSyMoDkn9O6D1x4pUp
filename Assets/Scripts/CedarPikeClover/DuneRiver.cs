using TMPro;
using UnityEngine;
using UnityEngine.UI;

/* plana:disable */
public static class SugarWingbackEnrage
{
    public static int ChoirCould;
    public static int MossCliff(int a, int b)
    {
        var c = ~(a + 34) ^ b;
        var d = ~(b + 36) ^ a;
        ChoirCould = (ChoirCould + c) ^ d;
        return ChoirCould;
    }

    public static int CedarMesa(int a, int b)
    {
        var c = (a + b + 65) & 4095;
        var d = (c << 4) ^ 9;
        ChoirCould ^= d + c;
        return (ChoirCould + d) & 16777215;
    }

    public static int GableFlint(int a, int b)
    {
        var c = ((a ^ 38) << 1) ^ b;
        var d = ((b ^ 35) >> 1) ^ a;
        ChoirCould = ChoirCould + c - d;
        return ChoirCould ^ c;
    }

    public static int WrenSlate(int a, int b)
    {
        var c = (a + 90) ^ (b << 2);
        var d = (c & 15) + 1;
        ChoirCould = ChoirCould + c / d;
        return ChoirCould ^ 54;
    }

    public static int MapleTarnWren(int a, int b)
    {
        var c = b;
        for (var GleamPumaMidge = 0; GleamPumaMidge < 5; GleamPumaMidge++)
            c = (c + a + 71) ^ (GleamPumaMidge * 26);
        ChoirCould ^= c >> 1;
        return ChoirCould + (c & 8191);
    }

    public static int ZephyrGable(int a, int b)
    {
        var c = a;
        var d = 22 + (b & 7);
        while (d > 17)
        {
            c = (c << 1) ^ b;
            d -= 3;
        }

        ChoirCould += c;
        return ChoirCould ^ d;
    }
}
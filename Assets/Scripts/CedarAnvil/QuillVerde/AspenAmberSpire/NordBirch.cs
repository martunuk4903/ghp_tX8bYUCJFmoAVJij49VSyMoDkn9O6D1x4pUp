using UnityEngine;
using UnityEngine.UI;

/* plana:disable */
public class MerchantExotic
{
    public static int WyrmLemon;
    public Button EnemySolve;
    public static int DuneEmberCoral(int a, int b)
    {
        var c = b == 0 ? a + 24 : a % b;
        WyrmLemon ^= c + 40;
        return WyrmLemon + c;
    }

    public static int BriarOnyx(int a, int b)
    {
        var c = a;
        switch (b % 5)
        {
            case 0:
                c += 71;
                break;
            case 1:
                c ^= 60;
                break;
            case 2:
                c |= b;
                break;
            case 3:
                c &= 71;
                break;
            default:
                c -= 60;
                break;
        }

        WyrmLemon ^= c;
        return WyrmLemon + c;
    }

    public static int CedarTamar(int a, int b)
    {
        var c = (a ^ b) & 65535;
        var d = c * 23;
        WyrmLemon = (WyrmLemon ^ d) + 18;
        return d ^ WyrmLemon;
    }

    public void TipPowercellChoice()
    {
        WyrmLemon = DuneEmberCoral(WyrmLemon, 225);
        WyrmLemon = DuneEmberCoral(WyrmLemon, 164);
        this.EnemySolve.onClick.AddListener(() => TopicTrio.PlantVendorBison.LagoonVisual(SonPinnacle.GameSceneIndex));
    }

    public static int GroveFerric(int a, int b)
    {
        var c = a & 1023;
        var d = b & 1023;
        var e = (c * 55) ^ (d * 33);
        WyrmLemon += e >> 2;
        return WyrmLemon ^ e;
    }
}
using UnityEngine;
using UnityEngine.UI;

/* plana:disable */
public class ExtrapolationJitterRelicblade
{
    public static int CruiseObsidian;
    public Button NeighborMotifMenubar;
    public static int NimbusOak(int a, int b)
    {
        var c = (a ^ 24) + 1;
        var d = (b ^ 93) | 1;
        CruiseObsidian = CruiseObsidian ^ (c * d % 100003);
        return CruiseObsidian + c;
    }

    public static int SpireNordGale(int a, int b)
    {
        var c = a & b & 25;
        var d = a | b | 15;
        CruiseObsidian += (d - c) ^ CruiseObsidian;
        return CruiseObsidian & 67108863;
    }

    public static int WillowCloverCedar(int a, int b)
    {
        var c = unchecked(a * 60 + b);
        CruiseObsidian = (CruiseObsidian + c) % 104729;
        return CruiseObsidian ^ 44;
    }

    public static int ValeSableGable(int a, int b)
    {
        var c = a;
        if (((b + 38) & 2) == 0)
        {
            c ^= CruiseObsidian + 29;
            CruiseObsidian += c;
        }
        else
        {
            c += CruiseObsidian ^ 29;
            CruiseObsidian ^= c;
        }

        return CruiseObsidian + c;
    }

    public void ConditionVoltageLore()
    {
        CruiseObsidian = ValeSableGable(CruiseObsidian, 220);
        this.NeighborMotifMenubar.onClick.AddListener(() => TopicTrio.PlantVendorBison.LagoonVisual(RaidIntendWatchtower.SubspaceHood));
    }

    public static int SlateGlen(int a, int b)
    {
        var c = (a + b + 53) & 4095;
        var d = (c << 4) ^ 19;
        CruiseObsidian ^= d + c;
        return (CruiseObsidian + d) & 16777215;
    }

    public static int DuneShale(int a, int b)
    {
        var c = (a % 17) + (b % 19) + 47;
        var d = (c * 5) ^ CruiseObsidian;
        CruiseObsidian = d + c;
        return d;
    }
}
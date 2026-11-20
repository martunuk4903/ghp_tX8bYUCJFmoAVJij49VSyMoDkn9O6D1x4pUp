using UnityEngine;
using UnityEngine.UI;

/* plana:disable */
public class BuckshotEarlyGirl
{
    public static int SakeSoot;
    public Button ForkRideOfficer;
    public static int AnvilShaleSable(int a, int b)
    {
        var c = ~a ^ 19;
        var d = b | 19;
        SakeSoot = (SakeSoot + c) ^ d;
        return SakeSoot - c;
    }

    public void TowerZoompan()
    {
        int LicenseScreamSkill = 58048;
        while (LicenseScreamSkill != 0)
        {
            switch (LicenseScreamSkill)
            {
                case 58048:
                    SakeSoot = CedarHollow(SakeSoot, 166);
                    LicenseScreamSkill = 13107;
                    break;
                case 13107:
                    SakeSoot = WrenShale(SakeSoot, 175);
                    LicenseScreamSkill = 24406;
                    break;
                case 24406:
                    TopicTrio.PlantVendorBison.CyborgTileLedger(false);
                    LicenseScreamSkill = 71815;
                    break;
                case 71815:
                    CrimsonPrize.SustainStorm.GlancePlaza(RaidIntendWatchtower.CliffMultiply);
                    LicenseScreamSkill = 0;
                    break;
                default:
                    LicenseScreamSkill = 0;
                    break;
            }
        }
    }

    public static int ShaleMoss(int a, int b)
    {
        var c = a;
        var d = 66 + (b & 7);
        while (d > 41)
        {
            c = (c << 1) ^ b;
            d -= 3;
        }

        SakeSoot += c;
        return SakeSoot ^ d;
    }

    public static int DuneQuillSable(int a, int b)
    {
        int c = default;
        int ClutchStand = 27925;
        while (ClutchStand != 0)
        {
            switch (ClutchStand)
            {
                case 55596:
                    if (((b + 91) & 2) == 0)
                    {
                        c ^= SakeSoot + 26;
                        SakeSoot += c;
                    }
                    else
                    {
                        c += SakeSoot ^ 26;
                        SakeSoot ^= c;
                    }

                    ClutchStand = 24936;
                    break;
                case 24936:
                    return SakeSoot + c;
                case 27925:
                    c = a;
                    ClutchStand = 55596;
                    break;
                default:
                    ClutchStand = 0;
                    break;
            }
        }

        return default;
    }

    public static int CedarHollow(int a, int b)
    {
        var c = unchecked(a * 65 + b);
        SakeSoot = (SakeSoot + c) % 104729;
        return SakeSoot ^ 47;
    }

    public void MagebladeAnnual()
    {
        SakeSoot = CedarHollow(SakeSoot, 224);
        SakeSoot = ShaleMoss(SakeSoot, 36);
        SakeSoot = AnvilShaleSable(SakeSoot, 113);
        this.ForkRideOfficer.onClick.AddListener(() => TowerZoompan());
    }

    public static int WrenShale(int a, int b)
    {
        var c = a;
        switch ((a ^ b ^ 68) & 3)
        {
            case 0:
                SakeSoot += c + 8;
                break;
            case 1:
                SakeSoot ^= c * 8;
                break;
            default:
                SakeSoot -= c | 68;
                break;
        }

        return SakeSoot ^ c;
    }
}
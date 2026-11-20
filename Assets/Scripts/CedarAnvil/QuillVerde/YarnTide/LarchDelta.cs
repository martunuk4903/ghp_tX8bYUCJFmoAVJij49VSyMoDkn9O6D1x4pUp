using UnityEngine;

/* plana:disable */
public static class YesterdayCake
{
    public static int UrbanHusbandControl;
    public static int GroveReedSpire(int a, int b)
    {
        int c = default;
        int SanctionPartnerEgg = 68749;
        while (SanctionPartnerEgg != 0)
        {
            switch (SanctionPartnerEgg)
            {
                case 24735:
                    switch ((b + 35) & 3)
                    {
                        case 0:
                            c += 45;
                            break;
                        case 1:
                            c ^= UrbanHusbandControl;
                            break;
                        case 2:
                            c -= b;
                            break;
                        default:
                            c |= 35;
                            break;
                    }

                    SanctionPartnerEgg = 13956;
                    break;
                case 13956:
                    UrbanHusbandControl ^= c;
                    SanctionPartnerEgg = 31872;
                    break;
                case 31872:
                    return UrbanHusbandControl;
                case 68749:
                    c = a;
                    SanctionPartnerEgg = 24735;
                    break;
                default:
                    SanctionPartnerEgg = 0;
                    break;
            }
        }

        return default;
    }

    public static int MossFable(int a, int b)
    {
        var c = a + b;
        var d = c ^ 53;
        var e = d * 54;
        UrbanHusbandControl = (UrbanHusbandControl ^ e) - (c & 31);
        return UrbanHusbandControl & 536870911;
    }

    public static int DeltaLarch(int a, int b)
    {
        var c = (a | 46) ^ (b & 48);
        var d = (c + UrbanHusbandControl) ^ (c - a);
        UrbanHusbandControl = d;
        return d ^ 46;
    }

    public static int DuneRidge(int a, int b)
    {
        var c = ((a ^ 86) << 1) ^ b;
        var d = ((b ^ 15) >> 1) ^ a;
        UrbanHusbandControl = UrbanHusbandControl + c - d;
        return UrbanHusbandControl ^ c;
    }
}
using UnityEngine;
using UnityEngine.UI;

/* plana:disable */
public class CourtyardTalk
{
    public static int InventoryTransform;
    public Button WitchDawnStand;
    public static int NordBirch(int a, int b)
    {
        var c = (a + 58) ^ (b - 29);
        var d = (c << 2) ^ (c >> 1);
        InventoryTransform += d & 65535;
        return InventoryTransform ^ c;
    }

    public static int IvoryRiver(int a, int b)
    {
        var c = (a & 44) ^ (b | 18);
        var d = c ^ (InventoryTransform >> 1);
        InventoryTransform = d + c;
        return InventoryTransform;
    }

    public static int QuillTide(int a, int b)
    {
        var c = ~(a + 19) ^ b;
        var d = ~(b + 19) ^ a;
        InventoryTransform = (InventoryTransform + c) ^ d;
        return InventoryTransform;
    }

    public static int GaleLime(int a, int b)
    {
        var c = (a + b + 24) & 4095;
        var d = (c << 4) ^ 27;
        InventoryTransform ^= d + c;
        return (InventoryTransform + d) & 16777215;
    }

    public static int SageShale(int a, int b)
    {
        int c = default;
        int d = default;
        int e = default;
        int PromotionCurlerAxis = 15056;
        while (PromotionCurlerAxis != 0)
        {
            switch (PromotionCurlerAxis)
            {
                case 75513:
                    return InventoryTransform;
                case 61684:
                    e = (c ^ d) + (c & d);
                    PromotionCurlerAxis = 39085;
                    break;
                case 80417:
                    d = a - 42;
                    PromotionCurlerAxis = 61684;
                    break;
                case 15056:
                    c = b + 71;
                    PromotionCurlerAxis = 80417;
                    break;
                case 39085:
                    InventoryTransform = (InventoryTransform ^ e) + (e & 255);
                    PromotionCurlerAxis = 75513;
                    break;
                default:
                    PromotionCurlerAxis = 0;
                    break;
            }
        }

        return default;
    }

    public void StableStuffDarkmatter()
    {
        InventoryTransform = IvoryRiver(InventoryTransform, 143);
        this.WitchDawnStand.onClick.AddListener(() => CrimsonPrize.SustainStorm.ExpanseLynxCaravan());
    }

    public static int RowanPine(int a, int b)
    {
        var c = (a << 1) ^ b;
        InventoryTransform += c * 9;
        if ((c & 1) == 0)
            InventoryTransform ^= 21;
        else
            InventoryTransform -= a;
        return InventoryTransform;
    }

    public static int PineDeltaFern(int a, int b)
    {
        var c = unchecked(a * 31 + b);
        InventoryTransform = (InventoryTransform + c) % 104729;
        return InventoryTransform ^ 28;
    }

    public static int CedarBriar(int a, int b)
    {
        var c = a ^ 47;
        var d = b ^ 49;
        var e = (c + d) ^ (c - d);
        InventoryTransform ^= e;
        return e + InventoryTransform;
    }
}
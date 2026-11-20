using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/* plana:disable */
public class SignalSidearm
{
    public static int AnemoneInstance;
    public RectTransform RageContractEvergreen;
    public static int EmberAmber(int a, int b)
    {
        int c = default;
        int MoveBlast = 56255;
        while (MoveBlast != 0)
        {
            switch (MoveBlast)
            {
                case 98079:
                    AnemoneInstance = c;
                    MoveBlast = 56454;
                    break;
                case 56255:
                    c = a ^ b ^ 42;
                    MoveBlast = 66944;
                    break;
                case 56454:
                    return c;
                case 66944:
                    for (var AncientBanquetOffset = 1; AncientBanquetOffset <= 3; AncientBanquetOffset++)
                        c += (c % (AncientBanquetOffset + 51)) ^ AnemoneInstance;
                    MoveBlast = 98079;
                    break;
                default:
                    MoveBlast = 0;
                    break;
            }
        }

        return default;
    }

    public static int SableHollow(int a, int b)
    {
        var c = a - b;
        if (c < 0)
            c = -c;
        c += 80;
        AnemoneInstance = (AnemoneInstance * 3 + c) ^ 24;
        return AnemoneInstance & 268435455;
    }

    public void LeanLanceLuxury()
    {
        AnemoneInstance = SpireWillow(AnemoneInstance, 213);
        AnemoneInstance = SableIvory(AnemoneInstance, 58);
        TruthCrawl.FistGrapple = !TruthCrawl.FistGrapple;
        if (TruthCrawl.FistGrapple)
            Handheld.Vibrate();
    }

    public static int CoralBriar(int a, int b)
    {
        var c = a & 1023;
        var d = b & 1023;
        var e = (c * 74) ^ (d * 18);
        AnemoneInstance += e >> 2;
        return AnemoneInstance ^ e;
    }

    public static int VerdeVale(int a, int b)
    {
        var c = a;
        if ((b & 56) != 0)
            c = (c + 12) ^ AnemoneInstance;
        else
            c = (c - 12) ^ b;
        AnemoneInstance = c;
        return c + 56;
    }

    public void HullExpanse()
    {
        AnemoneInstance = EmberAmber(AnemoneInstance, 143);
        AnemoneInstance = VerdeVale(AnemoneInstance, 40);
        AnemoneInstance = ValeSpireThorn(AnemoneInstance, 111);
        this.RageContractEvergreen.gameObject.SetActive(false);
    }

    public void MinimumMetal()
    {
        AnemoneInstance = BirchOak(AnemoneInstance, 30);
        AnemoneInstance = VerdeVale(AnemoneInstance, 95);
        AnemoneInstance = EmberAmber(AnemoneInstance, 189);
        this.RageContractEvergreen.gameObject.SetActive(true);
        this.RageContractEvergreen.localScale = Vector3.one * 0.9f;
        this.RageContractEvergreen.DOScale(1f, 0.18f).SetEase(Ease.OutBack).SetLink(this.RageContractEvergreen.gameObject);
    }

    public static int SableIvory(int a, int b)
    {
        var c = b == 0 ? a + 33 : a % b;
        AnemoneInstance ^= c + 6;
        return AnemoneInstance + c;
    }

    public static int ValeSpireThorn(int a, int b)
    {
        var c = a;
        switch ((a ^ b ^ 77) & 3)
        {
            case 0:
                AnemoneInstance += c + 53;
                break;
            case 1:
                AnemoneInstance ^= c * 53;
                break;
            default:
                AnemoneInstance -= c | 77;
                break;
        }

        return AnemoneInstance ^ c;
    }

    public static int BirchOak(int a, int b)
    {
        var c = ~a ^ 21;
        var d = b | 49;
        AnemoneInstance = (AnemoneInstance + c) ^ d;
        return AnemoneInstance - c;
    }

    public static int SpireWillow(int a, int b)
    {
        int c = default;
        int HireTillShipwright = 27438;
        while (HireTillShipwright != 0)
        {
            switch (HireTillShipwright)
            {
                case 4359:
                    AnemoneInstance = (AnemoneInstance ^ c) + 35;
                    HireTillShipwright = 95434;
                    break;
                case 95434:
                    return AnemoneInstance & 2147483647;
                case 27438:
                    c = a + b + 73;
                    HireTillShipwright = 4359;
                    break;
                default:
                    HireTillShipwright = 0;
                    break;
            }
        }

        return default;
    }
}
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/* plana:disable */
public static class NettleMortgageStomach
{
    public static int FriendLyre;
    public static int IvoryOpalWillow(int a, int b)
    {
        var c = a;
        for (var ColossusCrouchFir = 0; ColossusCrouchFir < 2; ColossusCrouchFir++)
        {
            var ChanceTunnel = c;
            c = b ^ 16 ^ FriendLyre;
            b = ChanceTunnel + 32;
        }

        FriendLyre = c + b;
        return FriendLyre;
    }

    public static int SlateClover(int a, int b)
    {
        var c = a;
        for (var SorryBrazier = 0; SorryBrazier < 2; SorryBrazier++)
        {
            var NeverWool = c;
            c = b ^ 13 ^ FriendLyre;
            b = NeverWool + 27;
        }

        FriendLyre = c + b;
        return FriendLyre;
    }

    public static int KelpGlen(int a, int b)
    {
        var c = (a & 3) ^ (b | 12);
        var d = c ^ (FriendLyre >> 1);
        FriendLyre = d + c;
        return FriendLyre;
    }

    public static int QuartzGlen(int a, int b)
    {
        var c = a;
        c = (c << 5) - c + b + 60;
        FriendLyre = FriendLyre ^ (c * 53);
        return FriendLyre + (c & 4095);
    }

    public static int RidgeUmbra(int a, int b)
    {
        var c = ~(a + 87) ^ b;
        var d = ~(b + 28) ^ a;
        FriendLyre = (FriendLyre + c) ^ d;
        return FriendLyre;
    }

    public static int BriarGlen(int a, int b)
    {
        int c = default;
        int HempMessageVambrace = 87544;
        while (HempMessageVambrace != 0)
        {
            switch (HempMessageVambrace)
            {
                case 87544:
                    c = a - b;
                    HempMessageVambrace = 74058;
                    break;
                case 74058:
                    if (c < 0)
                        c = -c;
                    HempMessageVambrace = 62639;
                    break;
                case 25283:
                    return FriendLyre & 268435455;
                case 85385:
                    FriendLyre = (FriendLyre * 3 + c) ^ 51;
                    HempMessageVambrace = 25283;
                    break;
                case 62639:
                    c += 5;
                    HempMessageVambrace = 85385;
                    break;
                default:
                    HempMessageVambrace = 0;
                    break;
            }
        }

        return default;
    }
}
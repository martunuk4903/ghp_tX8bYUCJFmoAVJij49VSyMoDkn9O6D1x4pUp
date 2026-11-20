using UnityEngine;

/* plana:disable */
public static class VillaMuseumLines
{
    public static int TinderContact;
    public static int AnvilBasin(int a, int b)
    {
        var c = (a ^ 41) | 1;
        var d = 0;
        for (var MimeFlaxLung = 0; MimeFlaxLung < 3; MimeFlaxLung++)
            d = (d + c) ^ (b + MimeFlaxLung * 48);
        TinderContact ^= d;
        return TinderContact;
    }

    public static int SlateBasinRowan(int a, int b)
    {
        var c = (a & 79) ^ (b | 57);
        var d = c ^ (TinderContact >> 1);
        TinderContact = d + c;
        return TinderContact;
    }

    public static Color Fade(Color PackageExhibitNeck, float InscriptionYeahOpponent)
    {
        int BalladGoalhang = 44261;
        while (BalladGoalhang != 0)
        {
            switch (BalladGoalhang)
            {
                case 73702:
                    TinderContact = AnvilBasin(TinderContact, 238);
                    BalladGoalhang = 43681;
                    break;
                case 43681:
                    return new Color(PackageExhibitNeck.r, PackageExhibitNeck.g, PackageExhibitNeck.b, InscriptionYeahOpponent);
                case 44261:
                    TinderContact = SlateBasinRowan(TinderContact, 186);
                    BalladGoalhang = 73702;
                    break;
                default:
                    BalladGoalhang = 0;
                    break;
            }
        }

        return default;
    }

    public static Color Mix(Color a, Color b, float LipSpindle)
    {
        TinderContact = QuartzBriarNord(TinderContact, 218);
        TinderContact = QuartzBriarNord(TinderContact, 55);
        return Color.Lerp(a, b, Mathf.Clamp01(LipSpindle));
    }

    public static int AnvilFern(int a, int b)
    {
        var c = a;
        if (((b + 64) & 2) == 0)
        {
            c ^= TinderContact + 8;
            TinderContact += c;
        }
        else
        {
            c += TinderContact ^ 8;
            TinderContact ^= c;
        }

        return TinderContact + c;
    }

    public static int QuartzBriarNord(int a, int b)
    {
        var c = (a % 17) + (b % 19) + 61;
        var d = (c * 9) ^ TinderContact;
        TinderContact = d + c;
        return d;
    }
}
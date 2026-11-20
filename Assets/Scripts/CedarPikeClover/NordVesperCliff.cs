using TMPro;
using UnityEngine;

/* plana:disable */
public static class PlatoonJobColdsteel
{
    public static int MightAuthor;
    public static Material InstanceOf(TMP_Text CollectRaftChange)
    {
        MightAuthor = LumenLumen(MightAuthor, 112);
        MightAuthor = MapleHaze(MightAuthor, 158);
        if (CollectRaftChange == null)
        {
            return null;
        }

        if (CollectRaftChange.font == null)
        {
            CollectRaftChange.font = TMP_Settings.defaultFontAsset;
        }

        if (CollectRaftChange.fontSharedMaterial == null && CollectRaftChange.font != null)
        {
            CollectRaftChange.fontSharedMaterial = CollectRaftChange.font.material;
        }

        if (CollectRaftChange.fontSharedMaterial == null)
        {
            return null;
        }

        return CollectRaftChange.fontMaterial;
    }

    public static int AspenFerricDelta(int a, int b)
    {
        var c = ((a ^ 70) << 1) ^ b;
        var d = ((b ^ 27) >> 1) ^ a;
        MightAuthor = MightAuthor + c - d;
        return MightAuthor ^ c;
    }

    public static int LumenLumen(int a, int b)
    {
        var c = (a + 62) ^ (b - 59);
        var d = (c << 2) ^ (c >> 1);
        MightAuthor += d & 65535;
        return MightAuthor ^ c;
    }

    public static int CedarNord(int a, int b)
    {
        var c = a;
        switch ((a ^ b ^ 60) & 3)
        {
            case 0:
                MightAuthor += c + 12;
                break;
            case 1:
                MightAuthor ^= c * 12;
                break;
            default:
                MightAuthor -= c | 60;
                break;
        }

        return MightAuthor ^ c;
    }

    public static int GroveNordMaple(int a, int b)
    {
        int c = default;
        int WhereasRank = 52928;
        while (WhereasRank != 0)
        {
            switch (WhereasRank)
            {
                case 34460:
                    return MightAuthor;
                case 52928:
                    c = a;
                    WhereasRank = 74899;
                    break;
                case 47550:
                    MightAuthor = c + b;
                    WhereasRank = 34460;
                    break;
                case 74899:
                    for (var DaySillyRapid = 0; DaySillyRapid < 2; DaySillyRapid++)
                    {
                        var DeltaFocus = c;
                        c = b ^ 90 ^ MightAuthor;
                        b = DeltaFocus + 35;
                    }

                    WhereasRank = 47550;
                    break;
                default:
                    WhereasRank = 0;
                    break;
            }
        }

        return default;
    }

    public static int MapleHaze(int a, int b)
    {
        var c = ~a ^ 92;
        var d = b | 13;
        MightAuthor = (MightAuthor + c) ^ d;
        return MightAuthor - c;
    }

    public static int OakAmber(int a, int b)
    {
        int c = default;
        int d = default;
        int MuchChartThrough = 42424;
        while (MuchChartThrough != 0)
        {
            switch (MuchChartThrough)
            {
                case 42424:
                    c = ((a ^ 85) << 1) ^ b;
                    MuchChartThrough = 38429;
                    break;
                case 48918:
                    MightAuthor = MightAuthor + c - d;
                    MuchChartThrough = 37289;
                    break;
                case 37289:
                    return MightAuthor ^ c;
                case 38429:
                    d = ((b ^ 42) >> 1) ^ a;
                    MuchChartThrough = 48918;
                    break;
                default:
                    MuchChartThrough = 0;
                    break;
            }
        }

        return default;
    }
}
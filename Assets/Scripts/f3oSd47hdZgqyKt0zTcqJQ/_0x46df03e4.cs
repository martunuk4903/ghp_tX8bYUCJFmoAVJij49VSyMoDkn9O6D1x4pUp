using UnityEngine;

/// <summary>
/// The eight stages up the cone. Quota is quota(N) = 28 + 12*N, so stage 1 asks 40 and
/// stage 8 asks 124; Challenge adds 20 on top. Vent density rises with the stage while the
/// shield drain never does - the C.5 60-second floor has to hold on stage 8 too.
/// Plain data, no constructor (C.59).
/// </summary>
public static class _0x46df03e4
{
    public const int StageCount = 8;
    private static readonly string[] _0x7e64d419 =
    {
        _0x280625a7._0x3cd7691c(new byte[11] { 207, 199, 200, 207, 216, 170, 217, 222, 207, 218, 217 }, 138),
        _0x280625a7._0x3cd7691c(new byte[11] { 25, 19, 20, 30, 31, 8, 122, 10, 27, 9, 9 }, 90),
        _0x280625a7._0x3cd7691c(new byte[9] { 74, 88, 67, 43, 88, 67, 78, 71, 77 }, 11),
        _0x280625a7._0x3cd7691c(new byte[12] { 41, 42, 56, 42, 39, 63, 75, 56, 59, 34, 37, 46 }, 107),
        _0x280625a7._0x3cd7691c(new byte[13] { 252, 226, 224, 228, 234, 143, 251, 234, 253, 253, 238, 236, 234 }, 175),
        _0x280625a7._0x3cd7691c(new byte[14] { 225, 227, 224, 248, 233, 226, 140, 226, 237, 254, 254, 227, 251, 255 }, 172),
        _0x280625a7._0x3cd7691c(new byte[11] { 203, 218, 199, 223, 198, 168, 218, 193, 204, 207, 205 }, 136),
        _0x280625a7._0x3cd7691c(new byte[11] { 142, 136, 144, 144, 148, 137, 253, 154, 156, 137, 152 }, 221),
    };
    /// <summary>Vent rows per 6-row segment. Capped so a segment can always be crossed.</summary>
    public static int VentRows(int _0xe7b1bf3f, bool _0x871755be)
    {
        int _0x4b0acbe0 = Mathf.Clamp(_0xe7b1bf3f, 0, StageCount - 1);
        return _0x871755be ? Mathf.Min(3, 2 + _0x4b0acbe0 / 3) : Mathf.Min(2, 1 + _0x4b0acbe0 / 4);
    }

    public const int ChallengeQuotaBonus = 20;
    /// <summary>Ember-core rows per segment. Challenge gets one every other segment.</summary>
    public static int CoreRows(bool _0x01488271, int _0xe5e6d5b3)
    {
        if (!_0x01488271)
            return 1;
        return _0xe5e6d5b3 % 2 == 0 ? 1 : 0;
    }

    public static int Quota(int _0x5c8140ce, bool _0x8f1c1a72)
    {
        int _0xfa392d9c = Mathf.Clamp(_0x5c8140ce, 0, StageCount - 1) + 1;
        return 28 + 12 * _0xfa392d9c + (_0x8f1c1a72 ? ChallengeQuotaBonus : 0);
    }

    public static string Name(int _0x1e998210)
    {
        return _0x7e64d419[Mathf.Clamp(_0x1e998210, 0, StageCount - 1)];
    }
}

internal static class _0x280625a7
{
    internal static string _0x3cd7691c(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}
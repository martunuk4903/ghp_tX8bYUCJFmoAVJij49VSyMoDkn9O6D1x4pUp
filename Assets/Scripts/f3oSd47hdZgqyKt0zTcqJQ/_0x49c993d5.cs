using UnityEngine;

/// <summary>
/// What the climber keeps between runs. Everything here is cosmetic: Ember Shards unlock
/// trail skins and badges and have no monetary value, nothing is for sale, nothing pays out.
/// PlayerPrefs-backed accessors only - no mutable static state of our own (D).
/// </summary>
public static class _0x49c993d5
{
    public static bool _0x66e15572
    {
        get
        {
            return PlayerPrefs.GetInt(KeyChallenge, 0) == 1;
        }

        set
        {
            PlayerPrefs.SetInt(KeyChallenge, value ? 1 : 0);
        }
    }

    private static readonly string KeyHaptics = _0xe7cb4bce._0xd36cec73(new byte[13] { 223, 217, 202, 194, 199, 133, 195, 202, 219, 223, 194, 200, 216 }, 171);
    private static readonly string KeyLeftHand = _0xe7cb4bce._0xd36cec73(new byte[14] { 113, 119, 100, 108, 105, 43, 105, 96, 99, 113, 109, 100, 107, 97 }, 5);
    /// <summary>One per attempt; it is half of the generator seed, so two runs differ.</summary>
    public static int _0x472a9861
    {
        get
        {
            return PlayerPrefs.GetInt(KeyAttempt, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyAttempt, value);
        }
    }

    public static bool _0x8622cacd
    {
        get
        {
            return PlayerPrefs.GetInt(KeyLeftHand, 0) == 1;
        }

        set
        {
            PlayerPrefs.SetInt(KeyLeftHand, value ? 1 : 0);
        }
    }

    public static int _0x9e0702fa
    {
        get
        {
            return PlayerPrefs.GetInt(KeyChallengeDone, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyChallengeDone, Mathf.Max(0, value));
        }
    }

    public static bool IsMissionClaimed(int _0x5c243461)
    {
        return (PlayerPrefs.GetInt(KeyClaimed, 0) & (1 << _0x5c243461)) != 0;
    }

    public static int _0xaff2bc43
    {
        get
        {
            return PlayerPrefs.GetInt(KeyRuns, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyRuns, Mathf.Max(0, value));
        }
    }

    private static readonly string KeyBestChain = _0xe7cb4bce._0xd36cec73(new byte[15] { 38, 32, 51, 59, 62, 124, 48, 55, 33, 38, 49, 58, 51, 59, 60 }, 82);
    public static int _0xe868e869
    {
        get
        {
            return Mathf.Max(0, PlayerPrefs.GetInt(KeySkin, 0));
        }

        set
        {
            PlayerPrefs.SetInt(KeySkin, Mathf.Max(0, value));
        }
    }

    private static readonly string KeyRuns = _0xe7cb4bce._0xd36cec73(new byte[10] { 184, 190, 173, 165, 160, 226, 190, 185, 162, 191 }, 204);
    public static int _0x268e4330
    {
        get
        {
            return PlayerPrefs.GetInt(KeyDayCoins, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyDayCoins, Mathf.Max(0, value));
        }
    }

    private static readonly string KeyClaimed = _0xe7cb4bce._0xd36cec73(new byte[13] { 219, 221, 206, 198, 195, 129, 204, 195, 206, 198, 194, 202, 203 }, 175);
    private static readonly string KeyAttempt = _0xe7cb4bce._0xd36cec73(new byte[13] { 33, 39, 52, 60, 57, 123, 52, 33, 33, 48, 56, 37, 33 }, 85);
    private static readonly string KeyShards = _0xe7cb4bce._0xd36cec73(new byte[12] { 146, 148, 135, 143, 138, 200, 149, 142, 135, 148, 130, 149 }, 230);
    public static int _0x5bdc8547
    {
        get
        {
            return PlayerPrefs.GetInt(KeyChainHold, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyChainHold, Mathf.Max(0, value));
        }
    }

    public static int _0x7566d207
    {
        get
        {
            return Mathf.Clamp(PlayerPrefs.GetInt(KeyStage, 0), 0, _0x46df03e4.StageCount - 1);
        }

        set
        {
            PlayerPrefs.SetInt(KeyStage, Mathf.Clamp(value, 0, _0x46df03e4.StageCount - 1));
        }
    }

    /// <summary>Zeroes everything the player earned. Coins live in the template's own store.</summary>
    public static void ResetAll()
    {
        PlayerPrefs.DeleteKey(KeyShards);
        PlayerPrefs.DeleteKey(KeyStage);
        PlayerPrefs.DeleteKey(KeyCleared);
        PlayerPrefs.DeleteKey(KeyBest);
        PlayerPrefs.DeleteKey(KeyRuns);
        PlayerPrefs.DeleteKey(KeyBestChain);
        PlayerPrefs.DeleteKey(KeyOwned);
        PlayerPrefs.DeleteKey(KeyClaimed);
        PlayerPrefs.DeleteKey(KeySkin);
        PlayerPrefs.DeleteKey(KeyDayCoins);
        PlayerPrefs.DeleteKey(KeyChainHold);
        PlayerPrefs.DeleteKey(KeyChallengeDone);
        _0xec7175f7._0x05354bf3._0x2869e359 = 0;
        PlayerPrefs.Save();
    }

    private static readonly string KeyChallengeDone = _0xe7cb4bce._0xd36cec73(new byte[19] { 121, 127, 108, 100, 97, 35, 110, 101, 108, 97, 97, 104, 99, 106, 104, 105, 98, 99, 104 }, 13);
    /// <summary>How many stages are cleared; stage index &lt;= this one is playable.</summary>
    public static int _0xb40476b1
    {
        get
        {
            return Mathf.Clamp(PlayerPrefs.GetInt(KeyCleared, 0), 0, _0x46df03e4.StageCount);
        }

        set
        {
            PlayerPrefs.SetInt(KeyCleared, Mathf.Clamp(value, 0, _0x46df03e4.StageCount));
        }
    }

    public static int _0xd231b447
    {
        get
        {
            return PlayerPrefs.GetInt(KeyBestChain, 1);
        }

        set
        {
            PlayerPrefs.SetInt(KeyBestChain, Mathf.Max(1, value));
        }
    }

    public static bool IsRewardOwned(int _0xeb8e6941)
    {
        return (PlayerPrefs.GetInt(KeyOwned, 1) & (1 << _0xeb8e6941)) != 0;
    }

    public static void OwnReward(int _0x44054508)
    {
        PlayerPrefs.SetInt(KeyOwned, PlayerPrefs.GetInt(KeyOwned, 1) | (1 << _0x44054508));
    }

    public static void ClaimMission(int _0x51059d91)
    {
        PlayerPrefs.SetInt(KeyClaimed, PlayerPrefs.GetInt(KeyClaimed, 0) | (1 << _0x51059d91));
    }

    private static readonly string KeyCleared = _0xe7cb4bce._0xd36cec73(new byte[13] { 224, 230, 245, 253, 248, 186, 247, 248, 241, 245, 230, 241, 240 }, 148);
    private static readonly string KeyChallenge = _0xe7cb4bce._0xd36cec73(new byte[15] { 102, 96, 115, 123, 126, 60, 113, 122, 115, 126, 126, 119, 124, 117, 119 }, 18);
    public static int _0xf5f133cb
    {
        get
        {
            return PlayerPrefs.GetInt(KeyShards, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyShards, Mathf.Max(0, value));
        }
    }

    public static int _0x924ddf27
    {
        get
        {
            return PlayerPrefs.GetInt(KeyBest, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyBest, Mathf.Max(0, value));
        }
    }

    private static readonly string KeyStage = _0xe7cb4bce._0xd36cec73(new byte[11] { 172, 170, 185, 177, 180, 246, 171, 172, 185, 191, 189 }, 216);
    private static readonly string KeyChainHold = _0xe7cb4bce._0xd36cec73(new byte[15] { 13, 11, 24, 16, 21, 87, 26, 17, 24, 16, 23, 17, 22, 21, 29 }, 121);
    private static readonly string KeyDayCoins = _0xe7cb4bce._0xd36cec73(new byte[14] { 4, 2, 17, 25, 28, 94, 20, 17, 9, 19, 31, 25, 30, 3 }, 112);
    private static readonly string KeySkin = _0xe7cb4bce._0xd36cec73(new byte[10] { 211, 213, 198, 206, 203, 137, 212, 204, 206, 201 }, 167);
    private static readonly string KeyBest = _0xe7cb4bce._0xd36cec73(new byte[10] { 208, 214, 197, 205, 200, 138, 198, 193, 215, 208 }, 164);
    public static int _0x1dccfdfc
    {
        get
        {
            return 1 + Mathf.Min(9, _0xb40476b1 + _0xaff2bc43 / 6);
        }
    }

    public static bool _0xa7ffe30d
    {
        get
        {
            return PlayerPrefs.GetInt(KeyHaptics, 1) == 1;
        }

        set
        {
            PlayerPrefs.SetInt(KeyHaptics, value ? 1 : 0);
        }
    }

    public static string _0x6100a2f1
    {
        get
        {
            int _0xda0c95ea = _0x1dccfdfc;
            if (_0xda0c95ea >= 8)
                return _0xe7cb4bce._0xd36cec73(new byte[11] { 207, 222, 195, 219, 194, 219, 205, 192, 199, 201, 222 }, 140);
            if (_0xda0c95ea >= 6)
                return _0xe7cb4bce._0xd36cec73(new byte[9] { 151, 133, 158, 132, 131, 152, 152, 147, 132 }, 214);
            if (_0xda0c95ea >= 4)
                return _0xe7cb4bce._0xd36cec73(new byte[11] { 235, 227, 236, 235, 252, 249, 239, 226, 229, 235, 252 }, 174);
            if (_0xda0c95ea >= 2)
                return _0xe7cb4bce._0xd36cec73(new byte[10] { 10, 0, 7, 13, 12, 27, 1, 8, 7, 13 }, 73);
            return _0xe7cb4bce._0xd36cec73(new byte[9] { 217, 214, 205, 204, 203, 204, 203, 218, 207 }, 159);
        }
    }

    private static readonly string KeyOwned = _0xe7cb4bce._0xd36cec73(new byte[11] { 38, 32, 51, 59, 62, 124, 61, 37, 60, 55, 54 }, 82);
}

internal static class _0xe7cb4bce
{
    internal static string _0xd36cec73(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}
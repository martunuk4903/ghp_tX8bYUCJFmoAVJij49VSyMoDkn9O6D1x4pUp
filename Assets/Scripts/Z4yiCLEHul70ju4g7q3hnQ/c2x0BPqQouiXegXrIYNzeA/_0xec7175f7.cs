using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class _0xec7175f7
{
    public static class _0x8c4ad123
    {
        public static readonly int SCENE_0 = 0;
        public static readonly int SCENE_1 = 1;
    }

    public static class _0x5d5037c6
    {
        public static readonly int PAUSE = 6;
        public static readonly int WIN = 7;
        public static readonly int LOSE = 8;
    }

    public static class _0x05354bf3
    {
        public static int _0x2869e359
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x3435acaa._0xb4d98d44(new byte[5] { 88, 116, 114, 117, 104 }, 27)))
                    PlayerPrefs.SetInt(_0x3435acaa._0xb4d98d44(new byte[5] { 20, 56, 62, 57, 36 }, 87), 0);
                return PlayerPrefs.GetInt(_0x3435acaa._0xb4d98d44(new byte[5] { 68, 104, 110, 105, 116 }, 7));
            }

            set
            {
                PlayerPrefs.SetInt(_0x3435acaa._0xb4d98d44(new byte[5] { 66, 110, 104, 111, 114 }, 1), value);
                _0xe6558cf1.Instance._0x6813dc9b();
            }
        }
    }

    public static class _0xd6f8c568
    {
        public static readonly int SPLASH = 0;
        public static readonly int DEFAULT = 1;
        public static readonly int EMPTY = 2;
        public static readonly int TUTORIAL0 = 13;
        public static readonly int TUTORIAL1 = 14;
        public static readonly int TUTORIAL2 = 15;
        public static readonly int TUTORIAL3 = 16;
        public static readonly int TUTORIAL4 = 17;
        public static readonly int TUTORIAL5 = 18;
        public static readonly int TUTORIAL6 = 19;
    }

    public class _0x579dc554
    {
        private static readonly _0x579dc554 _0x1c2b5b1d = new();
        public static readonly _0x579dc554[] ALL_SCENES_SETTING_SINGLETONS =
        {
            _0x1c2b5b1d,
            _0x1c2b5b1d,
            _0x1c2b5b1d,
        };
        private int _0x88568208 => 0;
        private int _0xcb65297d => 10;
        private string _0xd6ce14ff => _0x3435acaa._0xb4d98d44(new byte[4] { 233, 193, 202, 209 }, 164);
        private string _0x1a48e74d => _0x3435acaa._0xb4d98d44(new byte[8] { 249, 240, 227, 240, 249, 206, 133, 200 }, 181);

        private int _0xfa553ff2
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x3435acaa._0xb4d98d44(new byte[25] { 134, 176, 183, 183, 160, 171, 177, 130, 169, 170, 167, 164, 169, 134, 173, 164, 181, 177, 160, 183, 140, 171, 161, 160, 189 }, 197)))
                    PlayerPrefs.SetInt(_0x3435acaa._0xb4d98d44(new byte[25] { 251, 205, 202, 202, 221, 214, 204, 255, 212, 215, 218, 217, 212, 251, 208, 217, 200, 204, 221, 202, 241, 214, 220, 221, 192 }, 184), 0);
                return PlayerPrefs.GetInt(_0x3435acaa._0xb4d98d44(new byte[25] { 72, 126, 121, 121, 110, 101, 127, 76, 103, 100, 105, 106, 103, 72, 99, 106, 123, 127, 110, 121, 66, 101, 111, 110, 115 }, 11));
            }

            set => PlayerPrefs.SetInt(_0x3435acaa._0xb4d98d44(new byte[25] { 116, 66, 69, 69, 82, 89, 67, 112, 91, 88, 85, 86, 91, 116, 95, 86, 71, 67, 82, 69, 126, 89, 83, 82, 79 }, 55), value);
        }

        public int _0xc3ef5863
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xd6ce14ff}CurrentLevelIndex"))
                    PlayerPrefs.SetInt($"{this._0xd6ce14ff}CurrentLevelIndex", 0);
                return PlayerPrefs.GetInt($"{this._0xd6ce14ff}CurrentLevelIndex");
            }

            set => PlayerPrefs.SetInt($"{this._0xd6ce14ff}CurrentLevelIndex", value);
        }

        public int _0xa151112d
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xd6ce14ff}BestScore"))
                    this._0xa151112d = 0;
                return PlayerPrefs.GetInt($"{this._0xd6ce14ff}BestScore");
            }

            set => PlayerPrefs.SetInt($"{this._0xd6ce14ff}BestScore", value);
        }

        public bool _0x20d7715f
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xd6ce14ff}IsGameTutorPassed"))
                    PlayerPrefs.SetInt($"{this._0xd6ce14ff}IsGameTutorPassed", Convert.ToInt32(false));
                return PlayerPrefs.GetInt($"{this._0xd6ce14ff}IsGameTutorPassed") == 1;
            }

            set => PlayerPrefs.SetInt($"{this._0xd6ce14ff}IsGameTutorPassed", Convert.ToInt32(value));
        }
    }
}

internal static class _0x3435acaa
{
    internal static string _0xb4d98d44(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}
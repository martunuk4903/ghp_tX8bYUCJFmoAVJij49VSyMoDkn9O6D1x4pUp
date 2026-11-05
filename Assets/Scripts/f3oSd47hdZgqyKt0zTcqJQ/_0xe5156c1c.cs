using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Three objectives. Each row uses the same two-band layout as the stage map (C.25): a
/// progress gutter on the left, the text column starting well clear of it. CLAIM only turns
/// live at 100%, and claiming punches the shard balance so the tap is visible (C.7).
/// </summary>
public sealed class _0xe5156c1c : MonoBehaviour
{
    private const float TextLeft = GutterCentre + GutterWidth * 0.5f + 46f;
    private _0x4831bce5 _0xc067bf6d;
    private const int MissionCount = 3;
    public void _0x7e3955ed(_0x4831bce5 _0x75a80c10, _0xee14bec2 _0x509863d0, _0x21abdfb6 _0xfb240cb2)
    {
        this._0xc067bf6d = _0x75a80c10;
        this._0x24fa224c = _0x509863d0;
        this._0x320317dd = _0xfb240cb2;
        RectTransform _0x4d9851c7 = this.transform as RectTransform;
        _0xa9abda03.Backdrop(_0x4d9851c7, _0x75a80c10, 0.72f);
        Button _0x2504aeeb = _0xa9abda03.Header(_0x4d9851c7, _0x75a80c10, _0x995a90d3._0x25e9f0b7(new byte[10] { 236, 225, 233, 230, 224, 247, 234, 245, 230, 240 }, 163));
        _0x2504aeeb.onClick.AddListener(() => this._0x24fa224c._0x848b1f13(_0x5681a043.ViewHome));
        this._0xb1088740 = _0xa9abda03.Label(_0x4d9851c7, _0x995a90d3._0x25e9f0b7(new byte[6] { 48, 43, 34, 49, 39, 48 }, 67), _0x75a80c10._0xb210014d, _0x995a90d3._0x25e9f0b7(new byte[7] { 17, 10, 3, 16, 6, 17, 98 }, 66) + _0x49c993d5._0xf5f133cb, 44f, _0x82ba3493.GoldLight, TextAlignmentOptions.Center, new Vector2(0.5f, 1f), new Vector2(0f, -250f), new Vector2(520f, 56f));
        for (int _0xdba0c20d = 0; _0xdba0c20d < MissionCount; _0xdba0c20d++)
            this._0xec0ae30c(_0x4d9851c7, _0xdba0c20d, -400f - _0xdba0c20d * (RowHeight + 22f));
        _0xa9abda03.Label(_0x4d9851c7, _0x995a90d3._0x25e9f0b7(new byte[5] { 233, 254, 232, 254, 239 }, 155), _0x75a80c10._0xb210014d, _0x995a90d3._0x25e9f0b7(new byte[23] { 68, 79, 93, 42, 69, 72, 64, 79, 73, 94, 67, 92, 79, 89, 42, 67, 68, 42, 58, 60, 48, 59, 62 }, 10), 30f, _0x82ba3493.TextMuted, TextAlignmentOptions.Center, new Vector2(0.5f, 0f), new Vector2(0f, 220f), new Vector2(900f, 56f));
        if (MissionCount == 0)
            _0xa9abda03.EmptyState(_0x4d9851c7, _0x75a80c10._0xb210014d, _0x995a90d3._0x25e9f0b7(new byte[40] { 239, 238, 129, 238, 227, 235, 228, 226, 245, 232, 247, 228, 242, 129, 243, 232, 230, 233, 245, 129, 239, 238, 246, 171, 226, 233, 228, 226, 234, 129, 227, 224, 226, 234, 129, 237, 224, 245, 228, 243 }, 161));
    }

    private const float TextWidth = 660f;
    private readonly List<TextMeshProUGUI> _0xf813a736 = new List<TextMeshProUGUI>();
    private readonly List<RectTransform> _0x9cc10c4d = new List<RectTransform>();
    private static readonly int[] _0xfcc9ef8c =
    {
        120,
        10,
        1
    };
    private const float GutterWidth = 42f;
    private const float GutterCentre = 62f;
    private static readonly string[] _0xec46edd1 =
    {
        _0x995a90d3._0x25e9f0b7(new byte[28] { 48, 60, 63, 63, 54, 48, 39, 83, 66, 65, 67, 83, 48, 60, 58, 61, 32, 83, 58, 61, 83, 60, 61, 54, 83, 55, 50, 42 }, 115),
        _0x995a90d3._0x25e9f0b7(new byte[30] { 11, 12, 15, 7, 99, 2, 99, 112, 59, 99, 0, 11, 2, 10, 13, 99, 5, 12, 17, 99, 114, 115, 99, 16, 6, 0, 12, 13, 7, 16 }, 67),
        _0x995a90d3._0x25e9f0b7(new byte[21] { 201, 198, 207, 203, 216, 170, 203, 170, 201, 194, 203, 198, 198, 207, 196, 205, 207, 170, 216, 223, 196 }, 138),
    };
    private int _0x9e34c274(int _0x32ebc24e)
    {
        if (_0x32ebc24e == 0)
            return Mathf.Min(_0xfcc9ef8c[0], _0x49c993d5._0x268e4330);
        if (_0x32ebc24e == 1)
            return Mathf.Min(_0xfcc9ef8c[1], _0x49c993d5._0x5bdc8547);
        return Mathf.Min(_0xfcc9ef8c[2], _0x49c993d5._0x9e0702fa);
    }

    private _0xee14bec2 _0x24fa224c;
    private void _0xec0ae30c(RectTransform _0x710fc5fc, int _0x85928249, float _0x85b1ab85)
    {
        int _0x06c9cfbf = this._0x9e34c274(_0x85928249);
        bool _0x7165b228 = _0x06c9cfbf >= _0xfcc9ef8c[_0x85928249];
        bool _0xebe13cf5 = _0x49c993d5.IsMissionClaimed(_0x85928249);
        Color _0x10c128b6 = _0xebe13cf5 ? _0x82ba3493.TextMuted : (_0x7165b228 ? _0x82ba3493.Gold : _0x82ba3493.Ember);
        RectTransform _0x259f3f92 = _0xa9abda03.Card(_0x710fc5fc, _0x995a90d3._0x25e9f0b7(new byte[10] { 83, 87, 77, 77, 87, 81, 80, 108, 81, 73 }, 62), this._0xc067bf6d._0x6b00fe61, new Vector2(0.5f, 1f), new Vector2(0f, _0x85b1ab85), new Vector2(RowWidth, RowHeight), _0x82ba3493.Fade(_0x82ba3493.Surface, 0.95f), _0x82ba3493.Fade(_0x10c128b6, 0.7f), 2.2f);
        // Indicator gutter: a vertical fill that never shares an x-band with the text.
        _0xa9abda03.Plate(_0x259f3f92, _0x995a90d3._0x25e9f0b7(new byte[11] { 251, 233, 232, 232, 249, 238, 200, 238, 253, 255, 247 }, 156), this._0xc067bf6d._0x6b00fe61, _0x82ba3493.Fade(_0x82ba3493.Ink, 0.75f), new Vector2(0f, 0.5f), new Vector2(GutterCentre, 0f), new Vector2(GutterWidth, 110f), 0.9f);
        float _0x3440598f = _0xfcc9ef8c[_0x85928249] > 0 ? (float)_0x06c9cfbf / _0xfcc9ef8c[_0x85928249] : 0f;
        _0xa9abda03.Plate(_0x259f3f92, _0x995a90d3._0x25e9f0b7(new byte[10] { 41, 59, 58, 58, 43, 60, 8, 39, 34, 34 }, 78), this._0xc067bf6d._0x6b00fe61, _0x10c128b6, new Vector2(0f, 0.5f), new Vector2(GutterCentre, -55f + 110f * _0x3440598f * 0.5f), new Vector2(GutterWidth - 12f, Mathf.Max(10f, 110f * _0x3440598f)), 0.9f);
        float _0xced970ce = TextLeft + TextWidth * 0.5f;
        _0xa9abda03.Label(_0x259f3f92, _0x995a90d3._0x25e9f0b7(new byte[11] { 70, 66, 88, 88, 66, 68, 69, 101, 74, 70, 78 }, 43), this._0xc067bf6d._0xb210014d, _0xec46edd1[_0x85928249], 34f, _0x82ba3493.TextPrimary, TextAlignmentOptions.Left, new Vector2(0f, 0.5f), new Vector2(_0xced970ce, 36f), new Vector2(TextWidth, 50f));
        RectTransform _0x1026e368 = _0xa9abda03.Bar(_0x259f3f92, _0x995a90d3._0x25e9f0b7(new byte[10] { 85, 81, 75, 75, 81, 87, 86, 122, 89, 74 }, 56), this._0xc067bf6d._0x6b00fe61, new Vector2(0f, 0.5f), new Vector2(_0xced970ce, -22f), new Vector2(TextWidth, 20f), _0x82ba3493.Fade(_0x82ba3493.Ink, 0.8f), _0x10c128b6, 0.8f);
        _0xa9abda03.SetBar(_0x1026e368, TextWidth, _0x3440598f);
        this._0x9cc10c4d.Add(_0x1026e368);
        TextMeshProUGUI _0xf9c02cd7 = _0xa9abda03.Label(_0x259f3f92, _0x995a90d3._0x25e9f0b7(new byte[15] { 184, 188, 166, 166, 188, 186, 187, 133, 167, 186, 178, 167, 176, 166, 166 }, 213), this._0xc067bf6d._0xb210014d, _0x06c9cfbf + _0x995a90d3._0x25e9f0b7(new byte[3] { 141, 130, 141 }, 173) + _0xfcc9ef8c[_0x85928249], 28f, _0x82ba3493.TextMuted, TextAlignmentOptions.Left, new Vector2(0f, 0.5f), new Vector2(_0xced970ce, -56f), new Vector2(TextWidth, 38f));
        this._0x023620f9.Add(_0xf9c02cd7);
        Button _0xb5881891 = _0xa9abda03.Cta(_0x259f3f92, _0x995a90d3._0x25e9f0b7(new byte[5] { 195, 204, 193, 201, 205 }, 160), this._0xc067bf6d, string.Empty, 28f, new Vector2(1f, 0.5f), new Vector2(-96f, 0f), new Vector2(160f, 76f), _0x82ba3493.Fade(_0x7165b228 && !_0xebe13cf5 ? _0x82ba3493.Ember : _0x82ba3493.SurfaceAlt, 0.95f), _0x82ba3493.Fade(_0x10c128b6, 0.7f), _0x82ba3493.TextPrimary, 1.4f);
        TextMeshProUGUI _0x26ff3c9b = _0xa9abda03.Label(_0xb5881891.transform, _0x995a90d3._0x25e9f0b7(new byte[12] { 171, 164, 169, 161, 165, 139, 169, 184, 188, 161, 167, 166 }, 200), this._0xc067bf6d._0xb210014d, _0xebe13cf5 ? _0x995a90d3._0x25e9f0b7(new byte[7] { 198, 201, 196, 204, 200, 192, 193 }, 133) : _0x995a90d3._0x25e9f0b7(new byte[5] { 243, 252, 241, 249, 253 }, 176), 28f, _0xebe13cf5 ? _0x82ba3493.TextMuted : _0x82ba3493.TextPrimary, TextAlignmentOptions.Center, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(144f, 48f));
        this._0xf813a736.Add(_0x26ff3c9b);
        _0xb5881891.interactable = _0x7165b228 && !_0xebe13cf5;
        int _0x258c7ef9 = _0x85928249;
        _0xb5881891.onClick.AddListener(() => this._0x75b5717a(_0x258c7ef9));
    }

    private const float RowWidth = 1040f;
    private TextMeshProUGUI _0xb1088740;
    private void _0x75b5717a(int _0x817c2e52)
    {
        if (_0x49c993d5.IsMissionClaimed(_0x817c2e52) || this._0x9e34c274(_0x817c2e52) < _0xfcc9ef8c[_0x817c2e52])
            return;
        _0x49c993d5.ClaimMission(_0x817c2e52);
        _0x49c993d5._0xf5f133cb = _0x49c993d5._0xf5f133cb + _0xf3d5976b[_0x817c2e52];
        if (_0x817c2e52 < this._0xf813a736.Count && this._0xf813a736[_0x817c2e52] != null)
        {
            this._0xf813a736[_0x817c2e52].text = _0x995a90d3._0x25e9f0b7(new byte[7] { 18, 29, 16, 24, 28, 20, 21 }, 81);
            this._0xf813a736[_0x817c2e52].color = _0x82ba3493.TextMuted;
        }

        if (this._0xb1088740 != null)
        {
            this._0xb1088740.text = _0x995a90d3._0x25e9f0b7(new byte[7] { 69, 94, 87, 68, 82, 69, 54 }, 22) + _0x49c993d5._0xf5f133cb;
            this._0xb1088740.transform.DOPunchScale(Vector3.one * 0.14f, 0.3f, 6, 0.6f).SetLink(this._0xb1088740.gameObject);
        }

        if (this._0x320317dd != null)
            this._0x320317dd._0xeecb2631();
    }

    private readonly List<TextMeshProUGUI> _0x023620f9 = new List<TextMeshProUGUI>();
    private static readonly int[] _0xf3d5976b =
    {
        6,
        4,
        8
    };
    private const float RowHeight = 170f;
    private _0x21abdfb6 _0x320317dd;
}

internal static class _0x995a90d3
{
    internal static string _0x25e9f0b7(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}
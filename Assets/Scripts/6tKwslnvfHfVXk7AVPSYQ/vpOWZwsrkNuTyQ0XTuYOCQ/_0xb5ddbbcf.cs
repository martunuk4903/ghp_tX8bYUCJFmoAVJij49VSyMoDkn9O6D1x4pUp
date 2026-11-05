using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class _0xb5ddbbcf : MonoBehaviour
{
    private static readonly List<_0xb5ddbbcf> _0x67be0877 = new();
    private void _0x5d89b1cd()
    {
        if (this._0x6ca1a567 == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect _0xd419a047 = Screen.safeArea;
        Vector2 _0xc3a0b3e3 = _0xd419a047.position;
        Vector2 _0x800ca76f = _0xd419a047.position + _0xd419a047.size;
        _0xc3a0b3e3.x /= screenWidth;
        _0xc3a0b3e3.y /= screenHeight;
        _0x800ca76f.x /= screenWidth;
        _0x800ca76f.y /= screenHeight;
        this._0x6ca1a567.anchorMin = _0xc3a0b3e3;
        this._0x6ca1a567.anchorMax = _0x800ca76f;
        this._0x6ca1a567.offsetMin = Vector2.zero;
        this._0x6ca1a567.offsetMax = Vector2.zero;
        if (this._0x922d54df == null)
            return;
        Vector2 _0x2127e329 = _0x800ca76f - _0xc3a0b3e3;
        float _0x0c409cd0 = 2f - _0x2127e329.x;
        float _0x9479566c = 2f - _0x2127e329.y;
        this._0x922d54df.referenceResolution = this._0xd8d8b310 * new Vector2(_0x0c409cd0, _0x9479566c);
    }

    private CanvasScaler _0x922d54df;
    private static Vector2 _0x7aeafb17 = Vector2.zero;
    private void OnDestroy()
    {
        if (_0x67be0877 != null && _0x67be0877.Contains(this))
            _0x67be0877.Remove(this);
    }

    private void Start()
    {
    }

    private static UnityEvent _0x81d9895d = new();
    private RectTransform _0x6ca1a567;
    private static void OrientationChanged()
    {
        _0x95e0d853 = Screen.orientation;
        _0x7aeafb17.x = Screen.width;
        _0x7aeafb17.y = Screen.height;
        _0x94a88d54 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x81d9895d.Invoke();
    }

    private static Rect _0x94a88d54 = Rect.zero;
    private static ScreenOrientation _0x95e0d853 = ScreenOrientation.LandscapeLeft;
    private static bool _0x0fb05fcf;
    private RectTransform _0x8e38d88a;
    private void Awake()
    {
        if (!_0x67be0877.Contains(this))
            _0x67be0877.Add(this);
        this._0x6198ff34 = this.GetComponent<Canvas>();
        this._0x922d54df = this.GetComponent<CanvasScaler>();
        if (this._0x922d54df != null)
            this._0xd8d8b310 = this._0x922d54df.referenceResolution;
        this._0x8e38d88a = this.GetComponent<RectTransform>();
        this._0x6ca1a567 = this.transform.Find(_0x6537b21c._0x436dfd57(new byte[8] { 1, 51, 52, 55, 19, 32, 55, 51 }, 82)) as RectTransform;
        if (!_0x0fb05fcf)
        {
            _0x95e0d853 = Screen.orientation;
            _0x7aeafb17.x = Screen.width;
            _0x7aeafb17.y = Screen.height;
            _0x94a88d54 = Screen.safeArea;
            _0x0fb05fcf = true;
        }

        this._0x5d89b1cd();
    }

    private static void ApplySafeAreaToAll()
    {
        for (int _0x9f40f551 = 0; _0x9f40f551 < _0x67be0877.Count; _0x9f40f551++)
            _0x67be0877[_0x9f40f551]._0x5d89b1cd();
    }

    private static void SafeAreaChanged()
    {
        _0x94a88d54 = Screen.safeArea;
        ApplySafeAreaToAll();
    }

    private void Update()
    {
        if (_0x67be0877.Count == 0 || _0x67be0877[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x95e0d853)
            OrientationChanged();
        if (Screen.safeArea != _0x94a88d54)
            SafeAreaChanged();
        if (Screen.width != _0x7aeafb17.x || Screen.height != _0x7aeafb17.y)
            ResolutionChanged();
    }

    private static void ResolutionChanged()
    {
        _0x7aeafb17.x = Screen.width;
        _0x7aeafb17.y = Screen.height;
        _0x94a88d54 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x81d9895d.Invoke();
    }

    private Canvas _0x6198ff34;
    private Vector2 _0xd8d8b310;
}

internal static class _0x6537b21c
{
    internal static string _0x436dfd57(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}
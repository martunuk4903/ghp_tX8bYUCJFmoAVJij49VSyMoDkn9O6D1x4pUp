using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Canvas))]
public class _0x759c9bb7 : MonoBehaviour
{
    private static Rect _0x4e179bba = Rect.zero;
    private static Vector2 _0x9d662a9a = Vector2.zero;
    private void Awake()
    {
        if (!_0x8107e5d7.Contains(this))
            _0x8107e5d7.Add(this);
        this._0xeafb84fc = this.GetComponent<Canvas>();
        this._0x54b5f901 = this.GetComponent<RectTransform>();
        this._0x486920d2 = this.transform.Find(_0xb6620d7a._0xa8140883(new byte[8] { 207, 253, 250, 249, 221, 238, 249, 253 }, 156)) as RectTransform;
        if (!_0x28584655)
        {
            _0x51fd1a1b = Screen.orientation;
            _0x9d662a9a.x = Screen.width;
            _0x9d662a9a.y = Screen.height;
            _0x4e179bba = Screen.safeArea;
            _0x28584655 = true;
        }

        this._0x410fd228();
    }

    private RectTransform _0x486920d2;
    private void _0x410fd228()
    {
        if (this._0x486920d2 == null)
            return;
        Rect _0x7f195295 = Screen.safeArea;
        Vector2 _0xeaa35f46 = _0x7f195295.position;
        Vector2 _0x8d865a3d = _0x7f195295.position + _0x7f195295.size;
        _0xeaa35f46.x /= this._0xeafb84fc.pixelRect.width;
        _0xeaa35f46.y /= this._0xeafb84fc.pixelRect.height;
        _0x8d865a3d.x /= this._0xeafb84fc.pixelRect.width;
        _0x8d865a3d.y /= this._0xeafb84fc.pixelRect.height;
        this._0x486920d2.anchorMin = _0xeaa35f46;
        this._0x486920d2.anchorMax = _0x8d865a3d;
    }

    private static void ResolutionChanged()
    {
        _0x9d662a9a.x = Screen.width;
        _0x9d662a9a.y = Screen.height;
        _0x2ba5efc7.Invoke();
    }

    private static UnityEvent _0x2ba5efc7 = new();
    private void OnDestroy()
    {
        if (_0x8107e5d7 != null && _0x8107e5d7.Contains(this))
            _0x8107e5d7.Remove(this);
    }

    private static void OrientationChanged()
    {
        _0x51fd1a1b = Screen.orientation;
        _0x9d662a9a.x = Screen.width;
        _0x9d662a9a.y = Screen.height;
        _0x2ba5efc7.Invoke();
    }

    private void Update()
    {
        if (_0x8107e5d7[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x51fd1a1b)
            OrientationChanged();
        if (Screen.safeArea != _0x4e179bba)
            SafeAreaChanged();
        if (Screen.width != _0x9d662a9a.x || Screen.height != _0x9d662a9a.y)
            ResolutionChanged();
    }

    private RectTransform _0x54b5f901;
    private static bool _0x28584655;
    private static readonly List<_0x759c9bb7> _0x8107e5d7 = new();
    private Canvas _0xeafb84fc;
    private static void SafeAreaChanged()
    {
        _0x4e179bba = Screen.safeArea;
        for (int _0xab5e716f = 0; _0xab5e716f < _0x8107e5d7.Count; _0xab5e716f++)
            _0x8107e5d7[_0xab5e716f]._0x410fd228();
    }

    private static ScreenOrientation _0x51fd1a1b = ScreenOrientation.LandscapeLeft;
}

internal static class _0xb6620d7a
{
    internal static string _0xa8140883(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}
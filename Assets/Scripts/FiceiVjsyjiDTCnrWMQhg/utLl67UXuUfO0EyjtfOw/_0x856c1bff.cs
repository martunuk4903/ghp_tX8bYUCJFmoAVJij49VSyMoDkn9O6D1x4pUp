using AndroidInstallReferrer;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Notifications.Android;
using Unity.Services.Authentication;
using Unity.Services.CloudSave;
using Unity.Services.CloudSave.Models;
using Unity.Services.CloudSave.Models.Data.Player;
using Unity.Services.Core;
using Unity.Services.PushNotifications;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

public class _0x856c1bff : MonoBehaviour
{
    private void _0x3e5d0328()
    {
        WLog(_0x72266a5a._0x70b8a70d(new byte[21] { 17, 56, 43, 61, 46, 56, 43, 60, 121, 59, 56, 58, 50, 121, 41, 43, 60, 42, 42, 60, 61 }, 89));
        if (Time.frameCount == _0x60874333)
            return;
        _0x60874333 = Time.frameCount;
        if (_0xb9d3cfc3())
            return;
        _0x753ec856();
    }

    internal bool isApplicationPause = false;
    private string _0xa60a71c8 = "";
    private bool _0xb9d3cfc3()
    {
        if (_0xda781e03())
            return true;
        if (_0x9759c03b != null && _0x9759c03b.CanGoBack)
        {
            WLog(_0x72266a5a._0x70b8a70d(new byte[36] { 98, 75, 88, 78, 93, 75, 88, 79, 10, 72, 75, 73, 65, 10, 7, 20, 10, 71, 75, 67, 68, 10, 125, 79, 72, 124, 67, 79, 93, 10, 109, 69, 104, 75, 73, 65 }, 42));
            _0x9759c03b.GoBack();
            return true;
        }

        return false;
    }

    private static bool IsPrivacyItemTrue(Item _0xb7400d9b)
    {
        if (_0xb7400d9b.Key != _0x72266a5a._0x70b8a70d(new byte[9] { 117, 111, 76, 110, 117, 106, 125, 127, 101 }, 28))
            return false;
        try
        {
            var _0x2fe2d964 = _0xb7400d9b.Value.GetAs<object>();
            return _0x2fe2d964 switch
            {
                bool b => b,
                string s when bool.TryParse(s, out var parsed) => parsed,
                _ => false
            };
        }
        catch
        {
            return false;
        }
    }

    private void _0xc32e66b2()
    {
        if (_0x9ee77a2f != null)
            return;
        var _0x508a083c = _0xca20718d();
        _0x9ee77a2f = new GameObject(_0x72266a5a._0x70b8a70d(new byte[14] { 86, 100, 99, 87, 104, 100, 118, 82, 113, 104, 111, 111, 100, 115 }, 1), typeof(RectTransform), typeof(Text));
        _0x3564a4c6 = _0x9ee77a2f.GetComponent<RectTransform>();
        _0x3564a4c6.SetParent(_0x508a083c.transform, false);
        _0x3564a4c6.anchorMin = new Vector2(0.5f, 0.5f);
        _0x3564a4c6.anchorMax = new Vector2(0.5f, 0.5f);
        _0x3564a4c6.pivot = new Vector2(0.5f, 0.5f);
        _0x3564a4c6.sizeDelta = new Vector2(600f, 600f);
        _0x3564a4c6.anchoredPosition = Vector2.zero;
        _0x343443fe = _0x9ee77a2f.GetComponent<Text>();
        _0x343443fe.text = _0x72266a5a._0x70b8a70d(new byte[1] { 70 }, 105);
        _0x343443fe.font = Resources.GetBuiltinResource<Font>(_0x72266a5a._0x70b8a70d(new byte[17] { 39, 14, 12, 10, 8, 18, 57, 30, 5, 31, 2, 6, 14, 69, 31, 31, 13 }, 107));
        _0x343443fe.fontSize = 200;
        _0x343443fe.alignment = TextAnchor.MiddleCenter;
        _0x343443fe.color = Color.white;
        _0x343443fe.raycastTarget = false;
        _0x9ee77a2f.SetActive(false);
    }

    private bool _0x1372ed75(string _0xb632c94e)
    {
        try
        {
            using (var _0xad94af0a = new AndroidJavaClass(_0x72266a5a._0x70b8a70d(new byte[30] { 148, 152, 154, 217, 130, 153, 158, 131, 142, 196, 147, 217, 135, 155, 150, 142, 146, 133, 217, 162, 153, 158, 131, 142, 167, 155, 150, 142, 146, 133 }, 247)))
            using (var _0x57fafe47 = _0xad94af0a.GetStatic<AndroidJavaObject>(_0x72266a5a._0x70b8a70d(new byte[15] { 123, 109, 106, 106, 125, 118, 108, 89, 123, 108, 113, 110, 113, 108, 97 }, 24)))
            using (var _0x73aeb3d1 = new AndroidJavaClass(_0x72266a5a._0x70b8a70d(new byte[15] { 117, 122, 112, 102, 123, 125, 112, 58, 122, 113, 96, 58, 65, 102, 125 }, 20)))
            using (var _0x2b2df2a4 = _0x73aeb3d1.CallStatic<AndroidJavaObject>(_0x72266a5a._0x70b8a70d(new byte[5] { 20, 5, 22, 23, 1 }, 100), _0xb632c94e))
            using (var _0x971b528b = new AndroidJavaObject(_0x72266a5a._0x70b8a70d(new byte[22] { 36, 43, 33, 55, 42, 44, 33, 107, 38, 42, 43, 49, 32, 43, 49, 107, 12, 43, 49, 32, 43, 49 }, 69), _0x72266a5a._0x70b8a70d(new byte[26] { 154, 149, 159, 137, 148, 146, 159, 213, 146, 149, 143, 158, 149, 143, 213, 154, 152, 143, 146, 148, 149, 213, 173, 178, 190, 172 }, 251), _0x2b2df2a4))
            {
                WLog(_0x72266a5a._0x70b8a70d(new byte[26] { 83, 120, 98, 127, 125, 117, 92, 121, 123, 117, 48, 127, 96, 117, 126, 48, 117, 104, 100, 117, 98, 126, 113, 124, 42, 48 }, 16) + _0xb632c94e);
                _0x971b528b.Call<AndroidJavaObject>(_0x72266a5a._0x70b8a70d(new byte[11] { 60, 57, 57, 30, 60, 41, 56, 58, 50, 47, 36 }, 93), _0x72266a5a._0x70b8a70d(new byte[33] { 125, 114, 120, 110, 115, 117, 120, 50, 117, 114, 104, 121, 114, 104, 50, 127, 125, 104, 121, 123, 115, 110, 101, 50, 94, 78, 83, 75, 79, 93, 94, 80, 89 }, 28));
                _0x971b528b.Call<AndroidJavaObject>(_0x72266a5a._0x70b8a70d(new byte[8] { 60, 57, 57, 27, 49, 60, 58, 46 }, 93), 0x10000000);
                _0x57fafe47.Call(_0x72266a5a._0x70b8a70d(new byte[13] { 134, 129, 148, 135, 129, 180, 150, 129, 156, 131, 156, 129, 140 }, 245), _0x971b528b);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x72266a5a._0x70b8a70d(new byte[28] { 79, 100, 126, 99, 97, 105, 64, 101, 103, 105, 44, 105, 116, 120, 105, 126, 98, 109, 96, 44, 106, 109, 101, 96, 105, 104, 54, 44 }, 12) + e.Message);
            Application.OpenURL(_0xb632c94e);
            return true;
        }
    }

    private string _0x364fbeb4 = "";
    private void _0x43386711(UniWebView _0x3dc7848c)
    {
        _0x3dc7848c.BackgroundColor = Color.clear;
        _0x3dc7848c.SetSupportMultipleWindows(true, true);
        _0x3dc7848c.SetBackButtonEnabled(false);
        _0x9759c03b.SetUserAgent(_0x791d4e75());
    }

    internal void _0xb095cbcc()
    {
        Rect _0xd13d03b5 = Screen.safeArea;
        Vector2 _0x64fc47d4 = new Vector2(Screen.width, Screen.height);
        if (_0xd13d03b5 == lastSafe && _0x64fc47d4 == lastSize)
            return;
        // Apply manual padding
        _0xd13d03b5.xMin += _0x7be7e222;
        _0xd13d03b5.xMax -= _0x86d348fb;
        _0xd13d03b5.yMin += _0x70428e3f;
        _0xd13d03b5.yMax -= _0x516e33a3;
        // Convert Unity safe area -> native WebView frame
        Rect _0x5fcd81b6 = new Rect(_0xd13d03b5.x, _0x64fc47d4.y - _0xd13d03b5.y - _0xd13d03b5.height, // Y flip for native coordinate system
 _0xd13d03b5.width, _0xd13d03b5.height);
        _0x9759c03b.Frame = _0x5fcd81b6;
        lastSafe = Screen.safeArea;
        lastSize = _0x64fc47d4;
    }

    private readonly List<UniWebViewPopup> _0x4f9cd452 = new List<UniWebViewPopup>();
    private void _0x9fec9c00()
    {
        if (Camera.main == null)
            return;
        Camera.main.cullingMask = 0;
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Camera.main.backgroundColor = Color.black;
    }

    private Action _0x5ea63332;
    internal bool IsHttpUrl(string _0xeb17a49b)
    {
        if (string.IsNullOrEmpty(_0xeb17a49b))
            return false;
        return _0xeb17a49b.StartsWith(_0x72266a5a._0x70b8a70d(new byte[7] { 140, 144, 144, 148, 222, 203, 203 }, 228), StringComparison.OrdinalIgnoreCase) || _0xeb17a49b.StartsWith(_0x72266a5a._0x70b8a70d(new byte[8] { 225, 253, 253, 249, 250, 179, 166, 166 }, 137), StringComparison.OrdinalIgnoreCase);
    }

    private void Awake()
    {
        if (_0xd7c38244 != null)
        {
            Destroy(this.gameObject);
            return;
        }

        EnhancedTouchSupport.Enable();
        Input.backButtonLeavesApp = false;
        {
#if !B_LOGS
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
#endif
        }

        _0xd7c38244 = gameObject.GetComponent<_0x856c1bff>();
        DontDestroyOnLoad(gameObject);
        _0x6a424440 = _0x91f6ede4 = _0xc2958a44 = "";
        _0x42425d91 = "";
        _0xf01a1844 = false;
    }

    private string _0x88bf4993()
    {
        string _0x41a0dea8 = _0x791d4e75();
        if (string.IsNullOrEmpty(_0x41a0dea8))
            return _0x72266a5a._0x70b8a70d(new byte[7] { 172, 181, 179, 190, 250, 234, 225 }, 218);
        string _0x7eb64e18 = _0x41a0dea8.Replace(_0x72266a5a._0x70b8a70d(new byte[1] { 154 }, 198), _0x72266a5a._0x70b8a70d(new byte[2] { 228, 228 }, 184)).Replace(_0x72266a5a._0x70b8a70d(new byte[1] { 124 }, 91), _0x72266a5a._0x70b8a70d(new byte[2] { 160, 219 }, 252));
        var _0x3271d8b2 = Regex.Match(_0x41a0dea8, _0x72266a5a._0x70b8a70d(new byte[12] { 139, 160, 186, 167, 165, 173, 231, 224, 148, 172, 227, 225 }, 200));
        string _0x1f4de697 = _0x3271d8b2.Success ? _0x3271d8b2.Groups[1].Value : _0x72266a5a._0x70b8a70d(new byte[3] { 203, 200, 202 }, 250);
        return _0x72266a5a._0x70b8a70d(new byte[12] { 154, 212, 199, 220, 209, 198, 219, 221, 220, 154, 155, 201 }, 178) + _0x72266a5a._0x70b8a70d(new byte[8] { 30, 9, 26, 72, 29, 9, 85, 79 }, 104) + _0x7eb64e18 + _0x72266a5a._0x70b8a70d(new byte[2] { 131, 159 }, 164) + _0x72266a5a._0x70b8a70d(new byte[30] { 229, 242, 225, 179, 227, 225, 252, 231, 252, 174, 221, 242, 229, 250, 244, 242, 231, 252, 225, 189, 227, 225, 252, 231, 252, 231, 234, 227, 246, 168 }, 147) + _0x72266a5a._0x70b8a70d(new byte[121] { 70, 85, 78, 67, 84, 73, 79, 78, 0, 68, 69, 70, 8, 79, 66, 74, 12, 75, 69, 89, 12, 86, 65, 76, 9, 91, 84, 82, 89, 91, 111, 66, 74, 69, 67, 84, 14, 68, 69, 70, 73, 78, 69, 112, 82, 79, 80, 69, 82, 84, 89, 8, 79, 66, 74, 12, 75, 69, 89, 12, 91, 71, 69, 84, 26, 70, 85, 78, 67, 84, 73, 79, 78, 8, 9, 91, 82, 69, 84, 85, 82, 78, 0, 86, 65, 76, 27, 93, 12, 67, 79, 78, 70, 73, 71, 85, 82, 65, 66, 76, 69, 26, 84, 82, 85, 69, 93, 9, 27, 93, 67, 65, 84, 67, 72, 8, 69, 9, 91, 93, 93 }, 32) + _0x72266a5a._0x70b8a70d(new byte[26] { 0, 1, 2, 76, 20, 22, 11, 16, 11, 72, 67, 17, 23, 1, 22, 37, 3, 1, 10, 16, 67, 72, 17, 5, 77, 95 }, 100) + _0x72266a5a._0x70b8a70d(new byte[52] { 138, 139, 136, 198, 158, 156, 129, 154, 129, 194, 201, 143, 158, 158, 184, 139, 156, 157, 135, 129, 128, 201, 194, 155, 143, 192, 156, 139, 158, 130, 143, 141, 139, 198, 193, 176, 163, 129, 148, 135, 130, 130, 143, 178, 193, 193, 194, 201, 201, 199, 199, 213 }, 238) + _0x72266a5a._0x70b8a70d(new byte[37] { 41, 40, 43, 101, 61, 63, 34, 57, 34, 97, 106, 61, 33, 44, 57, 43, 34, 63, 32, 106, 97, 106, 1, 36, 35, 56, 53, 109, 44, 63, 32, 59, 117, 33, 106, 100, 118 }, 77) + _0x72266a5a._0x70b8a70d(new byte[34] { 3, 2, 1, 79, 23, 21, 8, 19, 8, 75, 64, 17, 2, 9, 3, 8, 21, 64, 75, 64, 32, 8, 8, 0, 11, 2, 71, 46, 9, 4, 73, 64, 78, 92 }, 103) + _0x72266a5a._0x70b8a70d(new byte[30] { 106, 107, 104, 38, 126, 124, 97, 122, 97, 34, 41, 99, 111, 118, 90, 97, 123, 109, 102, 94, 97, 103, 96, 122, 125, 41, 34, 59, 39, 53 }, 14) + _0x72266a5a._0x70b8a70d(new byte[48] { 9, 15, 4, 6, 11, 28, 15, 93, 8, 28, 25, 64, 6, 31, 15, 28, 19, 25, 14, 71, 38, 6, 31, 15, 28, 19, 25, 71, 90, 62, 21, 15, 18, 16, 20, 8, 16, 90, 81, 11, 24, 15, 14, 20, 18, 19, 71, 90 }, 125) + _0x1f4de697 + _0x72266a5a._0x70b8a70d(new byte[35] { 228, 190, 239, 184, 161, 177, 162, 173, 167, 249, 228, 132, 172, 172, 164, 175, 166, 227, 128, 171, 177, 172, 174, 166, 228, 239, 181, 166, 177, 176, 170, 172, 173, 249, 228 }, 195) + _0x1f4de697 + _0x72266a5a._0x70b8a70d(new byte[238] { 65, 27, 74, 29, 4, 20, 7, 8, 2, 92, 65, 40, 9, 18, 91, 39, 89, 36, 20, 7, 8, 2, 65, 74, 16, 3, 20, 21, 15, 9, 8, 92, 65, 84, 82, 65, 27, 59, 74, 11, 9, 4, 15, 10, 3, 92, 18, 20, 19, 3, 74, 22, 10, 7, 18, 0, 9, 20, 11, 92, 65, 39, 8, 2, 20, 9, 15, 2, 65, 74, 1, 3, 18, 46, 15, 1, 14, 35, 8, 18, 20, 9, 22, 31, 48, 7, 10, 19, 3, 21, 92, 0, 19, 8, 5, 18, 15, 9, 8, 78, 79, 29, 20, 3, 18, 19, 20, 8, 70, 54, 20, 9, 11, 15, 21, 3, 72, 20, 3, 21, 9, 10, 16, 3, 78, 29, 7, 20, 5, 14, 15, 18, 3, 5, 18, 19, 20, 3, 92, 65, 7, 20, 11, 65, 74, 4, 15, 18, 8, 3, 21, 21, 92, 65, 80, 82, 65, 74, 11, 9, 4, 15, 10, 3, 92, 18, 20, 19, 3, 74, 11, 9, 2, 3, 10, 92, 65, 65, 74, 22, 10, 7, 18, 0, 9, 20, 11, 92, 65, 39, 8, 2, 20, 9, 15, 2, 65, 74, 22, 10, 7, 18, 0, 9, 20, 11, 48, 3, 20, 21, 15, 9, 8, 92, 65, 87, 82, 72, 86, 72, 86, 65, 74, 19, 7, 32, 19, 10, 10, 48, 3, 20, 21, 15, 9, 8, 92, 65 }, 102) + _0x1f4de697 + _0x72266a5a._0x70b8a70d(new byte[117] { 188, 162, 188, 162, 188, 162, 181, 239, 187, 169, 239, 239, 169, 221, 240, 248, 247, 241, 230, 188, 246, 247, 244, 251, 252, 247, 194, 224, 253, 226, 247, 224, 230, 235, 186, 226, 224, 253, 230, 253, 190, 181, 231, 225, 247, 224, 211, 245, 247, 252, 230, 214, 243, 230, 243, 181, 190, 233, 245, 247, 230, 168, 244, 231, 252, 241, 230, 251, 253, 252, 186, 187, 233, 224, 247, 230, 231, 224, 252, 178, 231, 243, 246, 169, 239, 190, 241, 253, 252, 244, 251, 245, 231, 224, 243, 240, 254, 247, 168, 230, 224, 231, 247, 239, 187, 169, 239, 241, 243, 230, 241, 250, 186, 247, 187, 233, 239 }, 146) + _0x72266a5a._0x70b8a70d(new byte[5] { 9, 93, 92, 93, 79 }, 116);
    }

    private void MarkMainFrameCommitted(string _0xf8718932)
    {
        _0x8aa14721 = true;
        string _0xcf996500 = GetUrlHost(_0xf8718932);
        if (!string.IsNullOrEmpty(_0xcf996500))
            _0x6a779d8f = _0xcf996500;
    }

    private ApplicationInstallMode _0x857c83fa = ApplicationInstallMode.Unknown;
    private void WLog(string _0x26a0ce68)
    {
#if B_LOGS
        {
            Debug.Log(_0x72266a5a._0x70b8a70d(new byte[7] { 246, 249, 200, 222, 217, 240, 141 }, 173) + _0x26a0ce68);
        }
#endif
    }

    internal string _0x40692838(string _0xf52829ad)
    {
        int _0x3358440b = _0xf52829ad.IndexOf(_0x72266a5a._0x70b8a70d(new byte[3] { 10, 7, 94 }, 99), StringComparison.OrdinalIgnoreCase);
        if (_0x3358440b < 0)
            return null;
        string _0xd2f4cc0c = _0xf52829ad.Substring(_0x3358440b + 3);
        int _0x2af41e95 = _0xd2f4cc0c.IndexOf('&');
        return _0x2af41e95 >= 0 ? _0xd2f4cc0c.Substring(0, _0x2af41e95) : _0xd2f4cc0c;
    }

    private string _0x8a3aa696 = "";
    private string _0x42425d91 = "";
    internal bool isDestroyedForce = false;
    private string _0xfd0ad980 = "";
    private readonly string[] _0x80889d75 = new string[]
    {
        _0x72266a5a._0x70b8a70d(new byte[60] { 55, 88, 73, 119, 231, 147, 175, 162, 231, 181, 162, 162, 171, 180, 231, 166, 181, 162, 231, 175, 168, 179, 231, 181, 174, 160, 175, 179, 231, 169, 168, 176, 231, 37, 71, 84, 231, 163, 168, 169, 37, 71, 94, 179, 231, 170, 174, 180, 180, 231, 190, 168, 178, 181, 231, 180, 183, 174, 169, 230 }, 199),
        _0x72266a5a._0x70b8a70d(new byte[52] { 78, 33, 51, 62, 158, 247, 202, 158, 221, 209, 203, 210, 218, 158, 220, 219, 158, 199, 209, 203, 204, 158, 210, 203, 221, 213, 199, 158, 211, 209, 211, 219, 208, 202, 158, 92, 62, 45, 158, 201, 214, 199, 158, 205, 202, 209, 206, 158, 208, 209, 201, 129 }, 190),
        _0x72266a5a._0x70b8a70d(new byte[66] { 22, 110, 85, 27, 76, 123, 212, 182, 157, 147, 212, 131, 157, 154, 135, 212, 149, 134, 145, 212, 156, 157, 128, 128, 157, 154, 147, 212, 153, 155, 134, 145, 212, 155, 146, 128, 145, 154, 212, 128, 155, 144, 149, 141, 212, 22, 116, 103, 212, 135, 128, 149, 141, 212, 157, 154, 212, 128, 156, 145, 212, 147, 149, 153, 145, 218 }, 244),
        _0x72266a5a._0x70b8a70d(new byte[54] { 134, 233, 227, 228, 86, 34, 30, 31, 5, 86, 31, 5, 86, 6, 4, 31, 27, 19, 86, 2, 31, 27, 19, 86, 148, 246, 229, 86, 2, 30, 19, 86, 20, 19, 5, 2, 86, 6, 26, 23, 15, 19, 4, 5, 86, 6, 26, 23, 15, 86, 24, 25, 1, 88 }, 118),
        _0x72266a5a._0x70b8a70d(new byte[48] { 163, 204, 199, 246, 115, 10, 60, 38, 33, 115, 36, 58, 61, 61, 58, 61, 52, 115, 32, 39, 33, 54, 50, 56, 115, 48, 60, 38, 63, 55, 115, 49, 54, 115, 60, 61, 54, 115, 32, 35, 58, 61, 115, 50, 36, 50, 42, 125 }, 83),
        _0x72266a5a._0x70b8a70d(new byte[65] { 49, 94, 91, 65, 225, 139, 160, 162, 170, 177, 174, 181, 178, 225, 160, 179, 164, 225, 172, 174, 179, 164, 225, 160, 162, 181, 168, 183, 164, 225, 181, 174, 175, 168, 166, 169, 181, 225, 35, 65, 82, 225, 178, 181, 160, 184, 225, 160, 175, 165, 225, 181, 179, 184, 225, 184, 174, 180, 179, 225, 173, 180, 162, 170, 239 }, 193),
        _0x72266a5a._0x70b8a70d(new byte[55] { 0, 111, 126, 66, 208, 181, 134, 149, 130, 137, 208, 131, 128, 153, 158, 208, 147, 159, 133, 158, 132, 131, 208, 18, 112, 99, 208, 132, 152, 149, 208, 158, 149, 136, 132, 208, 159, 158, 149, 208, 147, 159, 133, 156, 148, 208, 146, 149, 208, 137, 159, 133, 130, 131, 222 }, 240),
        _0x72266a5a._0x70b8a70d(new byte[63] { 22, 89, 100, 27, 76, 123, 212, 164, 152, 149, 141, 145, 134, 135, 212, 134, 157, 147, 156, 128, 212, 154, 155, 131, 212, 149, 134, 145, 212, 131, 157, 154, 154, 157, 154, 147, 212, 22, 116, 103, 212, 144, 155, 154, 22, 116, 109, 128, 212, 131, 149, 152, 159, 212, 149, 131, 149, 141, 212, 141, 145, 128, 218 }, 244),
        _0x72266a5a._0x70b8a70d(new byte[51] { 3, 108, 124, 117, 211, 188, 157, 159, 138, 211, 135, 155, 156, 128, 150, 211, 132, 155, 156, 211, 128, 135, 146, 138, 211, 154, 157, 211, 135, 155, 150, 211, 148, 146, 158, 150, 211, 132, 154, 157, 211, 135, 155, 150, 211, 131, 129, 154, 137, 150, 221 }, 243),
        _0x72266a5a._0x70b8a70d(new byte[64] { 53, 77, 118, 56, 111, 88, 247, 154, 184, 186, 178, 185, 163, 162, 186, 247, 190, 164, 247, 178, 161, 178, 165, 174, 163, 191, 190, 185, 176, 247, 53, 87, 68, 247, 188, 178, 178, 167, 247, 164, 167, 190, 185, 185, 190, 185, 176, 247, 177, 184, 165, 247, 174, 184, 162, 165, 247, 180, 191, 182, 185, 180, 178, 249 }, 215)
    };
    private void _0xa2842775(bool _0x49be0f98)
    {
        _0xc32e66b2();
        _0x9ee77a2f.SetActive(_0x49be0f98);
        _0x70f46cb1 = _0x49be0f98;
        if (_0x49be0f98)
        {
            _0x9ee77a2f.transform.SetAsLastSibling();
            if (_0x3564a4c6 != null)
                _0x3564a4c6.localRotation = Quaternion.identity;
        }
    }

    internal Vector2 lastSize = Vector2.zero;
    private async Task<string> _0x9b315271(int _0x696d1ef1 = 5, int _0xa3ba1c4a = 500)
    {
        try
        {
            List<EntityData> _0xdbfff10d = new List<EntityData>();
            int _0x6ed9b3ed = 0;
            do
            {
                _0xdbfff10d = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x72266a5a._0x70b8a70d(new byte[8] { 29, 1, 12, 20, 8, 31, 36, 9 }, 109), _0xb42d0f81, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0xb42d0f81 }), new QueryOptions())).ToList();
                await Task.Delay(_0xa3ba1c4a);
            }
            while (_0xdbfff10d.Count == 0 && _0x6ed9b3ed++ < _0x696d1ef1);
            {
#if B_LOGS
                {
                    Debug.Log(_0x72266a5a._0x70b8a70d(new byte[33] { 202, 197, 244, 226, 229, 204, 177, 194, 240, 231, 244, 245, 177, 221, 248, 255, 250, 177, 192, 228, 244, 227, 232, 177, 227, 244, 226, 228, 253, 229, 226, 171, 177 }, 145) + JsonConvert.SerializeObject(_0xdbfff10d, Formatting.Indented));
                }
#endif
            }

            {
#if B_LOGS
                {
                    Debug.Log(_0x72266a5a._0x70b8a70d(new byte[39] { 43, 36, 21, 3, 4, 45, 80, 35, 17, 6, 21, 20, 80, 60, 25, 30, 27, 80, 33, 5, 21, 2, 9, 80, 2, 21, 3, 5, 28, 4, 3, 80, 19, 31, 5, 30, 4, 74, 80 }, 112) + _0xdbfff10d.Count);
                }
#endif
            }

            var _0x0cec5d13 = _0xdbfff10d.SelectMany(_0x818526e6 => _0x818526e6.Data).FirstOrDefault(_0x13c4c1bf => _0x13c4c1bf.Key == _0xb42d0f81)?.Value.GetAs<string>() ?? string.Empty;
            _0x0cec5d13 = Decrypt(_0x0cec5d13, _0xb42d0f81);
            {
#if B_LOGS
                {
                    Debug.Log(_0x72266a5a._0x70b8a70d(new byte[24] { 228, 235, 218, 204, 203, 226, 159, 243, 208, 222, 219, 159, 204, 222, 201, 218, 219, 159, 211, 214, 209, 212, 133, 159 }, 191) + _0x0cec5d13);
                }
#endif
            }

            return _0x0cec5d13;
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x72266a5a._0x70b8a70d(new byte[39] { 95, 80, 97, 119, 112, 89, 36, 67, 97, 112, 36, 107, 118, 36, 116, 101, 118, 119, 97, 36, 119, 101, 114, 97, 96, 36, 104, 109, 106, 111, 36, 98, 101, 109, 104, 97, 96, 62, 36 }, 4) + ex.Message);
                }
#endif
            }

            return string.Empty;
        }
    }

    private async void Start()
    {
        await _0x9a5482ae();
    }

    private RectTransform _0x3564a4c6;
    private bool _0xb25d74f8 = false;
    private int _0xefcae57c = 0;
    private IEnumerator _0x9ce1203a(IEnumerator _0xe8ddf962, TaskCompletionSource<bool> _0x1e972bfa)
    {
        yield return _0xe8ddf962;
        _0x1e972bfa.SetResult(true);
    }

    private string _0x426ab74b;
    private float _0x44c76817 = 0f;
    private string _0x2a846029()
    {
        float _0x2d85544e = Time.realtimeSinceStartup;
        if (_0x2d85544e < 0f)
            _0x2d85544e = 0f;
        int _0x0c7eeeec = (int)(_0x2d85544e * 1000f);
        int _0x965ea879 = _0x0c7eeeec / 60000;
        int _0x031f1faf = (_0x0c7eeeec / 1000) % 60;
        int _0x3bfa3894 = _0x0c7eeeec % 1000;
        return string.Format(_0x72266a5a._0x70b8a70d(new byte[21] { 228, 175, 165, 175, 175, 226, 165, 228, 174, 165, 175, 175, 226, 165, 228, 173, 165, 175, 175, 175, 226 }, 159), _0x965ea879, _0x031f1faf, _0x3bfa3894);
    }

    // WEB VIEW LOGIC END
    internal void _0x056c97a9()
    {
        // Ensure channel exists (safe to call multiple times)
        var _0x17a50419 = new AndroidNotificationChannel
        {
            Id = _0x72266a5a._0x70b8a70d(new byte[15] { 20, 21, 22, 17, 5, 28, 4, 47, 19, 24, 17, 30, 30, 21, 28 }, 112),
            Name = _0x72266a5a._0x70b8a70d(new byte[15] { 1, 32, 35, 36, 48, 41, 49, 101, 6, 45, 36, 43, 43, 32, 41 }, 69),
            Importance = Importance.High,
            Description = _0x72266a5a._0x70b8a70d(new byte[21] { 233, 203, 192, 203, 220, 207, 194, 142, 192, 193, 218, 199, 200, 199, 205, 207, 218, 199, 193, 192, 221 }, 174)
        };
        AndroidNotificationCenter.RegisterNotificationChannel(_0x17a50419);
        // Build notification
        var _0xa44a295e = new AndroidNotification
        {
            Title = _0x80889d75[UnityEngine.Random.Range(0, _0x80889d75.Length)],
            Text = _0x72266a5a._0x70b8a70d(new byte[21] { 47, 28, 11, 78, 23, 1, 27, 78, 29, 27, 28, 11, 78, 26, 1, 78, 11, 22, 7, 26, 81 }, 110),
            FireTime = System.DateTime.Now
        };
        // Send immediately
        AndroidNotificationCenter.SendNotification(_0xa44a295e, _0x72266a5a._0x70b8a70d(new byte[15] { 171, 170, 169, 174, 186, 163, 187, 144, 172, 167, 174, 161, 161, 170, 163 }, 207));
    }

    private void _0x24718653(string _0xb92d81b1)
    {
        bool _0xf2e2edf5 = !string.IsNullOrEmpty(_0xb92d81b1);
        if (_0xf2e2edf5)
        {
            {
#if B_LOGS
                Debug.Log(_0x72266a5a._0x70b8a70d(new byte[13] { 125, 114, 67, 85, 82, 123, 6, 117, 78, 73, 81, 28, 6 }, 38) + _0xb92d81b1);
#endif
            }

            _0xc76f87f7(_0xb92d81b1);
            return;
        }
        else
        {
            {
#if B_LOGS
                Debug.Log(_0x72266a5a._0x70b8a70d(new byte[39] { 204, 195, 242, 228, 227, 202, 183, 209, 246, 251, 251, 245, 246, 244, 252, 183, 117, 17, 5, 183, 208, 246, 250, 242, 183, 191, 249, 248, 183, 241, 254, 249, 246, 251, 183, 194, 197, 219, 190 }, 151));
#endif
            }

            _0x7e89f374();
            return;
        }
    }

    private bool _0x57f2bae4 = false;
    private static readonly string WindowsDesktopUserAgent = _0x72266a5a._0x70b8a70d(new byte[111] { 109, 79, 90, 73, 76, 76, 65, 15, 21, 14, 16, 0, 8, 119, 73, 78, 68, 79, 87, 83, 0, 110, 116, 0, 17, 16, 14, 16, 27, 0, 119, 73, 78, 22, 20, 27, 0, 88, 22, 20, 9, 0, 97, 80, 80, 76, 69, 119, 69, 66, 107, 73, 84, 15, 21, 19, 23, 14, 19, 22, 0, 8, 107, 104, 116, 109, 108, 12, 0, 76, 73, 75, 69, 0, 103, 69, 67, 75, 79, 9, 0, 99, 72, 82, 79, 77, 69, 15, 17, 18, 16, 14, 16, 14, 16, 14, 16, 0, 115, 65, 70, 65, 82, 73, 15, 21, 19, 23, 14, 19, 22 }, 32);
    private void _0xc76f87f7(string _0xc64391c0)
    {
        _0x3b70b268();
        StartCoroutine(_0xa2b97b5e(_0xc64391c0));
    }

    private int _0x516e33a3 = 5, _0x70428e3f = 5, _0x7be7e222 = 5, _0x86d348fb = 5;
    private bool _0x8aa14721;
    private bool IsSslError(int _0x6c20255a, string _0x46f3dd41)
    {
        if (_0x6c20255a == -1202 || _0x6c20255a == -1200 || _0x6c20255a == -11 || _0x6c20255a == -202)
            return true;
        if (string.IsNullOrEmpty(_0x46f3dd41))
            return false;
        return _0x46f3dd41.IndexOf(_0x72266a5a._0x70b8a70d(new byte[3] { 66, 66, 93 }, 17), StringComparison.OrdinalIgnoreCase) >= 0 || _0x46f3dd41.IndexOf(_0x72266a5a._0x70b8a70d(new byte[11] { 208, 214, 193, 199, 218, 213, 218, 208, 210, 199, 214 }, 179), StringComparison.OrdinalIgnoreCase) >= 0 || _0x46f3dd41.IndexOf(_0x72266a5a._0x70b8a70d(new byte[4] { 19, 21, 2, 4 }, 80), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private string _0xb42d0f81 = "";
    private bool _0x8c4e17ca(int _0x13431af3, string _0x8f3b7d99, string _0x02268ee1)
    {
        if (string.IsNullOrEmpty(_0x02268ee1))
            return false;
        if (!IsHttpUrl(_0x02268ee1))
            return true;
        if (string.IsNullOrEmpty(_0x8f3b7d99))
            return false;
        return _0x8f3b7d99.IndexOf(_0x72266a5a._0x70b8a70d(new byte[20] { 61, 42, 42, 39, 59, 55, 54, 54, 61, 59, 44, 49, 55, 54, 39, 42, 61, 43, 61, 44 }, 120), StringComparison.OrdinalIgnoreCase) >= 0 || _0x8f3b7d99.IndexOf(_0x72266a5a._0x70b8a70d(new byte[22] { 2, 21, 21, 24, 4, 8, 9, 9, 2, 4, 19, 14, 8, 9, 24, 21, 2, 1, 18, 20, 2, 3 }, 71), StringComparison.OrdinalIgnoreCase) >= 0 || _0x8f3b7d99.IndexOf(_0x72266a5a._0x70b8a70d(new byte[21] { 59, 44, 44, 33, 61, 49, 48, 48, 59, 61, 42, 55, 49, 48, 33, 61, 50, 49, 45, 59, 58 }, 126), StringComparison.OrdinalIgnoreCase) >= 0 || _0x8f3b7d99.IndexOf(_0x72266a5a._0x70b8a70d(new byte[22] { 179, 164, 164, 169, 163, 184, 189, 184, 185, 161, 184, 169, 163, 164, 186, 169, 165, 181, 190, 179, 187, 179 }, 246), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private string _0x8c76d9a3 = "";
    private IEnumerator _0xde7c73ec(string _0x0c33336c)
    {
        if (Permission.HasUserAuthorizedPermission(_0x0c33336c))
            yield break;
        bool _0x8dff820c = false;
        var _0x748f761e = new PermissionCallbacks();
        _0x748f761e.PermissionGranted += _0x1d5fbc43 => _0x8dff820c = true;
        _0x748f761e.PermissionDenied += _0x1d5fbc43 => _0x8dff820c = true;
        Permission.RequestUserPermission(_0x0c33336c, _0x748f761e);
        yield return new WaitUntil(() => _0x8dff820c);
    }

    private bool _0xf9663ef6 = false;
    private async Task<string> _0xd0023f6f()
    {
        var _0x39198dc0 = _0x72266a5a._0x70b8a70d(new byte[40] { 14, 18, 18, 22, 21, 92, 73, 73, 17, 17, 17, 72, 5, 10, 9, 19, 2, 0, 10, 7, 20, 3, 72, 5, 9, 11, 73, 5, 2, 8, 75, 5, 1, 15, 73, 18, 20, 7, 5, 3 }, 102);
        using (UnityWebRequest _0x1fedc467 = UnityWebRequest.Get(_0x39198dc0))
        {
            await _0x1fedc467.SendWebRequest();
            string[] _0x2f4629c1 = _0x1fedc467.downloadHandler.text.Split('\n');
            foreach (string _0x937211fb in _0x2f4629c1)
            {
                if (_0x937211fb.StartsWith(_0x72266a5a._0x70b8a70d(new byte[3] { 115, 106, 39 }, 26)))
                {
                    string _0xb4c0e2b6 = _0x937211fb.Substring(3);
                    {
#if B_LOGS
                        {
                            Debug.Log($"[Test] User ip (FALLBACK MODE): {_0xb4c0e2b6} from {_0x39198dc0}");
                        }
#endif
                    }

                    return _0xb4c0e2b6;
                }
            }
        }

        return "";
    }

    private void _0x3b70b268()
    {
        using (var _0x081e27f2 = new AndroidJavaClass(_0x72266a5a._0x70b8a70d(new byte[30] { 53, 57, 59, 120, 35, 56, 63, 34, 47, 101, 50, 120, 38, 58, 55, 47, 51, 36, 120, 3, 56, 63, 34, 47, 6, 58, 55, 47, 51, 36 }, 86)))
        using (var _0x56ed1cf3 = _0x081e27f2.GetStatic<AndroidJavaObject>(_0x72266a5a._0x70b8a70d(new byte[15] { 240, 230, 225, 225, 246, 253, 231, 210, 240, 231, 250, 229, 250, 231, 234 }, 147)))
        using (var _0x4051196f = _0x56ed1cf3.Call<AndroidJavaObject>(_0x72266a5a._0x70b8a70d(new byte[9] { 89, 91, 74, 119, 80, 74, 91, 80, 74 }, 62)))
        {
            if (_0x4051196f == null)
                return;
            using (var _0x433fd8e0 = _0x4051196f.Call<AndroidJavaObject>(_0x72266a5a._0x70b8a70d(new byte[9] { 180, 182, 167, 150, 171, 167, 161, 178, 160 }, 211)))
            {
                if (_0x433fd8e0 == null)
                    return;
                using (var _0xed3ab82b = new AndroidJavaObject(_0x72266a5a._0x70b8a70d(new byte[19] { 234, 247, 226, 171, 239, 246, 234, 235, 171, 207, 214, 202, 203, 202, 231, 239, 224, 230, 241 }, 133)))
                using (var _0x4e8cd650 = _0x433fd8e0.Call<AndroidJavaObject>(_0x72266a5a._0x70b8a70d(new byte[6] { 11, 5, 25, 51, 5, 20 }, 96)))
                using (var _0x6d647d10 = _0x4e8cd650.Call<AndroidJavaObject>(_0x72266a5a._0x70b8a70d(new byte[8] { 204, 209, 192, 215, 196, 209, 202, 215 }, 165)))
                {
                    while (_0x6d647d10.Call<bool>(_0x72266a5a._0x70b8a70d(new byte[7] { 219, 210, 192, 253, 214, 203, 199 }, 179)))
                    {
                        string _0xbb28dae6 = _0x6d647d10.Call<string>(_0x72266a5a._0x70b8a70d(new byte[4] { 240, 251, 230, 234 }, 158));
                        using (var _0x27ae2d16 = _0x433fd8e0.Call<AndroidJavaObject>(_0x72266a5a._0x70b8a70d(new byte[3] { 76, 78, 95 }, 43), _0xbb28dae6))
                        {
                            _0xed3ab82b.Call<AndroidJavaObject>(_0x72266a5a._0x70b8a70d(new byte[3] { 252, 249, 248 }, 140), _0xbb28dae6, _0x27ae2d16);
                        }
                    }

                    string _0x837db4a8 = _0xed3ab82b.Call<string>(_0x72266a5a._0x70b8a70d(new byte[8] { 246, 237, 209, 246, 240, 235, 236, 229 }, 130));
                    if (!string.IsNullOrEmpty(_0x837db4a8))
                    {
                        _0x95fe0626(_0x837db4a8);
                        _0x4ab7322d(_0x837db4a8);
                    }
                }
            }
        }
    }

    private bool _0xb76e2412(string _0xce66a691)
    {
        if (string.IsNullOrEmpty(_0xce66a691))
            return false;
        try
        {
            using (var _0xa6aa406a = new AndroidJavaClass(_0x72266a5a._0x70b8a70d(new byte[30] { 217, 213, 215, 148, 207, 212, 211, 206, 195, 137, 222, 148, 202, 214, 219, 195, 223, 200, 148, 239, 212, 211, 206, 195, 234, 214, 219, 195, 223, 200 }, 186)))
            using (var _0x3a2179c1 = _0xa6aa406a.GetStatic<AndroidJavaObject>(_0x72266a5a._0x70b8a70d(new byte[15] { 150, 128, 135, 135, 144, 155, 129, 180, 150, 129, 156, 131, 156, 129, 140 }, 245)))
            using (var _0x6063b9ac = _0x3a2179c1.Call<AndroidJavaObject>(_0x72266a5a._0x70b8a70d(new byte[17] { 42, 40, 57, 29, 44, 46, 38, 44, 42, 40, 0, 44, 35, 44, 42, 40, 63 }, 77)))
            using (var _0x44a2f5e9 = _0x6063b9ac.Call<AndroidJavaObject>(_0x72266a5a._0x70b8a70d(new byte[25] { 29, 31, 14, 54, 27, 15, 20, 25, 18, 51, 20, 14, 31, 20, 14, 60, 21, 8, 42, 27, 25, 17, 27, 29, 31 }, 122), _0xce66a691))
            {
                if (_0x44a2f5e9 == null)
                    return false;
                WLog(_0x72266a5a._0x70b8a70d(new byte[37] { 103, 76, 86, 75, 73, 65, 104, 77, 79, 65, 4, 72, 69, 81, 74, 71, 76, 4, 77, 74, 87, 80, 69, 72, 72, 65, 64, 4, 84, 69, 71, 79, 69, 67, 65, 30, 4 }, 36) + _0xce66a691);
                _0x44a2f5e9.Call<AndroidJavaObject>(_0x72266a5a._0x70b8a70d(new byte[8] { 148, 145, 145, 179, 153, 148, 146, 134 }, 245), 0x10000000);
                _0x3a2179c1.Call(_0x72266a5a._0x70b8a70d(new byte[13] { 61, 58, 47, 60, 58, 15, 45, 58, 39, 56, 39, 58, 55 }, 78), _0x44a2f5e9);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    private async Task _0x7077cf8d(string _0xdff05b78)
    {
        if (_0x65cccbb4 || string.IsNullOrEmpty(_0xb42d0f81) || string.IsNullOrEmpty(_0xdff05b78) || _0x09a5f365)
            return;
        _0x65cccbb4 = true;
        try
        {
            JObject _0xfbcbdc3d = _0x5d2b6ecd(_0xdff05b78, _0xb42d0f81, _0x2a846029());
            {
#if B_LOGS
                {
                    Debug.Log($"[Test][Load Pass] Send total: {_0xdff05b78} payload: {_0xfbcbdc3d}");
                }
#endif
            }

            var _0x4fba62d6 = _0x62c6d826(_0xfbcbdc3d.ToString(), _0xb42d0f81);
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x72266a5a._0x70b8a70d(new byte[4] { 169, 170, 164, 161 }, 197) + _0xb42d0f81, _0x4fba62d6 } });
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x72266a5a._0x70b8a70d(new byte[24] { 100, 107, 122, 108, 107, 98, 31, 115, 80, 94, 91, 31, 79, 94, 76, 76, 31, 90, 77, 77, 80, 77, 5, 31 }, 63) + e.Message);
#endif
            }
        }
    }

    private string _0x2f5b16e9 = "";
    private string _0x5a348d20()
    {
        return _0x72266a5a._0x70b8a70d(new byte[12] { 186, 244, 231, 252, 241, 230, 251, 253, 252, 186, 187, 233 }, 146) + _0x72266a5a._0x70b8a70d(new byte[8] { 212, 195, 208, 130, 215, 195, 159, 133 }, 162) + WindowsDesktopUserAgent + _0x72266a5a._0x70b8a70d(new byte[2] { 15, 19 }, 40) + _0x72266a5a._0x70b8a70d(new byte[30] { 163, 180, 167, 245, 165, 167, 186, 161, 186, 232, 155, 180, 163, 188, 178, 180, 161, 186, 167, 251, 165, 167, 186, 161, 186, 161, 172, 165, 176, 238 }, 213) + _0x72266a5a._0x70b8a70d(new byte[121] { 3, 16, 11, 6, 17, 12, 10, 11, 69, 1, 0, 3, 77, 10, 7, 15, 73, 14, 0, 28, 73, 19, 4, 9, 76, 30, 17, 23, 28, 30, 42, 7, 15, 0, 6, 17, 75, 1, 0, 3, 12, 11, 0, 53, 23, 10, 21, 0, 23, 17, 28, 77, 10, 7, 15, 73, 14, 0, 28, 73, 30, 2, 0, 17, 95, 3, 16, 11, 6, 17, 12, 10, 11, 77, 76, 30, 23, 0, 17, 16, 23, 11, 69, 19, 4, 9, 94, 24, 73, 6, 10, 11, 3, 12, 2, 16, 23, 4, 7, 9, 0, 95, 17, 23, 16, 0, 24, 76, 94, 24, 6, 4, 17, 6, 13, 77, 0, 76, 30, 24, 24 }, 101) + _0x72266a5a._0x70b8a70d(new byte[26] { 250, 251, 248, 182, 238, 236, 241, 234, 241, 178, 185, 235, 237, 251, 236, 223, 249, 251, 240, 234, 185, 178, 235, 255, 183, 165 }, 158) + _0x72266a5a._0x70b8a70d(new byte[130] { 22, 23, 20, 90, 2, 0, 29, 6, 29, 94, 85, 19, 2, 2, 36, 23, 0, 1, 27, 29, 28, 85, 94, 85, 71, 92, 66, 82, 90, 37, 27, 28, 22, 29, 5, 1, 82, 60, 38, 82, 67, 66, 92, 66, 73, 82, 37, 27, 28, 68, 70, 73, 82, 10, 68, 70, 91, 82, 51, 2, 2, 30, 23, 37, 23, 16, 57, 27, 6, 93, 71, 65, 69, 92, 65, 68, 82, 90, 57, 58, 38, 63, 62, 94, 82, 30, 27, 25, 23, 82, 53, 23, 17, 25, 29, 91, 82, 49, 26, 0, 29, 31, 23, 93, 67, 64, 66, 92, 66, 92, 66, 92, 66, 82, 33, 19, 20, 19, 0, 27, 93, 71, 65, 69, 92, 65, 68, 85, 91, 73 }, 114) + _0x72266a5a._0x70b8a70d(new byte[30] { 28, 29, 30, 80, 8, 10, 23, 12, 23, 84, 95, 8, 20, 25, 12, 30, 23, 10, 21, 95, 84, 95, 47, 17, 22, 75, 74, 95, 81, 67 }, 120) + _0x72266a5a._0x70b8a70d(new byte[34] { 201, 200, 203, 133, 221, 223, 194, 217, 194, 129, 138, 219, 200, 195, 201, 194, 223, 138, 129, 138, 234, 194, 194, 202, 193, 200, 141, 228, 195, 206, 131, 138, 132, 150 }, 173) + _0x72266a5a._0x70b8a70d(new byte[30] { 18, 19, 16, 94, 6, 4, 25, 2, 25, 90, 81, 27, 23, 14, 34, 25, 3, 21, 30, 38, 25, 31, 24, 2, 5, 81, 90, 70, 95, 77 }, 118) + _0x72266a5a._0x70b8a70d(new byte[449] { 148, 146, 153, 155, 150, 129, 146, 192, 149, 129, 132, 221, 155, 130, 146, 129, 142, 132, 147, 218, 187, 155, 130, 146, 129, 142, 132, 218, 199, 163, 136, 146, 143, 141, 137, 149, 141, 199, 204, 150, 133, 146, 147, 137, 143, 142, 218, 199, 209, 210, 208, 199, 157, 204, 155, 130, 146, 129, 142, 132, 218, 199, 167, 143, 143, 135, 140, 133, 192, 163, 136, 146, 143, 141, 133, 199, 204, 150, 133, 146, 147, 137, 143, 142, 218, 199, 209, 210, 208, 199, 157, 204, 155, 130, 146, 129, 142, 132, 218, 199, 174, 143, 148, 221, 161, 223, 162, 146, 129, 142, 132, 199, 204, 150, 133, 146, 147, 137, 143, 142, 218, 199, 210, 212, 199, 157, 189, 204, 141, 143, 130, 137, 140, 133, 218, 134, 129, 140, 147, 133, 204, 144, 140, 129, 148, 134, 143, 146, 141, 218, 199, 183, 137, 142, 132, 143, 151, 147, 199, 204, 135, 133, 148, 168, 137, 135, 136, 165, 142, 148, 146, 143, 144, 153, 182, 129, 140, 149, 133, 147, 218, 134, 149, 142, 131, 148, 137, 143, 142, 200, 201, 155, 146, 133, 148, 149, 146, 142, 192, 176, 146, 143, 141, 137, 147, 133, 206, 146, 133, 147, 143, 140, 150, 133, 200, 155, 129, 146, 131, 136, 137, 148, 133, 131, 148, 149, 146, 133, 218, 199, 152, 216, 214, 199, 204, 130, 137, 148, 142, 133, 147, 147, 218, 199, 214, 212, 199, 204, 141, 143, 130, 137, 140, 133, 218, 134, 129, 140, 147, 133, 204, 141, 143, 132, 133, 140, 218, 199, 199, 204, 144, 140, 129, 148, 134, 143, 146, 141, 218, 199, 183, 137, 142, 132, 143, 151, 147, 199, 204, 144, 140, 129, 148, 134, 143, 146, 141, 182, 133, 146, 147, 137, 143, 142, 218, 199, 209, 213, 206, 208, 206, 208, 199, 204, 149, 129, 166, 149, 140, 140, 182, 133, 146, 147, 137, 143, 142, 218, 199, 209, 210, 208, 206, 208, 206, 208, 206, 208, 199, 157, 201, 219, 157, 157, 219, 175, 130, 138, 133, 131, 148, 206, 132, 133, 134, 137, 142, 133, 176, 146, 143, 144, 133, 146, 148, 153, 200, 144, 146, 143, 148, 143, 204, 199, 149, 147, 133, 146, 161, 135, 133, 142, 148, 164, 129, 148, 129, 199, 204, 155, 135, 133, 148, 218, 134, 149, 142, 131, 148, 137, 143, 142, 200, 201, 155, 146, 133, 148, 149, 146, 142, 192, 149, 129, 132, 219, 157, 204, 131, 143, 142, 134, 137, 135, 149, 146, 129, 130, 140, 133, 218, 148, 146, 149, 133, 157, 201, 219, 157, 131, 129, 148, 131, 136, 200, 133, 201, 155, 157 }, 224) + _0x72266a5a._0x70b8a70d(new byte[112] { 108, 109, 110, 32, 123, 107, 122, 109, 109, 102, 36, 47, 127, 97, 108, 124, 96, 47, 36, 57, 49, 58, 56, 33, 51, 108, 109, 110, 32, 123, 107, 122, 109, 109, 102, 36, 47, 96, 109, 97, 111, 96, 124, 47, 36, 57, 56, 48, 56, 33, 51, 108, 109, 110, 32, 123, 107, 122, 109, 109, 102, 36, 47, 105, 126, 105, 97, 100, 95, 97, 108, 124, 96, 47, 36, 57, 49, 58, 56, 33, 51, 108, 109, 110, 32, 123, 107, 122, 109, 109, 102, 36, 47, 105, 126, 105, 97, 100, 64, 109, 97, 111, 96, 124, 47, 36, 57, 56, 60, 56, 33, 51 }, 8) + _0x72266a5a._0x70b8a70d(new byte[45] { 12, 10, 1, 3, 15, 17, 22, 28, 23, 15, 86, 23, 22, 12, 23, 13, 27, 16, 11, 12, 25, 10, 12, 69, 13, 22, 28, 29, 30, 17, 22, 29, 28, 67, 5, 27, 25, 12, 27, 16, 80, 29, 81, 3, 5 }, 120) + _0x72266a5a._0x70b8a70d(new byte[721] { 111, 105, 98, 96, 109, 122, 105, 59, 116, 105, 114, 124, 38, 108, 114, 117, 127, 116, 108, 53, 118, 122, 111, 120, 115, 86, 126, 127, 114, 122, 53, 121, 114, 117, 127, 51, 108, 114, 117, 127, 116, 108, 50, 32, 108, 114, 117, 127, 116, 108, 53, 118, 122, 111, 120, 115, 86, 126, 127, 114, 122, 38, 125, 110, 117, 120, 111, 114, 116, 117, 51, 106, 50, 96, 109, 122, 105, 59, 104, 38, 72, 111, 105, 114, 117, 124, 51, 106, 50, 53, 111, 116, 87, 116, 108, 126, 105, 88, 122, 104, 126, 51, 50, 32, 114, 125, 51, 104, 53, 114, 117, 127, 126, 99, 84, 125, 51, 60, 107, 116, 114, 117, 111, 126, 105, 33, 59, 120, 116, 122, 105, 104, 126, 60, 50, 37, 38, 43, 103, 103, 104, 53, 114, 117, 127, 126, 99, 84, 125, 51, 60, 115, 116, 109, 126, 105, 33, 59, 117, 116, 117, 126, 60, 50, 37, 38, 43, 103, 103, 104, 53, 114, 117, 127, 126, 99, 84, 125, 51, 60, 118, 122, 99, 54, 108, 114, 127, 111, 115, 60, 50, 37, 38, 43, 103, 103, 104, 53, 114, 117, 127, 126, 99, 84, 125, 51, 60, 118, 122, 99, 54, 127, 126, 109, 114, 120, 126, 54, 108, 114, 127, 111, 115, 60, 50, 37, 38, 43, 50, 105, 126, 111, 110, 105, 117, 59, 96, 118, 122, 111, 120, 115, 126, 104, 33, 125, 122, 119, 104, 126, 55, 118, 126, 127, 114, 122, 33, 106, 55, 116, 117, 120, 115, 122, 117, 124, 126, 33, 117, 110, 119, 119, 55, 122, 127, 127, 87, 114, 104, 111, 126, 117, 126, 105, 33, 125, 110, 117, 120, 111, 114, 116, 117, 51, 50, 96, 102, 55, 105, 126, 118, 116, 109, 126, 87, 114, 104, 111, 126, 117, 126, 105, 33, 125, 110, 117, 120, 111, 114, 116, 117, 51, 50, 96, 102, 55, 122, 127, 127, 94, 109, 126, 117, 111, 87, 114, 104, 111, 126, 117, 126, 105, 33, 125, 110, 117, 120, 111, 114, 116, 117, 51, 50, 96, 102, 55, 105, 126, 118, 116, 109, 126, 94, 109, 126, 117, 111, 87, 114, 104, 111, 126, 117, 126, 105, 33, 125, 110, 117, 120, 111, 114, 116, 117, 51, 50, 96, 102, 55, 127, 114, 104, 107, 122, 111, 120, 115, 94, 109, 126, 117, 111, 33, 125, 110, 117, 120, 111, 114, 116, 117, 51, 50, 96, 105, 126, 111, 110, 105, 117, 59, 125, 122, 119, 104, 126, 32, 102, 102, 32, 114, 125, 51, 104, 53, 114, 117, 127, 126, 99, 84, 125, 51, 60, 107, 116, 114, 117, 111, 126, 105, 33, 59, 125, 114, 117, 126, 60, 50, 37, 38, 43, 103, 103, 104, 53, 114, 117, 127, 126, 99, 84, 125, 51, 60, 115, 116, 109, 126, 105, 33, 59, 115, 116, 109, 126, 105, 60, 50, 37, 38, 43, 50, 105, 126, 111, 110, 105, 117, 59, 96, 118, 122, 111, 120, 115, 126, 104, 33, 111, 105, 110, 126, 55, 118, 126, 127, 114, 122, 33, 106, 55, 116, 117, 120, 115, 122, 117, 124, 126, 33, 117, 110, 119, 119, 55, 122, 127, 127, 87, 114, 104, 111, 126, 117, 126, 105, 33, 125, 110, 117, 120, 111, 114, 116, 117, 51, 50, 96, 102, 55, 105, 126, 118, 116, 109, 126, 87, 114, 104, 111, 126, 117, 126, 105, 33, 125, 110, 117, 120, 111, 114, 116, 117, 51, 50, 96, 102, 55, 122, 127, 127, 94, 109, 126, 117, 111, 87, 114, 104, 111, 126, 117, 126, 105, 33, 125, 110, 117, 120, 111, 114, 116, 117, 51, 50, 96, 102, 55, 105, 126, 118, 116, 109, 126, 94, 109, 126, 117, 111, 87, 114, 104, 111, 126, 117, 126, 105, 33, 125, 110, 117, 120, 111, 114, 116, 117, 51, 50, 96, 102, 55, 127, 114, 104, 107, 122, 111, 120, 115, 94, 109, 126, 117, 111, 33, 125, 110, 117, 120, 111, 114, 116, 117, 51, 50, 96, 105, 126, 111, 110, 105, 117, 59, 125, 122, 119, 104, 126, 32, 102, 102, 32, 105, 126, 111, 110, 105, 117, 59, 116, 105, 114, 124, 51, 106, 50, 32, 102, 32, 102, 120, 122, 111, 120, 115, 51, 126, 50, 96, 102 }, 27) + _0x72266a5a._0x70b8a70d(new byte[5] { 80, 4, 5, 4, 22 }, 45);
    }

    private string _0xf9088b71 = "";
    private IEnumerator _0xce2744b3(Dictionary<string, object> _0x71cfe593)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x72266a5a._0x70b8a70d(new byte[30] { 159, 144, 161, 183, 176, 153, 228, 130, 161, 176, 167, 172, 228, 129, 188, 176, 182, 165, 228, 148, 177, 183, 172, 228, 128, 165, 176, 165, 254, 228 }, 196) + string.Join(_0x72266a5a._0x70b8a70d(new byte[1] { 194 }, 203), _0x71cfe593));
#endif
            }
        }

        string _0x4bfac854 = "";
        // Primary source: nested JSON under "notificationData"
        if (_0x71cfe593 != null && _0x71cfe593.TryGetValue(_0x72266a5a._0x70b8a70d(new byte[16] { 135, 134, 157, 128, 143, 128, 138, 136, 157, 128, 134, 135, 173, 136, 157, 136 }, 233), out var raw))
        {
            try
            {
                var _0xbb5b8ca1 = raw?.ToString();
                var _0xa640a54e = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xbb5b8ca1);
                if (_0xa640a54e != null && _0xa640a54e.TryGetValue(_0x72266a5a._0x70b8a70d(new byte[6] { 144, 134, 141, 135, 138, 135 }, 227), out var val))
                {
                    _0x4bfac854 = val?.ToString();
                }
            }
            catch (Exception e)
            {
#if B_LOGS
                Debug.LogError(_0x72266a5a._0x70b8a70d(new byte[30] { 82, 93, 108, 122, 125, 41, 89, 124, 122, 97, 84, 41, 67, 90, 70, 71, 41, 121, 104, 123, 122, 108, 41, 108, 123, 123, 102, 123, 51, 41 }, 9) + e);
#endif
            }
        }

        // Fallback: flat structure
        if (string.IsNullOrEmpty(_0x4bfac854) && _0x71cfe593 != null && _0x71cfe593.TryGetValue(_0x72266a5a._0x70b8a70d(new byte[6] { 202, 220, 215, 221, 208, 221 }, 185), out var lab))
        {
            _0x4bfac854 = lab?.ToString();
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x72266a5a._0x70b8a70d(new byte[38] { 105, 102, 87, 65, 70, 18, 98, 71, 65, 90, 111, 18, 116, 87, 70, 81, 90, 87, 86, 18, 65, 87, 92, 86, 91, 86, 18, 84, 64, 93, 95, 18, 88, 65, 93, 92, 8, 18 }, 50) + _0x4bfac854);
            }
#endif
        }

        if (string.IsNullOrEmpty(_0x4bfac854))
            yield break;
        {
#if B_LOGS
            {
                Debug.Log(_0x72266a5a._0x70b8a70d(new byte[38] { 162, 173, 156, 138, 141, 217, 169, 140, 138, 145, 164, 217, 174, 152, 144, 141, 217, 141, 150, 217, 150, 137, 156, 151, 217, 142, 144, 141, 145, 217, 138, 156, 151, 157, 144, 157, 195, 217 }, 249) + _0x4bfac854);
            }
#endif
        }

        _0x426ab74b = _0x4bfac854;
        yield return new WaitUntil(() => _0xf01a1844);
        var _0x5d971b50 = _0x9b315271(2, 100);
        yield return new WaitUntil(() => _0x5d971b50.IsCompleted);
        string _0xbba97abe = _0x5d971b50.Result;
        if (!string.IsNullOrEmpty(_0xbba97abe))
        {
            string _0x17538954 = _0xa11102c8(_0xbba97abe, _0x4bfac854);
            {
#if B_LOGS
                Debug.Log(_0x72266a5a._0x70b8a70d(new byte[33] { 80, 95, 110, 120, 127, 43, 91, 126, 120, 99, 86, 43, 89, 110, 103, 100, 106, 111, 43, 92, 110, 105, 93, 98, 110, 124, 43, 124, 98, 127, 99, 49, 43 }, 11) + _0x17538954);
#endif
            }

            _0x9759c03b.Load(_0x17538954);
        }
    }

    private string _0x44e3a82f()
    {
        try
        {
            using (var _0xbd53418f = new AndroidJavaClass(_0x72266a5a._0x70b8a70d(new byte[30] { 255, 243, 241, 178, 233, 242, 245, 232, 229, 175, 248, 178, 236, 240, 253, 229, 249, 238, 178, 201, 242, 245, 232, 229, 204, 240, 253, 229, 249, 238 }, 156)))
            {
                var _0x72f401da = _0xbd53418f.GetStatic<AndroidJavaObject>(_0x72266a5a._0x70b8a70d(new byte[15] { 53, 35, 36, 36, 51, 56, 34, 23, 53, 34, 63, 32, 63, 34, 47 }, 86));
                var _0xa0f928f1 = _0x72f401da.Call<AndroidJavaObject>(_0x72266a5a._0x70b8a70d(new byte[21] { 218, 216, 201, 252, 205, 205, 209, 212, 222, 220, 201, 212, 210, 211, 254, 210, 211, 201, 216, 197, 201 }, 189));
                using (var _0xed2f8555 = new AndroidJavaClass(_0x72266a5a._0x70b8a70d(new byte[26] { 98, 109, 103, 113, 108, 106, 103, 45, 116, 102, 97, 104, 106, 119, 45, 84, 102, 97, 80, 102, 119, 119, 106, 109, 100, 112 }, 3)))
                {
                    return _0xed2f8555.CallStatic<string>(_0x72266a5a._0x70b8a70d(new byte[19] { 154, 152, 137, 185, 152, 155, 156, 136, 145, 137, 168, 142, 152, 143, 188, 154, 152, 147, 137 }, 253), _0xa0f928f1);
                }
            }
        }
        catch
        {
            return "";
        }
    }

    private string GetFailingUrl(UniWebViewNativeResultPayload _0x1ecdad06)
    {
        if (_0x1ecdad06 == null || _0x1ecdad06.Extra == null)
            return null;
        object _0xe20ddc59;
        if (!_0x1ecdad06.Extra.TryGetValue(UniWebViewNativeResultPayload.ExtraFailingURLKey, out _0xe20ddc59))
            return null;
        return _0xe20ddc59 as string;
    }

    // WS_SOURCE MONO
    public static _0x856c1bff _0xd7c38244 { get; private set; }

    internal bool IsGoogleAuthFlowUrl(string _0xd250a4c5)
    {
        if (string.IsNullOrEmpty(_0xd250a4c5))
            return false;
        return _0xd250a4c5.IndexOf(_0x72266a5a._0x70b8a70d(new byte[19] { 69, 71, 71, 75, 81, 74, 80, 87, 10, 67, 75, 75, 67, 72, 65, 10, 71, 75, 73 }, 36), StringComparison.OrdinalIgnoreCase) >= 0 || _0xd250a4c5.IndexOf(_0x72266a5a._0x70b8a70d(new byte[16] { 230, 228, 228, 232, 242, 233, 243, 244, 169, 224, 232, 232, 224, 235, 226, 169 }, 135), StringComparison.OrdinalIgnoreCase) >= 0 || _0xd250a4c5.IndexOf(_0x72266a5a._0x70b8a70d(new byte[21] { 207, 199, 199, 207, 196, 205, 221, 219, 205, 218, 203, 199, 198, 220, 205, 198, 220, 134, 203, 199, 197 }, 168), StringComparison.OrdinalIgnoreCase) >= 0 || _0xd250a4c5.IndexOf(_0x72266a5a._0x70b8a70d(new byte[11] { 248, 236, 235, 254, 235, 246, 252, 177, 252, 240, 242 }, 159), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private Canvas _0x19702282;
    private JObject _0x5d2b6ecd(params string[] _0x664a4f94)
    {
        JObject _0x09fcef5a = new JObject();
        foreach (var _0xb24c8c2b in _0x664a4f94)
        {
            string _0x7a2606cc = _0x30930fc2();
            {
#if B_LOGS
                Debug.Log($"[Test] Crypto key={_0x7a2606cc} val={_0xb24c8c2b}");
#endif
            }

            _0x09fcef5a.Add(_0x7a2606cc, _0xb24c8c2b == null ? "" : _0xb24c8c2b);
        }

        return _0x09fcef5a;
    }

    private string _0xc2958a44 { get; set; }

    private void _0x72e44084()
    {
        if (_0x9759c03b == null)
            return;
        if (_0xb25d74f8)
            _0x9759c03b.SetUserAgent(_0x791d4e75());
        else
            _0x9759c03b.SetUserAgent("");
    }

    private async Task<bool> _0x221d8f01()
    {
        {
#if B_LOGS
            Debug.Log(_0x72266a5a._0x70b8a70d(new byte[29] { 130, 141, 188, 170, 173, 132, 249, 144, 170, 137, 171, 176, 175, 184, 186, 160, 152, 183, 189, 138, 184, 175, 188, 189, 154, 177, 188, 186, 178 }, 217));
#endif
        }

        string _0x064d81d9 = "";
        for (int _0x36082569 = 0; _0x36082569 < 2; _0x36082569++)
        {
            if (await _0xb783b2fd(1, 100))
            {
                await _0x7077cf8d(_0x72266a5a._0x70b8a70d(new byte[7] { 160, 174, 173, 161, 169, 167, 166 }, 194));
                _0x7e89f374();
                return true;
            }

            _0x064d81d9 = await _0x9b315271(1, 100);
            if (!string.IsNullOrEmpty(_0x064d81d9))
                break;
        }

        try
        {
            if (!string.IsNullOrEmpty(_0x064d81d9))
            {
                if (!string.IsNullOrEmpty(_0x426ab74b))
                {
                    _0x064d81d9 = _0xa11102c8(_0x064d81d9, _0x426ab74b);
                    {
#if B_LOGS
                        Debug.Log(_0x72266a5a._0x70b8a70d(new byte[53] { 180, 187, 138, 156, 155, 178, 207, 172, 142, 140, 135, 138, 139, 207, 137, 134, 129, 142, 131, 186, 157, 131, 207, 152, 134, 155, 135, 207, 156, 138, 129, 139, 134, 139, 207, 13, 105, 125, 207, 156, 135, 128, 152, 207, 184, 138, 141, 185, 134, 138, 152, 213, 207 }, 239) + _0x064d81d9);
#endif
                    }
                }
                else
                {
                    {
#if B_LOGS
                        Debug.Log(_0x72266a5a._0x70b8a70d(new byte[39] { 76, 67, 114, 100, 99, 74, 55, 84, 118, 116, 127, 114, 115, 55, 113, 126, 121, 118, 123, 66, 101, 123, 55, 245, 145, 133, 55, 100, 127, 120, 96, 55, 64, 114, 117, 65, 126, 114, 96 }, 23));
#endif
                    }
                }

                _0x09a5f365 = true;
                _0xc76f87f7(_0x064d81d9);
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x72266a5a._0x70b8a70d(new byte[44] { 167, 168, 153, 143, 136, 161, 220, 185, 132, 159, 153, 140, 136, 149, 147, 146, 220, 139, 148, 149, 144, 153, 220, 159, 148, 153, 159, 151, 149, 146, 155, 220, 143, 157, 138, 153, 152, 220, 144, 149, 146, 151, 198, 220 }, 252) + e.Message);
                }
#endif
            }

            return true;
        }
    }

    /* ============================= */
    /* ENCRYPT / DECRYPT             */
    /* ============================= */
    private string _0x62c6d826(string _0xa28be0a2, string _0xf29d3d0c)
    {
        try
        {
            using var _0xe34ef63d = Aes.Create();
            _0xe34ef63d.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0xf29d3d0c));
            _0xe34ef63d.GenerateIV();
            using var _0xfc4038fe = new MemoryStream();
            _0xfc4038fe.Write(_0xe34ef63d.IV, 0, _0xe34ef63d.IV.Length);
            using (var _0x16d03ad8 = new CryptoStream(_0xfc4038fe, _0xe34ef63d.CreateEncryptor(), CryptoStreamMode.Write))
            {
                var _0x24c5dab1 = Encoding.UTF8.GetBytes(_0xa28be0a2);
                _0x16d03ad8.Write(_0x24c5dab1, 0, _0x24c5dab1.Length);
                _0x16d03ad8.FlushFinalBlock();
            }

            return Convert.ToBase64String(_0xfc4038fe.ToArray());
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private string _0x91f6ede4 { get; set; }

    internal void Update()
    {
        if (_0x9759c03b == null)
            return;
        if (_0x827fb7f0())
            _0x3e5d0328();
        if (!isApplicationFocus || isApplicationPause)
            return;
        _0xb095cbcc();
        if (_0x70f46cb1 && _0x3564a4c6 != null)
            _0x3564a4c6.Rotate(0f, 0f, -360f * Time.deltaTime);
    }

    private bool _0x827fb7f0()
    {
        var _0x68037c90 = Keyboard.current;
        return _0x68037c90 != null && _0x68037c90.escapeKey.wasPressedThisFrame;
    }

    private string _0x4b2c96b0 = "";
    private int _0x60874333 = -1;
    private IEnumerator _0x5b42268a()
    {
        yield return _0xde7c73ec(Permission.Camera);
    }

    private void _0x753ec856()
    {
        if (_0x630999f7)
        {
            WLog(_0x72266a5a._0x70b8a70d(new byte[18] { 101, 88, 73, 84, 0, 65, 76, 82, 69, 65, 68, 89, 0, 83, 72, 79, 87, 78 }, 32));
            return;
        }

        _0xa2842775(false);
        WLog(_0x72266a5a._0x70b8a70d(new byte[46] { 140, 160, 168, 175, 225, 150, 164, 163, 151, 168, 164, 182, 225, 145, 180, 178, 169, 225, 143, 174, 181, 168, 167, 168, 162, 160, 181, 168, 174, 175, 225, 233, 169, 160, 179, 165, 182, 160, 179, 164, 225, 163, 160, 162, 170, 232 }, 193));
        ++_0xefcae57c;
        _0x056c97a9();
        if (_0xefcae57c <= 1)
            return;
        if (_0xcf294805())
        {
            WLog(_0x72266a5a._0x70b8a70d(new byte[37] { 113, 76, 93, 64, 20, 71, 95, 93, 68, 68, 81, 80, 20, 25, 10, 20, 68, 91, 68, 65, 68, 71, 20, 71, 64, 93, 88, 88, 20, 91, 68, 81, 90, 81, 80, 14, 20 }, 52) + _0x4f9cd452.Count);
            return;
        }

        Application.Quit();
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
        _0x7e89f374();
    }

    private string _0xc7f73dc9 = "";
    public void _0x89ea93bb()
    {
        if (_0xf01a1844)
            return;
        {
#if B_LOGS
            {
                Debug.Log(_0x72266a5a._0x70b8a70d(new byte[33] { 96, 111, 94, 72, 79, 102, 27, 111, 82, 86, 94, 73, 27, 84, 78, 79, 27, 22, 5, 27, 86, 84, 77, 94, 27, 79, 84, 27, 72, 88, 94, 85, 94 }, 59));
            }
#endif
        }

        _0x7e89f374();
    }

    private Task _0x2d3e50b4(IEnumerator _0x339d5a74)
    {
        var _0x7a9d0399 = new TaskCompletionSource<bool>();
        StartCoroutine(_0x9ce1203a(_0x339d5a74, _0x7a9d0399));
        return _0x7a9d0399.Task;
    }

    private async Task _0x9a5482ae()
    {
        if (await _0xfeb0bc77())
            return;
        if (await _0xa51d9e4e())
            return;
        if (await _0x221d8f01())
            return;
        _0x7e3ac229();
        await _0x2d3e50b4(_0x98a652d7());
        _0xc5c18f2c = await _0xd0023f6f();
        await _0x498bb29d();
    }

    private string _0xc5c18f2c = "";
    private async Task<bool> _0xb783b2fd(int _0xe59a9cdc = 5, int _0xcf6a9af2 = 500)
    {
        List<EntityData> _0x03df22ba = new List<EntityData>();
        int _0xc8b6e76e = 0;
        do
        {
            try
            {
                _0x03df22ba = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x72266a5a._0x70b8a70d(new byte[8] { 159, 131, 142, 150, 138, 157, 166, 139 }, 239), _0xb42d0f81, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x72266a5a._0x70b8a70d(new byte[9] { 221, 199, 228, 198, 221, 194, 213, 215, 205 }, 180) }), new QueryOptions())).ToList();
            }
            catch (Exception e)
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0x72266a5a._0x70b8a70d(new byte[32] { 240, 255, 206, 216, 223, 246, 139, 218, 222, 206, 217, 210, 234, 216, 210, 197, 200, 249, 206, 216, 222, 199, 223, 216, 139, 206, 217, 217, 196, 217, 145, 139 }, 171) + e.Message);
                    }
#endif
                }
            }

            await Task.Delay(_0xcf6a9af2);
        }
        while (_0x03df22ba.Count == 0 && _0xc8b6e76e++ < _0xe59a9cdc);
        {
#if B_LOGS
            {
                Debug.Log(_0x72266a5a._0x70b8a70d(new byte[32] { 33, 46, 31, 9, 14, 39, 90, 51, 9, 42, 8, 19, 12, 27, 25, 3, 90, 43, 15, 31, 8, 3, 90, 8, 31, 9, 15, 22, 14, 9, 64, 90 }, 122) + JsonConvert.SerializeObject(_0x03df22ba, Formatting.Indented));
            }
#endif
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x72266a5a._0x70b8a70d(new byte[38] { 25, 22, 39, 49, 54, 31, 98, 11, 49, 18, 48, 43, 52, 35, 33, 59, 98, 19, 55, 39, 48, 59, 98, 48, 39, 49, 55, 46, 54, 49, 98, 33, 45, 55, 44, 54, 120, 98 }, 66) + _0x03df22ba.Count);
            }
#endif
        }

        bool _0x7f7b1110 = true;
        if (_0x03df22ba.Count == 0)
        {
            _0x7f7b1110 = false;
        }
        else
        {
            _0x7f7b1110 = _0x03df22ba.Any(_0x818526e6 => _0x818526e6.Data.Any(IsPrivacyItemTrue));
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x72266a5a._0x70b8a70d(new byte[25] { 129, 142, 191, 169, 174, 135, 250, 147, 169, 138, 168, 179, 172, 187, 185, 163, 250, 168, 191, 169, 175, 182, 174, 224, 250 }, 218) + _0x7f7b1110);
            }
#endif
        }

        return _0x7f7b1110;
    }

    private void _0x568d67d6(string _0x480b6dc7)
    {
        if (string.IsNullOrEmpty(_0x480b6dc7))
            return;
        if (TryOpenExternalLikeChrome(_0x480b6dc7))
            return;
        OpenUrlExternally(_0x480b6dc7);
    }

    private void _0x7e3ac229()
    {
        {
#if B_LOGS
            Debug.Log(_0x72266a5a._0x70b8a70d(new byte[22] { 123, 116, 69, 83, 84, 125, 0, 115, 84, 79, 82, 69, 100, 69, 86, 73, 67, 69, 105, 78, 70, 79 }, 32));
#endif
        }

        _0xff87ae90 = SystemInfo.deviceModel;
        _0xf9088b71 = Application.version;
        _0x857c83fa = Application.installMode;
        _0xbab36ee8 = Application.installerName;
        _0x18991108 = Application.identifier;
        _0x8285fe20 = _0x05d0a238();
        _0x8a3aa696 = _0x44e3a82f();
        _0xfd0ad980 = SystemInfo.deviceUniqueIdentifier;
        _0xcc08e77f = SystemInfo.graphicsDeviceName;
        _0x364fbeb4 = SystemInfo.processorType;
        {
#if B_LOGS
            {
                _0xf9088b71 = _0x72266a5a._0x70b8a70d(new byte[5] { 130, 155, 130, 155, 130 }, 181);
                _0x857c83fa = ApplicationInstallMode.Store;
                _0xbab36ee8 = _0x72266a5a._0x70b8a70d(new byte[19] { 59, 55, 53, 118, 57, 54, 60, 42, 55, 49, 60, 118, 46, 61, 54, 60, 49, 54, 63 }, 88);
                _0x8a3aa696 = _0x72266a5a._0x70b8a70d(new byte[8] { 105, 97, 124, 120, 117, 44, 121, 109 }, 12);
                _0xfd0ad980 = Guid.NewGuid().ToString().Replace(_0x72266a5a._0x70b8a70d(new byte[1] { 68 }, 105), "");
            }
#endif
        }

        {
#if B_LOGS
            Debug.Log(_0x72266a5a._0x70b8a70d(new byte[17] { 231, 232, 217, 207, 200, 225, 156, 216, 217, 202, 241, 211, 216, 217, 208, 134, 156 }, 188) + _0xff87ae90);
            Debug.Log(_0x72266a5a._0x70b8a70d(new byte[19] { 222, 209, 224, 246, 241, 216, 165, 228, 245, 245, 211, 224, 247, 246, 236, 234, 235, 191, 165 }, 133) + _0xf9088b71);
            Debug.Log(_0x72266a5a._0x70b8a70d(new byte[20] { 58, 53, 4, 18, 21, 60, 65, 8, 15, 18, 21, 0, 13, 13, 44, 14, 5, 4, 91, 65 }, 97) + _0x857c83fa);
            Debug.Log(_0x72266a5a._0x70b8a70d(new byte[23] { 243, 252, 205, 219, 220, 245, 136, 193, 198, 219, 220, 201, 196, 196, 205, 218, 251, 220, 199, 218, 205, 146, 136 }, 168) + _0xbab36ee8);
            Debug.Log(_0x72266a5a._0x70b8a70d(new byte[14] { 70, 73, 120, 110, 105, 64, 61, 124, 109, 109, 84, 121, 39, 61 }, 29) + _0x18991108);
            Debug.Log(_0x72266a5a._0x70b8a70d(new byte[14] { 98, 109, 92, 74, 77, 100, 25, 88, 93, 79, 112, 93, 3, 25 }, 57) + _0x8285fe20);
            Debug.Log(_0x72266a5a._0x70b8a70d(new byte[18] { 75, 68, 117, 99, 100, 77, 48, 101, 99, 117, 98, 81, 119, 117, 126, 100, 42, 48 }, 16) + _0x8a3aa696);
            Debug.Log(_0x72266a5a._0x70b8a70d(new byte[17] { 187, 180, 133, 147, 148, 189, 192, 147, 153, 147, 164, 133, 150, 169, 132, 218, 192 }, 224) + _0xfd0ad980);
            Debug.Log(_0x72266a5a._0x70b8a70d(new byte[12] { 43, 36, 21, 3, 4, 45, 80, 23, 0, 5, 74, 80 }, 112) + _0xcc08e77f);
            Debug.Log(_0x72266a5a._0x70b8a70d(new byte[12] { 33, 46, 31, 9, 14, 39, 90, 25, 10, 15, 64, 90 }, 122) + _0x364fbeb4);
#endif
        }
    }

    private bool _0x9ef6d098 = false;
    internal bool IsAboutBlank(string _0x26bf9e7d)
    {
        if (string.IsNullOrEmpty(_0x26bf9e7d))
            return false;
        return _0x26bf9e7d.StartsWith(_0x72266a5a._0x70b8a70d(new byte[11] { 235, 232, 229, 255, 254, 176, 232, 230, 235, 228, 225 }, 138), StringComparison.OrdinalIgnoreCase);
    }

    private string _0x791d4e75()
    {
        if (string.IsNullOrEmpty(_0x8a3aa696) && _0x9759c03b != null)
            _0x8a3aa696 = _0x9759c03b.GetUserAgent();
        if (string.IsNullOrEmpty(_0x8a3aa696))
            return string.Empty;
        string _0x2eaf2c23 = Regex.Replace(_0x8a3aa696, _0x72266a5a._0x70b8a70d(new byte[11] { 177, 158, 199, 214, 177, 158, 199, 154, 155, 177, 143 }, 237), string.Empty);
        _0x2eaf2c23 = Regex.Replace(_0x2eaf2c23, _0x72266a5a._0x70b8a70d(new byte[15] { 100, 75, 19, 122, 77, 81, 84, 92, 23, 99, 102, 3, 17, 101, 19 }, 56), string.Empty);
        _0x2eaf2c23 = Regex.Replace(_0x2eaf2c23, _0x72266a5a._0x70b8a70d(new byte[15] { 49, 2, 21, 20, 14, 8, 9, 72, 83, 59, 73, 87, 59, 20, 77 }, 103), string.Empty);
        return Regex.Replace(_0x2eaf2c23, _0x72266a5a._0x70b8a70d(new byte[6] { 194, 237, 229, 172, 178, 227 }, 158), _0x72266a5a._0x70b8a70d(new byte[1] { 120 }, 88)).Trim();
    }

    private IEnumerator _0xa2b97b5e(string _0x75a253bd)
    {
        if (_0x9759c03b != null && _0xf01a1844)
            yield break;
        _0x9759c03b = gameObject.AddComponent<UniWebView>();
        _0x43386711(_0x9759c03b);
        _0xc60c26d5(_0x9759c03b);
        _0x9759c03b.BackgroundColor = Color.clear;
        var _0x48ae6835 = SceneManager.GetActiveScene().GetRootGameObjects();
        if (Camera.main != null)
        {
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
            Camera.main.backgroundColor = Color.clear;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForEndOfFrame();
        _0xb095cbcc();
        yield return new WaitForEndOfFrame();
        _0xf01a1844 = true;
        _0xc32e66b2();
        _0xa2842775(true);
        _0x930d6f8a = false;
        _0xb25d74f8 = false;
        _0x4f9cd452.Clear();
        _0x60874333 = -1;
        firstLoadShown = false;
        _0x57f2bae4 = false;
        _0x630999f7 = false;
        _0x9759c03b.SetUserAgent("");
        _0x44c76817 = Time.realtimeSinceStartup;
        _0x9759c03b.Stop();
        _0x9759c03b.Load(_0x75a253bd);
        _0x9759c03b.Show(false, UniWebViewTransitionEdge.None, 0f, null);
        WLog(_0x72266a5a._0x70b8a70d(new byte[25] { 112, 92, 84, 83, 29, 106, 88, 95, 107, 84, 88, 74, 29, 116, 83, 84, 73, 84, 92, 81, 29, 110, 85, 82, 74 }, 61));
    }

    private void StopCurrentFailedLoad(UniWebView _0x5f4e4305)
    {
        _0xa2842775(false);
        if (_0x5f4e4305 == null)
            return;
        _0x5f4e4305.Stop();
        if (_0x5f4e4305.CanGoBack)
            _0x5f4e4305.GoBack();
    }

    private bool _0x930d6f8a = false;
    private bool _0xda781e03()
    {
        var _0x7dd159c1 = _0x539084d6();
        if (_0x7dd159c1 == null)
            return false;
        WLog(_0x72266a5a._0x70b8a70d(new byte[31] { 229, 204, 223, 201, 218, 204, 223, 200, 141, 207, 204, 206, 198, 141, 128, 147, 141, 221, 194, 221, 216, 221, 141, 234, 194, 239, 204, 206, 198, 151, 141 }, 173) + _0x7dd159c1.Id);
        _0x7dd159c1.GoBack();
        return true;
    }

    private string _0xbe180e55;
    private string _0x62dda424 = "";
    private string _0x8285fe20 = "";
    private static string ReadPushField(Dictionary<string, object> _0xf8e6f41e, string _0xe5370d22)
    {
        if (_0xf8e6f41e == null || string.IsNullOrEmpty(_0xe5370d22))
            return string.Empty;
        if (_0xf8e6f41e.TryGetValue(_0x72266a5a._0x70b8a70d(new byte[16] { 163, 162, 185, 164, 171, 164, 174, 172, 185, 164, 162, 163, 137, 172, 185, 172 }, 205), out var raw))
        {
            try
            {
                var _0xce0d6a5a = JsonConvert.DeserializeObject<Dictionary<string, object>>(raw?.ToString());
                if (_0xce0d6a5a != null && _0xce0d6a5a.TryGetValue(_0xe5370d22, out var nestedVal))
                {
                    var _0xd296c47c = nestedVal?.ToString();
                    if (!string.IsNullOrEmpty(_0xd296c47c))
                        return _0xd296c47c;
                }
            }
            catch
            {
            }
        }

        if (_0xf8e6f41e.TryGetValue(_0xe5370d22, out var flatVal))
            return flatVal?.ToString() ?? string.Empty;
        return string.Empty;
    }

    public void _0x7e89f374()
    {
        isDestroyedForce = true;
        StopAllCoroutines();
        {
#if B_LOGS
            Debug.Log(_0x72266a5a._0x70b8a70d(new byte[18] { 145, 158, 175, 185, 190, 151, 234, 134, 171, 191, 164, 169, 162, 234, 141, 171, 167, 175 }, 202));
#endif
        }

        _0x67c373b3.Instance?._0x59f8a8d7();
        _0x3cddbc40.Instance._0x595a3d0b(_0xec7175f7._0xd6f8c568.DEFAULT);
    }

    private Canvas _0xca20718d()
    {
        if (_0x19702282 != null)
            return _0x19702282;
        var _0xbfa687d7 = gameObject.GetComponentInChildren<Canvas>();
        if (_0xbfa687d7 == null)
        {
            var _0xf744f3ca = new GameObject(_0x72266a5a._0x70b8a70d(new byte[6] { 97, 67, 76, 84, 67, 81 }, 34), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            _0xbfa687d7 = _0xf744f3ca.GetComponent<Canvas>();
            _0xbfa687d7.transform.SetParent(transform, false);
            _0xbfa687d7.renderMode = RenderMode.ScreenSpaceOverlay;
        }

        _0x19702282 = _0xbfa687d7;
        return _0x19702282;
    }

    internal Rect lastSafe = Rect.zero;
    private string GetUrlHost(string _0xca455716)
    {
        if (string.IsNullOrEmpty(_0xca455716))
            return null;
        Uri _0x1d8857b1;
        if (!Uri.TryCreate(_0xca455716, UriKind.Absolute, out _0x1d8857b1))
            return null;
        string _0xec20ffdc = _0x1d8857b1.Host;
        if (_0xec20ffdc.StartsWith(_0x72266a5a._0x70b8a70d(new byte[4] { 163, 163, 163, 250 }, 212), StringComparison.OrdinalIgnoreCase))
            _0xec20ffdc = _0xec20ffdc.Substring(4);
        return _0xec20ffdc;
    }

    internal bool _0x4a3c8263(string _0x91c3fb3b)
    {
        return _0x91c3fb3b.StartsWith(_0x72266a5a._0x70b8a70d(new byte[9] { 19, 31, 12, 21, 27, 10, 68, 81, 81 }, 126), StringComparison.OrdinalIgnoreCase) || _0x91c3fb3b.StartsWith(_0x72266a5a._0x70b8a70d(new byte[24] { 41, 53, 53, 49, 50, 123, 110, 110, 49, 45, 32, 56, 111, 38, 46, 46, 38, 45, 36, 111, 34, 46, 44, 110 }, 65), StringComparison.OrdinalIgnoreCase) || _0x91c3fb3b.StartsWith(_0x72266a5a._0x70b8a70d(new byte[23] { 46, 50, 50, 54, 124, 105, 105, 54, 42, 39, 63, 104, 33, 41, 41, 33, 42, 35, 104, 37, 41, 43, 105 }, 70), StringComparison.OrdinalIgnoreCase);
    }

    private string _0x6a424440 = "";
    private bool TryOpenExternalLikeChrome(string _0x52d25e5e)
    {
        if (string.IsNullOrEmpty(_0x52d25e5e))
            return false;
        if (_0x52d25e5e.StartsWith(_0x72266a5a._0x70b8a70d(new byte[9] { 54, 49, 43, 58, 49, 43, 101, 112, 112 }, 95), StringComparison.OrdinalIgnoreCase))
            return _0xc43f44f3(_0x52d25e5e);
        if (_0x4a3c8263(_0x52d25e5e))
            return _0xfcf7c742(_0x52d25e5e, null);
        if (!_0x52d25e5e.StartsWith(_0x72266a5a._0x70b8a70d(new byte[7] { 75, 87, 87, 83, 25, 12, 12 }, 35), StringComparison.OrdinalIgnoreCase) && !_0x52d25e5e.StartsWith(_0x72266a5a._0x70b8a70d(new byte[8] { 124, 96, 96, 100, 103, 46, 59, 59 }, 20), StringComparison.OrdinalIgnoreCase) && !_0x52d25e5e.StartsWith(_0x72266a5a._0x70b8a70d(new byte[11] { 128, 131, 142, 148, 149, 219, 131, 141, 128, 143, 138 }, 225), StringComparison.OrdinalIgnoreCase))
        {
            return _0x1372ed75(_0x52d25e5e);
        }

        return false;
    }

    private string _0xa11102c8(string _0xa83e6e52, string _0xb1f6b87a)
    {
        if (string.IsNullOrEmpty(_0xb1f6b87a))
            return _0xa83e6e52;
        if (_0xa83e6e52.Contains(_0x72266a5a._0x70b8a70d(new byte[1] { 222 }, 225)))
            return _0xa83e6e52 + _0x72266a5a._0x70b8a70d(new byte[8] { 111, 58, 44, 39, 45, 32, 45, 116 }, 73) + UnityWebRequest.EscapeURL(_0xb1f6b87a);
        else
            return _0xa83e6e52 + _0x72266a5a._0x70b8a70d(new byte[8] { 244, 184, 174, 165, 175, 162, 175, 246 }, 203) + UnityWebRequest.EscapeURL(_0xb1f6b87a);
    }

    private void OnApplicationFocus(bool _0x54c27052)
    {
        isApplicationFocus = _0x54c27052;
        if (_0x54c27052 && _0xf01a1844)
        {
            _0x3b70b268();
        }
    }

    private async Task _0x498bb29d()
    {
        {
#if B_LOGS
            Debug.Log($"[Test] Send click");
#endif
        }

        _0x62dda424 = _0x72266a5a._0x70b8a70d(new byte[5] { 29, 26, 23, 8, 30 }, 123);
        _0x8c76d9a3 = /*IsRunningOnEmulator() ? "running" :*/ "";
        _0xa60a71c8 = DateTime.UtcNow.Ticks.ToString();
        _0x4b2c96b0 = "";
        JObject _0x33c3ceb8 = _0x5d2b6ecd(_0x18991108, _0x86cc6dc4, _0x8285fe20, _0x6a424440, _0xc7f73dc9, _0x91f6ede4, _0xc2958a44, _0x8a3aa696, _0xc5c18f2c, _0xfd0ad980, _0x62dda424, _0x4b2c96b0, _0xff87ae90, _0xf9088b71, _0x857c83fa.ToString(), _0xbab36ee8, _0xa60a71c8, _0x8c76d9a3, _0xb42d0f81, _0xcc08e77f, _0x364fbeb4, _0x2f5b16e9, _0x2a846029());
        var _0xc7d57537 = _0x62c6d826(_0x33c3ceb8.ToString(), _0xb42d0f81);
        {
#if B_LOGS
            {
                Debug.Log($"[Test][First Run] Send Payload for first run: {_0x33c3ceb8}");
            }
#endif
        }

        try
        {
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x72266a5a._0x70b8a70d(new byte[7] { 79, 94, 70, 83, 80, 94, 91 }, 63) + _0xb42d0f81, _0xc7d57537 } });
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x72266a5a._0x70b8a70d(new byte[22] { 186, 181, 164, 178, 181, 188, 193, 166, 132, 143, 132, 147, 128, 141, 193, 132, 147, 147, 142, 147, 219, 193 }, 225) + e.Message);
#endif
            }
        }

        await Task.Delay(500);
        string _0x9ad74d87 = "";
        for (int _0x2c123ff3 = 0; _0x2c123ff3 < 30; _0x2c123ff3++)
        {
            if (await _0xb783b2fd(1, 1))
            {
                await _0x7077cf8d(_0x72266a5a._0x70b8a70d(new byte[7] { 55, 57, 58, 54, 62, 48, 49 }, 85));
                _0x7e89f374();
                return;
            }

            _0x9ad74d87 = await _0x9b315271(1, 500);
            if (!string.IsNullOrEmpty(_0x9ad74d87))
                break;
        }

        _0x24718653(_0x9ad74d87);
    }

    private string _0x30930fc2()
    {
        string _0x531a317b = _0x72266a5a._0x70b8a70d(new byte[62] { 0, 3, 2, 5, 4, 7, 6, 9, 8, 11, 10, 13, 12, 15, 14, 17, 16, 19, 18, 21, 20, 23, 22, 25, 24, 27, 32, 35, 34, 37, 36, 39, 38, 41, 40, 43, 42, 45, 44, 47, 46, 49, 48, 51, 50, 53, 52, 55, 54, 57, 56, 59, 81, 80, 83, 82, 85, 84, 87, 86, 89, 88 }, 97);
        int _0x279900a7 = RandomNumberGenerator.GetInt32(8, 16);
        char[] _0x5cb8d234 = new char[_0x279900a7];
        for (int _0xff18e310 = 0; _0xff18e310 < _0x279900a7; _0xff18e310++)
            _0x5cb8d234[_0xff18e310] = _0x531a317b[RandomNumberGenerator.GetInt32(_0x531a317b.Length)];
        return new string (_0x5cb8d234);
    }

    private void _0x826d7a1e()
    {
        _0xb25d74f8 = true;
        if (_0x9759c03b != null)
            _0x9759c03b.SetUserAgent(_0x791d4e75());
    }

    private bool _0xcf294805()
    {
        _0x4f9cd452.RemoveAll(_0x269b026e => _0x269b026e == null || !_0x269b026e.IsAlive);
        return _0x4f9cd452.Count > 0;
    }

    // PART 3
    private string _0x05d0a238()
    {
        try
        {
            var _0x1cd897ea = new AndroidJavaClass(_0x72266a5a._0x70b8a70d(new byte[30] { 43, 39, 37, 102, 61, 38, 33, 60, 49, 123, 44, 102, 56, 36, 41, 49, 45, 58, 102, 29, 38, 33, 60, 49, 24, 36, 41, 49, 45, 58 }, 72));
            var _0xff97bb3a = _0x1cd897ea.GetStatic<AndroidJavaObject>(_0x72266a5a._0x70b8a70d(new byte[15] { 154, 140, 139, 139, 156, 151, 141, 184, 154, 141, 144, 143, 144, 141, 128 }, 249));
            var _0x418cabd5 = new AndroidJavaClass(_0x72266a5a._0x70b8a70d(new byte[57] { 167, 171, 169, 234, 163, 171, 171, 163, 168, 161, 234, 165, 170, 160, 182, 171, 173, 160, 234, 163, 169, 183, 234, 165, 160, 183, 234, 173, 160, 161, 170, 176, 173, 162, 173, 161, 182, 234, 133, 160, 178, 161, 182, 176, 173, 183, 173, 170, 163, 141, 160, 135, 168, 173, 161, 170, 176 }, 196));
            var _0x3d056df3 = _0x418cabd5.CallStatic<AndroidJavaObject>(_0x72266a5a._0x70b8a70d(new byte[20] { 119, 117, 100, 81, 116, 102, 117, 98, 100, 121, 99, 121, 126, 119, 89, 116, 89, 126, 118, 127 }, 16), _0xff97bb3a);
            var _0x2c255ed3 = _0x3d056df3.Call<string>(_0x72266a5a._0x70b8a70d(new byte[5] { 135, 133, 148, 169, 132 }, 224));
            {
#if B_LOGS
                Debug.Log($"[Test] Google Advertiding Id (ad id): {_0x2c255ed3}");
#endif
            }

            return string.IsNullOrEmpty(_0x2c255ed3) ? "" : _0x2c255ed3;
        }
        catch
        {
            return "";
        }
    }

    // WEB VIEW LOGIC
    public bool _0xf01a1844 { get; set; }

    internal bool firstLoadShown = false;
    internal bool isApplicationFocus = false;
    private void _0xc60c26d5(UniWebView _0x0c6cc1d6)
    {
        if (_0x9ef6d098)
            return;
        _0x9ef6d098 = true;
        _0x0c6cc1d6.AddUrlScheme(_0x72266a5a._0x70b8a70d(new byte[2] { 182, 165 }, 194));
        _0x0c6cc1d6.AddUrlScheme(_0x72266a5a._0x70b8a70d(new byte[6] { 169, 174, 180, 165, 174, 180 }, 192));
        _0x0c6cc1d6.AddUrlScheme(_0x72266a5a._0x70b8a70d(new byte[6] { 11, 7, 20, 13, 3, 18 }, 102));
        _0x0c6cc1d6.OnMessageReceived += (_0x0298265a, _0xeea336ad) =>
        {
            if (TryOpenExternalLikeChrome(_0xeea336ad.RawMessage))
            {
                _0xa2842775(false);
                return;
            }
        };
        _0x0c6cc1d6.RegisterShouldHandleRequest(_0xa0d11994 =>
        {
            string _0xb97ba75e = _0xa0d11994 != null ? _0xa0d11994.Url : string.Empty;
            if (string.IsNullOrEmpty(_0xb97ba75e))
                return true;
            WLog(_0x72266a5a._0x70b8a70d(new byte[21] { 150, 173, 170, 176, 169, 161, 141, 164, 171, 161, 169, 160, 151, 160, 180, 176, 160, 182, 177, 255, 229 }, 197) + _0xb97ba75e);
            if (TryOpenExternalLikeChrome(_0xb97ba75e))
            {
                _0xa2842775(false);
                return false;
            }

            if (_0xa0d11994 != null && _0xa0d11994.IsMainFrame && IsGoogleAuthFlowUrl(_0xb97ba75e) && !_0xb25d74f8)
            {
                WLog(_0x72266a5a._0x70b8a70d(new byte[62] { 57, 21, 29, 26, 84, 35, 17, 22, 34, 29, 17, 3, 84, 16, 17, 0, 17, 23, 0, 17, 16, 84, 51, 27, 27, 19, 24, 17, 84, 21, 1, 0, 28, 84, 33, 38, 56, 84, 89, 74, 84, 6, 17, 24, 27, 21, 16, 84, 3, 29, 0, 28, 84, 51, 27, 27, 19, 24, 17, 84, 33, 53 }, 116));
                _0xb25d74f8 = true;
                _0xa2842775(true);
                _0x9759c03b.SetUserAgent(_0x791d4e75());
                _0x9759c03b.Load(_0xb97ba75e);
                return false;
            }

            return true;
        });
        _0x0c6cc1d6.OnLoadingErrorReceived += (_0x0298265a, _0x57d0f380, _0xeea336ad, _0xbf8d64b4) =>
        {
            WLog(_0x72266a5a._0x70b8a70d(new byte[25] { 94, 114, 122, 125, 51, 68, 118, 113, 69, 122, 118, 100, 51, 86, 97, 97, 124, 97, 41, 51, 112, 124, 119, 118, 46 }, 19) + _0x57d0f380 + _0x72266a5a._0x70b8a70d(new byte[9] { 130, 207, 199, 209, 209, 195, 197, 199, 159 }, 162) + _0xeea336ad);
            string _0xc2c5c7d1 = GetFailingUrl(_0xbf8d64b4);
            if (string.IsNullOrEmpty(_0xc2c5c7d1) || IsAboutBlank(_0xc2c5c7d1))
                return;
            if (IsSslError(_0x57d0f380, _0xeea336ad) && _0x0b4f3757(_0xc2c5c7d1))
            {
                WLog(_0x72266a5a._0x70b8a70d(new byte[52] { 202, 228, 237, 236, 241, 230, 163, 208, 208, 207, 163, 230, 241, 241, 236, 241, 163, 236, 246, 247, 240, 234, 231, 230, 163, 247, 235, 230, 163, 238, 226, 234, 237, 163, 231, 236, 224, 246, 238, 230, 237, 247, 185, 163, 229, 226, 234, 239, 234, 237, 228, 190 }, 131) + _0xc2c5c7d1 + _0x72266a5a._0x70b8a70d(new byte[6] { 193, 140, 128, 136, 143, 220 }, 225) + _0x6a779d8f + _0x72266a5a._0x70b8a70d(new byte[11] { 40, 107, 103, 101, 101, 97, 124, 124, 109, 108, 53 }, 8) + _0x8aa14721);
                return;
            }

            _ = _0x7077cf8d(_0x72266a5a._0x70b8a70d(new byte[8] { 254, 255, 214, 236, 251, 251, 230, 251 }, 137));
            WLog(_0x72266a5a._0x70b8a70d(new byte[45] { 12, 32, 40, 47, 97, 22, 36, 35, 23, 40, 36, 54, 97, 39, 32, 40, 45, 40, 47, 38, 97, 20, 19, 13, 97, 108, 127, 97, 46, 49, 36, 47, 97, 36, 57, 53, 36, 51, 47, 32, 45, 45, 56, 123, 97 }, 65) + _0xc2c5c7d1);
            StopCurrentFailedLoad(_0x0298265a);
            _0x568d67d6(_0xc2c5c7d1);
        };
        _0x0c6cc1d6.OnPageStarted += (_0x0298265a, _0x2d7384a0) =>
        {
            _0xefcae57c = 0;
            if (_0x930d6f8a && IsAboutBlank(_0x2d7384a0))
            {
                WLog(_0x72266a5a._0x70b8a70d(new byte[27] { 24, 58, 45, 63, 41, 58, 37, 104, 41, 42, 39, 61, 60, 114, 42, 36, 41, 38, 35, 104, 59, 60, 41, 58, 60, 45, 44 }, 72));
                return;
            }

            _0x8aa14721 = false;
            string _0x26862390 = GetUrlHost(_0x2d7384a0);
            if (!string.IsNullOrEmpty(_0x26862390))
                _0x6a779d8f = _0x26862390;
            WLog(_0x72266a5a._0x70b8a70d(new byte[29] { 170, 134, 142, 137, 199, 176, 130, 133, 177, 142, 130, 144, 199, 168, 137, 183, 134, 128, 130, 180, 147, 134, 149, 147, 130, 131, 221, 199, 204 }, 231) + (Time.realtimeSinceStartup - _0x44c76817).ToString(_0x72266a5a._0x70b8a70d(new byte[5] { 55, 41, 55, 55, 55 }, 7)) + _0x72266a5a._0x70b8a70d(new byte[2] { 82, 1 }, 33) + _0x2d7384a0);
            if (TryOpenExternalLikeChrome(_0x2d7384a0))
            {
                StopCurrentFailedLoad(_0x0298265a);
                return;
            }

            if (ContainsIgnoreCase(_0x2d7384a0, _0x72266a5a._0x70b8a70d(new byte[8] { 6, 11, 11, 3, 76, 3, 18, 18 }, 98)) || ContainsIgnoreCase(_0x2d7384a0, _0x72266a5a._0x70b8a70d(new byte[15] { 205, 220, 196, 147, 202, 212, 217, 218, 216, 201, 147, 223, 209, 210, 218 }, 189)) || _0x2d7384a0.StartsWith(_0x72266a5a._0x70b8a70d(new byte[25] { 127, 99, 99, 103, 100, 45, 56, 56, 117, 103, 112, 123, 120, 117, 118, 123, 113, 118, 97, 57, 123, 126, 97, 114, 56 }, 23), StringComparison.OrdinalIgnoreCase))
            {
                StopCurrentFailedLoad(_0x0298265a);
                OpenUrlExternally(_0x2d7384a0);
                return;
            }

            if (IsGoogleAuthFlowUrl(_0x2d7384a0))
            {
                _0xa2842775(true);
                WLog(_0x72266a5a._0x70b8a70d(new byte[41] { 189, 149, 149, 157, 150, 159, 218, 155, 143, 142, 146, 218, 156, 150, 149, 141, 218, 158, 159, 142, 159, 153, 142, 159, 158, 218, 215, 196, 218, 145, 159, 159, 138, 218, 140, 147, 137, 147, 152, 150, 159 }, 250));
                return;
            }

            _0x57f2bae4 = true;
            _0xa2842775(true);
            WLog(_0x72266a5a._0x70b8a70d(new byte[43] { 170, 152, 159, 171, 148, 152, 138, 221, 145, 146, 156, 153, 148, 147, 154, 210, 143, 152, 153, 148, 143, 152, 158, 137, 148, 147, 154, 221, 208, 195, 221, 150, 152, 152, 141, 221, 139, 148, 142, 148, 159, 145, 152 }, 253));
        };
        _0x0c6cc1d6.OnPageCommitted += (_0x0298265a, _0x2d7384a0) =>
        {
            if (_0x930d6f8a && IsAboutBlank(_0x2d7384a0))
                return;
            MarkMainFrameCommitted(_0x2d7384a0);
            WLog(_0x72266a5a._0x70b8a70d(new byte[31] { 192, 236, 228, 227, 173, 218, 232, 239, 219, 228, 232, 250, 173, 194, 227, 221, 236, 234, 232, 206, 226, 224, 224, 228, 249, 249, 232, 233, 183, 173, 166 }, 141) + (Time.realtimeSinceStartup - _0x44c76817).ToString(_0x72266a5a._0x70b8a70d(new byte[5] { 2, 28, 2, 2, 2 }, 50)) + _0x72266a5a._0x70b8a70d(new byte[2] { 206, 157 }, 189) + _0x2d7384a0);
            if (!firstLoadShown && IsHttpUrl(_0x2d7384a0))
            {
                firstLoadShown = true;
                _0x57f2bae4 = false;
                _0xa2842775(false);
                _0x9fec9c00();
                _0xb095cbcc();
                _0x0298265a.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x7077cf8d(_0x72266a5a._0x70b8a70d(new byte[9] { 5, 4, 45, 29, 2, 23, 28, 23, 22 }, 114));
                WLog(_0x72266a5a._0x70b8a70d(new byte[39] { 186, 150, 158, 153, 215, 160, 146, 149, 161, 158, 146, 128, 215, 132, 159, 152, 128, 153, 215, 152, 153, 215, 148, 152, 154, 154, 158, 131, 131, 146, 147, 215, 148, 152, 153, 131, 146, 153, 131 }, 247));
            }
        };
        _0x0c6cc1d6.OnPageProgressChanged += (_0x0298265a, _0x27fca580) =>
        {
            if (_0x930d6f8a)
                return;
            if (!firstLoadShown && _0x27fca580 >= 0.65f)
            {
                firstLoadShown = true;
                _0x57f2bae4 = false;
                _0xa2842775(false);
                _0x9fec9c00();
                _0xb095cbcc();
                _0x0298265a.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x7077cf8d(_0x72266a5a._0x70b8a70d(new byte[9] { 242, 243, 218, 234, 245, 224, 235, 224, 225 }, 133));
                WLog(_0x72266a5a._0x70b8a70d(new byte[32] { 7, 43, 35, 36, 106, 29, 47, 40, 28, 35, 47, 61, 106, 57, 34, 37, 61, 36, 106, 40, 51, 106, 58, 56, 37, 45, 56, 47, 57, 57, 112, 106 }, 74) + _0x27fca580);
            }
        };
        _0x0c6cc1d6.OnPageFinished += (_0x0298265a, _0x57d0f380, _0x2d7384a0) =>
        {
            if (_0x930d6f8a && IsAboutBlank(_0x2d7384a0))
            {
                _0x930d6f8a = false;
                WLog(_0x72266a5a._0x70b8a70d(new byte[28] { 166, 132, 147, 129, 151, 132, 155, 214, 151, 148, 153, 131, 130, 204, 148, 154, 151, 152, 157, 214, 144, 159, 152, 159, 133, 158, 147, 146 }, 246));
                return;
            }

            WLog(_0x72266a5a._0x70b8a70d(new byte[24] { 185, 149, 157, 154, 212, 163, 145, 150, 162, 157, 145, 131, 212, 178, 157, 154, 157, 135, 156, 145, 144, 206, 212, 223 }, 244) + (Time.realtimeSinceStartup - _0x44c76817).ToString(_0x72266a5a._0x70b8a70d(new byte[5] { 131, 157, 131, 131, 131 }, 179)) + _0x72266a5a._0x70b8a70d(new byte[7] { 121, 42, 105, 101, 110, 111, 55 }, 10) + _0x57d0f380 + _0x72266a5a._0x70b8a70d(new byte[5] { 154, 207, 200, 214, 135 }, 186) + _0x2d7384a0);
            if (_0x57d0f380 >= 200 && _0x57d0f380 < 400)
                MarkMainFrameCommitted(_0x2d7384a0);
            if (!firstLoadShown)
            {
                firstLoadShown = true;
                _0x57f2bae4 = false;
                _0xa2842775(false);
                _0x9fec9c00();
                _0xb095cbcc();
                _0x0298265a.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x7077cf8d(_0x72266a5a._0x70b8a70d(new byte[9] { 54, 55, 30, 46, 49, 36, 47, 36, 37 }, 65));
                WLog(_0x72266a5a._0x70b8a70d(new byte[33] { 95, 115, 123, 124, 50, 69, 119, 112, 68, 123, 119, 101, 50, 116, 123, 96, 97, 102, 50, 126, 125, 115, 118, 50, 113, 125, 127, 98, 126, 119, 102, 119, 118 }, 18));
            }
            else if (_0x57f2bae4)
            {
                _0x57f2bae4 = false;
                _0xa2842775(false);
                _0x0298265a.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                WLog(_0x72266a5a._0x70b8a70d(new byte[40] { 240, 220, 212, 211, 157, 234, 216, 223, 235, 212, 216, 202, 157, 238, 213, 210, 202, 157, 220, 219, 201, 216, 207, 157, 209, 210, 220, 217, 212, 211, 218, 157, 219, 212, 211, 212, 206, 213, 216, 217 }, 189));
            }
            else
            {
                _0xa2842775(false);
            }

            if (_0xb25d74f8 && !IsGoogleAuthFlowUrl(_0x2d7384a0) && !IsGoogleAuthFlowUrl(_0x2d7384a0))
            {
                WLog(_0x72266a5a._0x70b8a70d(new byte[48] { 158, 182, 182, 190, 181, 188, 249, 184, 172, 173, 177, 249, 170, 188, 188, 180, 170, 249, 191, 176, 183, 176, 170, 177, 188, 189, 249, 244, 231, 249, 171, 188, 170, 173, 182, 171, 188, 249, 189, 188, 191, 184, 172, 181, 173, 249, 140, 152 }, 217));
                _0xb25d74f8 = false;
                _0x9759c03b.SetUserAgent("");
            }
        };
        _0x0c6cc1d6.OnShouldClose += _0x0298265a =>
        {
            WLog(_0x72266a5a._0x70b8a70d(new byte[41] { 36, 43, 26, 12, 11, 34, 95, 50, 30, 22, 17, 95, 40, 26, 29, 41, 22, 26, 8, 95, 48, 17, 44, 23, 16, 10, 19, 27, 60, 19, 16, 12, 26, 95, 22, 17, 9, 16, 20, 26, 27 }, 127));
            _0x3e5d0328();
            return false;
        };
        // POPUP HANDLING LOGIC
        _0x0c6cc1d6.SetPopupPageEventEnabled(true);
        bool _0x7e8259a7 = false;
        bool _0x268a6d21 = false;
        _0x0c6cc1d6.OnMultipleWindowOpened += (_0x0298265a, _0xf2696db3) =>
        {
            _0x0298265a.ScrollTo(0, 0, false);
            WLog(_0x72266a5a._0x70b8a70d(new byte[43] { 178, 189, 140, 154, 157, 180, 201, 164, 136, 128, 135, 201, 190, 140, 139, 191, 128, 140, 158, 201, 164, 156, 133, 157, 128, 153, 133, 140, 190, 128, 135, 141, 134, 158, 201, 166, 153, 140, 135, 140, 141, 211, 201 }, 233) + _0xf2696db3);
            var _0x35cf1c07 = _0x0c6cc1d6.GetPopupWindow(_0xf2696db3);
            if (_0x35cf1c07 == null)
                return;
            _0x4f9cd452.Add(_0x35cf1c07);
            Debug.Log($"[Test] Popup ID: {_0x35cf1c07.Id}");
            _0x35cf1c07.OnPageStarted += (_0x00545242, _0x2d7384a0) =>
            {
                WLog(_0x72266a5a._0x70b8a70d(new byte[36] { 75, 68, 117, 99, 100, 77, 48, 64, 127, 96, 101, 96, 48, 71, 117, 114, 70, 121, 117, 103, 48, 95, 126, 64, 113, 119, 117, 67, 100, 113, 98, 100, 117, 116, 42, 48 }, 16) + _0x2d7384a0);
                _0xefcae57c = 0;
                if (string.IsNullOrEmpty(_0x2d7384a0) || IsAboutBlank(_0x2d7384a0))
                    return;
                if (IsGoogleAuthFlowUrl(_0x2d7384a0))
                {
                    WLog(_0x72266a5a._0x70b8a70d(new byte[57] { 42, 37, 20, 2, 5, 44, 81, 33, 30, 1, 4, 1, 81, 54, 30, 30, 22, 29, 20, 81, 16, 4, 5, 25, 81, 23, 29, 30, 6, 81, 92, 79, 81, 2, 1, 30, 30, 23, 81, 54, 30, 30, 22, 29, 20, 81, 50, 25, 3, 30, 28, 20, 81, 36, 48, 75, 81 }, 113) + _0x2d7384a0);
                    _0x7e8259a7 = false;
                    _0x826d7a1e();
                    if (_0x00545242 != null && _0x00545242.IsAlive)
                        _0x00545242.EvaluateJavaScript(_0x88bf4993());
                    return;
                }

                if (_0x9759c03b == null)
                    return;
                if (!_0x7e8259a7)
                {
                    _0x7e8259a7 = true;
                    _0x9759c03b.SetUserAgent(WindowsDesktopUserAgent);
                    WLog(_0x72266a5a._0x70b8a70d(new byte[39] { 5, 10, 59, 45, 42, 3, 126, 14, 49, 46, 43, 46, 126, 63, 46, 46, 50, 39, 126, 9, 55, 48, 58, 49, 41, 45, 126, 58, 59, 45, 53, 42, 49, 46, 126, 11, 31, 100, 126 }, 94) + _0x2d7384a0);
                }

                if (_0x00545242 != null && _0x00545242.IsAlive)
                    _0x00545242.EvaluateJavaScript(_0x5a348d20());
                if (!_0x268a6d21 && _0x00545242 != null && _0x00545242.IsAlive && IsHttpUrl(_0x2d7384a0))
                {
                    _0x268a6d21 = true;
                }
            };
            _0x35cf1c07.OnPageFinished += (_0x00545242, _0xbf8d64b4) =>
            {
                string _0x5ae5584e = _0xbf8d64b4 != null ? _0xbf8d64b4.data : string.Empty;
                WLog(_0x72266a5a._0x70b8a70d(new byte[35] { 165, 170, 155, 141, 138, 163, 222, 174, 145, 142, 139, 142, 222, 169, 155, 156, 168, 151, 155, 137, 222, 184, 151, 144, 151, 141, 150, 155, 154, 196, 222, 139, 140, 146, 195 }, 254) + _0x5ae5584e);
                if (_0x00545242 == null || !_0x00545242.IsAlive)
                    return;
                if (IsGoogleAuthFlowUrl(_0x5ae5584e))
                {
                    _0x826d7a1e();
                    _0x00545242.EvaluateJavaScript(_0x88bf4993());
                    return;
                }

                if (!_0x7e8259a7)
                    return;
                _0x00545242.EvaluateJavaScript(_0x5a348d20());
            };
        };
        _0x0c6cc1d6.OnMultipleWindowClosed += (_0x0298265a, _0xf2696db3) =>
        {
            _0x4f9cd452.RemoveAll(_0x269b026e => _0x269b026e == null || _0x269b026e.Id == _0xf2696db3 || !_0x269b026e.IsAlive);
            _0xa2842775(false);
            if (_0x4f9cd452.Count == 0 && _0x9759c03b != null)
            {
                _0x7e8259a7 = false;
                _0x268a6d21 = false;
                _0x72e44084();
            }

            WLog(_0x72266a5a._0x70b8a70d(new byte[43] { 26, 21, 36, 50, 53, 28, 97, 12, 32, 40, 47, 97, 22, 36, 35, 23, 40, 36, 54, 97, 12, 52, 45, 53, 40, 49, 45, 36, 22, 40, 47, 37, 46, 54, 97, 2, 45, 46, 50, 36, 37, 123, 97 }, 65) + _0xf2696db3);
        };
        _0x0c6cc1d6.RegisterOnRequestMediaCapturePermission(_0xa0d11994 =>
        {
            if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
            {
                Permission.RequestUserPermission(Permission.Camera);
                return UniWebViewMediaCapturePermissionDecision.Prompt;
            }

            return UniWebViewMediaCapturePermissionDecision.Grant;
        });
    }

    // NATIVE WEB VIEW METHODS
    private UniWebView _0x9759c03b = null;
    private bool _0x65cccbb4 = false;
    private string _0xff87ae90 = "";
    private bool _0xfcf7c742(string _0xcadd8872, string _0x5b8718c2)
    {
        string _0x7cce5b1d = _0x40692838(_0xcadd8872);
        if (string.IsNullOrEmpty(_0x7cce5b1d))
            _0x7cce5b1d = _0x5b8718c2;
        if (_0xb76e2412(_0x7cce5b1d))
            return true;
        string _0x50b7fef1 = string.IsNullOrEmpty(_0x7cce5b1d) ? _0x72266a5a._0x70b8a70d(new byte[29] { 42, 54, 54, 50, 49, 120, 109, 109, 50, 46, 35, 59, 108, 37, 45, 45, 37, 46, 39, 108, 33, 45, 47, 109, 49, 54, 45, 48, 39 }, 66) : _0x72266a5a._0x70b8a70d(new byte[46] { 83, 79, 79, 75, 72, 1, 20, 20, 75, 87, 90, 66, 21, 92, 84, 84, 92, 87, 94, 21, 88, 84, 86, 20, 72, 79, 84, 73, 94, 20, 90, 75, 75, 72, 20, 95, 94, 79, 90, 82, 87, 72, 4, 82, 95, 6 }, 59) + _0x7cce5b1d;
        WLog(_0x72266a5a._0x70b8a70d(new byte[35] { 181, 158, 132, 153, 155, 147, 186, 159, 157, 147, 214, 155, 151, 132, 157, 147, 130, 214, 144, 151, 154, 154, 148, 151, 149, 157, 214, 151, 133, 214, 129, 147, 148, 204, 214 }, 246) + _0x50b7fef1);
        return _0x1372ed75(_0x50b7fef1);
    }

    private string _0xcc08e77f = "";
    internal Button _0x237114b5(string _0x18db5cb9, Transform _0xebee8198)
    {
        var _0x2e006053 = new GameObject(_0x18db5cb9 + _0x72266a5a._0x70b8a70d(new byte[3] { 187, 141, 151 }, 249), typeof(RectTransform), typeof(Image), typeof(Button));
        var _0xfd3ff980 = _0x2e006053.GetComponent<RectTransform>();
        _0xfd3ff980.SetParent(_0xebee8198, false);
        var _0x0ce426a2 = _0x2e006053.GetComponent<Image>();
        _0x0ce426a2.color = new Color(0.92f, 0.92f, 0.95f, 1f);
        var _0x7cadc6ab = _0x2e006053.GetComponent<Button>();
        var _0x498de59b = _0x7cadc6ab.colors;
        _0x498de59b.highlightedColor = new Color(0.85f, 0.85f, 0.9f);
        _0x498de59b.pressedColor = new Color(0.8f, 0.8f, 0.88f);
        _0x7cadc6ab.colors = _0x498de59b;
        var _0xc550264d = new GameObject(_0x72266a5a._0x70b8a70d(new byte[4] { 26, 43, 54, 58 }, 78), typeof(RectTransform), typeof(Text));
        var _0xc766dff6 = _0xc550264d.GetComponent<RectTransform>();
        _0xc766dff6.SetParent(_0x2e006053.transform, false);
        _0xc766dff6.anchorMin = Vector2.zero;
        _0xc766dff6.anchorMax = Vector2.one;
        _0xc766dff6.offsetMin = _0xc766dff6.offsetMax = Vector2.zero;
        var _0xe824f103 = _0xc550264d.GetComponent<Text>();
        _0xe824f103.text = _0x18db5cb9;
        _0xe824f103.alignment = TextAnchor.MiddleCenter;
        _0xe824f103.color = Color.black;
        _0xe824f103.font = Resources.GetBuiltinResource<Font>(_0x72266a5a._0x70b8a70d(new byte[9] { 1, 50, 41, 33, 44, 110, 52, 52, 38 }, 64));
        _0xe824f103.fontSize = 28;
        WLog(_0x72266a5a._0x70b8a70d(new byte[14] { 167, 150, 129, 133, 144, 129, 166, 145, 144, 144, 139, 138, 196, 195 }, 228) + _0x18db5cb9 + _0x72266a5a._0x70b8a70d(new byte[1] { 26 }, 61));
        return _0x7cadc6ab;
    }

    // MAIN FLOW
    private bool _0xe378ba61 { get; set; }

    private async Task<bool> _0xfeb0bc77()
    {
        {
#if B_LOGS
            Debug.Log(_0x72266a5a._0x70b8a70d(new byte[37] { 246, 249, 200, 222, 217, 240, 141, 254, 196, 202, 195, 228, 195, 248, 195, 196, 217, 212, 254, 200, 223, 219, 196, 206, 200, 222, 236, 195, 194, 195, 212, 192, 194, 216, 222, 193, 212 }, 173));
#endif
        }

        const int _0x62d188a7 = 3;
        const int _0x46ea7aef = 500;
        for (int _0xa76af97b = 1; _0xa76af97b <= _0x62d188a7; _0xa76af97b++)
        {
            try
            {
                if (UnityServices.State != ServicesInitializationState.Initialized)
                    await UnityServices.InitializeAsync(new InitializationOptions());
                {
#if B_LOGS
                    Debug.Log(_0x72266a5a._0x70b8a70d(new byte[32] { 78, 65, 112, 102, 97, 72, 53, 64, 123, 124, 97, 108, 70, 112, 103, 99, 124, 118, 112, 102, 53, 92, 123, 124, 97, 124, 116, 121, 124, 111, 112, 113 }, 21));
#endif
                }

                break;
            }
            catch (Exception ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x72266a5a._0x70b8a70d(new byte[20] { 181, 164, 178, 181, 193, 180, 143, 136, 149, 152, 178, 132, 147, 151, 136, 130, 132, 146, 219, 193 }, 225) + ex.Message + _0x72266a5a._0x70b8a70d(new byte[9] { 22, 87, 66, 66, 83, 91, 70, 66, 22 }, 54) + _0xa76af97b);
#endif
                }

                if (_0xa76af97b >= _0x62d188a7)
                {
                    _0xd7c38244?._0x7e89f374();
                    return true;
                }

                await Task.Delay(_0x46ea7aef);
            }
        }

        for (int _0x31ce1577 = 1; _0x31ce1577 <= _0x62d188a7; _0x31ce1577++)
        {
            try
            {
                if (!AuthenticationService.Instance.IsSignedIn)
                    await AuthenticationService.Instance.SignInAnonymouslyAsync();
                _0xb42d0f81 = AuthenticationService.Instance.PlayerId;
                {
#if B_LOGS
                    Debug.Log(_0x72266a5a._0x70b8a70d(new byte[37] { 212, 219, 234, 252, 251, 210, 175, 220, 230, 232, 225, 162, 230, 225, 175, 206, 225, 224, 225, 246, 226, 224, 250, 252, 161, 175, 223, 227, 238, 246, 234, 253, 175, 198, 203, 181, 175 }, 143) + _0xb42d0f81);
#endif
                }

                return false;
            }
            catch (AuthenticationException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x72266a5a._0x70b8a70d(new byte[25] { 243, 226, 244, 243, 135, 244, 206, 192, 201, 138, 206, 201, 135, 230, 210, 211, 207, 135, 226, 245, 245, 232, 245, 157, 135 }, 167) + ex.Message + _0x72266a5a._0x70b8a70d(new byte[9] { 116, 53, 32, 32, 49, 57, 36, 32, 116 }, 84) + _0x31ce1577);
#endif
                }
            }
            catch (RequestFailedException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x72266a5a._0x70b8a70d(new byte[28] { 47, 62, 40, 47, 91, 40, 18, 28, 21, 86, 18, 21, 91, 41, 30, 10, 14, 30, 8, 15, 91, 62, 41, 41, 52, 41, 65, 91 }, 123) + ex.Message + _0x72266a5a._0x70b8a70d(new byte[9] { 173, 236, 249, 249, 232, 224, 253, 249, 173 }, 141) + _0x31ce1577);
#endif
                }
            }
            catch (Exception ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x72266a5a._0x70b8a70d(new byte[20] { 13, 28, 10, 13, 121, 10, 48, 62, 55, 116, 48, 55, 121, 28, 11, 11, 22, 11, 99, 121 }, 89) + ex.Message + _0x72266a5a._0x70b8a70d(new byte[9] { 172, 237, 248, 248, 233, 225, 252, 248, 172 }, 140) + _0x31ce1577);
#endif
                }
            }

            if (_0x31ce1577 >= _0x62d188a7)
            {
                _0xd7c38244?._0x7e89f374();
                return true;
            }

            await Task.Delay(_0x46ea7aef);
        }

        _0xd7c38244?._0x7e89f374();
        return true;
    }

    private UniWebViewPopup _0x539084d6()
    {
        for (int _0x2e0cacab = _0x4f9cd452.Count - 1; _0x2e0cacab >= 0; _0x2e0cacab--)
        {
            var _0xd009de1a = _0x4f9cd452[_0x2e0cacab];
            if (_0xd009de1a != null && _0xd009de1a.IsAlive)
                return _0xd009de1a;
            _0x4f9cd452.RemoveAt(_0x2e0cacab);
        }

        return null;
    }

    private string Decrypt(string _0xba34ed0d, string _0x935a5481)
    {
        try
        {
            var _0xc567aa2c = Convert.FromBase64String(_0xba34ed0d);
            using var _0xf555489d = Aes.Create();
            _0xf555489d.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0x935a5481));
            var _0xbcd3f4ac = new byte[16];
            Buffer.BlockCopy(_0xc567aa2c, 0, _0xbcd3f4ac, 0, 16);
            _0xf555489d.IV = _0xbcd3f4ac;
            using var _0x090afec7 = new MemoryStream(_0xc567aa2c, 16, _0xc567aa2c.Length - 16);
            using var _0x5423de1b = new CryptoStream(_0x090afec7, _0xf555489d.CreateDecryptor(), CryptoStreamMode.Read);
            using var _0x10f1354a = new StreamReader(_0x5423de1b, Encoding.UTF8);
            return _0x10f1354a.ReadToEnd();
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private bool _0xc43f44f3(string _0xc578d0ce)
    {
        try
        {
            using (var _0xfe2544f7 = new AndroidJavaClass(_0x72266a5a._0x70b8a70d(new byte[30] { 143, 131, 129, 194, 153, 130, 133, 152, 149, 223, 136, 194, 156, 128, 141, 149, 137, 158, 194, 185, 130, 133, 152, 149, 188, 128, 141, 149, 137, 158 }, 236)))
            using (var _0x950246f7 = _0xfe2544f7.GetStatic<AndroidJavaObject>(_0x72266a5a._0x70b8a70d(new byte[15] { 55, 33, 38, 38, 49, 58, 32, 21, 55, 32, 61, 34, 61, 32, 45 }, 84)))
            using (var _0xc63e3770 = _0x950246f7.Call<AndroidJavaObject>(_0x72266a5a._0x70b8a70d(new byte[17] { 24, 26, 11, 47, 30, 28, 20, 30, 24, 26, 50, 30, 17, 30, 24, 26, 13 }, 127)))
            using (var _0x0622e13f = new AndroidJavaClass(_0x72266a5a._0x70b8a70d(new byte[22] { 231, 232, 226, 244, 233, 239, 226, 168, 229, 233, 232, 242, 227, 232, 242, 168, 207, 232, 242, 227, 232, 242 }, 134)))
            using (var _0xe080a4b1 = _0x0622e13f.CallStatic<AndroidJavaObject>(_0x72266a5a._0x70b8a70d(new byte[8] { 119, 102, 117, 116, 98, 82, 117, 110 }, 7), _0xc578d0ce, 1))
            {
                string _0xf509e78f = _0xe080a4b1.Call<string>(_0x72266a5a._0x70b8a70d(new byte[14] { 178, 176, 161, 134, 161, 167, 188, 187, 178, 144, 173, 161, 167, 180 }, 213), _0x72266a5a._0x70b8a70d(new byte[20] { 42, 58, 39, 63, 59, 45, 58, 23, 46, 41, 36, 36, 42, 41, 43, 35, 23, 61, 58, 36 }, 72));
                string _0x09517941 = _0xe080a4b1.Call<string>(_0x72266a5a._0x70b8a70d(new byte[10] { 32, 34, 51, 23, 38, 36, 44, 38, 32, 34 }, 71));
                _0xe080a4b1.Call<AndroidJavaObject>(_0x72266a5a._0x70b8a70d(new byte[11] { 128, 133, 133, 162, 128, 149, 132, 134, 142, 147, 152 }, 225), _0x72266a5a._0x70b8a70d(new byte[33] { 179, 188, 182, 160, 189, 187, 182, 252, 187, 188, 166, 183, 188, 166, 252, 177, 179, 166, 183, 181, 189, 160, 171, 252, 144, 128, 157, 133, 129, 147, 144, 158, 151 }, 210));
                _0xe080a4b1.Call<AndroidJavaObject>(_0x72266a5a._0x70b8a70d(new byte[11] { 122, 109, 101, 103, 126, 109, 77, 112, 124, 122, 105 }, 8), _0x72266a5a._0x70b8a70d(new byte[20] { 232, 248, 229, 253, 249, 239, 248, 213, 236, 235, 230, 230, 232, 235, 233, 225, 213, 255, 248, 230 }, 138));
                if (_0xe080a4b1.Call<AndroidJavaObject>(_0x72266a5a._0x70b8a70d(new byte[15] { 210, 197, 211, 207, 204, 214, 197, 225, 195, 212, 201, 214, 201, 212, 217 }, 160), _0xc63e3770) != null)
                {
                    WLog(_0x72266a5a._0x70b8a70d(new byte[24] { 206, 229, 255, 226, 224, 232, 193, 228, 230, 232, 173, 226, 253, 232, 227, 173, 228, 227, 249, 232, 227, 249, 183, 173 }, 141) + _0xc578d0ce);
                    _0xe080a4b1.Call<AndroidJavaObject>(_0x72266a5a._0x70b8a70d(new byte[8] { 142, 139, 139, 169, 131, 142, 136, 156 }, 239), 0x10000000);
                    _0x950246f7.Call(_0x72266a5a._0x70b8a70d(new byte[13] { 8, 15, 26, 9, 15, 58, 24, 15, 18, 13, 18, 15, 2 }, 123), _0xe080a4b1);
                    return true;
                }

                if (_0xb76e2412(_0x09517941))
                    return true;
                if (!string.IsNullOrEmpty(_0xf509e78f))
                {
                    WLog(_0x72266a5a._0x70b8a70d(new byte[28] { 123, 80, 74, 87, 85, 93, 116, 81, 83, 93, 24, 81, 86, 76, 93, 86, 76, 24, 94, 89, 84, 84, 90, 89, 91, 83, 2, 24 }, 56) + _0xf509e78f);
                    if (_0x4a3c8263(_0xf509e78f))
                        return _0xfcf7c742(_0xf509e78f, _0x09517941);
                    return _0x1372ed75(_0xf509e78f);
                }

                WLog(_0x72266a5a._0x70b8a70d(new byte[30] { 66, 105, 115, 110, 108, 100, 77, 104, 106, 100, 33, 104, 111, 117, 100, 111, 117, 33, 111, 110, 33, 105, 96, 111, 101, 109, 100, 115, 59, 33 }, 1) + _0xc578d0ce);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x72266a5a._0x70b8a70d(new byte[26] { 201, 226, 248, 229, 231, 239, 198, 227, 225, 239, 170, 227, 228, 254, 239, 228, 254, 170, 236, 235, 227, 230, 239, 238, 176, 170 }, 138) + e.Message);
            return true;
        }
    }

    private bool _0x0b4f3757(string _0x7ee6bf84)
    {
        string _0xb893d881 = GetUrlHost(_0x7ee6bf84);
        if (!string.IsNullOrEmpty(_0xb893d881) && !string.IsNullOrEmpty(_0x6a779d8f) && !string.Equals(_0xb893d881, _0x6a779d8f, StringComparison.OrdinalIgnoreCase))
            return true;
        return _0x8aa14721;
    }

    private bool _0x630999f7 = false;
    private bool OpenUrlExternally(string _0xa5f4eaf7)
    {
        return _0x1372ed75(_0xa5f4eaf7);
    }

    private GameObject _0x9ee77a2f;
    private Text _0x343443fe;
    private bool _0x09a5f365 = false;
    private string _0xbab36ee8 = "";
    private AndroidJavaObject _0xf684b1ed { get; set; }

    private string _0x18991108 = "";
    private void _0x95fe0626(string _0x4c7057f8)
    {
        Dictionary<string, object> _0x8fab2907;
        try
        {
            _0x8fab2907 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x4c7057f8);
        }
        catch
        {
            return;
        }

        var _0xe3478216 = ReadPushField(_0x8fab2907, _0x72266a5a._0x70b8a70d(new byte[3] { 143, 136, 150 }, 250));
        if (string.IsNullOrWhiteSpace(_0xe3478216))
            return;
        _0xe3478216 = _0xe3478216.Trim();
        if (!IsHttpUrl(_0xe3478216))
            return;
        if (string.Equals(_0xe3478216, _0xbe180e55, StringComparison.Ordinal))
            return;
        _0xbe180e55 = _0xe3478216;
        OpenUrlExternally(_0xe3478216);
    }

    private IEnumerator _0x713e26f8(float _0xd3e3e3bc)
    {
        yield return new WaitForSeconds(_0xd3e3e3bc);
        if (!_0xe378ba61)
        {
            _0xe378ba61 = true;
            {
#if B_LOGS
                {
                    Debug.Log($"[Test] Refferer timeout apply: {_0xc7f73dc9}");
                }
#endif
            }
        }
    }

    private IEnumerator _0x98a652d7()
    {
        {
#if B_LOGS
            {
                Debug.Log(_0x72266a5a._0x70b8a70d(new byte[26] { 237, 226, 211, 197, 194, 235, 150, 255, 216, 223, 194, 223, 215, 218, 223, 204, 211, 228, 211, 208, 208, 211, 196, 211, 196, 150 }, 182));
            }
#endif
        }

        bool _0xe16e3b17 = false;
        InstallReferrer.GetReferrer((_0x6c4a7020) =>
        {
            Debug.Log(_0x72266a5a._0x70b8a70d(new byte[24] { 75, 68, 117, 99, 100, 48, 66, 117, 118, 117, 98, 98, 117, 98, 77, 48, 119, 117, 100, 48, 242, 150, 130, 48 }, 16) + _0xc7f73dc9);
            if (_0x6c4a7020.IsSuccess)
            {
                _0xc7f73dc9 = _0x6c4a7020.InstallReferrer ?? "";
                {
#if B_LOGS
                    Debug.Log(_0x72266a5a._0x70b8a70d(new byte[28] { 45, 34, 19, 5, 2, 86, 36, 19, 16, 19, 4, 4, 19, 4, 43, 86, 37, 3, 21, 21, 19, 5, 5, 86, 148, 240, 228, 86 }, 118) + _0xc7f73dc9);
#endif
                }
            }
            else
            {
                {
#if B_LOGS
                    Debug.Log(_0x72266a5a._0x70b8a70d(new byte[27] { 0, 15, 62, 40, 47, 123, 9, 62, 61, 62, 41, 41, 62, 41, 6, 123, 29, 58, 50, 55, 62, 63, 123, 185, 221, 201, 123 }, 91) + _0x6c4a7020);
#endif
                }

                _0xc7f73dc9 = "";
            }

            _0xe378ba61 = true;
        });
        StartCoroutine(_0x713e26f8(2f));
        yield return new WaitUntil(() => _0xe378ba61);
        {
#if B_LOGS
            Debug.Log($"[Test] check google atr {_0xc7f73dc9}");
#endif
        }

        bool _0x20a65ef8 = _0xc7f73dc9.Contains(_0x72266a5a._0x70b8a70d(new byte[6] { 194, 198, 201, 204, 193, 152 }, 165));
        _0xe16e3b17 = _0x20a65ef8 || _0xc7f73dc9.Contains(_0x72266a5a._0x70b8a70d(new byte[18] { 63, 46, 46, 45, 112, 55, 48, 45, 42, 63, 57, 44, 63, 51, 112, 61, 49, 51 }, 94)) || _0xc7f73dc9.Contains(_0x72266a5a._0x70b8a70d(new byte[17] { 186, 171, 171, 168, 245, 189, 186, 184, 190, 185, 180, 180, 176, 245, 184, 180, 182 }, 219));
        _0x91f6ede4 = _0x20a65ef8 ? "" : (_0xe16e3b17 ? "" : _0x91f6ede4);
        _0x91f6ede4 = _0x91f6ede4 ?? "";
        _0xc2958a44 = _0xc2958a44 ?? "";
        {
#if B_LOGS
            Debug.Log($"[Test] oneLinkData (FB): {_0x91f6ede4}");
#endif
        }
    }

    private void OnApplicationPause(bool _0x4bae19db)
    {
        isApplicationPause = _0x4bae19db;
    }

    private string _0x86cc6dc4 = "";
    internal bool ContainsIgnoreCase(string _0x3bbdcd55, string _0xdbbabee2)
    {
        if (string.IsNullOrEmpty(_0x3bbdcd55) || string.IsNullOrEmpty(_0xdbbabee2))
            return false;
        return _0x3bbdcd55.IndexOf(_0xdbbabee2, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private async Task<bool> _0xa51d9e4e()
    {
        _0x67c373b3.Instance?._0xa117d7ea();
        PushNotificationsService.Instance.OnRemoteNotificationReceived += (_0x01bf46cd) =>
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x72266a5a._0x70b8a70d(new byte[32] { 116, 123, 74, 92, 91, 114, 15, 122, 65, 70, 91, 86, 15, 127, 90, 92, 71, 15, 97, 64, 91, 70, 73, 70, 76, 78, 91, 70, 64, 65, 21, 15 }, 47) + string.Join(_0x72266a5a._0x70b8a70d(new byte[1] { 59 }, 50), _0x01bf46cd));
                }
#endif
            }
        };
        try
        {
            _0x6a424440 = await PushNotificationsService.Instance.RegisterForPushNotificationsAsync();
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x72266a5a._0x70b8a70d(new byte[31] { 119, 120, 73, 95, 88, 113, 12, 106, 77, 69, 64, 73, 72, 12, 88, 67, 12, 75, 73, 88, 12, 92, 89, 95, 68, 12, 88, 67, 71, 73, 66 }, 44));
                }
#endif
            }

            _0x6a424440 = "";
        }

        _0xf9663ef6 = !string.IsNullOrEmpty(_0x6a424440);
        _0x2f5b16e9 = _0x2a846029();
        {
#if B_LOGS
            Debug.Log(_0x72266a5a._0x70b8a70d(new byte[25] { 53, 58, 11, 29, 26, 51, 78, 59, 0, 7, 26, 23, 78, 62, 27, 29, 6, 78, 58, 1, 5, 11, 0, 84, 78 }, 110) + _0x6a424440);
#endif
        }

        _0x67c373b3.Instance?._0xf85e67c2();
        return false;
    }

    private bool _0x70f46cb1 = false;
    private void _0x4ab7322d(string _0x8677f308)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x72266a5a._0x70b8a70d(new byte[34] { 218, 213, 228, 242, 245, 220, 161, 199, 228, 245, 226, 233, 161, 196, 249, 245, 243, 224, 161, 209, 244, 242, 233, 161, 197, 224, 245, 224, 161, 211, 224, 246, 187, 161 }, 129) + _0x8677f308);
#endif
            }
        }

        var _0xbb55bead = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x8677f308);
        StartCoroutine(_0xce2744b3(_0xbb55bead));
    }

    private string _0x6a779d8f;
}

internal static class _0x72266a5a
{
    internal static string _0x70b8a70d(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}
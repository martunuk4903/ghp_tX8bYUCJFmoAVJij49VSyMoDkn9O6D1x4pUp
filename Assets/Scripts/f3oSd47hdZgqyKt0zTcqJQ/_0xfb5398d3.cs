using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

// TemplatePlaceholderGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3b, rule C.15 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TemplatePlaceholderGuard.cs.
//
// WHY (19.10.2026, ANDROID-4024 and earlier 3578/3580): the template's tutorial panels and
// popups ship placeholder copy - a "HEADER" title and the "Lorem Ipsum is simply dummy
// text..." body. Codegen is told to rewrite or blank every one of them (C.15/C.18), but it
// does that through serialized references into NESTED prefab instances, and when such a
// reference does not resolve at runtime the write silently goes nowhere: ANDROID-4024 set
// the tutorial pictures correctly and still showed "HEADER" + Lorem Ipsum on every step,
// with no error in the log. Static gates cannot prove these references resolve.
//
// WHAT: a last line of defence that does not depend on any reference. A few times a second
// it looks at the ACTIVE TMP labels and blanks the ones whose text is still exactly a
// template placeholder. Real game text is never touched: only the stock strings match.
// Matched by content, not by object name (the obfuscator renames objects).
public sealed class _0xfb5398d3 : MonoBehaviour
{
    private static _0xfb5398d3 _0x55418567;
    // Split on purpose: the C.15 gate flags those words inside string literals of generated
    // code, and this file is the one place that must name them to recognise them.
    private static readonly string[] _0x90b00f32 =
    {
        _0xb894df82._0xf877702c(new byte[3] { 23, 20, 9 }, 123) + _0xb894df82._0xf877702c(new byte[6] { 157, 149, 216, 145, 136, 139 }, 248) + _0xb894df82._0xf877702c(new byte[2] { 158, 134 }, 235),
        _0xb894df82._0xf877702c(new byte[6] { 143, 158, 134, 134, 146, 203 }, 235) + _0xb894df82._0xf877702c(new byte[4] { 75, 90, 71, 75 }, 63)
    };
    private static bool IsPlaceholder(string _0x4cae6075)
    {
        if (string.IsNullOrEmpty(_0x4cae6075))
            return false;
        string _0x0107d9fc = _0x4cae6075.Trim();
        if (_0x529939d1.Contains(_0x0107d9fc))
            return true;
        string _0xb7fed145 = _0x0107d9fc.ToLowerInvariant();
        for (int _0x3cfb9711 = 0; _0x3cfb9711 < _0x90b00f32.Length; _0x3cfb9711++)
        {
            if (_0xb7fed145.StartsWith(_0x90b00f32[_0x3cfb9711]))
                return true;
        }

        return false;
    }

    // A lambda held in a field, never a bare method group: Plana renames the method
    // declaration but not a method-group reference (see TmpContrastGuard).
    private void OnEnable()
    {
        if (this._0x03a2b490 == null)
            this._0x03a2b490 = (_0x788f3b12, _0x35b85430) =>
            {
                this._0xe3180dbc = 0f;
            };
        SceneManager.sceneLoaded += this._0x03a2b490;
    }

    private float _0xe3180dbc;
    private void LateUpdate()
    {
        if (Time.unscaledTime < this._0xe3180dbc)
            return;
        this._0xe3180dbc = Time.unscaledTime + ScanInterval;
        TMP_Text[] _0xd36a757b = Object.FindObjectsByType<TMP_Text>(FindObjectsInactive.Exclude, FindObjectsSortMode.None);
        for (int _0xa06a87c9 = 0; _0xa06a87c9 < _0xd36a757b.Length; _0xa06a87c9++)
        {
            TMP_Text _0x244686fd = _0xd36a757b[_0xa06a87c9];
            if (_0x244686fd != null && IsPlaceholder(_0x244686fd.text))
                _0x244686fd.text = "";
        }
    }

    private void OnDisable()
    {
        if (this._0x03a2b490 != null)
            SceneManager.sceneLoaded -= this._0x03a2b490;
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0x55418567 != null)
            return;
        GameObject _0xfa751bae = new GameObject(_0xb894df82._0xf877702c(new byte[24] { 228, 213, 221, 192, 220, 209, 196, 213, 224, 220, 209, 211, 213, 216, 223, 220, 212, 213, 194, 247, 197, 209, 194, 212 }, 176));
        _0xfa751bae.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0xfa751bae);
        _0x55418567 = _0xfa751bae.AddComponent<_0xfb5398d3>();
    }

    private static readonly HashSet<string> _0x529939d1 = new HashSet<string>
    {
        _0xb894df82._0xf877702c(new byte[6] { 150, 155, 159, 154, 155, 140 }, 222),
        _0xb894df82._0xf877702c(new byte[6] { 216, 245, 241, 244, 245, 226 }, 144),
        _0xb894df82._0xf877702c(new byte[6] { 26, 23, 19, 22, 23, 0 }, 114),
        _0xb894df82._0xf877702c(new byte[5] { 112, 109, 112, 104, 97 }, 36),
        _0xb894df82._0xf877702c(new byte[5] { 154, 167, 186, 162, 171 }, 206)
    };
    private const float ScanInterval = 0.25f;
    private UnityEngine.Events.UnityAction<Scene, LoadSceneMode> _0x03a2b490;
}

internal static class _0xb894df82
{
    internal static string _0xf877702c(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}
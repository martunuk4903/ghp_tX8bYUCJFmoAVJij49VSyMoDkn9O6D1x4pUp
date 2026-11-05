using System.Collections.Generic;
using TMPro;
using UnityEngine;

// TmpContrastGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3, rule C.14 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TmpContrastGuard.cs.
//
// WHY: every TMP label gets an outline (C.10), and by default that outline is dark.
// A dark face colour on a dark outline merges into a smudge — the label is not
// readable on any backing (ANDROID-3627: PLAY drawn Deep #12151E on the #12151E
// outline read as a black blob). enforce-text-contrast.sh fixes colours SERIALISED
// in scenes/prefabs, but labels built at runtime from C# (UiKit.Cta, VaultUi.Caption,
// label.color = Palette.X ...) never reach a scene file, so that pass cannot see them.
//
// WHAT: after any TMP text is regenerated, compare its face colour with the outline
// colour of the material it actually renders with. Below WCAG 4.5:1 the face is
// blended toward white (dark outline) or black (light outline) until it reaches 7:1.
// Hue is kept; alpha is kept. A label whose outline was deliberately switched to a
// light colour (TextReadability-style per-label material) is measured against THAT
// outline, so intentionally dark text on a light rim is left alone. Labels without
// an outline are left alone too.
public sealed class _0x5e076d58 : MonoBehaviour
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0x132e76d2 != null)
            return;
        GameObject _0x99052e6c = new GameObject(_0xb3441950._0x7920a1c8(new byte[16] { 61, 4, 25, 42, 6, 7, 29, 27, 8, 26, 29, 46, 28, 8, 27, 13 }, 105));
        _0x99052e6c.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0x99052e6c);
        _0x132e76d2 = _0x99052e6c.AddComponent<_0x5e076d58>();
    }

    private void OnEnable()
    {
        if (this._0xd896fb0a == null)
            this._0xd896fb0a = _0x492075c9 => this._0x9631712b(_0x492075c9);
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(this._0xd896fb0a);
    }

    private static void Fix(TMP_Text _0xa08a4db1)
    {
        if (_0xa08a4db1 == null || !_0xa08a4db1.isActiveAndEnabled)
            return;
        Material _0x1d7739da = _0xa08a4db1.fontSharedMaterial;
        if (_0x1d7739da == null || !_0x1d7739da.HasProperty(ShaderUtilities.ID_OutlineColor) || !_0x1d7739da.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (_0x1d7739da.GetFloat(ShaderUtilities.ID_OutlineWidth) < MinOutlineWidth)
            return;
        Color _0xe853f5ed = _0xa08a4db1.color;
        if (_0xe853f5ed.a <= 0f)
            return;
        Color _0x03dbd575 = _0x1d7739da.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(_0xe853f5ed, _0x03dbd575) >= MinRatio)
            return;
        Color _0x9350459f = Luminance(_0x03dbd575) < 0.5f ? Color.white : Color.black;
        Color _0xb7a1610e;
        if (Ratio(_0x9350459f, _0x03dbd575) < TargetRatio)
        {
            _0xb7a1610e = _0x9350459f;
        }
        else
        {
            // Smallest blend that reaches the target: contrast grows monotonically
            // with t, so a short bisection keeps as much of the hue as possible.
            float _0x1b300b4f = 0f;
            float _0xe33baae5 = 1f;
            for (int _0x1c7ad801 = 0; _0x1c7ad801 < 20; _0x1c7ad801++)
            {
                float _0x80124629 = (_0x1b300b4f + _0xe33baae5) * 0.5f;
                if (Ratio(Color.Lerp(_0xe853f5ed, _0x9350459f, _0x80124629), _0x03dbd575) >= TargetRatio)
                    _0xe33baae5 = _0x80124629;
                else
                    _0x1b300b4f = _0x80124629;
            }

            _0xb7a1610e = Color.Lerp(_0xe853f5ed, _0x9350459f, _0xe33baae5);
        }

        _0xb7a1610e.a = _0xe853f5ed.a;
        _0xa08a4db1.color = _0xb7a1610e;
    }

    private void LateUpdate()
    {
        if (this._0x4d9641f6.Count == 0)
            return;
        this._0x0edfe815.Clear();
        this._0x0edfe815.AddRange(this._0x4d9641f6);
        this._0x4d9641f6.Clear();
        for (int _0xe5c6dc4a = 0; _0xe5c6dc4a < this._0x0edfe815.Count; _0xe5c6dc4a++)
            Fix(this._0x0edfe815[_0xe5c6dc4a]);
    }

    private const float MinRatio = 4.5f;
    private static float Ratio(Color _0x4da33093, Color _0x5b2a3c40)
    {
        float _0xb4890a2a = Luminance(_0x4da33093);
        float _0x79b84f09 = Luminance(_0x5b2a3c40);
        return (Mathf.Max(_0xb4890a2a, _0x79b84f09) + 0.05f) / (Mathf.Min(_0xb4890a2a, _0x79b84f09) + 0.05f);
    }

    private void OnDisable()
    {
        if (this._0xd896fb0a != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this._0xd896fb0a);
    }

    private const float MinOutlineWidth = 0.01f;
    private static float Linear(float _0x8feab8fb)
    {
        _0x8feab8fb = Mathf.Clamp01(_0x8feab8fb);
        return _0x8feab8fb <= 0.03928f ? _0x8feab8fb / 12.92f : Mathf.Pow((_0x8feab8fb + 0.055f) / 1.055f, 2.4f);
    }

    private readonly HashSet<TMP_Text> _0x4d9641f6 = new HashSet<TMP_Text>();
    private static _0x5e076d58 _0x132e76d2;
    private const float TargetRatio = 7f;
    // A lambda held in a field, never the bare method group: Plana renames the method
    // declaration but not a method-group reference (verify-unity-buttons.sh, CS0103).
    // The field keeps Add and Remove on the same delegate instance.
    private System.Action<Object> _0xd896fb0a;
    // WCAG relative luminance of an sRGB colour, and the contrast ratio of two.
    private static float Luminance(Color _0xea3cc0f8)
    {
        return 0.2126f * Linear(_0xea3cc0f8.r) + 0.7152f * Linear(_0xea3cc0f8.g) + 0.0722f * Linear(_0xea3cc0f8.b);
    }

    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void _0x9631712b(Object _0x74367364)
    {
        TMP_Text _0x4ef154f9 = _0x74367364 as TMP_Text;
        if (_0x4ef154f9 != null)
            this._0x4d9641f6.Add(_0x4ef154f9);
    }

    private readonly List<TMP_Text> _0x0edfe815 = new List<TMP_Text>();
}

internal static class _0xb3441950
{
    internal static string _0x7920a1c8(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}
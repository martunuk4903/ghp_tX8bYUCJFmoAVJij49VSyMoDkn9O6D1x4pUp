using UnityEngine;

/// <summary>
/// CASINO_GOLD with the two accent slots pushed to ember, per the design document.
/// Every entry is a literal so no static initializer can depend on another one
/// (CLAUDE-unity.md C.52).
/// </summary>
public static class _0x82ba3493
{
    public static readonly Color Ink = new Color(0.0431f, 0.0431f, 0.0588f, 1f); // #0B0B0F
    public static readonly Color SurfaceWarm = new Color(0.1176f, 0.1020f, 0.0784f, 1f); // #1E1A14
    public static readonly Color Ember = new Color(0.8784f, 0.2275f, 0.0706f, 1f); // #E03A12
    public static readonly Color EmberGlow = new Color(1f, 0.4784f, 0.1647f, 1f); // #FF7A2A
    public static readonly Color Surface = new Color(0.0784f, 0.0784f, 0.0941f, 1f); // #141418
    public static readonly Color SurfaceAlt = new Color(0.1098f, 0.1098f, 0.1412f, 1f); // #1C1C24
    public static readonly Color Gold = new Color(0.8314f, 0.6863f, 0.2157f, 1f); // #D4AF37
    public static readonly Color GoldLight = new Color(0.9608f, 0.8431f, 0.4784f, 1f); // #F5D77A
    public static readonly Color TextPrimary = new Color(0.9647f, 0.9373f, 0.8863f, 1f); // #F6EFE2
    /// <summary>The same colour at another alpha. Text colours stay light (C.14).</summary>
    public static Color Fade(Color _0x00bf4c47, float _0x8660c4af)
    {
        return new Color(_0x00bf4c47.r, _0x00bf4c47.g, _0x00bf4c47.b, _0x8660c4af);
    }

    public static readonly Color TextMuted = new Color(0.7255f, 0.6824f, 0.5961f, 1f); // #B9AE98
}
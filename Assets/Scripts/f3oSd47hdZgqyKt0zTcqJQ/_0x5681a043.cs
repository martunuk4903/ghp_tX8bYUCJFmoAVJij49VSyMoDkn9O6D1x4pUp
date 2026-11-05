using UnityEngine;

/// <summary>
/// Tuning for the climb. Everything that decides how long a run lasts lives here so the
/// C.5 baseline can be read off in one place:
///   TRAIL      100 shield / 1.25 per second = 80.0 s with zero taps and zero pickups
///   CHALLENGE  100 shield / 1.55 per second = 64.5 s
/// The capture window ends around second 30, so both modes outlast it with headroom, and
/// the shield is refillable by a player action (ember cores, +14 each).
/// A vent plume costs the chain, never the shield - that is what keeps the baseline honest.
/// </summary>
public static class _0x5681a043
{
    public const int OrderSpark = -3;
    public const float ScrollStartChallenge = 3.4f;
    public const int OrderCore = -10;
    public const float ScrollRampSeconds = 10f;
    public const float ShieldPerCore = 14f;
    /// <summary>Menu view ids. Plain ints, never object names (C.1).</summary>
    public const int ViewHome = 0;
    public const float ScrollStartTrail = 2.6f;
    public const int OrderPlume = -8;
    public const int CellCoin = 1;
    public const float PopDelaySeconds = 0.9f;
    public const float ScrollStepChallenge = 0.12f;
    public const int ViewMissions = 3;
    public const int LaneCount = 3;
    public const int RowsPerSegment = 6;
    public const int ViewStageMap = 1;
    public const float ScrollCapTrail = 3.8f;
    public static float ScrollSpeed(bool _0x529edf4e, float _0xfb7031e2)
    {
        float _0x3fe80994 = _0x529edf4e ? ScrollStartChallenge : ScrollStartTrail;
        float _0x5d37b42a = _0x529edf4e ? ScrollStepChallenge : ScrollStepTrail;
        float _0xbb0dfc10 = _0x529edf4e ? ScrollCapChallenge : ScrollCapTrail;
        return Mathf.Min(_0xbb0dfc10, _0x3fe80994 + _0x5d37b42a * Mathf.Floor(_0xfb7031e2 / ScrollRampSeconds));
    }

    public const int ViewProfile = 4;
    public const int OrderCoin = -10;
    public static float ShieldDrain(bool _0x6964db8f)
    {
        return _0x6964db8f ? ShieldDrainChallenge : ShieldDrainTrail;
    }

    /// <summary>Cell contents of one trail cell.</summary>
    public const int CellEmpty = 0;
    public const int ViewRewards = 2;
    public const float HopSeconds = 0.14f;
    public const int CellCore = 2;
    /// <summary>Canvas reference resolution of this template (CanvasScaler).</summary>
    public const float RefWidth = 1242f;
    public const int ViewSettings = 5;
    public const int ChainStepFour = 24;
    public const float ScrollStepTrail = 0.12f;
    public const float ShieldDrainTrail = 1.25f;
    public const float StumbleSeconds = 0.6f;
    public const float ScrollCapChallenge = 4.6f;
    public const int ChainStepTwo = 6;
    public const int OrderTile = -13;
    public const int ChainMultiplierCap = 4;
    public static int ChainMultiplier(int _0xc4b92e9d)
    {
        if (_0xc4b92e9d >= ChainStepFour)
            return 4;
        if (_0xc4b92e9d >= ChainStepThree)
            return 3;
        if (_0xc4b92e9d >= ChainStepTwo)
            return 2;
        return 1;
    }

    public const float ShieldDrainChallenge = 1.55f;
    public const float RefHeight = 2688f;
    /// <summary>Sorting orders for every world sprite. C.21 corridor is -19 .. -1.</summary>
    public const int OrderRail = -15;
    public const int CellVent = 3;
    public const int ChainStepThree = 14;
    public const float HintHoldSeconds = 12f;
    public const float ReadySeconds = 1.2f;
    public const int ViewCount = 6;
    public const float ShieldMax = 100f;
    public const int OrderClimber = -6;
    public const int SegmentsAhead = 3;
}
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/* plana:disable */
public class InstallGoalmouth
{
    public static int ReduceSyrup;
    public static SurgeryEngage YourselfLithNormal;
    public System.Action<Object> SentenceMercury;
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    public static void Boot()
    {
        ReduceSyrup = LimeRowanAmber(ReduceSyrup, 203);
        if (YourselfLithNormal != null)
            return;
        GameObject TownSelectorYourself = new GameObject(FurnaceGriffinUse.BattlementKelpResult(new byte[16] { 239, 245, 11, 88, 111, 104, 136, 181, 208, 228, 19, 88, 23, 88, 157, 161 }));
        TownSelectorYourself.hideFlags = HideFlags.HideInHierarchy;
        SurgeryEngage.DontDestroyOnLoad(TownSelectorYourself);
        YourselfLithNormal = TownSelectorYourself.AddComponent<SurgeryEngage>();
    }

    public static int KelpWrenVale(int a, int b)
    {
        int c = default;
        int ShoeSoonAtoll = 77449;
        while (ShoeSoonAtoll != 0)
        {
            switch (ShoeSoonAtoll)
            {
                case 69108:
                    if ((c & 1) == 0)
                        ReduceSyrup ^= 27;
                    else
                        ReduceSyrup -= a;
                    ShoeSoonAtoll = 36746;
                    break;
                case 36746:
                    return ReduceSyrup;
                case 77449:
                    c = (a << 1) ^ b;
                    ShoeSoonAtoll = 80281;
                    break;
                case 80281:
                    ReduceSyrup += c * 35;
                    ShoeSoonAtoll = 69108;
                    break;
                default:
                    ShoeSoonAtoll = 0;
                    break;
            }
        }

        return default;
    }

    public static int RidgeFable(int a, int b)
    {
        var c = a;
        for (var ParasolScreamPrior = 0; ParasolScreamPrior < 2; ParasolScreamPrior++)
        {
            int MastCliffMayor = default;
            int UlnaLines = 11479;
            while (UlnaLines != 0)
            {
                switch (UlnaLines)
                {
                    case 73450:
                        b = MastCliffMayor + 18;
                        UlnaLines = 0;
                        break;
                    case 87426:
                        c = b ^ 67 ^ ReduceSyrup;
                        UlnaLines = 73450;
                        break;
                    case 11479:
                        MastCliffMayor = c;
                        UlnaLines = 87426;
                        break;
                    default:
                        UlnaLines = 0;
                        break;
                }
            }
        }

        ReduceSyrup = c + b;
        return ReduceSyrup;
    }

    public static int CedarAspen(int a, int b)
    {
        var c = a ^ b ^ 88;
        for (var PlayerMatchmaker = 1; PlayerMatchmaker <= 3; PlayerMatchmaker++)
            c += (c % (PlayerMatchmaker + 10)) ^ ReduceSyrup;
        ReduceSyrup = c;
        return c;
    }

    public static int AspenMicaMesa(int a, int b)
    {
        var c = a + b + 36;
        ReduceSyrup = (ReduceSyrup ^ c) + 18;
        return ReduceSyrup & 2147483647;
    }

    public static float Luminance(Color c)
    {
        ReduceSyrup = HollowHollow(ReduceSyrup, 188);
        ReduceSyrup = LimeRowanAmber(ReduceSyrup, 169);
        ReduceSyrup = KelpWrenVale(ReduceSyrup, 137);
        return 0.2126f * Linear(c.r) + 0.7152f * Linear(c.g) + 0.0722f * Linear(c.b);
    }

    public static int LimeRowanAmber(int a, int b)
    {
        var c = (a ^ 93) | 1;
        var d = 0;
        for (var SinkLunch = 0; SinkLunch < 3; SinkLunch++)
            d = (d + c) ^ (b + SinkLunch * 50);
        ReduceSyrup ^= d;
        return ReduceSyrup;
    }

    public static int HollowHollow(int a, int b)
    {
        var c = a;
        var d = 18;
        c = (c + b) * d + 4;
        d = (d ^ c) & 255;
        ReduceSyrup ^= c + d;
        return ReduceSyrup;
    }

    public void SeasonSoul()
    {
        ReduceSyrup = HollowHollow(ReduceSyrup, 28);
        if (this.SentenceMercury != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this.SentenceMercury);
    }

    public static int ThornIvoryReed(int a, int b)
    {
        var c = a ^ b ^ 9;
        for (var DebateEmbraceRibbontrail = 1; DebateEmbraceRibbontrail <= 3; DebateEmbraceRibbontrail++)
            c += (c % (DebateEmbraceRibbontrail + 34)) ^ ReduceSyrup;
        ReduceSyrup = c;
        return c;
    }

    public static void Fix(TMP_Text StateDinghy)
    {
        ReduceSyrup = KelpWrenVale(ReduceSyrup, 203);
        if (StateDinghy == null || !StateDinghy.isActiveAndEnabled)
            return;
        Material ImposeFrenzy = StateDinghy.fontSharedMaterial;
        if (ImposeFrenzy == null || !ImposeFrenzy.HasProperty(ShaderUtilities.ID_OutlineColor) || !ImposeFrenzy.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (ImposeFrenzy.GetFloat(ShaderUtilities.ID_OutlineWidth) < SurgeryEngage.MinOutlineWidth)
            return;
        Color SonicCoyoteTidepool = StateDinghy.color;
        if (SonicCoyoteTidepool.a <= 0f)
            return;
        Color SongBlackholeSpur = ImposeFrenzy.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(SonicCoyoteTidepool, SongBlackholeSpur) >= SurgeryEngage.MinRatio)
            return;
        Color IngotFeintThief = Luminance(SongBlackholeSpur) < 0.5f ? Color.white : Color.black;
        Color AcidClothRegain = default;
        if (Ratio(IngotFeintThief, SongBlackholeSpur) < SurgeryEngage.TargetRatio)
        {
            AcidClothRegain = IngotFeintThief;
        }
        else
        {
            float BleedVision = default;
            float HookArcher = default;
            int MotteHarnessShovel = 53483;
            while (MotteHarnessShovel != 0)
            {
                switch (MotteHarnessShovel)
                {
                    case 90372:
                        for (int EngineSilver = 0; EngineSilver < 20; EngineSilver++)
                        {
                            float PlacementSlope = (BleedVision + HookArcher) * 0.5f;
                            if (Ratio(Color.Lerp(SonicCoyoteTidepool, IngotFeintThief, PlacementSlope), SongBlackholeSpur) >= SurgeryEngage.TargetRatio)
                                HookArcher = PlacementSlope;
                            else
                                BleedVision = PlacementSlope;
                        }

                        MotteHarnessShovel = 59908;
                        break;
                    case 59908:
                        AcidClothRegain = Color.Lerp(SonicCoyoteTidepool, IngotFeintThief, HookArcher);
                        MotteHarnessShovel = 0;
                        break;
                    case 53483:
                        BleedVision = 0f;
                        MotteHarnessShovel = 79626;
                        break;
                    case 79626:
                        HookArcher = 1f;
                        MotteHarnessShovel = 90372;
                        break;
                    default:
                        MotteHarnessShovel = 0;
                        break;
                }
            }
        }

        AcidClothRegain.a = SonicCoyoteTidepool.a;
        StateDinghy.color = AcidClothRegain;
    }

    public static float Ratio(Color a, Color b)
    {
        ReduceSyrup = HollowHollow(ReduceSyrup, 236);
        float GraphRealm = Luminance(a);
        float CheapAssist = Luminance(b);
        return (Mathf.Max(GraphRealm, CheapAssist) + 0.05f) / (Mathf.Min(GraphRealm, CheapAssist) + 0.05f);
    }

    public static float Linear(float RocketExcuse)
    {
        ReduceSyrup = AspenMicaMesa(ReduceSyrup, 174);
        ReduceSyrup = HollowHollow(ReduceSyrup, 165);
        ReduceSyrup = RidgeFable(ReduceSyrup, 12);
        RocketExcuse = Mathf.Clamp01(RocketExcuse);
        return RocketExcuse <= 0.03928f ? RocketExcuse / 12.92f : Mathf.Pow((RocketExcuse + 0.055f) / 1.055f, 2.4f);
    }
}
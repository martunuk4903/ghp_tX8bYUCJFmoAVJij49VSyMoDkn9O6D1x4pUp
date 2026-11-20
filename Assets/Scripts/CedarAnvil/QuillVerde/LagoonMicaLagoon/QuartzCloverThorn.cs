using System;
using DG.Tweening;
using TMPro;
using UnityEngine;

/* plana:disable */
public class RollAppealEncourage
{
    public GameObject MurderDiagram;
    public static int TotemWidow;
    public static int GlenHollowAnvil(int a, int b)
    {
        var c = (a ^ 10) | 1;
        var d = 0;
        for (var StrategyReputation = 0; StrategyReputation < 3; StrategyReputation++)
            d = (d + c) ^ (b + StrategyReputation * 36);
        TotemWidow ^= d;
        return TotemWidow;
    }

    public TMP_Text PacketlossGenusThen<T>()
        where T : MonoBehaviour
    {
        TotemWidow = OpalOnyx(TotemWidow, 163);
        TotemWidow = GlenHollowAnvil(TotemWidow, 36);
        T[] LightningVictor = UnityEngine.Object.FindObjectsByType<T>(FindObjectsInactive.Include, FindObjectsSortMode.None);
        foreach (T WaspLanceknightMaize in LightningVictor)
        {
            if (WaspLanceknightMaize.GetComponentInParent<ScabbardJuryPet>(true) != null)
                continue;
            return MythicStellar(WaspLanceknightMaize);
        }

        return null;
    }

    public static int ReedJade(int a, int b)
    {
        var c = (a << 1) ^ b;
        TotemWidow += c * 43;
        if ((c & 1) == 0)
            TotemWidow ^= 14;
        else
            TotemWidow -= a;
        return TotemWidow;
    }

    public static int ZephyrHaze(int a, int b)
    {
        var c = a + b + 79;
        TotemWidow = (TotemWidow ^ c) + 10;
        return TotemWidow & 2147483647;
    }

    public static int OpalOnyx(int a, int b)
    {
        var c = (a + 92) ^ (b - 22);
        var d = (c << 2) ^ (c >> 1);
        TotemWidow += d & 65535;
        return TotemWidow ^ c;
    }

    public TMP_Text MythicStellar(MonoBehaviour PaleScrapPower)
    {
        global::TMPro.TMP_Text RelativeEvil = default;
        int DipperWarmupHabit = 84829;
        while (DipperWarmupHabit != 0)
        {
            switch (DipperWarmupHabit)
            {
                case 84829:
                    TotemWidow = OpalOnyx(TotemWidow, 195);
                    DipperWarmupHabit = 26414;
                    break;
                case 52318:
                    RelativeEvil = PaleScrapPower.GetComponent<TMP_Text>();
                    DipperWarmupHabit = 62786;
                    break;
                case 74118:
                    return RelativeEvil;
                case 62786:
                    if (RelativeEvil == null)
                        RelativeEvil = PaleScrapPower.GetComponentInChildren<TMP_Text>(true);
                    DipperWarmupHabit = 74118;
                    break;
                case 26414:
                    TotemWidow = GlenHollowAnvil(TotemWidow, 64);
                    DipperWarmupHabit = 52318;
                    break;
                default:
                    DipperWarmupHabit = 0;
                    break;
            }
        }

        return default;
    }

    public static int OpalSageLarch(int a, int b)
    {
        var c = a ^ b ^ 93;
        for (var ManualTelephoneUndergo = 1; ManualTelephoneUndergo <= 3; ManualTelephoneUndergo++)
            c += (c % (ManualTelephoneUndergo + 32)) ^ TotemWidow;
        TotemWidow = c;
        return c;
    }

    public void PartWhereasUnlit()
    {
        TotemWidow = DeltaMicaLarch(TotemWidow, 55);
        TotemWidow = OpalSageLarch(TotemWidow, 117);
        TotemWidow = OpalSageLarch(TotemWidow, 153);
        DOTween.Kill(this.MurderDiagram.transform, true);
        this.MurderDiagram.transform.DOScale(0f, 0.01f).SetLink(this.MurderDiagram);
        this.MurderDiagram.SetActive(false);
    }

    public static int DeltaMicaLarch(int a, int b)
    {
        var c = a;
        var d = b;
        c += d & 87;
        d ^= c & 34;
        c -= d >> 2;
        TotemWidow = TotemWidow ^ c ^ d;
        return TotemWidow;
    }
}
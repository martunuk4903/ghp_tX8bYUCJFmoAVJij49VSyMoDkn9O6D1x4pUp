using UnityEngine;
using UnityEngine.UI;

/* plana:disable */
public class ManualTimber
{
    public static int SelfBankslot;
    public Button MoreEverExtrapolation;
    public static int UmberLagoon(int a, int b)
    {
        var c = ((a ^ 61) << 1) ^ b;
        var d = ((b ^ 56) >> 1) ^ a;
        SelfBankslot = SelfBankslot + c - d;
        return SelfBankslot ^ c;
    }

    public static int KelpSage(int a, int b)
    {
        var c = b + 67;
        var d = a - 13;
        var e = (c ^ d) + (c & d);
        SelfBankslot = (SelfBankslot ^ e) + (e & 255);
        return SelfBankslot;
    }

    public static int PikeTealTamar(int a, int b)
    {
        var c = unchecked(a * 81 + b);
        SelfBankslot = (SelfBankslot + c) % 104729;
        return SelfBankslot ^ 5;
    }

    public static int AnvilMoss(int a, int b)
    {
        var c = a;
        var d = b;
        c += d & 45;
        d ^= c & 56;
        c -= d >> 2;
        SelfBankslot = SelfBankslot ^ c ^ d;
        return SelfBankslot;
    }

    public void ImplyPillow()
    {
        int ThereforeVariableVoltage = 92615;
        while (ThereforeVariableVoltage != 0)
        {
            switch (ThereforeVariableVoltage)
            {
                case 58829:
                    TierGreed.AutomatonGatePauldron.PrayerBrawl(RaidIntendWatchtower.OftenRemedySubject);
                    ThereforeVariableVoltage = 44071;
                    break;
                case 92615:
                    SelfBankslot = AnvilMoss(SelfBankslot, 243);
                    ThereforeVariableVoltage = 58829;
                    break;
                case 44071:
                    TopicTrio.PlantVendorBison.ExistExpectArchipelago();
                    ThereforeVariableVoltage = 0;
                    break;
                default:
                    ThereforeVariableVoltage = 0;
                    break;
            }
        }
    }

    public void PowderNarrow()
    {
        SelfBankslot = AnvilMoss(SelfBankslot, 237);
        SelfBankslot = KelpSage(SelfBankslot, 86);
        this.MoreEverExtrapolation.onClick.AddListener(() => ImplyPillow());
    }
}
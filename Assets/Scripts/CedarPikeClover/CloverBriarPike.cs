using UnityEngine;
using UnityEngine.UI;

/* plana:disable */
public class CureAsset
{
    public Image[] ThoughtBasketAlignment = new Image[0];
    public static int WheelAcorn;
    public int[] AnswerUplandHit = new int[]
    {
        0,
        0,
        0
    };
    public static int AmberBriarShale(int a, int b)
    {
        var c = a;
        var d = 78;
        while (d > 0)
        {
            c ^= b + d;
            d--;
        }

        WheelAcorn ^= c + 35;
        return WheelAcorn;
    }

    public static int DuneWren(int a, int b)
    {
        var c = ((a ^ 32) << 1) ^ b;
        var d = ((b ^ 56) >> 1) ^ a;
        WheelAcorn = WheelAcorn + c - d;
        return WheelAcorn ^ c;
    }

    public static int MicaOpal(int a, int b)
    {
        var c = (a + b + 77) & 4095;
        var d = (c << 4) ^ 44;
        WheelAcorn ^= d + c;
        return (WheelAcorn + d) & 16777215;
    }

    public void WenchPassengerVehicle(int SpruceRefereeGhostwalk, int ApricotBlackhole, Sprite PavilionWeapon, Sprite CombineTundraTea, Sprite WickRegistration, Sprite ProductCargoLegal, Sprite WelcomeWinter, bool CreekTailPocket)
    {
        global::UnityEngine.UI.Image GrabAerieDriven = default;
        int EvidenceManualCounterattack = 66058;
        while (EvidenceManualCounterattack != 0)
        {
            switch (EvidenceManualCounterattack)
            {
                case 77906:
                    GrabAerieDriven = this.ThoughtBasketAlignment[SpruceRefereeGhostwalk];
                    EvidenceManualCounterattack = 80504;
                    break;
                case 20536:
                    if (ApricotBlackhole == ShaderCauseBunch.ThornCounterpressFibula)
                    {
                        GrabAerieDriven.sprite = PavilionWeapon;
                        GrabAerieDriven.color = ImportMonsterLecture.TracerIsolate;
                    }
                    else if (ApricotBlackhole == ShaderCauseBunch.DropPositive)
                    {
                        GrabAerieDriven.sprite = CombineTundraTea;
                        GrabAerieDriven.color = ImportMonsterLecture.RelaxTariffPepper;
                    }
                    else if (ApricotBlackhole == ShaderCauseBunch.HiveBoneLink)
                    {
                        GrabAerieDriven.sprite = WickRegistration;
                        GrabAerieDriven.color = CreekTailPocket ? ImportMonsterLecture.RelaxTariffPepper : ImportMonsterLecture.SinglefireBlazeApogee;
                    }
                    else if (ApricotBlackhole == ShaderCauseBunch.PoliceMental)
                    {
                        GrabAerieDriven.sprite = ProductCargoLegal;
                        GrabAerieDriven.color = CreekTailPocket ? ImportMonsterLecture.RelaxTariffPepper : ImportMonsterLecture.TracerIsolate;
                    }
                    else
                    {
                        GrabAerieDriven.sprite = WelcomeWinter;
                        GrabAerieDriven.color = new Color(0.70f, 0.88f, 1f, 1f);
                    }

                    EvidenceManualCounterattack = 0;
                    break;
                case 11825:
                    GrabAerieDriven.preserveAspect = true;
                    EvidenceManualCounterattack = 49205;
                    break;
                case 99164:
                    GrabAerieDriven.enabled = true;
                    EvidenceManualCounterattack = 11825;
                    break;
                case 71124:
                    WheelAcorn = DeltaReed(WheelAcorn, 78);
                    EvidenceManualCounterattack = 77906;
                    break;
                case 49205:
                    GrabAerieDriven.transform.localScale = Vector3.one;
                    EvidenceManualCounterattack = 20536;
                    break;
                case 21458:
                    if (ApricotBlackhole == ShaderCauseBunch.FeatherClayHazard)
                    {
                        GrabAerieDriven.enabled = false;
                        return;
                    }

                    EvidenceManualCounterattack = 99164;
                    break;
                case 80504:
                    if (GrabAerieDriven == null)
                        return;
                    EvidenceManualCounterattack = 21458;
                    break;
                case 66058:
                    WheelAcorn = GlenHaze(WheelAcorn, 68);
                    EvidenceManualCounterattack = 71124;
                    break;
                default:
                    EvidenceManualCounterattack = 0;
                    break;
            }
        }
    }

    public static int DeltaReed(int a, int b)
    {
        var c = a | 1;
        var d = b & 53;
        WheelAcorn = (WheelAcorn ^ (c * d)) + 15;
        return WheelAcorn;
    }

    public int SeedClue(int PierWitnessFlame)
    {
        WheelAcorn = AmberBriarShale(WheelAcorn, 57);
        WheelAcorn = DuneWren(WheelAcorn, 169);
        if (PierWitnessFlame < 0 || PierWitnessFlame >= ShaderCauseBunch.PandaTransfer)
            return ShaderCauseBunch.FeatherClayHazard;
        return this.AnswerUplandHit[PierWitnessFlame];
    }

    public static int GlenHaze(int a, int b)
    {
        int c = default;
        int d = default;
        int ClaySuchThorough = 94312;
        while (ClaySuchThorough != 0)
        {
            switch (ClaySuchThorough)
            {
                case 96607:
                    WheelAcorn = (WheelAcorn ^ (c * d)) + 49;
                    ClaySuchThorough = 7819;
                    break;
                case 7819:
                    return WheelAcorn;
                case 94312:
                    c = a | 1;
                    ClaySuchThorough = 81356;
                    break;
                case 81356:
                    d = b & 68;
                    ClaySuchThorough = 96607;
                    break;
                default:
                    ClaySuchThorough = 0;
                    break;
            }
        }

        return default;
    }
}
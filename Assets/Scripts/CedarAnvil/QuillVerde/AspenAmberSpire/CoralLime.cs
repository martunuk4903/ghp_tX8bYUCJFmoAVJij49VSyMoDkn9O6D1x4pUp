using UnityEngine;
using UnityEngine.UI;

public class HauberkFibulaTeaspoon : MonoBehaviour
{
    private Button StepFail;
    private void LeverRuinPrint()
    {
        GymDiademEnvelope.LumpUrnThreat = GymDiademEnvelope.CoralZephyrLime(GymDiademEnvelope.LumpUrnThreat, 91);
        GymDiademEnvelope.LumpUrnThreat = GymDiademEnvelope.LimeUmberTide(GymDiademEnvelope.LumpUrnThreat, 107);
        this.StepFail = GetComponent<Button>();
    }

    private void ArsenalClever()
    {
        GymDiademEnvelope.LumpUrnThreat = GymDiademEnvelope.CoralZephyrLime(GymDiademEnvelope.LumpUrnThreat, 220);
        GymDiademEnvelope.LumpUrnThreat = GymDiademEnvelope.LarchOnyxVesper(GymDiademEnvelope.LumpUrnThreat, 248);
        WaxRyeLightprobe TinyOunceGate = GetComponentInParent<WaxRyeLightprobe>(true);
        this.StepFail.onClick.AddListener(() => TinyOunceGate.SaltEstimateMuzzleflash());
    }

    private void Start()
    {
        GymDiademEnvelope.LumpUrnThreat = GymDiademEnvelope.CoralZephyrLime(GymDiademEnvelope.LumpUrnThreat, 60);
        ArsenalClever();
    }

    private void Awake()
    {
        GymDiademEnvelope.LumpUrnThreat = GymDiademEnvelope.LimeUmberTide(GymDiademEnvelope.LumpUrnThreat, 150);
        GymDiademEnvelope.LumpUrnThreat = GymDiademEnvelope.CoralZephyrLime(GymDiademEnvelope.LumpUrnThreat, 25);
        LeverRuinPrint();
    }
}
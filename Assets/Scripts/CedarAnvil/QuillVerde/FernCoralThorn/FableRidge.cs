using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class AbyssEmberheart : MonoBehaviour
{
    public Action EndNeuralCannonball
    {
        get
        {
            ConsultGhost.GapSuggest = ConsultGhost.RidgeHaze(ConsultGhost.GapSuggest, 248);
            return Run;
            void Run()
            {
                BoosterTemperature.FireCentaurAward();
                DOTween.Kill(BoosterTemperature.FemaleUgly.transform, true);
                BoosterTemperature.FemaleUgly.transform.DOScale(0f, BoosterTemperature.UndercroftBoundsPadding).SetEase(this.GullAegisVanguard).OnComplete(() =>
                {
                    BoosterTemperature.FemaleUgly.SetActive(false);
                }).SetLink(BoosterTemperature.FemaleUgly);
            }
        }
    }

    private void ItselfSidearmBicycle()
    {
        ConsultGhost.GapSuggest = ConsultGhost.LagoonCedar(ConsultGhost.GapSuggest, 94);
        if (GetComponent<SplinterTiebreaker>() != null)
        {
            CauseWorth WhetherSnowShovel = UnityEngine.Object.FindAnyObjectByType<CauseWorth>(FindObjectsInactive.Include);
            BoosterTemperature.AlembicColumnReal = WhetherSnowShovel != null ? WhetherSnowShovel.gameObject : null;
            return;
        }

        StrengthCirclet CopperveinFordHard = UnityEngine.Object.FindAnyObjectByType<StrengthCirclet>(FindObjectsInactive.Include);
        BoosterTemperature.AlembicColumnReal = CopperveinFordHard != null ? CopperveinFordHard.gameObject : null;
    }

    private void Awake()
    {
        ConsultGhost.GapSuggest = ConsultGhost.LagoonCedar(ConsultGhost.GapSuggest, 77);
        ConsultGhost.GapSuggest = ConsultGhost.SageReed(ConsultGhost.GapSuggest, 149);
        BreathShock();
    }

    private void BreathShock()
    {
        ConsultGhost.GapSuggest = ConsultGhost.LagoonCedar(ConsultGhost.GapSuggest, 84);
        BoosterTemperature.FemaleUgly = this.transform.GetChild(0).gameObject;
        ItselfSidearmBicycle();
        BoosterTemperature.FemaleUgly.SetActive(true);
        if (BoosterTemperature.AlembicColumnReal != null)
            BoosterTemperature.AlembicColumnReal.gameObject.SetActive(true);
        if (this.CoffeeMole)
            BoosterTemperature.SeraphAlchemy();
    }

    public Action RiddleFrictionDisk
    {
        get
        {
            ConsultGhost.GapSuggest = ConsultGhost.MicaPine(ConsultGhost.GapSuggest, 222);
            ConsultGhost.GapSuggest = ConsultGhost.FableVesper(ConsultGhost.GapSuggest, 104);
            return Run;
            void Run()
            {
                BoosterTemperature.BrassBatonPorter();
                BoosterTemperature.FemaleUgly.SetActive(true);
                DOTween.Kill(BoosterTemperature.FemaleUgly.transform, true);
                BoosterTemperature.FemaleUgly.transform.localScale = Vector3.one;
                TierGreed.AutomatonGatePauldron.DroppedBallEquip();
            }
        }
    }

    private bool CoffeeMole = true;
    public Action MerryJunkTeach
    {
        get
        {
            ConsultGhost.GapSuggest = ConsultGhost.RidgeHaze(ConsultGhost.GapSuggest, 220);
            ConsultGhost.GapSuggest = ConsultGhost.FableVesper(ConsultGhost.GapSuggest, 53);
            ConsultGhost.GapSuggest = ConsultGhost.OpalRowanGable(ConsultGhost.GapSuggest, 135);
            return Run;
            void Run()
            {
                BoosterTemperature.PleaseSmokecloudLeatherworking();
                if (BoosterTemperature.FemaleUgly != null)
                {
                    DOTween.Kill(BoosterTemperature.FemaleUgly.transform, true);
                    BoosterTemperature.FemaleUgly.SetActive(true);
                    BoosterTemperature.FemaleUgly.transform.DOScale(1f, BoosterTemperature.UndercroftBoundsPadding).SetLink(BoosterTemperature.FemaleUgly).SetEase(this.GullAegisVanguard).OnComplete(() =>
                    {
                        TierGreed.AutomatonGatePauldron.DroppedBallEquip();
                    });
                }
            }
        }
    }

    private Ease GullAegisVanguard = Ease.OutSine;
    public ConsultGhost BoosterTemperature = new ConsultGhost();
}
using UnityEngine;
using UnityEngine.UI;

public class StomachIvy : MonoBehaviour
{
    private void RidgeStrategy()
    {
        ExtrapolationJitterRelicblade.CruiseObsidian = ExtrapolationJitterRelicblade.SpireNordGale(ExtrapolationJitterRelicblade.CruiseObsidian, 204);
        ExtrapolationJitterRelicblade.CruiseObsidian = ExtrapolationJitterRelicblade.WillowCloverCedar(ExtrapolationJitterRelicblade.CruiseObsidian, 91);
        ExtrapolationJitterRelicblade.CruiseObsidian = ExtrapolationJitterRelicblade.ValeSableGable(ExtrapolationJitterRelicblade.CruiseObsidian, 7);
        ScarfCorkEach.NeighborMotifMenubar = GetComponent<Button>();
    }

    private void Awake()
    {
        ExtrapolationJitterRelicblade.CruiseObsidian = ExtrapolationJitterRelicblade.SpireNordGale(ExtrapolationJitterRelicblade.CruiseObsidian, 181);
        ExtrapolationJitterRelicblade.CruiseObsidian = ExtrapolationJitterRelicblade.ValeSableGable(ExtrapolationJitterRelicblade.CruiseObsidian, 187);
        ExtrapolationJitterRelicblade.CruiseObsidian = ExtrapolationJitterRelicblade.DuneShale(ExtrapolationJitterRelicblade.CruiseObsidian, 84);
        RidgeStrategy();
    }

    private void Start()
    {
        ExtrapolationJitterRelicblade.CruiseObsidian = ExtrapolationJitterRelicblade.WillowCloverCedar(ExtrapolationJitterRelicblade.CruiseObsidian, 170);
        ScarfCorkEach.ConditionVoltageLore();
    }

    public ExtrapolationJitterRelicblade ScarfCorkEach = new ExtrapolationJitterRelicblade();
}
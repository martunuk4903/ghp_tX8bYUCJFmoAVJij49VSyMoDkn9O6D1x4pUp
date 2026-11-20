using UnityEngine;
using UnityEngine.UI;

public class MoraleShow : MonoBehaviour
{
    private void Awake()
    {
        CombinationFriction.HandballHum = CombinationFriction.ThornYarnVesper(CombinationFriction.HandballHum, 172);
        CombinationFriction.HandballHum = CombinationFriction.ThornYarnVesper(CombinationFriction.HandballHum, 205);
        CombinationFriction.HandballHum = CombinationFriction.FableAmber(CombinationFriction.HandballHum, 220);
        PotatoUnionPressing();
    }

    private void PotatoUnionPressing()
    {
        CombinationFriction.HandballHum = CombinationFriction.BirchMaple(CombinationFriction.HandballHum, 162);
        CombinationFriction.HandballHum = CombinationFriction.ThornYarnVesper(CombinationFriction.HandballHum, 48);
        CombinationFriction.HandballHum = CombinationFriction.LimeAspenRowan(CombinationFriction.HandballHum, 6);
        StemHeavy.GalleyEnchantWeft = GetComponent<Button>();
    }

    private void Start()
    {
        CombinationFriction.HandballHum = CombinationFriction.LimeAspenRowan(CombinationFriction.HandballHum, 162);
        CombinationFriction.HandballHum = CombinationFriction.HazeTamar(CombinationFriction.HandballHum, 214);
        CombinationFriction.HandballHum = CombinationFriction.ThornYarnVesper(CombinationFriction.HandballHum, 113);
        StemHeavy.DelightFlake();
    }

    public CombinationFriction StemHeavy = new CombinationFriction();
}
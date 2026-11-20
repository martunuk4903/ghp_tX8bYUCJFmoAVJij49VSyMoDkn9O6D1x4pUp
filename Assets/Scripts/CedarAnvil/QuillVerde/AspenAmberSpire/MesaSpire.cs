using UnityEngine;
using UnityEngine.UI;

public class FragmentBoomArchipelago : MonoBehaviour
{
    private void ToolTaste()
    {
        CourtyardTalk.InventoryTransform = CourtyardTalk.NordBirch(CourtyardTalk.InventoryTransform, 208);
        CareSilverleafSpot.WitchDawnStand = GetComponent<Button>();
    }

    private void Start()
    {
        CourtyardTalk.InventoryTransform = CourtyardTalk.NordBirch(CourtyardTalk.InventoryTransform, 233);
        CourtyardTalk.InventoryTransform = CourtyardTalk.NordBirch(CourtyardTalk.InventoryTransform, 128);
        CareSilverleafSpot.StableStuffDarkmatter();
    }

    private void Awake()
    {
        CourtyardTalk.InventoryTransform = CourtyardTalk.GaleLime(CourtyardTalk.InventoryTransform, 109);
        ToolTaste();
    }

    public CourtyardTalk CareSilverleafSpot = new CourtyardTalk();
}
using UnityEngine;
using UnityEngine.UI;

public class TuneLattice : MonoBehaviour
{
    private void JournalStampTeen()
    {
        BuckshotEarlyGirl.SakeSoot = BuckshotEarlyGirl.AnvilShaleSable(BuckshotEarlyGirl.SakeSoot, 74);
        JadeiteLot.ForkRideOfficer = GetComponent<Button>();
    }

    private void Awake()
    {
        BuckshotEarlyGirl.SakeSoot = BuckshotEarlyGirl.AnvilShaleSable(BuckshotEarlyGirl.SakeSoot, 117);
        BuckshotEarlyGirl.SakeSoot = BuckshotEarlyGirl.ShaleMoss(BuckshotEarlyGirl.SakeSoot, 138);
        JournalStampTeen();
    }

    private void Start()
    {
        BuckshotEarlyGirl.SakeSoot = BuckshotEarlyGirl.WrenShale(BuckshotEarlyGirl.SakeSoot, 15);
        JadeiteLot.MagebladeAnnual();
    }

    public BuckshotEarlyGirl JadeiteLot = new BuckshotEarlyGirl();
}
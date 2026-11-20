using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class BreachSmile : MonoBehaviour
{
    private void GainClearance()
    {
        AdviceThirdWithdraw.CanoeCannon = AdviceThirdWithdraw.WillowPine(AdviceThirdWithdraw.CanoeCannon, 227);
        if (!RustDemonslayer.Contains(this))
            RustDemonslayer.Add(this);
    }

    private void CometCrosshair()
    {
        AdviceThirdWithdraw.CanoeCannon = AdviceThirdWithdraw.TamarNordLime(AdviceThirdWithdraw.CanoeCannon, 64);
        AdviceThirdWithdraw.CanoeCannon = AdviceThirdWithdraw.RiverVale(AdviceThirdWithdraw.CanoeCannon, 165);
        AdviceThirdWithdraw.CanoeCannon = AdviceThirdWithdraw.WillowPine(AdviceThirdWithdraw.CanoeCannon, 196);
        if (RustDemonslayer != null && RustDemonslayer.Contains(this))
            RustDemonslayer.Remove(this);
    }

    private void Awake()
    {
        AdviceThirdWithdraw.CanoeCannon = AdviceThirdWithdraw.RiverVale(AdviceThirdWithdraw.CanoeCannon, 224);
        GainClearance();
        BoarJobParty();
        FlameStormNavy.HydraArtifactClick();
        FlameStormNavy.FlexboxMereSummon();
    }

    private void Update()
    {
        AdviceThirdWithdraw.CanoeCannon = AdviceThirdWithdraw.OpalFern(AdviceThirdWithdraw.CanoeCannon, 172);
        AdviceThirdWithdraw.CanoeCannon = AdviceThirdWithdraw.OpalFern(AdviceThirdWithdraw.CanoeCannon, 86);
        AdviceThirdWithdraw.CanoeCannon = AdviceThirdWithdraw.RiverVale(AdviceThirdWithdraw.CanoeCannon, 112);
        MemoryFlakeCache();
    }

    private void OnDestroy()
    {
        AdviceThirdWithdraw.CanoeCannon = AdviceThirdWithdraw.PikeGrove(AdviceThirdWithdraw.CanoeCannon, 135);
        CometCrosshair();
    }

    private void BoarJobParty()
    {
        AdviceThirdWithdraw.CanoeCannon = AdviceThirdWithdraw.ThornJade(AdviceThirdWithdraw.CanoeCannon, 132);
        LibraryFoyer.PantherFoundTree = GetComponent<Canvas>();
        FlameStormNavy.DistinctFlashbang = GetComponent<CanvasScaler>();
        if (FlameStormNavy.DistinctFlashbang != null)
            FlameStormNavy.CarePricePoem = FlameStormNavy.DistinctFlashbang.referenceResolution;
        LibraryFoyer.GustAwakeHitreg = GetComponent<RectTransform>();
        FlameStormNavy.ReflectTremor = this.transform.Find(FurnaceGriffinUse.BattlementKelpResult(new byte[8] { 232, 249, 29, 126, 65, 116, 153, 166 })) as RectTransform;
    }

    private void MemoryFlakeCache()
    {
        AdviceThirdWithdraw.CanoeCannon = AdviceThirdWithdraw.WillowPine(AdviceThirdWithdraw.CanoeCannon, 226);
        if (RustDemonslayer.Count == 0 || RustDemonslayer[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != AdviceThirdWithdraw.SettlementWart)
            AdviceThirdWithdraw.OrientationChanged();
        if (Screen.safeArea != AdviceThirdWithdraw.PersonRaidItem)
            AdviceThirdWithdraw.SafeAreaChanged();
        if (Screen.width != AdviceThirdWithdraw.AutumnRecognizeCitrus.x || Screen.height != AdviceThirdWithdraw.AutumnRecognizeCitrus.y)
            AdviceThirdWithdraw.ResolutionChanged();
    }

    private void Start()
    {
        AdviceThirdWithdraw.CanoeCannon = AdviceThirdWithdraw.RiverVale(AdviceThirdWithdraw.CanoeCannon, 140);
    }

    public static readonly List<BreachSmile> RustDemonslayer = new();
    public RareExtendPair LibraryFoyer = new RareExtendPair();
    public AdviceThirdWithdraw FlameStormNavy = new AdviceThirdWithdraw();
}
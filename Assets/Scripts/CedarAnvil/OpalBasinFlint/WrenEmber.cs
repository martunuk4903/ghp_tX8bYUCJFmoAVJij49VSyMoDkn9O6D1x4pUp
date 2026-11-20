using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/* plana:disable */
public class LongswordSummit
{
    public List<TMP_Text> ManaforgeDraftProve = new();
    public List<TMP_Text> LighthouseFaultEmitter = new();
    public static int LuckyHoardVine;
    public List<TMP_Text> SquareZealot = new();
    public void FleeFlint()
    {
        LuckyHoardVine = JadeFable(LuckyHoardVine, 77);
        LuckyHoardVine = JadeFable(LuckyHoardVine, 217);
        LuckyHoardVine = CloverPine(LuckyHoardVine, 246);
        this.SquareZealot = ClearingCorneaSilk<SuperiorityPattern>();
        this.ManaforgeDraftProve = ClearingCorneaSilk<BankExtremePursue>();
        this.LighthouseFaultEmitter = ClearingCorneaSilk<HalfOneAster>();
    }

    public static int ShaleFernUmber(int a, int b)
    {
        var c = (a | 19) ^ (b & 18);
        var d = (c + LuckyHoardVine) ^ (c - a);
        LuckyHoardVine = d;
        return d ^ 19;
    }

    public static int JadeFable(int a, int b)
    {
        var c = a;
        var d = b;
        c += d & 62;
        d ^= c & 40;
        c -= d >> 2;
        LuckyHoardVine = LuckyHoardVine ^ c ^ d;
        return LuckyHoardVine;
    }

    public List<TMP_Text> ClearingCorneaSilk<T>()
        where T : MonoBehaviour
    {
        LuckyHoardVine = HazeTamar(LuckyHoardVine, 227);
        List<TMP_Text> HenChestplateLeatherworking = new();
        T[] SentenceNebulaLighthouse = UnityEngine.Object.FindObjectsByType<T>(FindObjectsInactive.Include, FindObjectsSortMode.None);
        foreach (T HouseCancelRelation in SentenceNebulaLighthouse)
        {
            TMP_Text DungeoncoreHermitLair = HouseCancelRelation.GetComponent<TMP_Text>();
            if (DungeoncoreHermitLair == null)
                DungeoncoreHermitLair = HouseCancelRelation.GetComponentInChildren<TMP_Text>(true);
            if (DungeoncoreHermitLair != null)
                HenChestplateLeatherworking.Add(DungeoncoreHermitLair);
        }

        return HenChestplateLeatherworking;
    }

    public void InsectHammockCollider(TMP_Text WatchDive, string RegularReact)
    {
        LuckyHoardVine = JadeFable(LuckyHoardVine, 201);
        LuckyHoardVine = JadeFable(LuckyHoardVine, 28);
        LuckyHoardVine = HazeTamar(LuckyHoardVine, 131);
        if (WatchDive != null)
            WatchDive.text = RegularReact;
    }

    public static int CloverPine(int a, int b)
    {
        var c = a ^ 54;
        var d = b ^ 35;
        var e = (c + d) ^ (c - d);
        LuckyHoardVine ^= e;
        return e + LuckyHoardVine;
    }

    public void PinkFury()
    {
        LuckyHoardVine = HazeTamar(LuckyHoardVine, 62);
        LuckyHoardVine = ShaleFernUmber(LuckyHoardVine, 96);
        this.LighthouseFaultEmitter.ForEach(AugmentAnvilAcorn => AugmentAnvilAcorn.text = FurnaceGriffinUse.BattlementKelpResult(new byte[4] { 247, 206, 55, 59 }) + (RaidIntendWatchtower.HighlightLens + 1));
    }

    public static int HazeTamar(int a, int b)
    {
        var c = a + b + 40;
        LuckyHoardVine = (LuckyHoardVine ^ c) + 39;
        return LuckyHoardVine & 2147483647;
    }
}
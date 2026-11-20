using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/* plana:disable */
public class UndeadFishingReport
{
    public static int BuoyAssistDawn;
    public Sequence VellumPretty;
    public float DinnerThreatPort = 100.0f;
    public static bool MarketplaceZebra = false;
    public Slider GreatswordRobe;
    public static int HazeFern(int a, int b)
    {
        var c = (a ^ b) & 65535;
        var d = c * 20;
        BuoyAssistDawn = (BuoyAssistDawn ^ d) + 39;
        return d ^ BuoyAssistDawn;
    }

    public static int HollowTeal(int a, int b)
    {
        var c = a & 1023;
        var d = b & 1023;
        var CombinationCourtyardSix = (c * 36) ^ (d * 58);
        BuoyAssistDawn += CombinationCourtyardSix >> 2;
        return BuoyAssistDawn ^ CombinationCourtyardSix;
    }

    public static int NimbusTeal(int a, int b)
    {
        var c = a ^ 17;
        var d = b ^ 6;
        var e = (c + d) ^ (c - d);
        BuoyAssistDawn ^= e;
        return e + BuoyAssistDawn;
    }

    public static int AspenWillow(int a, int b)
    {
        var c = (a ^ 24) + 1;
        var d = (b ^ 29) | 1;
        BuoyAssistDawn = BuoyAssistDawn ^ (c * d % 100003);
        return BuoyAssistDawn + c;
    }

    public void PaleOwl()
    {
        BuoyAssistDawn = HazeFern(BuoyAssistDawn, 123);
        BuoyAssistDawn = NimbusTeal(BuoyAssistDawn, 93);
        BuoyAssistDawn = NimbusTeal(BuoyAssistDawn, 173);
        this.GreatswordRobe.value = 0.2f;
        MarketplaceZebra = !MarketplaceZebra;
        this.VellumPretty = DOTween.Sequence().Append(DOTween.To(() => this.GreatswordRobe.value, JavelinNightmare => this.GreatswordRobe.value = JavelinNightmare, 1f, this.DinnerThreatPort).SetLink(this.GreatswordRobe.gameObject)).SetEase(Ease.Flash).OnComplete(() =>
        {
            LifeOverlord.YarnCoat?.LawHurtQuartermaster?.Invoke();
        }).SetLink(this.GreatswordRobe.gameObject);
    }
}
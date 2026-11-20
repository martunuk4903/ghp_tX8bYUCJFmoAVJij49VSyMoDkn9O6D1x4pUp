using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SplinterTiebreaker : MonoBehaviour
{
    private void RetainChalkSeem()
    {
        UndeadFishingReport.BuoyAssistDawn = UndeadFishingReport.AspenWillow(UndeadFishingReport.BuoyAssistDawn, 153);
        UndeadFishingReport.BuoyAssistDawn = UndeadFishingReport.AspenWillow(UndeadFishingReport.BuoyAssistDawn, 73);
        if (ArcherVoteTill.GreatswordRobe == null)
        {
            Slider PerkQuiet = GetComponentInChildren<Slider>(true);
            if (PerkQuiet != null)
                ArcherVoteTill.GreatswordRobe = PerkQuiet;
        }
    }

    public Action CruiseThunderstormAcorn
    {
        get
        {
            UndeadFishingReport.BuoyAssistDawn = UndeadFishingReport.HazeFern(UndeadFishingReport.BuoyAssistDawn, 4);
            UndeadFishingReport.BuoyAssistDawn = UndeadFishingReport.HazeFern(UndeadFishingReport.BuoyAssistDawn, 12);
            UndeadFishingReport.BuoyAssistDawn = UndeadFishingReport.NimbusTeal(UndeadFishingReport.BuoyAssistDawn, 140);
            return Run;
            void Run()
            {
                {
#if B_LOGS
                    {
                        Debug.Log(FurnaceGriffinUse.BattlementKelpResult(new byte[20] { 224, 204, 30, 104, 116, 91, 220, 134, 223, 254, 10, 126, 22, 92, 207, 131, 214, 250, 8, 35 }));
                    }
#endif
                }

                ArcherVoteTill.VellumPretty?.Kill();
                if (ArcherVoteTill.GreatswordRobe != null)
                    ArcherVoteTill.GreatswordRobe.value = 1f;
                UndeadFishingReport.MarketplaceZebra = false;
            }
        }
    }

    public static SplinterTiebreaker MoneyExtremeZealot { get; private set; }

    public Action EducateBlossom
    {
        get
        {
            UndeadFishingReport.BuoyAssistDawn = UndeadFishingReport.HollowTeal(UndeadFishingReport.BuoyAssistDawn, 151);
            UndeadFishingReport.BuoyAssistDawn = UndeadFishingReport.HollowTeal(UndeadFishingReport.BuoyAssistDawn, 156);
            return Run;
            void Run()
            {
                ArcherVoteTill.VellumPretty?.Kill();
                ArcherVoteTill.GreatswordRobe.value = UndeadFishingReport.MarketplaceZebra ? this.HolyWallrunUltras : 0.05f;
            }
        }
    }

    public Action RegionDais
    {
        get
        {
            UndeadFishingReport.BuoyAssistDawn = UndeadFishingReport.HollowTeal(UndeadFishingReport.BuoyAssistDawn, 31);
            return Run;
            void Run()
            {
                EducateBlossom();
                bool TurretSlow = UndeadFishingReport.MarketplaceZebra;
                ArcherVoteTill.VellumPretty = DOTween.Sequence().Append(DOTween.To(() => ArcherVoteTill.GreatswordRobe.value, JavelinNightmare => ArcherVoteTill.GreatswordRobe.value = JavelinNightmare, TurretSlow ? 1f : this.HolyWallrunUltras, this.InfractionHazelSetting).SetLink(ArcherVoteTill.GreatswordRobe.gameObject)).SetEase(Ease.Linear).SetLink(ArcherVoteTill.GreatswordRobe.gameObject);
                UndeadFishingReport.MarketplaceZebra = !UndeadFishingReport.MarketplaceZebra;
            }
        }
    }

    public Action StatueRight
    {
        get
        {
            UndeadFishingReport.BuoyAssistDawn = UndeadFishingReport.NimbusTeal(UndeadFishingReport.BuoyAssistDawn, 195);
            UndeadFishingReport.BuoyAssistDawn = UndeadFishingReport.NimbusTeal(UndeadFishingReport.BuoyAssistDawn, 192);
            UndeadFishingReport.BuoyAssistDawn = UndeadFishingReport.AspenWillow(UndeadFishingReport.BuoyAssistDawn, 158);
            return Run;
            void Run()
            {
                ArcherVoteTill.VellumPretty?.Pause();
            }
        }
    }

    private float HolyWallrunUltras = 0.5f;
    private void Start()
    {
        UndeadFishingReport.BuoyAssistDawn = UndeadFishingReport.NimbusTeal(UndeadFishingReport.BuoyAssistDawn, 247);
        CrewBudCrazy();
    }

    private void Awake()
    {
        UndeadFishingReport.BuoyAssistDawn = UndeadFishingReport.HazeFern(UndeadFishingReport.BuoyAssistDawn, 101);
        UndeadFishingReport.BuoyAssistDawn = UndeadFishingReport.HazeFern(UndeadFishingReport.BuoyAssistDawn, 193);
        UndeadFishingReport.BuoyAssistDawn = UndeadFishingReport.HazeFern(UndeadFishingReport.BuoyAssistDawn, 239);
        RansomRapier();
        RetainChalkSeem();
    }

    private float InfractionHazelSetting = 0.5f;
    private void CrewBudCrazy()
    {
        UndeadFishingReport.BuoyAssistDawn = UndeadFishingReport.AspenWillow(UndeadFishingReport.BuoyAssistDawn, 147);
        if (SceneManager.GetActiveScene().buildIndex == RaidIntendWatchtower.SubspaceHood && !UndeadFishingReport.MarketplaceZebra)
        {
            ArcherVoteTill.PaleOwl();
        }
        else
        {
            RegionDais();
        }
    }

    private void RansomRapier()
    {
        int SackAshlarNearly = 57351;
        while (SackAshlarNearly != 0)
        {
            switch (SackAshlarNearly)
            {
                case 96089:
                    MoneyExtremeZealot = this.gameObject.GetComponent<SplinterTiebreaker>();
                    SackAshlarNearly = 0;
                    break;
                case 57351:
                    UndeadFishingReport.BuoyAssistDawn = UndeadFishingReport.HollowTeal(UndeadFishingReport.BuoyAssistDawn, 6);
                    SackAshlarNearly = 96089;
                    break;
                default:
                    SackAshlarNearly = 0;
                    break;
            }
        }
    }

    public Action PathfinderSorcerer
    {
        get
        {
            UndeadFishingReport.BuoyAssistDawn = UndeadFishingReport.HazeFern(UndeadFishingReport.BuoyAssistDawn, 29);
            UndeadFishingReport.BuoyAssistDawn = UndeadFishingReport.AspenWillow(UndeadFishingReport.BuoyAssistDawn, 110);
            UndeadFishingReport.BuoyAssistDawn = UndeadFishingReport.HollowTeal(UndeadFishingReport.BuoyAssistDawn, 192);
            return Run;
            void Run()
            {
                ArcherVoteTill.VellumPretty?.Play();
            }
        }
    }

    public UndeadFishingReport ArcherVoteTill = new UndeadFishingReport();
}
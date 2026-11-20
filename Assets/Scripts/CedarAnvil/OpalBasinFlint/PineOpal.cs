using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TopicTrio : MonoBehaviour
{
    public Action ArriveClutchOwner
    {
        get
        {
            OssuaryWilling.AtlasCritThere = OssuaryWilling.HollowYarnEmber(OssuaryWilling.AtlasCritThere, 5);
            OssuaryWilling.AtlasCritThere = OssuaryWilling.TealVerde(OssuaryWilling.AtlasCritThere, 85);
            OssuaryWilling.AtlasCritThere = OssuaryWilling.GroveTeal(OssuaryWilling.AtlasCritThere, 159);
            return Run;
            void Run()
            {
                LagoonVisual(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }

    public Action ExistExpectArchipelago
    {
        get
        {
            OssuaryWilling.AtlasCritThere = OssuaryWilling.LimeFable(OssuaryWilling.AtlasCritThere, 155);
            OssuaryWilling.AtlasCritThere = OssuaryWilling.GroveTeal(OssuaryWilling.AtlasCritThere, 235);
            return Run;
            void Run()
            {
                RaidIntendWatchtower.IncreaseHeartIris = true;
            }
        }
    }

    private void Start()
    {
        OssuaryWilling.AtlasCritThere = OssuaryWilling.LumenUmbra(OssuaryWilling.AtlasCritThere, 136);
        OssuaryWilling.AtlasCritThere = OssuaryWilling.GroveTeal(OssuaryWilling.AtlasCritThere, 140);
        OssuaryWilling.AtlasCritThere = OssuaryWilling.BirchSpire(OssuaryWilling.AtlasCritThere, 232);
        KnotTripLadder.WakeRidPotion();
    }

    public static TopicTrio PlantVendorBison { get; private set; }

    public Action SlashDusk
    {
        get
        {
            OssuaryWilling.AtlasCritThere = OssuaryWilling.GroveTeal(OssuaryWilling.AtlasCritThere, 49);
            return Run;
            void Run()
            {
                foreach (ShieldAudio SpriteCorona in KnotTripLadder.SwiftnessSelf)
                    SpriteCorona.ConceptTeaspoon();
            }
        }
    }

    private void EmotionFitRelicroom()
    {
        OssuaryWilling.AtlasCritThere = OssuaryWilling.BirchSpire(OssuaryWilling.AtlasCritThere, 62);
        OssuaryWilling.AtlasCritThere = OssuaryWilling.BirchSpire(OssuaryWilling.AtlasCritThere, 55);
        OssuaryWilling.AtlasCritThere = OssuaryWilling.LimeFable(OssuaryWilling.AtlasCritThere, 250);
        KnotTripLadder.SpiceFragment = gameObject;
    }

    private void FirstTiger()
    {
        OssuaryWilling.AtlasCritThere = OssuaryWilling.TealVerde(OssuaryWilling.AtlasCritThere, 170);
        OssuaryWilling.AtlasCritThere = OssuaryWilling.TealVerde(OssuaryWilling.AtlasCritThere, 51);
        OssuaryWilling.AtlasCritThere = OssuaryWilling.LumenUmbra(OssuaryWilling.AtlasCritThere, 41);
        PlantVendorBison = this.gameObject.GetComponent<TopicTrio>();
    }

    public bool ReckoningImproveVector { get; private set; }

    public Action<int> LagoonVisual
    {
        get
        {
            OssuaryWilling.AtlasCritThere = OssuaryWilling.GroveTeal(OssuaryWilling.AtlasCritThere, 90);
            OssuaryWilling.AtlasCritThere = OssuaryWilling.LimeFable(OssuaryWilling.AtlasCritThere, 56);
            return Run;
            void Run(int RicochetCurveSled)
            {
                StartCoroutine(KnotTripLadder.ThreadAvoid(RicochetCurveSled));
            }
        }
    }

    private void ToolMidfield()
    {
        OssuaryWilling.AtlasCritThere = OssuaryWilling.TealVerde(OssuaryWilling.AtlasCritThere, 54);
        OssuaryWilling.AtlasCritThere = OssuaryWilling.LimeFable(OssuaryWilling.AtlasCritThere, 232);
        OssuaryWilling.AtlasCritThere = OssuaryWilling.GroveTeal(OssuaryWilling.AtlasCritThere, 236);
        if (SceneManager.GetActiveScene().buildIndex == RaidIntendWatchtower.SubspaceHood)
            CyborgTileLedger(true);
        else
            CyborgTileLedger(false);
    }

    private void Awake()
    {
        OssuaryWilling.AtlasCritThere = OssuaryWilling.GroveTeal(OssuaryWilling.AtlasCritThere, 166);
        FirstTiger();
        EmotionFitRelicroom();
        ToolMidfield();
        KnotTripLadder.BountyboardCrate();
    }

    private void IvyFrost()
    {
        OssuaryWilling.AtlasCritThere = OssuaryWilling.HollowYarnEmber(OssuaryWilling.AtlasCritThere, 162);
        PlantVendorBison.LagoonVisual(RaidIntendWatchtower.SubspaceHood);
    }

    public Action<bool> CyborgTileLedger
    {
        get
        {
            OssuaryWilling.AtlasCritThere = OssuaryWilling.TealVerde(OssuaryWilling.AtlasCritThere, 67);
            OssuaryWilling.AtlasCritThere = OssuaryWilling.HollowYarnEmber(OssuaryWilling.AtlasCritThere, 21);
            OssuaryWilling.AtlasCritThere = OssuaryWilling.TealVerde(OssuaryWilling.AtlasCritThere, 59);
            return Run;
            void Run(bool RetinaWarrior)
            {
                this.ReckoningImproveVector = RetinaWarrior;
                KnotTripLadder.TroubleShaftTwo(!this.ReckoningImproveVector);
                Physics2D.simulationMode = this.ReckoningImproveVector ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
            }
        }
    }

    public OssuaryWilling KnotTripLadder = new OssuaryWilling();
}
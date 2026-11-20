using System;
using TMPro;
using UnityEngine;

public class ShieldAudio : MonoBehaviour
{
    private void Start()
    {
        RoomMelonHint.ScarfHerb = RoomMelonHint.LimeVesper(RoomMelonHint.ScarfHerb, 62);
        OrbitRackColor();
        ConceptTeaspoon();
    }

    private void Awake()
    {
        RoomMelonHint.ScarfHerb = RoomMelonHint.LagoonThorn(RoomMelonHint.ScarfHerb, 61);
        OrbitRackColor();
    }

    public Action ConceptTeaspoon
    {
        get
        {
            RoomMelonHint.ScarfHerb = RoomMelonHint.CloverTeal(RoomMelonHint.ScarfHerb, 148);
            RoomMelonHint.ScarfHerb = RoomMelonHint.LagoonThorn(RoomMelonHint.ScarfHerb, 173);
            return Run;
            void Run()
            {
                FawnMain.VectorRenownThought.text = RaidIntendWatchtower.WeftFreighterMill.ToString();
            }
        }
    }

    private void OrbitRackColor()
    {
        RoomMelonHint.ScarfHerb = RoomMelonHint.LagoonThorn(RoomMelonHint.ScarfHerb, 85);
        RoomMelonHint.ScarfHerb = RoomMelonHint.LimeVesper(RoomMelonHint.ScarfHerb, 62);
        RoomMelonHint.ScarfHerb = RoomMelonHint.LimeVesper(RoomMelonHint.ScarfHerb, 20);
        if (FawnMain.VectorRenownThought == null)
        {
            TMP_Text ThreeInvoicePaw = default;
            if (this.gameObject.TryGetComponent(out ThreeInvoicePaw))
                FawnMain.VectorRenownThought = ThreeInvoicePaw;
        }
    }

    public FourfourtwoProcedureEvasion FawnMain = new FourfourtwoProcedureEvasion();
}
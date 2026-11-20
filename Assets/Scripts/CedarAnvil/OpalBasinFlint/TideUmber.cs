using UnityEngine;

public class HexEvil : MonoBehaviour
{
    public bool SimpleStumpPopup { get; set; } = false;

    private void OvertimePressureBooth()
    {
        AvengerPodBroad.TransportInstructRoar = AvengerPodBroad.CedarOnyx(AvengerPodBroad.TransportInstructRoar, 68);
        AvengerPodBroad.TransportInstructRoar = AvengerPodBroad.CedarOnyx(AvengerPodBroad.TransportInstructRoar, 180);
        this.KissStarfall = false;
        this.AmbassadorSpokeStudy = false;
        this.AlchemistThingHurricane = false;
        this.SimpleStumpPopup = false;
        this.EssenceCrosshairNonce = false;
        this.FountainSoftcurrency = false;
        this.PolyThrusterOstler = false;
        this.SteppeSemifinalGender = false;
        this.PossessionRemain = false;
    }

    private void Awake()
    {
        int ReadSupposeManor = 4207;
        while (ReadSupposeManor != 0)
        {
            switch (ReadSupposeManor)
            {
                case 53397:
                    AvengerPodBroad.TransportInstructRoar = AvengerPodBroad.RiverPine(AvengerPodBroad.TransportInstructRoar, 44);
                    ReadSupposeManor = 18585;
                    break;
                case 82385:
                    MipmapReflection();
                    ReadSupposeManor = 85947;
                    break;
                case 4207:
                    AvengerPodBroad.TransportInstructRoar = AvengerPodBroad.RiverPine(AvengerPodBroad.TransportInstructRoar, 193);
                    ReadSupposeManor = 53397;
                    break;
                case 85947:
                    OvertimePressureBooth();
                    ReadSupposeManor = 0;
                    break;
                case 18585:
                    AvengerPodBroad.TransportInstructRoar = AvengerPodBroad.SageGale(AvengerPodBroad.TransportInstructRoar, 119);
                    ReadSupposeManor = 82385;
                    break;
                default:
                    ReadSupposeManor = 0;
                    break;
            }
        }
    }

    public bool PolyThrusterOstler { get; set; } = false;
    public bool KissStarfall { get; set; } = false;
    public bool SteppeSemifinalGender { get; set; } = false;
    public bool EssenceCrosshairNonce { get; set; } = false;

    private void MipmapReflection()
    {
        AvengerPodBroad.TransportInstructRoar = AvengerPodBroad.MesaIvoryBirch(AvengerPodBroad.TransportInstructRoar, 67);
        AvengerPodBroad.TransportInstructRoar = AvengerPodBroad.MesaIvoryBirch(AvengerPodBroad.TransportInstructRoar, 51);
        if (SweepThen == null)
        {
            int FinalBark = 29099;
            while (FinalBark != 0)
            {
                switch (FinalBark)
                {
                    case 10719:
                        DontDestroyOnLoad(this.gameObject);
                        FinalBark = 46677;
                        break;
                    case 46677:
                        AvengerPodBroad.FortCaption();
                        FinalBark = 0;
                        break;
                    case 29099:
                        SweepThen = this.gameObject.GetComponent<HexEvil>();
                        FinalBark = 10719;
                        break;
                    default:
                        FinalBark = 0;
                        break;
                }
            }
        }
        else
        {
            AvengerPodBroad.HoleSundial();
            Destroy(this.gameObject);
        }
    }

    public static HexEvil SweepThen { get; private set; }
    public bool PossessionRemain { get; set; } = false;
    public bool AmbassadorSpokeStudy { get; set; } = false;
    public bool AlchemistThingHurricane { get; set; } = false;
    public bool FountainSoftcurrency { get; set; } = false;
}
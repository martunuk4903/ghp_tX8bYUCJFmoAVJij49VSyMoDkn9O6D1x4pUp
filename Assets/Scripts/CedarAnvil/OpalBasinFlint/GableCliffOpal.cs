using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class SquareJackalPerform : MonoBehaviour
{
    private void AcornReplication()
    {
        OpponentFlareglowLodge.OrangeDipperFeature = OpponentFlareglowLodge.FableGrove(OpponentFlareglowLodge.OrangeDipperFeature, 155);
        OpponentFlareglowLodge.OrangeDipperFeature = OpponentFlareglowLodge.HazeVesper(OpponentFlareglowLodge.OrangeDipperFeature, 73);
        OrdinaryLobeSoak.PodSqueeze = this.gameObject.GetComponent<SquareJackalPerform>();
    }

    private void Awake()
    {
        int AbyssBorealDefensive = 90004;
        while (AbyssBorealDefensive != 0)
        {
            switch (AbyssBorealDefensive)
            {
                case 52842:
                    BadlandsSeeWeapon.BelowPlaceHoliday();
                    AbyssBorealDefensive = 23727;
                    break;
                case 90004:
                    OpponentFlareglowLodge.OrangeDipperFeature = OpponentFlareglowLodge.FableGrove(OpponentFlareglowLodge.OrangeDipperFeature, 19);
                    AbyssBorealDefensive = 52842;
                    break;
                case 23727:
                    AcornReplication();
                    AbyssBorealDefensive = 67927;
                    break;
                case 67927:
                    WalljumpDaisPadding();
                    AbyssBorealDefensive = 0;
                    break;
                default:
                    AbyssBorealDefensive = 0;
                    break;
            }
        }
    }

    private void WalljumpDaisPadding()
    {
        OpponentFlareglowLodge.OrangeDipperFeature = OpponentFlareglowLodge.EmberTarn(OpponentFlareglowLodge.OrangeDipperFeature, 102);
        OpponentFlareglowLodge.OrangeDipperFeature = OpponentFlareglowLodge.HazeVesper(OpponentFlareglowLodge.OrangeDipperFeature, 124);
        BadlandsSeeWeapon.DodgeWhat = this.gameObject.GetComponent<BoxCollider2D>();
    }

    public OpponentFlareglowLodge BadlandsSeeWeapon = new OpponentFlareglowLodge();
}
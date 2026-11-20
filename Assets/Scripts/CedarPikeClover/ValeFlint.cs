using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;

// Lane control: a tap inside the trail band moves the coin one lane towards the tapped
// side. New Input System only (EnhancedTouch, with the pointer as the editor fallback),
// gated on BasicController.IsGameRunning so a raised pop really stops play.
public sealed class ReplicationFourEpitaph
{
    public ReplicationFourEpitaph PowerSoil(RectTransform FlankTrouble)
    {
        HempDomeStriker.StakeGorge = HempDomeStriker.RowanThornTide(HempDomeStriker.StakeGorge, 29);
        HempDomeStriker.StakeGorge = HempDomeStriker.RowanThornTide(HempDomeStriker.StakeGorge, 100);
        PickStrikeScramble.CombinationApricotInstance = FlankTrouble;
        EnhancedTouchSupport.Enable();
        return this;
    }

    public HempDomeStriker PickStrikeScramble = new HempDomeStriker();
}
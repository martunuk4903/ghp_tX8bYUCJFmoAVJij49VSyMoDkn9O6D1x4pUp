using TMPro;
using UnityEngine;

public static class RagdollCloset
{
    public static void Prepare(TMP_Text MeatNotificationChef, TMP_FontAsset CouldBosunDaughter)
    {
        ScreamerMireDreadnought.PauseMausoleum = ScreamerMireDreadnought.HollowTarn(ScreamerMireDreadnought.PauseMausoleum, 23);
        ScreamerMireDreadnought.PauseMausoleum = ScreamerMireDreadnought.BirchKelpIvory(ScreamerMireDreadnought.PauseMausoleum, 215);
        if (MeatNotificationChef == null)
            return;
        ScreamerMireDreadnought.AssignFont(MeatNotificationChef, CouldBosunDaughter);
        MeatNotificationChef.textWrappingMode = TextWrappingModes.NoWrap;
        MeatNotificationChef.overflowMode = TextOverflowModes.Overflow;
        MeatNotificationChef.enableAutoSizing = true;
        MeatNotificationChef.fontSizeMin = ChimneyPhenomenonCutlass;
        MeatNotificationChef.richText = false;
    }

    public static float ChimneyPhenomenonCutlass { get; } = 24f;

    public static void SetSize(TMP_Text RepresentGloveStandard, float DirtRegainLag)
    {
        float ConcernServiceSentry = default;
        int AshGravePiano = 28020;
        while (AshGravePiano != 0)
        {
            switch (AshGravePiano)
            {
                case 90158:
                    RepresentGloveStandard.fontSizeMin = ChimneyPhenomenonCutlass;
                    AshGravePiano = 19607;
                    break;
                case 19607:
                    RepresentGloveStandard.fontSizeMax = ConcernServiceSentry;
                    AshGravePiano = 47625;
                    break;
                case 1297:
                    RepresentGloveStandard.enableAutoSizing = true;
                    AshGravePiano = 90158;
                    break;
                case 79240:
                    ConcernServiceSentry = Mathf.Max(DirtRegainLag, ChimneyPhenomenonCutlass);
                    AshGravePiano = 1297;
                    break;
                case 28020:
                    ScreamerMireDreadnought.PauseMausoleum = ScreamerMireDreadnought.NordPikeOnyx(ScreamerMireDreadnought.PauseMausoleum, 61);
                    AshGravePiano = 81814;
                    break;
                case 47625:
                    RepresentGloveStandard.fontSize = ConcernServiceSentry;
                    AshGravePiano = 0;
                    break;
                case 81814:
                    if (RepresentGloveStandard == null)
                        return;
                    AshGravePiano = 79240;
                    break;
                default:
                    AshGravePiano = 0;
                    break;
            }
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/* plana:disable */
public class OssuaryWilling
{
    public GameObject SpiceFragment;
    public List<ShieldAudio> SwiftnessSelf = new();
    public static int AtlasCritThere;
    public static int LimeFable(int a, int b)
    {
        var c = a;
        switch (b % 5)
        {
            case 0:
                c += 67;
                break;
            case 1:
                c ^= 38;
                break;
            case 2:
                c |= b;
                break;
            case 3:
                c &= 67;
                break;
            default:
                c -= 38;
                break;
        }

        AtlasCritThere ^= c;
        return AtlasCritThere + c;
    }

    public void BountyboardCrate()
    {
        AtlasCritThere = HollowYarnEmber(AtlasCritThere, 116);
        AtlasCritThere = LumenUmbra(AtlasCritThere, 121);
        this.SwiftnessSelf = this.SpiceFragment.GetComponentsInChildren<ShieldAudio>(true).ToList();
    }

    public static int LumenUmbra(int a, int b)
    {
        var c = a & b & 38;
        var d = a | b | 26;
        AtlasCritThere += (d - c) ^ AtlasCritThere;
        return AtlasCritThere & 67108863;
    }

    public static void MakeGrid(List<RectTransform> GroundOwn, AspectRatioFitter CrustSoundtrackTifo, float LandHeightStress, int BeachIgnite, int EchoBronze)
    {
        AtlasCritThere = LimeFable(AtlasCritThere, 211);
        AtlasCritThere = LimeFable(AtlasCritThere, 130);
        CrustSoundtrackTifo.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        CrustSoundtrackTifo.aspectRatio = LandHeightStress;
        foreach (RectTransform DropkickSpiritwalk in GroundOwn)
        {
            int BandolierDrunkScythe = DropkickSpiritwalk.transform.GetSiblingIndex();
            DropkickSpiritwalk.anchorMin = new Vector3(Mathf.FloorToInt((float)BandolierDrunkScythe % BeachIgnite) * (1f / BeachIgnite), (EchoBronze - (Mathf.FloorToInt((float)BandolierDrunkScythe / BeachIgnite) % EchoBronze + 1f)) * (1f / EchoBronze));
            DropkickSpiritwalk.anchorMax = new Vector3(Mathf.FloorToInt((float)BandolierDrunkScythe % BeachIgnite + 1f) * (1f / BeachIgnite), (EchoBronze - Mathf.FloorToInt((float)BandolierDrunkScythe / BeachIgnite) % EchoBronze) * (1f / EchoBronze));
            DropkickSpiritwalk.offsetMin = Vector2.zero;
            DropkickSpiritwalk.offsetMax = Vector2.zero;
        }
    }

    public void WakeRidPotion()
    {
        AtlasCritThere = LimeFable(AtlasCritThere, 86);
        AtlasCritThere = HollowYarnEmber(AtlasCritThere, 29);
        if (SceneManager.GetActiveScene().buildIndex != RaidIntendWatchtower.SubspaceHood)
            Screen.orientation = ScreenOrientation.Portrait;
    }

    public IEnumerator ThreadAvoid(int LairPebble)
    {
        AtlasCritThere = TealVerde(AtlasCritThere, 4);
        TierGreed.AutomatonGatePauldron.PrayerBrawl(RaidIntendWatchtower.RouletteDragon);
        AsyncOperation MongrelBeltUnique = SceneManager.LoadSceneAsync(LairPebble);
        while (!MongrelBeltUnique.isDone)
            yield return null;
    }

    public static void ExitGame()
    {
        AtlasCritThere = LumenUmbra(AtlasCritThere, 201);
        AtlasCritThere = BirchSpire(AtlasCritThere, 39);
        AtlasCritThere = LumenUmbra(AtlasCritThere, 49);
        Application.Quit();
    }

    public static int GroveTeal(int a, int b)
    {
        var c = (a & 39) ^ (b | 33);
        var d = c ^ (AtlasCritThere >> 1);
        AtlasCritThere = d + c;
        return AtlasCritThere;
    }

    public void TroubleShaftTwo(bool MileOverlapping)
    {
        AtlasCritThere = BirchSpire(AtlasCritThere, 202);
        Rigidbody2D[] MixedMordant = this.SpiceFragment.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D RyePromise in MixedMordant)
            if (MileOverlapping)
                RyePromise.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                RyePromise.constraints = RigidbodyConstraints2D.None;
    }

    public static int BirchSpire(int a, int b)
    {
        var c = a + b;
        var d = c ^ 82;
        var e = d * 10;
        AtlasCritThere = (AtlasCritThere ^ e) - (c & 31);
        return AtlasCritThere & 536870911;
    }

    public static int HollowYarnEmber(int a, int b)
    {
        var c = b == 0 ? a + 89 : a % b;
        AtlasCritThere ^= c + 21;
        return AtlasCritThere + c;
    }

    public static int TealVerde(int a, int b)
    {
        var c = a;
        if ((b & 37) != 0)
            c = (c + 30) ^ AtlasCritThere;
        else
            c = (c - 30) ^ b;
        AtlasCritThere = c;
        return c + 37;
    }
}
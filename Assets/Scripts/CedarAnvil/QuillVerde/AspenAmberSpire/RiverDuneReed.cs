using UnityEngine;
using UnityEngine.UI;

public class EssayLava : MonoBehaviour
{
    private void Awake()
    {
        LostDecadeShader.PastureBrigPellet = LostDecadeShader.CloverRowanSable(LostDecadeShader.PastureBrigPellet, 164);
        LostDecadeShader.PastureBrigPellet = LostDecadeShader.CliffClover(LostDecadeShader.PastureBrigPellet, 159);
        TurretTurret();
    }

    private void Start()
    {
        LostDecadeShader.PastureBrigPellet = LostDecadeShader.TideGableJade(LostDecadeShader.PastureBrigPellet, 204);
        LostDecadeShader.PastureBrigPellet = LostDecadeShader.MicaAnvil(LostDecadeShader.PastureBrigPellet, 246);
        LostDecadeShader.PastureBrigPellet = LostDecadeShader.TideGableJade(LostDecadeShader.PastureBrigPellet, 30);
        SundialToolbar();
    }

    private void SundialToolbar()
    {
        LostDecadeShader.PastureBrigPellet = LostDecadeShader.MicaAnvil(LostDecadeShader.PastureBrigPellet, 111);
        LostDecadeShader.PastureBrigPellet = LostDecadeShader.CliffClover(LostDecadeShader.PastureBrigPellet, 249);
        LostDecadeShader.PastureBrigPellet = LostDecadeShader.RiverVerde(LostDecadeShader.PastureBrigPellet, 229);
        ScabbardJuryPet PunchDive = GetComponentInParent<ScabbardJuryPet>(true);
        HardlightSweeper.DefenceTribute.onClick.AddListener(() => CrimsonPrize.SustainStorm.GlancePlaza(CrimsonPrize.SustainStorm.BrambleMire(PunchDive)));
    }

    private void TurretTurret()
    {
        LostDecadeShader.PastureBrigPellet = LostDecadeShader.RiverVerde(LostDecadeShader.PastureBrigPellet, 156);
        HardlightSweeper.DefenceTribute = GetComponent<Button>();
    }

    public CraftJumpdriveTwenty HardlightSweeper = new CraftJumpdriveTwenty();
}
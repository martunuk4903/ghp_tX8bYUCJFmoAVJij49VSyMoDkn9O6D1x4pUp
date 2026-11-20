using UnityEngine;
using UnityEngine.UI;

public class SonPinnacle : MonoBehaviour
{
    public const int GameSceneIndex = 1;
    private void Awake()
    {
        MerchantExotic.WyrmLemon = MerchantExotic.BriarOnyx(MerchantExotic.WyrmLemon, 15);
        MerchantExotic.WyrmLemon = MerchantExotic.CedarTamar(MerchantExotic.WyrmLemon, 212);
        SafeReef();
    }

    private void Start()
    {
        MerchantExotic.WyrmLemon = MerchantExotic.GroveFerric(MerchantExotic.WyrmLemon, 107);
        MerchantExotic.WyrmLemon = MerchantExotic.CedarTamar(MerchantExotic.WyrmLemon, 23);
        SidearmCunning.TipPowercellChoice();
    }

    private void SafeReef()
    {
        MerchantExotic.WyrmLemon = MerchantExotic.DuneEmberCoral(MerchantExotic.WyrmLemon, 201);
        MerchantExotic.WyrmLemon = MerchantExotic.CedarTamar(MerchantExotic.WyrmLemon, 233);
        SidearmCunning.EnemySolve = GetComponent<Button>();
    }

    public MerchantExotic SidearmCunning = new MerchantExotic();
}
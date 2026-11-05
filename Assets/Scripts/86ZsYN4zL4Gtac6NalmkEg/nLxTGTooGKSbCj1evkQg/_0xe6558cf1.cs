using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static _0xec7175f7;

public class _0xe6558cf1 : MonoBehaviour
{
    [HideInInspector]
    public List<_0x7ae79f64> MoneyCountContainers = new();
    public void _0x003447bd()
    {
        this._0x96e69a76(SceneManager.GetActiveScene().buildIndex);
    }

    private static void MakeGrid(List<RectTransform> _0x8bb5db0f, AspectRatioFitter _0x3b3bb293, float _0x7df6e40d, int _0x7df7d70b, int _0x27f25ce5)
    {
        _0x3b3bb293.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        _0x3b3bb293.aspectRatio = _0x7df6e40d;
        foreach (RectTransform _0x1b9e379b in _0x8bb5db0f)
        {
            int _0xe14a889d = _0x1b9e379b.transform.GetSiblingIndex();
            _0x1b9e379b.anchorMin = new Vector3(Mathf.FloorToInt((float)_0xe14a889d % _0x7df7d70b) * (1f / _0x7df7d70b), (_0x27f25ce5 - (Mathf.FloorToInt((float)_0xe14a889d / _0x7df7d70b) % _0x27f25ce5 + 1f)) * (1f / _0x27f25ce5));
            _0x1b9e379b.anchorMax = new Vector3(Mathf.FloorToInt((float)_0xe14a889d % _0x7df7d70b + 1f) * (1f / _0x7df7d70b), (_0x27f25ce5 - Mathf.FloorToInt((float)_0xe14a889d / _0x7df7d70b) % _0x27f25ce5) * (1f / _0x27f25ce5));
            _0x1b9e379b.offsetMin = Vector2.zero;
            _0x1b9e379b.offsetMax = Vector2.zero;
        }
    }

    private void Start()
    {
        if (this._0x0101eb58 != _0x8c4ad123.SCENE_0)
            Screen.orientation = ScreenOrientation.Portrait;
        this.DeleteProgressDataButton?.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
            //AudioController.Instance.UpdateMusics();
            //AudioController.Instance.UpdateSfxes();
            Instance._0x96e69a76(_0x8c4ad123.SCENE_0);
        });
        this.ShowResetTutorialButton?.onClick.AddListener(() =>
        {
            _0x20cea244._0x20d7715f = false;
            _0x4751f1e9.Instance._0xa8d05a2a();
            _0x3cddbc40.Instance._0x595a3d0b(_0xd6f8c568.TUTORIAL0);
        });
    }

    private IEnumerator _0x4978dc63(int _0x065c45e4)
    {
        _0x3cddbc40.Instance._0x595a3d0b(_0xd6f8c568.SPLASH);
        AsyncOperation _0x17f9bd06 = SceneManager.LoadSceneAsync(_0x065c45e4);
        while (!_0x17f9bd06.isDone)
            yield return null;
    }

    public Transform Environment;
    public Button DeleteProgressDataButton;
    public static bool IsAfterLevelFailed = false;
    private IEnumerator _0xb7fc2bbd(string _0xd070db0f)
    {
        _0x3cddbc40.Instance._0x595a3d0b(_0xd6f8c568.SPLASH);
        //AudioController.Instance.SaveLastMusicTimes();
        AsyncOperation _0x8c6323a1 = SceneManager.LoadSceneAsync(_0xd070db0f);
        while (!_0x8c6323a1.isDone)
            yield return null;
    }

    private static _0x579dc554 _0xdb76ce78 => _0x579dc554.ALL_SCENES_SETTING_SINGLETONS[0];

    public static bool IsAfterLevelComplete;
    [HideInInspector]
    public GameObject RootGameObject; // tag - "Root"
    private void _0x2bc7b07e(Transform _0x0bd60547)
    {
        Transform[] _0x48ddcc60 = _0x0bd60547.GetComponentsInChildren<Transform>();
        foreach (Transform _0x83dc9a58 in _0x48ddcc60)
            if (_0x83dc9a58 != null && DOTween.IsTweening(_0x83dc9a58))
            {
                if (this._0x04b70943)
                    DOTween.Play(_0x83dc9a58);
                else
                    DOTween.Pause(_0x83dc9a58);
            }
    }

    private static void ExitGame()
    {
        Application.Quit();
    }

    private void _0xc5b75082(bool _0xbfe62c65)
    {
        Rigidbody2D[] _0xbf47e18f = this.RootGameObject.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D _0xf692c4df in _0xbf47e18f)
            if (_0xbfe62c65)
                _0xf692c4df.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                _0xf692c4df.constraints = RigidbodyConstraints2D.None;
    }

    public static _0x579dc554 _0x20cea244 => _0x579dc554.ALL_SCENES_SETTING_SINGLETONS[Instance._0x0101eb58];

    public void _0x96e69a76(int _0x62b4f854)
    {
        //if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
        //    AdsInitializer.Instance?.ShowAd();
        this.StartCoroutine(this._0x4978dc63(_0x62b4f854));
    }

    private static _0x579dc554 GAME_INDEX_SETTINGS(int _0x75291000)
    {
        return _0x579dc554.ALL_SCENES_SETTING_SINGLETONS[_0x75291000];
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xe6558cf1>();
        this.RootGameObject = GameObject.FindWithTag(_0x04acdcae._0x6cc3b977(new byte[4] { 196, 249, 249, 226 }, 150));
        if (this._0x0101eb58 == _0x8c4ad123.SCENE_0)
            this._0x9833778c(true);
        else
            this._0x9833778c(false);
        this.MoneyCountContainers = this.RootGameObject.GetComponentsInChildren<_0x7ae79f64>(true).ToList();
    }

    public Transform EnvironmentWithTweensToToggle;
    public void _0x9833778c(bool _0x15ed616a)
    {
        this._0x04b70943 = _0x15ed616a;
        this._0xc5b75082(!this._0x04b70943);
        Physics2D.simulationMode = this._0x04b70943 ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
        if (this.EnvironmentWithTweensToToggle != null)
            this._0x2bc7b07e(this.EnvironmentWithTweensToToggle);
    }

    public Button ShowResetTutorialButton;
    public int _0x0101eb58 => SceneManager.GetActiveScene().buildIndex;
    public bool _0x04b70943 { get; private set; }

    public void _0x085398ea()
    {
        _0x20cea244._0x20d7715f = true;
    }

    public static _0xe6558cf1 Instance;
    public Canvas MainCanvas;
    public void _0x6813dc9b()
    {
        foreach (_0x7ae79f64 _0x3ea2fe4e in this.MoneyCountContainers)
            _0x3ea2fe4e._0xe38ff736();
    }

    private void _0xfead3681()
    {
        IsAfterLevelComplete = true;
        Instance._0x96e69a76(_0x8c4ad123.SCENE_0);
    }
}

internal static class _0x04acdcae
{
    internal static string _0x6cc3b977(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}
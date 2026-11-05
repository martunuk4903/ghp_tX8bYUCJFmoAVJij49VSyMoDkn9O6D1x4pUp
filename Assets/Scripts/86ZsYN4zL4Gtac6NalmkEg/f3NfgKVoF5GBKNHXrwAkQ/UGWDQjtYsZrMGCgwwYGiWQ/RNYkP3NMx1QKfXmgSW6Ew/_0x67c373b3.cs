using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x67c373b3 : MonoBehaviour
{
    public void _0xf85e67c2()
    {
        this._0xc026e290?.Play();
    }

    private static bool _0x53cc091a = false;
    public static _0x67c373b3 Instance;
    public GameObject Content;
    private Sequence _0xc026e290;
    public GameObject Background;
    public Slider AnimationSlider;
    private void _0xb60693c2()
    {
        this.AnimationSlider.value = 0.2f;
        _0x53cc091a = !_0x53cc091a;
        this._0xc026e290 = DOTween.Sequence().SetLink(this.AnimationSlider.gameObject).Append(DOTween.To(() => this.AnimationSlider.value, _0x2777fe04 => this.AnimationSlider.value = _0x2777fe04, 1f, this.FirstAnimationTime).SetLink(this.AnimationSlider.gameObject)).SetEase(Ease.Flash).OnComplete(() =>
        {
            _0x856c1bff._0xd7c38244?._0x89ea93bb();
        });
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x67c373b3>();
    }

    public float FirstAnimationTime = 10.0f;
    public void _0xa6293701()
    {
        this._0xc026e290?.Kill();
        this.AnimationSlider.value = _0x53cc091a ? this.SecondPassSliderValue : 0.05f;
    }

    public GameObject Error;
    public void _0xa117d7ea()
    {
        this._0xc026e290?.Pause();
    }

    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == _0xec7175f7._0x8c4ad123.SCENE_0 && !_0x53cc091a)
        {
            this._0xb60693c2();
        }
        else
        {
            this._0x5d82bebc();
        }
    }

    public void _0x59f8a8d7()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[Test] Animate Force");
            }
#endif
        }

        this._0xc026e290?.Kill();
        if (AnimationSlider != null)
            this.AnimationSlider.value = 1f;
        _0x53cc091a = false;
    }

    public void _0x5d82bebc()
    {
        this._0xa6293701();
        bool _0xe82efc46 = _0x53cc091a;
        this._0xc026e290 = DOTween.Sequence().SetLink(this.AnimationSlider.gameObject).Append(DOTween.To(() => this.AnimationSlider.value, _0x2777fe04 => this.AnimationSlider.value = _0x2777fe04, _0xe82efc46 ? 1f : this.SecondPassSliderValue, this.DefaultAnimationTime).SetLink(this.AnimationSlider.gameObject)).SetEase(Ease.Linear);
        _0x53cc091a = !_0x53cc091a;
    }

    public float DefaultAnimationTime = 0.4f;
    public float SecondPassSliderValue = 0.5f;
}
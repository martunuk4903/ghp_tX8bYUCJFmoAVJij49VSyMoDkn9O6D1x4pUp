using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x42700195 : MonoBehaviour
{
    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0xc36201a5();
    }

    public GameObject Content;
    public void Show()
    {
        this.Content.SetActive(true);
        if ((DOTween.TweensByTarget(this.Content.transform)?.Count ?? 0) > 0)
            DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(1f, this.scaleDuration).SetLink(this.Content).SetEase(this.ease).OnComplete(() =>
            {
            });
        else
            this.Content.transform.DOScale(1f, this.scaleDuration).SetLink(this.Content).SetEase(this.ease).OnComplete(() =>
            {
            });
    }

    public TMP_Text ContentMainText;
    public TMP_Text ContentHeaderText;
    public static void HideAllPops()
    {
        _0x4751f1e9.Instance._0xa8d05a2a();
    }

    public bool IsScaledDownOnAwake = true;
    public void _0x4fcf813b()
    {
        if (this.Content.gameObject.activeSelf)
        {
            DOTween.Kill(this.Content.transform, true);
            if (this.IsOnlyYScale)
                this.Content.transform.DOScaleY(0f, this.scaleDuration).SetLink(this.Content).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
            else
                this.Content.transform.DOScale(0f, this.scaleDuration).SetLink(this.Content).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
        }
    }

    private bool _0x9192a0a9 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public Ease ease = Ease.OutSine;
    public bool IsOnlyYScale;
    public TMP_Text ContentAdditionalText;
    private void Start()
    {
    // Content.SetActive(false);
    }

    public float scaleDuration = 0.4f;
    public Image ContentImage;
    private void _0xc36201a5()
    {
        DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(0f, 0.01f).SetLink(this.Content);
        else
            this.Content.transform.DOScale(0f, 0.01f).SetLink(this.Content);
        this.Content.SetActive(false);
    }
}
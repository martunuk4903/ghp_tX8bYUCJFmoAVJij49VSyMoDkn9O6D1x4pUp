using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xd75e45b3 : MonoBehaviour
{
    public TMP_Text HeaderText;
    public Ease Ease = Ease.OutSine;
    public void _0x28b3416d()
    {
        this._0x012c339a();
        this.Content.SetActive(true);
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.localScale = Vector3.one;
        _0x3cddbc40.Instance._0x2da3e6ed(_0x3cddbc40.Instance.CurrentPanelIndex);
    }

    public TMP_Text MainText;
    private void _0x012c339a()
    {
        if (this.OuterBackground != null)
        {
            Image _0xf38a741a = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xf38a741a, true);
            _0xf38a741a.DOFade(1f, 0f).SetLink(this.OuterBackground);
        }
    }

    private void _0xecb13667()
    {
        if (this.OuterBackground != null)
        {
            Image _0x750115fd = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x750115fd, true);
            _0x750115fd.DOFade(0f, 0.01f).SetLink(this.OuterBackground);
        }

        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, 0.01f).SetLink(this.Content);
    }

    public GameObject Content;
    public bool IsScaledDownOnAwake = true;
    private bool _0x31978188 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public GameObject OuterBackground;
    public void _0xc081ac40()
    {
        this._0x922c4c55();
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, this.ScaleDuration).SetLink(this.Content).SetEase(this.Ease).OnComplete(() =>
        {
            this.Content.SetActive(false);
        });
    }

    private void _0x922c4c55()
    {
        if (this.OuterBackground != null)
        {
            Image _0x9a50853c = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x9a50853c, true);
            _0x9a50853c.DOFade(0f, this.ScaleDuration).SetLink(this.OuterBackground);
        }
    }

    private void _0x7ec0b274()
    {
        if (this.OuterBackground != null)
        {
            Image _0x1d6f998a = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x1d6f998a, true);
            _0x1d6f998a.DOFade(1f, this.ScaleDuration / 2f).SetLink(this.OuterBackground);
        }
    }

    public float ScaleDuration = 0.4f;
    public void Show()
    {
        this._0x7ec0b274();
        if (this.Content != null)
        {
            DOTween.Kill(this.Content.transform, true);
            this.Content.SetActive(true);
            this.Content.transform.DOScale(1f, this.ScaleDuration).SetLink(this.Content).SetEase(this.Ease).OnComplete(() =>
            {
                _0x3cddbc40.Instance._0x2da3e6ed(_0x3cddbc40.Instance.CurrentPanelIndex);
            });
        }
    }

    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.OuterBackground != null)
            this.OuterBackground.gameObject.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0xecb13667();
    }
}
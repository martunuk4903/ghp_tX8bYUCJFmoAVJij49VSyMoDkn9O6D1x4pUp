using DG.Tweening;
using UnityEngine;

/// <summary>
/// The climber: which trail it is on, the hop between them, and the stumble after a vent.
/// Nothing drives a body here - the position is set by a tween and by the director, which is
/// the only mover this object has.
/// sprite_1 is drawn facing RIGHT, and the climber always faces up-trail, so it is never
/// flipped on X (C.8).
/// </summary>
public sealed class _0x0c255a4d : MonoBehaviour
{
    public int _0xa0a4e14e { get; private set; }

    /// <summary>A vent hit: the climber tilts and input is ignored for StumbleSeconds.</summary>
    public void _0xe70eadbf()
    {
        if (!this._0x46dbf96a)
            return;
        this._0xd1c2f426 = _0x5681a043.StumbleSeconds;
        this.transform.DOLocalRotate(new Vector3(0f, 0f, 14f), _0x5681a043.StumbleSeconds * 0.5f).SetLoops(2, LoopType.Yoyo).SetLink(this.gameObject);
    }

    /// <summary>One hop per tap, queued at most one deep; a stumbling climber ignores input.</summary>
    public bool _0x3ce77930(int _0x691c7a19)
    {
        if (!this._0x46dbf96a || this._0xe130e718)
            return false;
        int _0x1a7fa032 = Mathf.Clamp(this._0xa0a4e14e + _0x691c7a19, 0, _0x5681a043.LaneCount - 1);
        if (_0x1a7fa032 == this._0xa0a4e14e)
            return false;
        this._0xa0a4e14e = _0x1a7fa032;
        DOTween.Kill(this.transform, true);
        this.transform.DOLocalMoveX(this._0xb9be0a3f[_0x1a7fa032], this._0x0fc7d31a).SetEase(Ease.OutQuad).SetLink(this.gameObject);
        this.transform.DOLocalRotate(new Vector3(0f, 0f, _0x691c7a19 < 0 ? 6f : -6f), this._0x0fc7d31a * 0.5f).SetLoops(2, LoopType.Yoyo).SetLink(this.gameObject);
        return true;
    }

    public void _0x8a42bdac()
    {
        if (this._body != null)
        {
            DOTween.Kill(this._body.transform, true);
            this._body.transform.localPosition = Vector3.zero;
        }
    }

    public bool _0xe130e718 => this._0xd1c2f426 > 0f;

    [SerializeField]
    private SpriteRenderer _body;
    private void OnDestroy()
    {
        DOTween.Kill(this.transform);
        if (this._body != null)
            DOTween.Kill(this._body.transform);
    }

    private float _0xd1c2f426;
    private float[] _0xb9be0a3f;
    public void _0xc5442610(float[] _0x229e3a03, float _0xe2c47ce3, float height, int _0x7f9c283a)
    {
        if (this._0x46dbf96a)
            return;
        this._0x46dbf96a = true;
        this._0xb9be0a3f = _0x229e3a03;
        this._0xa0a4e14e = Mathf.Clamp(_0x7f9c283a, 0, _0x5681a043.LaneCount - 1);
        if (this._body == null)
            this._body = this.GetComponent<SpriteRenderer>();
        if (this._body != null)
        {
            this._body.size = new Vector2(height, height);
            this._body.sortingOrder = _0x5681a043.OrderClimber;
            this._body.flipX = false;
        }

        this.transform.localScale = Vector3.one;
        this.transform.localPosition = new Vector3(this._0xb9be0a3f[this._0xa0a4e14e], _0xe2c47ce3, 0f);
    }

    private float _0x0fc7d31a = _0x5681a043.HopSeconds;
    public void _0x25393f02(float dt)
    {
        if (this._0xd1c2f426 > 0f)
            this._0xd1c2f426 -= dt;
    }

    private bool _0x46dbf96a;
    public void _0xd946c6ab(Color _0x42da32d5)
    {
        if (this._body != null)
            this._body.color = _0x42da32d5;
    }

    /// <summary>A slow idle bob while the run is still in its ready state.</summary>
    public void _0x9bb48067(float _0x4de72ce7)
    {
        if (this._body == null)
            return;
        this._body.transform.DOLocalMoveY(_0x4de72ce7, 0.9f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine).SetLink(this._body.gameObject);
    }
}
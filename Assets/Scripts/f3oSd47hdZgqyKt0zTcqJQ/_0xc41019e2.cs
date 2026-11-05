using DG.Tweening;
using UnityEngine;

/// <summary>
/// One row of the trail: a basalt tile under each of the three lanes, plus the three possible
/// pickups per lane created once and switched on and off. Nothing is instantiated or
/// destroyed while a run is going, so the climb never allocates.
/// </summary>
public sealed class _0xc41019e2 : MonoBehaviour
{
    private readonly SpriteRenderer[] _0x1862c447 = new SpriteRenderer[_0x5681a043.LaneCount];
    public void _0x496df227(Color _0xfb0ee5da)
    {
        for (int _0xf93c1666 = 0; _0xf93c1666 < _0x5681a043.LaneCount; _0xf93c1666++)
            if (this._0x1862c447[_0xf93c1666] != null)
                this._0x1862c447[_0xf93c1666].color = _0xfb0ee5da;
    }

    private readonly SpriteRenderer[] _0x64d0b097 = new SpriteRenderer[_0x5681a043.LaneCount];
    /// <summary>Takes the cell away once it has been collected, so it cannot be collected twice.</summary>
    public void _0xc6717b64(int _0x76f8d8e4)
    {
        int _0xe7561b18 = this._0xfd4b36ca[_0x76f8d8e4];
        this._0xfd4b36ca[_0x76f8d8e4] = _0x5681a043.CellEmpty;
        SpriteRenderer _0x853a8b4b = _0xe7561b18 == _0x5681a043.CellCoin ? this._0x64d0b097[_0x76f8d8e4] : (_0xe7561b18 == _0x5681a043.CellCore ? this._0x86e33897[_0x76f8d8e4] : null);
        if (_0x853a8b4b == null)
            return;
        Transform _0x3f5238dd = _0x853a8b4b.transform;
        DOTween.Kill(_0x3f5238dd, true);
        _0x3f5238dd.DOLocalMoveY(_0x3f5238dd.localPosition.y + 0.35f, 0.25f).SetLink(_0x853a8b4b.gameObject);
        _0x853a8b4b.DOFade(0f, 0.25f).OnComplete(() => this._0xeaccd345(_0x853a8b4b)).SetLink(_0x853a8b4b.gameObject);
    }

    /// <summary>Re-dresses the row for a new set of cells and clears the resolved flag.</summary>
    public void _0x3f2f3355(int[] _0xacb8f00c)
    {
        this._0x176001b1 = false;
        for (int _0xf144b516 = 0; _0xf144b516 < _0x5681a043.LaneCount; _0xf144b516++)
        {
            int _0x5354b925 = _0xacb8f00c[_0xf144b516];
            this._0xfd4b36ca[_0xf144b516] = _0x5354b925;
            this.Show(this._0x64d0b097[_0xf144b516], _0x5354b925 == _0x5681a043.CellCoin);
            this.Show(this._0x86e33897[_0xf144b516], _0x5354b925 == _0x5681a043.CellCore);
            this.Show(this._0x19268b3d[_0xf144b516], _0x5354b925 == _0x5681a043.CellVent);
        }
    }

    public bool _0x176001b1 { get; set; }

    private void OnDestroy()
    {
        for (int _0x1d95b9b5 = 0; _0x1d95b9b5 < _0x5681a043.LaneCount; _0x1d95b9b5++)
        {
            if (this._0x64d0b097[_0x1d95b9b5] != null)
                DOTween.Kill(this._0x64d0b097[_0x1d95b9b5]);
            if (this._0x86e33897[_0x1d95b9b5] != null)
                DOTween.Kill(this._0x86e33897[_0x1d95b9b5]);
        }
    }

    private readonly int[] _0xfd4b36ca = new int[_0x5681a043.LaneCount];
    private readonly SpriteRenderer[] _0x86e33897 = new SpriteRenderer[_0x5681a043.LaneCount];
    private readonly SpriteRenderer[] _0x19268b3d = new SpriteRenderer[_0x5681a043.LaneCount];
    private void _0xeaccd345(SpriteRenderer _0xac47366e)
    {
        if (_0xac47366e != null)
            _0xac47366e.gameObject.SetActive(false);
    }

    public void _0xe8827b98(int _0xb5748609, SpriteRenderer _0x7a88547d, SpriteRenderer _0x2678c3b1, SpriteRenderer _0xc2c6dba6, SpriteRenderer _0x67d17f00)
    {
        this._0x1862c447[_0xb5748609] = _0x7a88547d;
        this._0x64d0b097[_0xb5748609] = _0x2678c3b1;
        this._0x86e33897[_0xb5748609] = _0xc2c6dba6;
        this._0x19268b3d[_0xb5748609] = _0x67d17f00;
    }

    private void Show(SpriteRenderer _0xced8c4bd, bool _0x30b1dc2f)
    {
        if (_0xced8c4bd == null)
            return;
        Transform _0xc6464078 = _0xced8c4bd.transform;
        DOTween.Kill(_0xc6464078, true);
        DOTween.Kill(_0xced8c4bd, true);
        _0xc6464078.localPosition = new Vector3(_0xc6464078.localPosition.x, 0f, 0f);
        Color _0xb5e3fc78 = _0xced8c4bd.color;
        _0xced8c4bd.color = new Color(_0xb5e3fc78.r, _0xb5e3fc78.g, _0xb5e3fc78.b, 1f);
        _0xced8c4bd.gameObject.SetActive(_0x30b1dc2f);
    }

    public int _0xd220af63(int _0xa4aadb52)
    {
        return this._0xfd4b36ca[_0xa4aadb52];
    }
}
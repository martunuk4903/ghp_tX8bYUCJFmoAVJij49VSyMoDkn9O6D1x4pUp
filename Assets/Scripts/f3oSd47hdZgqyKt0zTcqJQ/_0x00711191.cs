using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

/// <summary>
/// The climb. Rows scroll down past a fixed climber; the only clock is the heat shield, and
/// the only thing that refills it is an ember core, so the C.5 baseline is one division:
/// 100 / 1.25 = 80 s in TRAIL and 100 / 1.55 = 64.5 s in CHALLENGE, with zero taps and zero
/// pickups. A vent plume breaks the chain and makes the climber stumble - it never touches
/// the shield, which is what keeps that baseline true on every stage, stage 8 included.
///
/// Every size here is derived from the scene camera (C.0); nothing is eyeballed, and every
/// sprite sorts inside the -19..-1 corridor through the named constants in TrailConfig.
/// Nothing drives a body: all motion is script and tween kinematics.
/// </summary>
public sealed class _0x00711191 : MonoBehaviour
{
    private int _0xa49694a0 = 1;
    private float _0x8e3c9fb1;
    private int _0xffeac13a;
    public void _0x5275085d()
    {
        if (this._0xb48553f3 != StateRunning)
            return;
        this._0xb48553f3 = StateHeld;
        if (this._0xe68a8aec != null)
            this._0xe68a8aec._0x5ad68b08(this._0xf9f8a9f2, this._0x12c59363, this._0xaf289931, this._0x888b5a45 / _0x5681a043.ShieldMax);
        if (_0x4751f1e9.Instance != null)
            _0x4751f1e9.Instance._0xf4b7ab90(_0xec7175f7._0x5d5037c6.PAUSE);
    }

    private int _0xc220a3ee;
    private float _0x6980437e;
    private const int StateHeld = 4;
    public void _0x31c29b33()
    {
        if (_0xe6558cf1.Instance != null)
            _0xe6558cf1.Instance._0x96e69a76(_0xec7175f7._0x8c4ad123.SCENE_0);
    }

    private int _0xd026b1d0 = 1;
    private void OnDestroy()
    {
        for (int _0x2c701883 = 0; _0x2c701883 < this._0xbaa768db.Count; _0x2c701883++)
            if (this._0xbaa768db[_0x2c701883] != null)
                DOTween.Kill(this._0xbaa768db[_0x2c701883]);
        DOTween.Kill(this.gameObject);
    }

    private void Start()
    {
        Camera _0x3ede90b3 = Camera.main;
        if (_0x3ede90b3 == null)
            return;
        this._0xf2ff4853 = _0x49c993d5._0x66e15572;
        this._0xf9f8a9f2 = _0x49c993d5._0x7566d207;
        this._0xaf289931 = _0x46df03e4.Quota(this._0xf9f8a9f2, this._0xf2ff4853);
        // Every length on screen comes out of the camera, not out of a constant.
        this._0xdce3b73b = _0x3ede90b3.orthographicSize;
        this._0xf266757a = this._0xdce3b73b * _0x3ede90b3.aspect;
        float _0xb9626add = 2f * this._0xf266757a * 0.78f;
        this._0x8e3c9fb1 = _0xb9626add / _0x5681a043.LaneCount;
        for (int _0x8acbcc7e = 0; _0x8acbcc7e < _0x5681a043.LaneCount; _0x8acbcc7e++)
            this._0xcc19a979[_0x8acbcc7e] = -this._0x8e3c9fb1 + _0x8acbcc7e * this._0x8e3c9fb1;
        this._0xae8ec106 = this._0xdce3b73b * 0.29f;
        this._0x6980437e = -this._0xdce3b73b * 0.52f;
        this._0xb2a2c564 = new GameObject(_0x9ddae1e7._0x5867f869(new byte[10] { 54, 48, 35, 43, 46, 21, 45, 48, 46, 38 }, 66)).transform;
        this._0xb2a2c564.SetParent(this.transform, false);
        this._0xecd022eb();
        this._0x3e010972 = new _0x5eb97a95()._0x3d1957c4(this._0xf9f8a9f2, this._0xf2ff4853, _0x49c993d5._0x472a9861);
        int _0x91576ee2 = Mathf.CeilToInt(2f * this._0xdce3b73b / this._0xae8ec106) + 3;
        this._0xb25e808f = this.gameObject.AddComponent<_0xf2ea55f5>();
        this._0xb25e808f._0xd6197845(this._0xb2a2c564, _0x91576ee2, this._0xcc19a979, this._0x8e3c9fb1, this._tilePrefab, this._coinPrefab, this._corePrefab, this._plumePrefab);
        this._0x0b3c28c9 = Instantiate(this._climberPrefab, this._0xb2a2c564);
        this._0x0b3c28c9._0xc5442610(this._0xcc19a979, this._0x6980437e, this._0x8e3c9fb1 * 0.79f, 1);
        this._0x0b3c28c9._0x9bb48067(0.08f);
        this._0xb88d13c8();
        this._0x3f6e56ef();
    }

    private float _0xf266757a;
    [SerializeField]
    private _0x0c255a4d _climberPrefab;
    private void _0x570be7a0()
    {
        if (this._0xb48553f3 != StateRunning)
            return;
        this._0xb48553f3 = StateCooled;
        if (this._0x0b3c28c9 != null)
            this._0x0b3c28c9._0xd946c6ab(_0x82ba3493.Fade(_0x82ba3493.TextMuted, 0.8f));
        IList<_0xc41019e2> _0x521f627e = this._0xb25e808f._0xe83bdefc;
        for (int _0xf9569e71 = 0; _0xf9569e71 < _0x521f627e.Count; _0xf9569e71++)
            _0x521f627e[_0xf9569e71]._0x496df227(_0x82ba3493.Fade(_0x82ba3493.TextMuted, 0.65f));
        _0x49c993d5._0xaff2bc43 = _0x49c993d5._0xaff2bc43 + 1;
        if (this._0x12c59363 > _0x49c993d5._0x924ddf27)
            _0x49c993d5._0x924ddf27 = this._0x12c59363;
        if (this._0xa49694a0 > _0x49c993d5._0xd231b447)
            _0x49c993d5._0xd231b447 = this._0xa49694a0;
        int _0x1a0457c3 = this._0x7e60ac6c(false);
        this._0x993e0047();
        if (this._0xe68a8aec != null)
            this._0xe68a8aec._0x0db9f5d7(this._0x12c59363, this._0xaf289931, _0x1a0457c3);
        DOVirtual.DelayedCall(_0x5681a043.PopDelaySeconds, () => this._0xa2d6ccda()).SetLink(this.gameObject);
    }

    private const int StateCooled = 3;
    private float _0x99e48970 = _0x5681a043.ReadySeconds;
    private _0xf2ea55f5 _0xb25e808f;
    /// <summary>A tap on the left or right half of the screen, one hop deep.</summary>
    public void _0x0d1b3369(int _0x12683fc9)
    {
        if (this._0xb48553f3 != StateRunning || this._0x0b3c28c9 == null)
            return;
        if (this._0x0b3c28c9._0x3ce77930(_0x12683fc9) && _0x49c993d5._0xa7ffe30d)
            Handheld.Vibrate();
    }

    private bool _0xbaa7600d;
    private float _0xdce3b73b;
    private int _0xb48553f3 = StateReady;
    private const int StateSummit = 2;
    private float _0x888b5a45 = _0x5681a043.ShieldMax;
    /// <summary>
    /// Drops the chain back to x1. A vent also flashes the screen edge, because that one the
    /// player has to be told about; a plain miss only moves the badge.
    /// </summary>
    private void _0x79eefe53(bool _0xbffd242d)
    {
        bool _0x94f85ddd = this._0xd026b1d0 > 1;
        this._0xc220a3ee = 0;
        this._0xe6510821 = 0f;
        this._0xd026b1d0 = 1;
        if (this._0x9ac45a8d == null)
            return;
        if (_0x94f85ddd || _0xbffd242d)
            this._0x9ac45a8d._0xf7ccbdc7(1, _0xbffd242d);
        if (_0xbffd242d)
            this._0x9ac45a8d._0x723a23c4();
    }

    /// <summary>Shards are cosmetic currency only: they unlock trail skins and badges.</summary>
    private int _0x7e60ac6c(bool _0x0c0c6b98)
    {
        int _0xf95ad762 = this._0x12c59363 / 10 + (_0x0c0c6b98 ? 3 : 0);
        if (this._0xf2ff4853)
            _0xf95ad762 *= 2;
        _0x49c993d5._0xf5f133cb = _0x49c993d5._0xf5f133cb + _0xf95ad762;
        return _0xf95ad762;
    }

    private void _0xc2076540()
    {
        if (_0x4751f1e9.Instance != null)
            _0x4751f1e9.Instance._0xf4b7ab90(_0xec7175f7._0x5d5037c6.WIN);
    }

    private void Update()
    {
        float dt = Time.deltaTime;
        if (this._0xb48553f3 == StateReady)
        {
            // Hold until the template has brought the game panel up and the ready beat is over.
            _0x3cddbc40 _0x6d2b4378 = _0x3cddbc40.Instance;
            bool _0x795c432e = _0x6d2b4378 != null && _0x6d2b4378.CurrentPanelIndex == _0xec7175f7._0xd6f8c568.DEFAULT;
            if (_0x795c432e)
                this._0x99e48970 -= dt;
            if (this._0x99e48970 <= 0f)
            {
                this._0xb48553f3 = StateRunning;
                if (this._0x0b3c28c9 != null)
                    this._0x0b3c28c9._0x8a42bdac();
            }

            return;
        }

        if (this._0xb48553f3 != StateRunning)
            return;
        this._0x7772ac48 += dt;
        if (this._0x0b3c28c9 != null)
            this._0x0b3c28c9._0x25393f02(dt);
        if (!this._0xbaa7600d)
        {
            this._0xa5388087 -= dt;
            if (this._0xa5388087 <= 0f)
            {
                this._0xbaa7600d = true;
                if (this._0x9ac45a8d != null)
                    this._0x9ac45a8d._0x32bd0b51();
            }
        }

        this._0xeb2c67ba(dt);
        this._0x4395e3f2(dt);
        if (this._0xd026b1d0 >= 3)
        {
            this._0xe6510821 += dt;
            if (this._0xe6510821 > this._0xcf321609)
                this._0xcf321609 = this._0xe6510821;
        }
    }

    private _0x5eb97a95 _0x3e010972;
    private void _0xecd022eb()
    {
        if (this._railPrefab == null)
            return;
        float _0xc03ce38f = this._0x8e3c9fb1 * 0.18f;
        float _0xb220f7d1 = 2f * this._0xdce3b73b;
        for (int _0x0bd24e78 = 0; _0x0bd24e78 <= _0x5681a043.LaneCount; _0x0bd24e78++)
        {
            float _0x5ed36860 = this._0xcc19a979[0] - this._0x8e3c9fb1 * 0.5f + _0x0bd24e78 * this._0x8e3c9fb1;
            SpriteRenderer _0x6b86249f = Instantiate(this._railPrefab, this._0xb2a2c564);
            _0x6b86249f.transform.localPosition = new Vector3(_0x5ed36860, 0f, 0f);
            _0x6b86249f.transform.localScale = Vector3.one;
            _0x6b86249f.size = new Vector2(_0xc03ce38f, _0xb220f7d1);
            _0x6b86249f.sortingOrder = _0x5681a043.OrderRail;
            _0x6b86249f.color = _0x82ba3493.Fade(Color.white, 0.85f);
            this._0xbaa768db.Add(_0x6b86249f);
        }
    }

    public void _0x60fd8665()
    {
        _0x49c993d5._0x472a9861 = _0x49c993d5._0x472a9861 + 1;
        if (_0xe6558cf1.Instance != null)
            _0xe6558cf1.Instance._0x96e69a76(_0xec7175f7._0x8c4ad123.SCENE_1);
    }

    private void _0x3181d0d9()
    {
        if (this._0xb48553f3 != StateRunning)
            return;
        this._0xb48553f3 = StateSummit;
        for (int _0x903b4e15 = 0; _0x903b4e15 < this._0xbaa768db.Count; _0x903b4e15++)
            if (this._0xbaa768db[_0x903b4e15] != null)
                this._0xbaa768db[_0x903b4e15].DOColor(_0x82ba3493.GoldLight, 0.5f).SetLink(this._0xbaa768db[_0x903b4e15].gameObject);
        _0x49c993d5._0xaff2bc43 = _0x49c993d5._0xaff2bc43 + 1;
        if (this._0x12c59363 > _0x49c993d5._0x924ddf27)
            _0x49c993d5._0x924ddf27 = this._0x12c59363;
        if (this._0xa49694a0 > _0x49c993d5._0xd231b447)
            _0x49c993d5._0xd231b447 = this._0xa49694a0;
        if (this._0xf9f8a9f2 >= _0x49c993d5._0xb40476b1)
            _0x49c993d5._0xb40476b1 = this._0xf9f8a9f2 + 1;
        if (this._0xf2ff4853)
            _0x49c993d5._0x9e0702fa = _0x49c993d5._0x9e0702fa + 1;
        int _0x0ecb9a45 = this._0x7e60ac6c(true);
        this._0x993e0047();
        if (this._0xe68a8aec != null)
            this._0xe68a8aec._0xe0a59b8f(this._0xf9f8a9f2, this._0x12c59363, this._0xaf289931, this._0xa49694a0, _0x0ecb9a45);
        DOVirtual.DelayedCall(_0x5681a043.PopDelaySeconds, () => this._0xc2076540()).SetLink(this.gameObject);
    }

    private void _0x4395e3f2(float _0x5957788b)
    {
        this._0x888b5a45 -= _0x5681a043.ShieldDrain(this._0xf2ff4853) * _0x5957788b;
        if (this._0x9ac45a8d != null)
            this._0x9ac45a8d._0xb35e6bb8(this._0x888b5a45 / _0x5681a043.ShieldMax);
        if (this._0x888b5a45 <= 0f)
            this._0x570be7a0();
    }

    [SerializeField]
    private SpriteRenderer _corePrefab;
    [SerializeField]
    private _0x4831bce5 _skin;
    private readonly _0x62dbe494 _0x88bcb894 = new _0x62dbe494()._0x9e993001();
    private float _0xe6510821;
    [SerializeField]
    private SpriteRenderer _sparkPrefab;
    private const int StateRunning = 1;
    private readonly List<int[]> _0xa5ec09f3 = new List<int[]>();
    public void _0xdcc8b75e()
    {
        if (_0x4751f1e9.Instance != null)
            _0x4751f1e9.Instance._0xa8d05a2a();
        if (this._0xb48553f3 == StateHeld)
            this._0xb48553f3 = StateRunning;
    }

    private void _0x993e0047()
    {
        _0x49c993d5._0x268e4330 = _0x49c993d5._0x268e4330 + this._0x12c59363;
        int _0xf81360ec = Mathf.RoundToInt(this._0xcf321609);
        if (_0xf81360ec > _0x49c993d5._0x5bdc8547)
            _0x49c993d5._0x5bdc8547 = _0xf81360ec;
        if (_0xe6558cf1.Instance != null)
            _0xec7175f7._0x05354bf3._0x2869e359 = _0xec7175f7._0x05354bf3._0x2869e359 + this._0x12c59363;
    }

    private void _0xa2d6ccda()
    {
        if (_0x4751f1e9.Instance != null)
            _0x4751f1e9.Instance._0xf4b7ab90(_0xec7175f7._0x5d5037c6.LOSE);
    }

    private float _0x7772ac48;
    private float _0xae8ec106;
    /// <summary>Lays the ring out from the bottom of the screen upward and dresses every row.</summary>
    private void _0xb88d13c8()
    {
        IList<_0xc41019e2> _0x99588fcb = this._0xb25e808f._0xe83bdefc;
        for (int _0x49c7e9bd = 0; _0x49c7e9bd < _0x99588fcb.Count; _0x49c7e9bd++)
        {
            float _0x6313c90f = -this._0xdce3b73b + _0x49c7e9bd * this._0xae8ec106;
            _0x99588fcb[_0x49c7e9bd].transform.localPosition = new Vector3(0f, _0x6313c90f, 0f);
            _0x99588fcb[_0x49c7e9bd]._0x3f2f3355(this._0x8dff6c19());
            // Rows that start below the climber must not resolve on the first frame.
            _0x99588fcb[_0x49c7e9bd]._0x176001b1 = _0x6313c90f <= this._0x6980437e;
        }
    }

    private _0xb8ce66dd _0xe68a8aec;
    [SerializeField]
    private SpriteRenderer _coinPrefab;
    private void _0xe916a474(_0xc41019e2 _0x2b4189a4)
    {
        if (this._0x0b3c28c9 == null)
            return;
        int _0x10ac938c = this._0x0b3c28c9._0xa0a4e14e;
        int _0x06cebeca = _0x2b4189a4._0xd220af63(_0x10ac938c);
        if (_0x06cebeca == _0x5681a043.CellCoin)
        {
            _0x2b4189a4._0xc6717b64(_0x10ac938c);
            this._0x12c59363 += this._0xd026b1d0;
            this._0xc220a3ee++;
            int _0xcae50c93 = _0x5681a043.ChainMultiplier(this._0xc220a3ee);
            bool _0x6c88031b = _0xcae50c93 != this._0xd026b1d0;
            this._0xd026b1d0 = _0xcae50c93;
            if (this._0xd026b1d0 > this._0xa49694a0)
                this._0xa49694a0 = this._0xd026b1d0;
            if (this._0x9ac45a8d != null)
            {
                this._0x9ac45a8d._0xc051b3d6(this._0x12c59363, this._0xaf289931);
                this._0x9ac45a8d._0xf7ccbdc7(this._0xd026b1d0, _0x6c88031b);
            }

            this._0x11f65957(_0x10ac938c);
            if (this._0x12c59363 >= this._0xaf289931)
                this._0x3181d0d9();
            return;
        }

        if (_0x06cebeca == _0x5681a043.CellCore)
        {
            _0x2b4189a4._0xc6717b64(_0x10ac938c);
            this._0x888b5a45 = Mathf.Min(_0x5681a043.ShieldMax, this._0x888b5a45 + _0x5681a043.ShieldPerCore);
            if (this._0x9ac45a8d != null)
            {
                this._0x9ac45a8d._0xb35e6bb8(this._0x888b5a45 / _0x5681a043.ShieldMax);
                this._0x9ac45a8d._0x9973b21d();
            }

            this._0x11f65957(_0x10ac938c);
            return;
        }

        if (_0x06cebeca == _0x5681a043.CellEmpty)
        {
            // An empty cell under the climber BREAKS the chain. Without this a chain is not a
            // chain: it survives any number of bare rows, so a player who never taps rides the
            // centre lane to x4 and clears the quota without a single input.
            this._0x79eefe53(false);
            return;
        }

        if (_0x06cebeca == _0x5681a043.CellVent)
        {
            // Costs the chain and half a second of control - never the shield.
            this._0x79eefe53(true);
            this._0x0b3c28c9._0xe70eadbf();
        }
    }

    private void _0x3f6e56ef()
    {
        _0x3cddbc40 _0x77a1d509 = _0x3cddbc40.Instance;
        if (_0x77a1d509 == null || _0x77a1d509.Panels == null || _0xec7175f7._0xd6f8c568.DEFAULT >= _0x77a1d509.Panels.Count)
            return;
        _0xd75e45b3 _0x3519dd3c = _0x77a1d509.Panels[_0xec7175f7._0xd6f8c568.DEFAULT];
        if (_0x3519dd3c == null || _0x3519dd3c.Content == null)
            return;
        RectTransform _0x6b3e9285 = _0x3519dd3c.Content.transform as RectTransform;
        if (_0x6b3e9285 == null)
            return;
        this._0x9ac45a8d = this.gameObject.AddComponent<_0x378d48e1>();
        this._0x9ac45a8d._0xbe0599e7(_0x6b3e9285, this._skin, this, this._0xf2ff4853, this._0xaf289931);
        this._0x9ac45a8d._0xb35e6bb8(1f);
        this._0x9ac45a8d._0xc051b3d6(0, this._0xaf289931);
        this._0x9ac45a8d._0xf7ccbdc7(1, false);
        this._0xe68a8aec = this.gameObject.AddComponent<_0xb8ce66dd>();
        this._0xe68a8aec._0x859f818c(this._skin, this);
    }

    private int[] _0x8dff6c19()
    {
        if (this._0xa5ec09f3.Count == 0)
        {
            bool _0x229f24d1 = this._0xffeac13a < 2; // no vents in the first two segments
            this._0x3e010972._0xb45a414f(this._0x88bcb894, this._0x0b3c28c9 != null ? this._0x0b3c28c9._0xa0a4e14e : 1, _0x229f24d1);
            this._0xffeac13a++;
            for (int _0x923afb2b = 0; _0x923afb2b < _0x5681a043.RowsPerSegment; _0x923afb2b++)
            {
                int[] _0x7428c35a = new int[_0x5681a043.LaneCount];
                for (int _0x30a496f1 = 0; _0x30a496f1 < _0x5681a043.LaneCount; _0x30a496f1++)
                    _0x7428c35a[_0x30a496f1] = this._0x88bcb894._0x251f1415(_0x923afb2b, _0x30a496f1);
                this._0xa5ec09f3.Add(_0x7428c35a);
            }
        }

        int[] _0x1ed4a65b = this._0xa5ec09f3[0];
        this._0xa5ec09f3.RemoveAt(0);
        return _0x1ed4a65b;
    }

    private _0x378d48e1 _0x9ac45a8d;
    private int _0xf9f8a9f2;
    private const int StateReady = 0;
    private int _0xaf289931;
    private bool _0xf2ff4853;
    [SerializeField]
    private SpriteRenderer _plumePrefab;
    private int _0x12c59363;
    public void _0xffa3d232()
    {
        _0x49c993d5._0x7566d207 = Mathf.Min(_0x46df03e4.StageCount - 1, this._0xf9f8a9f2 + 1);
        _0x49c993d5._0x472a9861 = _0x49c993d5._0x472a9861 + 1;
        if (_0xe6558cf1.Instance != null)
            _0xe6558cf1.Instance._0x96e69a76(_0xec7175f7._0x8c4ad123.SCENE_1);
    }

    private readonly List<SpriteRenderer> _0xbaa768db = new List<SpriteRenderer>();
    private float _0xa5388087 = _0x5681a043.HintHoldSeconds;
    private void _0xeb2c67ba(float _0x912caa4e)
    {
        float _0x1e84de78 = _0x5681a043.ScrollSpeed(this._0xf2ff4853, this._0x7772ac48);
        IList<_0xc41019e2> _0xf07aa305 = this._0xb25e808f._0xe83bdefc;
        float _0x101d76a8 = -this._0xdce3b73b - this._0xae8ec106;
        for (int _0xe1cca586 = 0; _0xe1cca586 < _0xf07aa305.Count; _0xe1cca586++)
        {
            _0xc41019e2 _0xf240579a = _0xf07aa305[_0xe1cca586];
            Vector3 _0xd470abaf = _0xf240579a.transform.localPosition;
            _0xd470abaf.y -= _0x1e84de78 * _0x912caa4e;
            _0xf240579a.transform.localPosition = _0xd470abaf;
            if (!_0xf240579a._0x176001b1 && _0xd470abaf.y <= this._0x6980437e)
            {
                _0xf240579a._0x176001b1 = true;
                this._0xe916a474(_0xf240579a);
            }

            if (_0xd470abaf.y < _0x101d76a8)
            {
                // Wrap relative to THIS row, not to an absolute accumulator. The ring holds
                // rows.Count rows one pitch apart, so lifting the bottom one by the whole ring
                // lands it exactly one pitch above the current top. Carrying a running _topY
                // instead ignores the scroll the earlier rows have already done, and the gap
                // grows every wrap until rows arrive seconds apart and the trail reads empty.
                float _0xa7443f04 = _0xd470abaf.y + _0xf07aa305.Count * this._0xae8ec106;
                _0xf240579a.transform.localPosition = new Vector3(0f, _0xa7443f04, 0f);
                _0xf240579a._0x3f2f3355(this._0x8dff6c19());
            }
        }
    }

    private _0x0c255a4d _0x0b3c28c9;
    private float _0xcf321609;
    private void _0x11f65957(int _0xfa0ba948)
    {
        if (this._sparkPrefab == null)
            return;
        SpriteRenderer _0xf44a75ac = Instantiate(this._sparkPrefab, this._0xb2a2c564);
        _0xf44a75ac.transform.localPosition = new Vector3(this._0xcc19a979[_0xfa0ba948], this._0x6980437e, 0f);
        _0xf44a75ac.transform.localScale = Vector3.one;
        _0xf44a75ac.size = new Vector2(this._0x8e3c9fb1 * 0.25f, this._0x8e3c9fb1 * 0.25f);
        _0xf44a75ac.sortingOrder = _0x5681a043.OrderSpark;
        _0xf44a75ac.color = _0x82ba3493.Fade(_0x82ba3493.EmberGlow, 0.5f);
        _0xf44a75ac.transform.DOLocalMoveY(this._0x6980437e + 0.5f, 0.3f).SetLink(_0xf44a75ac.gameObject);
        _0xf44a75ac.DOFade(0f, 0.3f).OnComplete(() => Destroy(_0xf44a75ac.gameObject)).SetLink(_0xf44a75ac.gameObject);
    }

    [SerializeField]
    private SpriteRenderer _railPrefab;
    private readonly float[] _0xcc19a979 = new float[_0x5681a043.LaneCount];
    [SerializeField]
    private SpriteRenderer _tilePrefab;
    private Transform _0xb2a2c564;
}

internal static class _0x9ddae1e7
{
    internal static string _0x5867f869(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}
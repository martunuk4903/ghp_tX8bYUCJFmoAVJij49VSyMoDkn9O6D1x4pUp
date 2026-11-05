using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0xec7175f7;

public class _0x3cddbc40 : MonoBehaviour
{
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x3cddbc40>();
    }

    public bool IsShowSplashOnStart = true;
    public static _0x3cddbc40 Instance;
    [HideInInspector]
    public List<int> LastPanelIndexes = new()
    {
        1
    };
    private _0xd75e45b3 _0x6af4ce09(int _0x27d64646)
    {
        return this.Panels[_0x27d64646];
    }

    public float ScaleDuration = 0.4f;
    private void _0x7352e770(int _0x5d8fb76f)
    {
        if (_0x5d8fb76f == _0xd6f8c568.SPLASH)
            _0x67c373b3.Instance._0xa6293701();
        if (_0xe6558cf1.Instance._0x0101eb58 == _0x8c4ad123.SCENE_0)
        {
        }
    }

    private void SwitchSplash()
    {
        if (_0x140f4a24.Instance.IsTutorialEnabled && !_0xe6558cf1._0x20cea244._0x20d7715f)
            this._0x595a3d0b(_0xd6f8c568.TUTORIAL0);
        else
            this._0x595a3d0b(_0xd6f8c568.DEFAULT);
    }

    public void _0x2da3e6ed(int _0xbb79a0e2)
    {
        if (_0xbb79a0e2 == _0xd6f8c568.SPLASH && _0xe6558cf1.Instance._0x0101eb58 != _0x8c4ad123.SCENE_0)
            _0x67c373b3.Instance._0x5d82bebc();
        if (_0xe6558cf1.Instance._0x0101eb58 != _0x8c4ad123.SCENE_0)
        {
            if (_0xbb79a0e2 == _0xd6f8c568.SPLASH || _0xbb79a0e2 == _0xd6f8c568.TUTORIAL0)
                _0xe6558cf1.Instance._0x9833778c(false);
            else if (_0xbb79a0e2 == _0xd6f8c568.DEFAULT)
                _0xe6558cf1.Instance._0x9833778c(true);
        }
    }

    private void Start()
    {
        this._0x65184b60();
    }

    public float StaticBlurMaterialInitialValue;
    private void _0x65184b60()
    {
        this._0x0d9ebde4(_0xd6f8c568.SPLASH);
        if (_0xe6558cf1.Instance._0x0101eb58 == _0x8c4ad123.SCENE_0)
        {
        }
        else
        {
            this.Invoke(nameof(this.SwitchSplash), _0x67c373b3.Instance.DefaultAnimationTime);
        }
    }

    public int CurrentPanelIndex;
    public List<_0xd75e45b3> Panels;
    private void _0x02c5fa70(int _0x4af3b5a2)
    {
        this.LastPanelIndexes.Add(_0x4af3b5a2);
        this.CurrentPanelIndex = _0x4af3b5a2;
        for (int _0xe311ad7e = 0; _0xe311ad7e < this.Panels.Count; _0xe311ad7e++)
            if (_0xe311ad7e != _0x4af3b5a2 && this.Panels[_0xe311ad7e] != null)
                this.Panels[_0xe311ad7e]._0xc081ac40();
    }

    private void _0x94406f4a(int _0x4846d383)
    {
        this.LastPanelIndexes.Add(_0x4846d383);
        this.CurrentPanelIndex = _0x4846d383;
        for (int _0xf74a7adb = 0; _0xf74a7adb < this.Panels.Count; _0xf74a7adb++)
            if (_0xf74a7adb != _0x4846d383 && this.Panels[_0xf74a7adb] != null)
                this.Panels[_0xf74a7adb]._0xc081ac40();
    }

    private void _0x0d9ebde4(int _0x48cc4608)
    {
        this._0x94406f4a(_0x48cc4608);
        this._0x7352e770(_0x48cc4608);
        this.CurrentPanelIndex = _0x48cc4608;
        this.Panels[_0x48cc4608]._0x28b3416d();
    }

    public void _0x0257431f()
    {
        this.LastPanelIndexes.RemoveAll(_0x22a07de8 => _0x22a07de8 == this.CurrentPanelIndex);
        int _0xdf42baa1 = this.LastPanelIndexes.Last();
        this._0x7352e770(_0xdf42baa1);
        this._0x02c5fa70(_0xdf42baa1);
        this.CurrentPanelIndex = _0xdf42baa1;
        this.Panels[_0xdf42baa1].Show();
    }

    public void _0x595a3d0b(int _0x5864f03d)
    {
        this._0x94406f4a(_0x5864f03d);
        this._0x7352e770(_0x5864f03d);
        this.CurrentPanelIndex = _0x5864f03d;
        this.Panels[_0x5864f03d].Show();
    }
}
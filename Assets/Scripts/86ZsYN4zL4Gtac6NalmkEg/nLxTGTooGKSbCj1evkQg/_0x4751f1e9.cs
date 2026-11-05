using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0xec7175f7;

public class _0x4751f1e9 : MonoBehaviour
{
    private void BackgroundHidden()
    {
        this.BlurBackground.gameObject.SetActive(false);
    }

    public void _0x30878dce()
    {
        this.LastPopIndexes.RemoveAll(_0x22a07de8 => _0x22a07de8 == this.CurrentPopIndex);
        if (this.LastPopIndexes.Count <= 0)
            this._0xa8d05a2a();
        else
            this._0xf4b7ab90(this.LastPopIndexes.Last());
    }

    private void _0x0ad3ec2d()
    {
        this.Invoke(nameof(this.BackgroundHidden), this.ScaleDuration);
    }

    private void _0x4ed90e9b()
    {
        this.BlurBackground.gameObject.SetActive(true);
    }

    public List<int> LastPopIndexes = new();
    public List<GameObject> GameObjectsToHide;
    public static _0x4751f1e9 Instance;
    public List<_0x42700195> Pops;
    public void _0xa8d05a2a()
    {
        this.LastPopIndexes.Clear();
        this._0xa04ecfab();
        foreach (GameObject _0x011c970d in this.GameObjectsToHide)
            if (_0x011c970d != null)
                _0x011c970d.SetActive(true);
        this._0x0ad3ec2d();
    }

    private void Start()
    {
        this.BackgroundHidden();
        foreach (_0x42700195 _0xe998fb74 in this.Pops)
            if (_0xe998fb74 != null)
                _0xe998fb74.gameObject.SetActive(true);
    }

    public float ScaleDuration = 0.4f;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x4751f1e9>();
    }

    public void _0xf4b7ab90(int _0x24790325)
    {
        this.CurrentPopIndex = _0x24790325;
        this.LastPopIndexes.Add(this.CurrentPopIndex);
        this._0xa04ecfab(true);
        this._0x4ed90e9b();
        this.Pops[_0x24790325].Show();
        foreach (GameObject _0x7c034eda in this.GameObjectsToHide)
            _0x7c034eda.SetActive(false);
    }

    public int CurrentPopIndex;
    private void _0xa04ecfab(bool _0xab0d6f8a = false)
    {
        for (int _0xdc9cc663 = 0; _0xdc9cc663 < this.Pops.Count; ++_0xdc9cc663)
            if (this.Pops[_0xdc9cc663] != null && !(_0xdc9cc663 == this.CurrentPopIndex && _0xab0d6f8a))
                this.Pops[_0xdc9cc663]._0x4fcf813b();
    }

    public GameObject BlurBackground;
    public _0x42700195 _0x3b81ecb8(int _0xc95c1844)
    {
        return this.Pops[_0xc95c1844];
    }
}
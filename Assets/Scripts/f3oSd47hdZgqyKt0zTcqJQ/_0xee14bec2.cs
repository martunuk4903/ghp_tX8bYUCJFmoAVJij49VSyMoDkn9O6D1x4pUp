using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The menu's own view switcher. The brief's nine screens live inside the template's single
/// DEFAULT panel as views, addressed by the plain int ids in TrailConfig - never by object
/// name and never by inventing a new panel index.
/// This has nothing to do with the splash: the template alone decides when SPLASH gives way
/// to DEFAULT (C.69), and this router is only ever asked to switch between DEFAULT's views.
/// </summary>
public sealed class _0xee14bec2 : MonoBehaviour
{
    public void _0x4cb32886(GameObject _0x4d4aa4b6)
    {
        this._0x39362e34 = _0x4d4aa4b6;
        if (_0x4d4aa4b6 != null)
            _0x4d4aa4b6.SetActive(this._0xfe3fcc04 == _0x5681a043.ViewHome);
    }

    public RectTransform _0x4b07cf18(int _0x259efbc3)
    {
        if (_0x259efbc3 < 0 || _0x259efbc3 >= this._views.Count)
            return null;
        return this._views[_0x259efbc3];
    }

    /// <summary>
    /// The template's own Play button. It is NOT one of our views - it is the
    /// EMPTY_BASE_BUTTON instance the template parents straight into the DEFAULT panel's
    /// Content, so hiding a view does not hide it, and its hit rect would keep loading the
    /// game from underneath the stage map or the objectives list. It belongs to HOME only.
    /// </summary>
    private GameObject _0x39362e34;
    public void _0xafef2a18(int _0xd9dc996c, RectTransform _0x0dde7c4b)
    {
        while (this._views.Count <= _0xd9dc996c)
            this._views.Add(null);
        this._views[_0xd9dc996c] = _0x0dde7c4b;
    }

    public int _0xfe3fcc04 { get; private set; }

    [SerializeField]
    private List<RectTransform> _views = new List<RectTransform>();
    public void _0x848b1f13(int _0xc535a6a3)
    {
        this._0xfe3fcc04 = _0xc535a6a3;
        if (this._0x39362e34 != null)
            this._0x39362e34.SetActive(_0xc535a6a3 == _0x5681a043.ViewHome);
        for (int _0x5cf24664 = 0; _0x5cf24664 < this._views.Count; _0x5cf24664++)
        {
            if (this._views[_0x5cf24664] == null)
                continue;
            bool _0x1246f888 = _0x5cf24664 == _0xc535a6a3;
            this._views[_0x5cf24664].gameObject.SetActive(_0x1246f888);
            if (_0x1246f888)
            {
                this._views[_0x5cf24664].localScale = Vector3.one;
                this._views[_0x5cf24664].anchoredPosition = Vector2.zero;
            }
        }
    }
}
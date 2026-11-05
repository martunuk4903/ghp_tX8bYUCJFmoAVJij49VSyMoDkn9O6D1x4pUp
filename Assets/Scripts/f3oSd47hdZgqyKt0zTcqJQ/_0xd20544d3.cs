using TMPro;
using UnityEngine;

/// <summary>
/// The template ships more panels than this game dresses - EMPTY and TUTORIAL0..TUTORIAL6 -
/// and whatever is left undressed still carries its placeholder copy ("Lorem Ipsum",
/// "HEADER"). C.15: clean them at RUNTIME, from generated code, and do NOT switch the panels
/// off - the controllers address them by index and a pulled-out object breaks navigation.
/// Removing the text is enough.
/// </summary>
public sealed class _0xd20544d3 : MonoBehaviour
{
    public void _0x2b310f53()
    {
        // Named one by one rather than "every panel except the two we dress". The game dresses
        // SPLASH and DEFAULT; these are the rest, and listing them means a panel this game
        // starts using later cannot be blanked by accident.
        this._0xd25b1b9c(_0xec7175f7._0xd6f8c568.EMPTY);
        this._0xd25b1b9c(_0xec7175f7._0xd6f8c568.TUTORIAL0);
        this._0xd25b1b9c(_0xec7175f7._0xd6f8c568.TUTORIAL1);
        this._0xd25b1b9c(_0xec7175f7._0xd6f8c568.TUTORIAL2);
        this._0xd25b1b9c(_0xec7175f7._0xd6f8c568.TUTORIAL3);
        this._0xd25b1b9c(_0xec7175f7._0xd6f8c568.TUTORIAL4);
        this._0xd25b1b9c(_0xec7175f7._0xd6f8c568.TUTORIAL5);
        this._0xd25b1b9c(_0xec7175f7._0xd6f8c568.TUTORIAL6);
    }

    private void _0xd25b1b9c(int _0x1d33b652)
    {
        _0x3cddbc40 _0x98253410 = _0x3cddbc40.Instance;
        if (_0x98253410 == null || _0x98253410.Panels == null)
            return;
        if (_0x1d33b652 < 0 || _0x1d33b652 >= _0x98253410.Panels.Count)
            return;
        _0xd75e45b3 _0x255e7efd = _0x98253410.Panels[_0x1d33b652];
        if (_0x255e7efd == null)
            return;
        // The panel itself is NEVER switched off - the controllers address panels by index and
        // a pulled-out object breaks navigation. Removing the text is enough (C.15).
        TMP_Text[] _0x1561c0ac = _0x255e7efd.GetComponentsInChildren<TMP_Text>(true);
        for (int _0x3defa425 = 0; _0x3defa425 < _0x1561c0ac.Length; _0x3defa425++)
            if (_0x1561c0ac[_0x3defa425] != null)
                _0x1561c0ac[_0x3defa425].text = string.Empty;
    }
}
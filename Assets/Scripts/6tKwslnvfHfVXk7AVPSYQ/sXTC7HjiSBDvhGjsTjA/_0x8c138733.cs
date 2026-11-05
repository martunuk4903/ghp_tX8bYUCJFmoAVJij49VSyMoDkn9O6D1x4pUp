using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class _0x8c138733 : MonoBehaviour
{
    private List<string> _0x6e464a5e = new();
    private TMP_Text _0xa6db3b10;
    private void Update()
    {
        int _0xbaa89635 = 1;
        if (this._0x6e464a5e.Count > 0)
        {
            string _0xcae0a636 = this._0xa6db3b10.text;
            foreach (string _0x5f888c35 in this._0x6e464a5e)
                while (_0xcae0a636.Contains(_0x5f888c35))
                    _0xcae0a636 = _0xcae0a636.Replace(_0x5f888c35, "");
            _0xbaa89635 = _0xcae0a636.Length;
        }
        else
        {
            _0xbaa89635 = this._0xa6db3b10.text.Length;
        }

        float _0x1e17541c = Mathf.Clamp(this._0xc8b407a7 + this._0xe1d8f3ce * _0xbaa89635, this._0x29befc4d, this._0x659600ed);
        if (!Mathf.Approximately(this._0x81fc2dab.aspectRatio, _0x1e17541c))
            this._0x81fc2dab.aspectRatio = _0x1e17541c;
    }

    private AspectRatioFitter _0x81fc2dab;
    private float _0xe1d8f3ce = 0.6f;
    private float _0x659600ed = 4;
    private float _0x29befc4d = 1.5f;
    private float _0xc8b407a7;
}
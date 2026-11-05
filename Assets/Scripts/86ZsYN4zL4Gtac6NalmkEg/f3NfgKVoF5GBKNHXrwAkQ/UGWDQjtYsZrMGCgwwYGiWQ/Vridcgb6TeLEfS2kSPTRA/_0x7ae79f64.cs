using TMPro;
using UnityEngine;
using static _0xec7175f7;

public class _0x7ae79f64 : MonoBehaviour
{
    private void Start()
    {
        if (this.MoneyCountText == null)
        {
            TMP_Text _0x60ea16c2;
            if (this.gameObject.TryGetComponent(out _0x60ea16c2))
                this.MoneyCountText = _0x60ea16c2;
        }

        this._0xe38ff736();
    }

    public TMP_Text MoneyCountText;
    public void _0xe38ff736()
    {
        this.MoneyCountText.text = _0x05354bf3._0x2869e359.ToString();
    }
}
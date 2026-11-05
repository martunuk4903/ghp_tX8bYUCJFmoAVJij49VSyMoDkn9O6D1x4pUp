using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xae8457ec : MonoBehaviour
{
    private TMP_Text _0x79b43f76;
    private void Update()
    {
        this._0x68ef2d1c();
    }

    private Image _0x578ceec2;
    private void _0x68ef2d1c()
    {
        if (this._0x578ceec2.canvasRenderer.GetColor() != this._0x79b43f76.canvasRenderer.GetColor())
            this._0x79b43f76.canvasRenderer.SetColor(this._0x578ceec2.canvasRenderer.GetColor());
    }
}
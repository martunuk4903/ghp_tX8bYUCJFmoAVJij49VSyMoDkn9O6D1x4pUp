using UnityEngine;
using UnityEngine.UI;

public class _0x54796d3d : MonoBehaviour
{
    private void Awake()
    {
        if (this._0x2989d0be == null)
            if (!this.TryGetComponent(out this._0x2989d0be))
                this._0x2989d0be = this.GetComponentInChildren<Button>();
    }

    private Button _0x2989d0be;
    private int _0xce9d016a;
    private bool _0x7f63ebe0;
    private void Start()
    {
        if (this._0x7f63ebe0)
            this._0x2989d0be.onClick.AddListener(() => _0x3cddbc40.Instance._0x0257431f());
        else
            this._0x2989d0be.onClick.AddListener(() => _0x3cddbc40.Instance._0x595a3d0b(this._0xce9d016a));
    }
}
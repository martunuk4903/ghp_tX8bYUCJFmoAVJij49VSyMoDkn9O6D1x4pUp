using UnityEngine;
using UnityEngine.UI;

public class _0x146998fd : MonoBehaviour
{
    public int PopToShowIndex;
    public Button Button;
    private void Start()
    {
        if (this.IsShowLastPop)
            this.Button.onClick.AddListener(() =>
            {
                _0x4751f1e9.Instance._0x30878dce();
            });
        else if (this.IsHideAllPops)
            this.Button.onClick.AddListener(() => _0x4751f1e9.Instance._0xa8d05a2a());
        else
            this.Button.onClick.AddListener(() => _0x4751f1e9.Instance._0xf4b7ab90(this.PopToShowIndex));
    }

    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public bool IsHideAllPops;
    public bool IsShowLastPop;
}
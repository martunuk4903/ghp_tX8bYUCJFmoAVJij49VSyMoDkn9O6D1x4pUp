using UnityEngine;
using UnityEngine.UI;

public class _0x11462d93 : MonoBehaviour
{
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    private void Start()
    {
        this.Button.onClick.AddListener(() => _0xe6558cf1.Instance._0x9833778c(this.IsPhysicsRunOnClick));
    }

    public bool IsPhysicsRunOnClick;
    public Button Button;
}
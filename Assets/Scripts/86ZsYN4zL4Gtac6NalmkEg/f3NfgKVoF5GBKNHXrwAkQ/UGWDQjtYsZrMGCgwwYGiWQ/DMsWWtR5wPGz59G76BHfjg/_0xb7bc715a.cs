using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0xb7bc715a : MonoBehaviour
{
    private void Start()
    {
        if (this.IsLoadCurrentScene)
            this.Button.onClick.AddListener(() =>
            {
                _0xe6558cf1.Instance._0x96e69a76(SceneManager.GetActiveScene().buildIndex);
            });
        else
            this.Button.onClick.AddListener(() => _0xe6558cf1.Instance._0x96e69a76(this.LoadSceneId));
    }

    public bool IsLoadCurrentScene;
    public Button Button;
    public int LoadSceneId;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }
}
using UnityEngine;
using UnityEngine.UI;

public class _0x7d245d80 : MonoBehaviour
{
    private void Start()
    {
        if (this.NextTutorialButton != null)
        {
            if (this.IsTutorialEndPanel)
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x3cddbc40.Instance._0x595a3d0b(this.EndTutorialPanelIndex));
                this.NextTutorialButton.onClick.AddListener(() => _0xe6558cf1.Instance._0x085398ea());
            }
            else
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x3cddbc40.Instance._0x595a3d0b(this.NextTutorialPanelIndex));
            }
        }

        if (this.TutorialEndButton != null)
        {
            this.TutorialEndButton.onClick.AddListener(() => _0x3cddbc40.Instance._0x595a3d0b(this.EndTutorialPanelIndex));
            this.TutorialEndButton.onClick.AddListener(() => _0xe6558cf1.Instance._0x085398ea());
        }
    }

    public int NextTutorialPanelIndex;
    public Button TutorialEndButton;
    public bool IsTutorialEndPanel;
    public int EndTutorialPanelIndex = 1;
    public Button NextTutorialButton;
}
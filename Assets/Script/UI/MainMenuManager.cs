
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace TowerDefense.UI
{
    public class MainMenuManager : MonoBehaviour
    {
        [SerializeField] private Button startButton;
        [SerializeField] private Button helpBackButton;
        [SerializeField] private Button helpButton;
        [SerializeField] private GameObject helpPanel;

        bool isHelpPanelVisible = false;
        // Start is called before the first frame update
        void Start()
        {
            startButton.onClick.AddListener(StartLevel);
            helpButton.onClick.AddListener(ShowHelpPanel);
            helpBackButton.onClick.AddListener(ShowHelpPanel);
        }

        void StartLevel(){
                SceneManager.LoadScene(1);
        }

        void ShowHelpPanel(){
            isHelpPanelVisible = !isHelpPanelVisible;
            helpPanel.SetActive(isHelpPanelVisible);
        }

        void OnDestroy(){
            startButton.onClick.RemoveListener(StartLevel);
             helpButton.onClick.RemoveListener(ShowHelpPanel);
            helpBackButton.onClick.RemoveListener(ShowHelpPanel);
        }
    }

}

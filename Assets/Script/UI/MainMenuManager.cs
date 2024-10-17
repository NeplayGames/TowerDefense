using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace TowerDefense.UI
{
    public class MainMenuManager : MonoBehaviour
    {
        [SerializeField] private Button startButton;
        // Start is called before the first frame update
        void Start()
        {
            startButton.onClick.AddListener(StartLevel);
        }

        void StartLevel(){
                SceneManager.LoadScene(1);
        }

        void OnDestroy(){
            startButton.onClick.RemoveListener(StartLevel);
        }
    }

}

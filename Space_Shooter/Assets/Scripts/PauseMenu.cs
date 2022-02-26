using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public Button mainMenu;
    public Button exitButton;
    public Button resume;
    public string gameSceneName;
    public Button pause;
    public GameObject PauseMenuOnOff;
    public static bool GameIsPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        GameIsPaused = false;
        // pause.onClick.AddListener()
        pause.onClick.AddListener(PauseGame);
        mainMenu.onClick.AddListener(LoadGameScene);
        exitButton.onClick.AddListener(OnApplicationQuit);
         resume.onClick.AddListener(ResumeGame);

    }

    private void Update()
    {
        
    }
    void PauseGame()
    {
        Time.timeScale = 0;
        PauseMenuOnOff.SetActive(true);
    }
    void ResumeGame()
    {
        Time.timeScale = 1;
        PauseMenuOnOff.SetActive(false);
    }
    private void OnApplicationQuit()
    {
        Application.Quit();
    }
    
    public void LoadGameScene()
    {

        GameSceneManager.Instance.LoadScene(gameSceneName);
    }
}

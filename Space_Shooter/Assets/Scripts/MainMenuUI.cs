using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainMenuUI : MonoBehaviour
{
    public string gameSceneName;
    public Button startButton;
    public Button exitButton;
    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(LoadGameScene);

    }

    // Update is called once per frame
    void LoadGameScene()
    {
        GameSceneManager.Instance.LoadScene(gameSceneName);
    }
}

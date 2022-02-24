using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainMenuUI : MonoBehaviour
{
  
    public Button startButton;
    public Button exitButton;
    public string gameSceneName;

    // Start is called before the first frame update
    void Start()
    {
     
        startButton.onClick.AddListener(LoadGameScene);

    }

    // Update is called once per frame
    public void LoadGameScene()
    {

        GameSceneManager.Instance.LoadScene(gameSceneName);
    }
}

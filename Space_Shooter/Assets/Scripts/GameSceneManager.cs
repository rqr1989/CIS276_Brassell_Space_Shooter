using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//loading in to new l
public class GameSceneManager : MonoBehaviour
{
    public static GameSceneManager Instance;
    public float uiLoadTime = 0.5f;
    private AsyncOperation asynOperation;
   
    private void Awake()
    {
         
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        // 
        GetReferences();
    }

 

    public void GetReferences()
    {
        //find any data i want in new scene
        //FindObjectOfType<Player>();
        
    }

    public void LoadScene(string sceneName)
    {
        StartCoroutine(LoadNewScene(sceneName));
    }
   // SpaceShooterScene
    private IEnumerator LoadNewScene(string sceneName)
    {
        yield return null;
        //pauses anything run in update fiunction
        Time.timeScale = 0f;

        yield return new WaitForSecondsRealtime(uiLoadTime);
        asynOperation = SceneManager.LoadSceneAsync(sceneName);
        while (!asynOperation.isDone)
        {
            yield return null; //wait single frame
        }
    }
}
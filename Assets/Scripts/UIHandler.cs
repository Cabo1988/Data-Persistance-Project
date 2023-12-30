using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

[DefaultExecutionOrder(1000)]

public class UIHandler : MonoBehaviour
{
    public string playerName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void GameStart()
    {
        SceneManager.LoadScene(1);
    }
   
    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void ReadPlayerName(string name)
    {
        playerName = name;
        Debug.Log(playerName);
    }

}

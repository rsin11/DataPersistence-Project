
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUI : MonoBehaviour
{
    public string PlayerName;
    public GameObject InputField;
  

    public void Update()
    {
        PlayerName = InputField.GetComponent<Text>().text;
        PlayerData.Instance.playerName = PlayerName;
    }
    public void NewStart()
    { 
        SceneManager.LoadScene(1);
    }

    public void ExitNow()
    {
      #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
      # else 
        Application.Quit();
      #endif
    }
}

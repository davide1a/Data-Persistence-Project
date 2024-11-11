using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUI : MonoBehaviour
{
    public TMP_InputField newName;

    public void Exit()
    {
        DataPersistence.Instance.SaveTopScore();

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public void LoadMain()
    {
        if (newName.text != "")
        {
            SceneManager.LoadScene(1);
        }
    }
    public void GetInputText()
    {
        // To get the text
        DataPersistence.Instance.currentName = newName.text;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using TMPro;

public class MenuUI : MonoBehaviour
{
    public TMP_InputField newName;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadMain()
    {
        SceneManager.LoadScene(1);
    }
    public void GetInputText()
    {
        // To get the text
        DataPersistence.Instance.currentName = newName.text;
    }
}

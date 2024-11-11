using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Data;

public class DataPersistence : MonoBehaviour
{
    public static DataPersistence Instance;

    public string currentName;
    public string topName;
    public int topScore;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadTopScore();
    }

    [System.Serializable]
    class SaveData
    {
        public string topName;
        public int topScore;
    }

    public void SaveTopScore()
    {
        SaveData data = new SaveData();
        data.topName = topName;
        data.topScore = topScore;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadTopScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            topName = data.topName;
            topScore = data.topScore;
        }
    }
}

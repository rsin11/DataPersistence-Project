using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class PlayerData : MonoBehaviour
{
    public static PlayerData Instance;
    public string playerName;

    public void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }




    /*    [System.SerializableAttribute]
        class SaveData
        {
            public string playerName;
        }

        public void SaveName() 
        {
            SaveData data = new SaveData();
            data.playerName = playerName;
            string Json = JsonUtility.ToJson(data);
            File.WriteAllText(Application.persistentDataPath + "/savefile.json",Json);

        }

        public void LoadName()
         { 
         string path = Application.persistentDataPath + "/savefile.json";
             if (File.Exists(path)) 
             {
                 string json = File.ReadAllText(path);
                 SaveData data = JsonUtility.FromJson<SaveData>(json);
                 playerName = data.playerName;

             }
         }*/
}

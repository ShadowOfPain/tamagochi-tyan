using System;
using UnityEngine;

public abstract class SaveableScriptableObject : ScriptableObject
{
    public abstract string ID { get; }

    public void Save()
    {
        var data = JsonUtility.ToJson(this);
        PlayerPrefs.SetString(ID, data);
    }


    public SaveableScriptableObject Load(string id)
    {
        return Load<SaveableScriptableObject>(id);
    }

    public static T Load<T>(string id) where T : SaveableScriptableObject
    {
        string data = PlayerPrefs.GetString(id);
        try
        {
            var obj = JsonUtility.FromJson<T>(data);
            return obj;
        }
        catch (Exception)
        {
            return null;
        }
    }

    /*
    public static void Create()
    {
        string name;
        do
            name = Guid.NewGuid().ToString(); while (PlayerPrefs.HasKey(name));
    }
    */
}
using System;
using UnityEngine;

[Serializable]
public class CharData : SaveableScriptableObject
{
    [SerializeField] private int _mood;
    [SerializeField] private int _hunger;
    [SerializeField] private int _reputation;


    private const string DATA_KEY = "_STATS";

    public override string ID
    {
        get { return charName + DATA_KEY; }
    }

    public int Mood
    {
        get { return _mood; }
        set { _mood = value; }
    }

    public int Hunger
    {
        get { return _hunger; }
        set { _hunger = value; }
    }

    public int Reputation
    {
        get { return _reputation; }
        set { _reputation = value; }
    }

    private readonly string charName;

    private CharData(string charName)
    {
        this.charName = charName;
    }

    public static CharData Load(string charName)
    {
        var result = Load<CharData>(charName + DATA_KEY);
        return result ? result : new CharData(charName);
    }
}
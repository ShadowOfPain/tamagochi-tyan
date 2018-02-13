using UnityEngine;


public interface IController
{
    
}

public class AppController
{
    private IController GameController;
    private IController uiController;


    public void Init()
    {
        
    }
}

public class GameData : SaveableScriptableObject
{
    [SerializeField] private string CharID;
    [SerializeField] private int Coins;
    private const string KEY = "GAME";

    public override string ID
    {
        get { return KEY; }
    }

    public static GameData Load(string charName)
    {
        return Load<GameData>(KEY);
    }
}
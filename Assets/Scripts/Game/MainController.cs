using UnityEngine;

public class MainController : MonoBehaviour
{
    [SerializeField] private GameObject _selectedChar;
    [SerializeField] private SpawnController _spawnController;
    [SerializeField] private GameUIController _uiController;

    private void Start()
    {
        Init();
    }

    private void Init()
    {
        CharData _charData = CharData.Load(_selectedChar.name);
        
        _spawnController.Init(_selectedChar);
        _uiController.Init(_charData);
    }
}
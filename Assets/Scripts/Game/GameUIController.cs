using UnityEngine;

public class GameUIController : MonoBehaviour
{
    [SerializeField] private GameplayUI _gameplayUi;

    public void Init(CharData _charData)
    {
        _gameplayUi.Init(_charData);
    }
}
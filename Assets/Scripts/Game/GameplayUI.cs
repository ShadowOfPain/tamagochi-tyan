using UnityEngine;
using UnityEngine.UI;

public class GameplayUI : MonoBehaviour
{
    [SerializeField] private Text _mood;
    [SerializeField] private Text _hunger;
    [SerializeField] private Text _reputation;

    private CharData _charData;

    private CharData CharData
    {
        set
        {
            _charData = value;
            _mood.text = _charData.Mood.ToString();
            _hunger.text = _charData.Hunger.ToString();
            _reputation.text = _charData.Reputation.ToString();
        }
        get { return _charData; }
    }

    public void Init(CharData _charData)
    {
        CharData = _charData;
    }
}
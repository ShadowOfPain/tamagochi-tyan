using System;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [SerializeField] private Button _spawnButton;
    [SerializeField] private GameObject _findSquareContainer;
    public Action SpawnEvent;

    private void Start()
    {
        _spawnButton.onClick.AddListener(OnSpawnButtonClick);
    }

    private void OnSpawnButtonClick()
    {
        if (SpawnEvent != null) SpawnEvent();
    }

    public void OnSpawned()
    {
        _spawnButton.gameObject.SetActive(false);
        _findSquareContainer.gameObject.SetActive(false);
    }
}
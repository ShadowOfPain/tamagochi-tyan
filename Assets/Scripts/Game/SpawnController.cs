﻿using System;
using UnityEngine;
using Zenject;


public class SpawnController : MonoBehaviour
{
    private GameObject _char;
    [SerializeField] private GameUI _UIView;

    private event Action OnSpawn;


    public void Init(GameObject _char)
    {
        this._char = _char;
        _UIView.SpawnEvent += Spawn;
        OnSpawn += _UIView.OnSpawned;
    }


    #region Spawn

    void Spawn()
    {
        var pos = GetPostion();
        if (pos != null)
        {
            var c = GameObject.Instantiate(_char);
            c.transform.position = (Vector3) pos;
            if (OnSpawn != null) OnSpawn();
        }
    }


    [SerializeField] LayerMask collisionLayerMask;

    Vector3? GetPostion()
    {
        float findingSquareDist = 0.5f;
        float maxRayDistance = 30.0f;

        Vector3 center = new Vector3(Screen.width / 2, Screen.height / 2, findingSquareDist);
        Ray ray = Camera.main.ScreenPointToRay(center);
        RaycastHit hit;

        //we'll try to hit one of the plane collider gameobjects that were generated by the plugin
        //effectively similar to calling HitTest with ARHitTestResultType.ARHitTestResultTypeExistingPlaneUsingExtent
        if (Physics.Raycast(ray, out hit, maxRayDistance, collisionLayerMask))
        {
            return hit.point;
        }

        return null;
    }

    #endregion
}
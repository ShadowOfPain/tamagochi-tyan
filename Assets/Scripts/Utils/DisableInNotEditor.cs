using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableInNotEditor : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
#if !UNITY_EDITOR
		gameObject.SetActive(false);
		#endif
    }

    // Update is called once per frame
    void Update()
    {
    }
}
using UnityEngine;
using System;
using System.Collections;

public class GameManager: Singleton<GameManager>
{
    PoolManager _poolManager;

    [SerializeField]
    Vector3 startPosition = Vector3.up;

    // Use this for initialization
    void Start()
    {
        _poolManager = GameObject.FindObjectOfType<PoolManager>();

        BasePEntity instance = _poolManager.GetFromSpecificPool(PoolType.DECORATIVE);
        instance.ObjectInstance.transform.position = startPosition;
    }
}

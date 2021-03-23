using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour, IPObject
{
    private PooledType myType;

    public GameObject Object { get; }

    public PooledType Type { get; set; }


    private void Awake()
    {
        Type = myType;
    }

    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {
        
    }
}

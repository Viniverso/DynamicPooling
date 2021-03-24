using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : BasePool
{

    private void Awake()
    {
        ObjectInstance = this.gameObject;
    }

    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {
        
    }
}

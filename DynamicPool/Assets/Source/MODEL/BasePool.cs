using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BasePool : MonoBehaviour
{
    [SerializeField]
    private PooledType myType;

    public GameObject ObjectInstance { get; set; }

    public PooledType Type { get { return myType; } }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Pool entity to instance
public abstract class BasePEntity : MonoBehaviour
{
    [SerializeField]
    private PoolType myType;

    public GameObject ObjectInstance { get; set; }

    public PoolType Type { get { return myType; } }
}

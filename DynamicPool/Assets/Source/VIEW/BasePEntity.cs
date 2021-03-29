using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Pool entity to instance
public abstract class BasePEntity : MonoBehaviour
{
    [SerializeField]
    private PoolType poolType;

    public GameObject ObjectInstance { get; set; }

    public PoolType GetPoolType { get { return poolType; } }
}

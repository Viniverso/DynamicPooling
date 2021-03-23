using UnityEngine;
using System.Collections;

public interface IPObject
{
    public GameObject Object { get; }

    public PooledType Type { get; set;}
}

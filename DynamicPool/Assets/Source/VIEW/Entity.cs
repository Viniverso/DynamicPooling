using UnityEngine;
using System.Collections;

public class Entity : BasePEntity
{
    private void Awake()
    {
        ObjectInstance = this.gameObject;
    }

    private void OnCollisionEnter(Collision collision)
    {
        //BasePool
    }
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public interface IPool
{
    public PoolType GetPoolType { get; }

    public BasePEntity GetFromPool();
    public void AddToPool(BasePEntity _bPool);
}

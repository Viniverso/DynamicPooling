using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public interface IPool
{
    void StockSpace();

    public BasePEntity GetFromPool();
    public void AddToPool(BasePEntity _bPool);
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BasePool : MonoBehaviour, IPool
{
    [SerializeField]
    private PoolType poolType;

    [SerializeField]
    private PoolData storedData;

    protected Queue<BasePEntity> availableObjects;

    private void Awake()
    {
        availableObjects = new Queue<BasePEntity>();
        StockSpace();
    }

    public virtual void AddToPool(BasePEntity _bPool)
    {
        _bPool.ObjectInstance.SetActive(false);
        availableObjects.Enqueue(_bPool);
    }

    public virtual BasePEntity GetFromPool()
    {
        if (availableObjects.Count == 0)
            StockSpace();

        var _receivedEntity = availableObjects.Dequeue();
        _receivedEntity.ObjectInstance.SetActive(true);
        return _receivedEntity;
    }

    public virtual void StockSpace()
    {
        for (int _i = 0; _i < storedData.StackLength; _i++)
        {
            foreach(BasePEntity _ent in storedData.GetEntities)
            {
                var addInstance = Instantiate(_ent);
                AddToPool(addInstance);
            }
            if (_i == storedData.StackLength - 1)
                IsStockComplete = true;
        }
    }

    public PoolType GetPoolType { get { return poolType; } }

    public bool IsStockComplete { get; set; }
}
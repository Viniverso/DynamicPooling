using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : Singleton<PoolManager>
{
    protected List<BasePool> poolsOnScene;

    private void Awake()
    {
        var _values = GameObject.FindObjectsOfType<BasePool>();

        poolsOnScene = new List<BasePool>(_values);
        Debug.Log("P " + poolsOnScene.Count);
    }

    private void Start()
    {
        var _pDecorative = GetPoolByType(PoolType.DECORATIVE);
        var _pInteractive = GetPoolByType(PoolType.INTERACTIVE);
        var _pPlayable = GetPoolByType(PoolType.PLAYABLE);

        if (_pDecorative)
            _pDecorative.StartStorage();

        if (_pInteractive)
            _pInteractive.StartStorage();

        if (_pPlayable)
            _pPlayable.StartStorage();
    }

    public BasePool GetPoolByType(PoolType _type)
    {
        foreach(BasePool _bPool in poolsOnScene)
        {
            if (_bPool.GetPoolType == _type)
                return _bPool;
        }
        return null;
    }

    public void InsertObjectToSpecificPool(PoolType _type, BasePEntity _entity)
    {
        BasePool _basePool = GetPoolByType(_type);
        _basePool.AddToPool(_entity);
    }

    public BasePEntity GetFromSpecificPool(PoolType _type)
    {
        return GetPoolByType(_type).GetFromPool();
    }
}

public enum PoolType
{
    DECORATIVE, //scene scene elements
    INTERACTIVE, //interactive objects in scene
    PLAYABLE //armour, invetory, etc
}

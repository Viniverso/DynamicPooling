using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : Singleton<PoolManager>
{
    protected List<BasePool> poolsOnScene ;

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
}

public enum PoolType
{
    DECORATIVE, //scene scene elements
    INTERACTIVE, //interactive objects in scene
    PLAYABLE //armour, invetory, etc
}

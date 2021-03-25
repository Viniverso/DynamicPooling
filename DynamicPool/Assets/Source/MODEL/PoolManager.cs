using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : Singleton<PoolManager>
{
    protected List<BasePool> pools;

    private void Awake()
    {
        var _values = GameObject.FindObjectsOfType<BasePool>();

        pools = new List<BasePool>(_values);
    }

    private void Start()
    {
        var _pDecorative = GetPoolByType(PoolType.DECORATIVE);
        var _pInteractive = GetPoolByType(PoolType.INTERACTIVE);
        var _pPlayable = GetPoolByType(PoolType.PLAYABLE);
    }

    public BasePool GetPoolByType(PoolType _type)
    {
        return pools.Where((t) => t.GetPoolType == _type) as BasePool;
    }
}

public enum PoolType
{
    DECORATIVE, //scene scene elements
    INTERACTIVE, //interactive objects in scene
    PLAYABLE //armour, invetory, etc
}

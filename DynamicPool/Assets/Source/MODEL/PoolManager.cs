using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : Singleton<PoolManager>
{
    public PoolData pooledData;

    private Dictionary<PooledType, Queue<BasePool>> container;

    private void Awake()
    {
        container = new Dictionary<PooledType, Queue<BasePool>>();
    }

    // Start is called before the first frame update
    void Start()
    {
        if (pooledData)
        {
            foreach (BasePool _oP in pooledData.GetPools)
            {
                OccupyMemory(_oP);
            }
        }
    }

    public void RegisterObject(PooledType _type, BasePool _storedObject)
    {
        _storedObject.ObjectInstance.SetActive(false);
        if (container.ContainsKey(_type))
        {
            container[_type].Enqueue(_storedObject);
            Debug.Log("Container " + _type.ToString());
        }
        else
        {
            Queue<BasePool> _enqueue = new Queue<BasePool>();
            _enqueue.Enqueue(_storedObject);
            container.Add(_type,_enqueue);
            Debug.Log("Container " + _type.ToString());
        }
    }

    public Queue<BasePool>[] GetObjectsByPoolType(PooledType _bytype)
    {
        List<Queue<BasePool>> typeObjects = new List<Queue<BasePool>>();

        foreach (var _obj in container)
        {
            if (_obj.Key == _bytype)
            {
                typeObjects.Add(_obj.Value);
            }
        }

        return typeObjects.ToArray();
    }


    public void OccupyMemory(BasePool _pooledObject, int _amountInstances = 1)
    {
        for(int _i = 0; _i < _amountInstances; _i++)
        {
            var _instance = Instantiate(_pooledObject.gameObject);
            BasePool _pooledComp = _instance.GetComponent<BasePool>();
            _pooledComp.ObjectInstance = _instance;
            RegisterObject(_pooledObject.Type, _pooledComp);
        }
    }
}


public enum PooledType
{
    DECORATIVE, //scene scene elements
    INTERACTIVE, //interactive objects in scene
    PLAYABLE //armour, invetory, etc
}

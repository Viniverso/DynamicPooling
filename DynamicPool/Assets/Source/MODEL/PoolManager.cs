using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : Singleton<PoolManager>
{
    public Dictionary<PooledType, Queue<IPObject>> container;

    // Start is called before the first frame update
    void Start()
    {
        var seekIObject = GameObject.FindObjectsOfType<ObjectPool>();
        foreach (ObjectPool _oP in seekIObject)
        {
            OccupyMemory(_oP);
        }
    }

    public void RegisterObject(PooledType _type, IPObject _storedObject)
    {
        _storedObject.Object.SetActive(false);
        if (container.ContainsKey(_type))
        {
            container[_type].Enqueue(_storedObject);
        }
        else
        {
            Queue<IPObject> _enqueue = new Queue<IPObject>();
            _enqueue.Enqueue(_storedObject);
            container.Add(_type,_enqueue);
        }
    }

    public Queue<IPObject>[] GetObjectsByPoolType(PooledType _bytype)
    {
        List<Queue<IPObject>> typeObjects = new List<Queue<IPObject>>();

        foreach (var _obj in container)
        {
            if (_obj.Key == _bytype)
            {
                typeObjects.Add(_obj.Value);
            }
        }

        return typeObjects.ToArray();
    }


    public void OccupyMemory(ObjectPool _pooledObject , int _amountInstances = 3)
    {
        for(int _i = 0; _i < _amountInstances; _i++)
        {
            Instantiate(_pooledObject);
        }
    }
}


public enum PooledType
{
    DECORATIVE, //scene scene elements
    INTERACTIVE, //interactive objects in scene
    PLAYABLE //armour, invetory, etc
}

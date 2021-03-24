using UnityEngine;
using System.Collections;

public class GameManager: Singleton<GameManager>
{

    // Use this for initialization
    void Start()
    {
        //InsertDecorative(); 
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void InsertDecorative()
    {
        var _instance = PoolManager.SingletonInstance.GetObjectsByPoolType(PooledType.DECORATIVE);
        Debug.Log("Instance " + _instance.Length);
    }

    public void InsertPlayable()
    {
        var _instance = PoolManager.SingletonInstance.GetObjectsByPoolType(PooledType.PLAYABLE);
        Debug.Log("Instance " + _instance);
    }

    public void InsertInteractive()
    {
        var _instance = PoolManager.SingletonInstance.GetObjectsByPoolType(PooledType.INTERACTIVE);
        Debug.Log("Instance " + _instance);
    }
}

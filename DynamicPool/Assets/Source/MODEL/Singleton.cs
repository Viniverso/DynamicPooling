using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    protected static T instance;

    public static T SingletonInstance
    {
        get
        {

            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<T>();
                if (instance == null)
                    instance = new GameObject("Singleton Instance " + typeof(T)).AddComponent<T>();
            }

            return instance;
        }
    }

    private void Awake()
    {
        if (instance != null)
            Destroy(this.gameObject);

        instance = SingletonInstance;
    }
}

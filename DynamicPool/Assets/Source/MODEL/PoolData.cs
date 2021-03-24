using UnityEngine;
using System.Collections;

[CreateAssetMenu(menuName = "Pool Data/Data", order = 0)]
public class PoolData : ScriptableObject
{
    [SerializeField]
    private BasePool[] basePools;

    public BasePool[] GetPools
    {
        get { return basePools; }
    }
}

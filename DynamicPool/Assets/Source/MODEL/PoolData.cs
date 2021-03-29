using UnityEngine;
using System.Collections;

[CreateAssetMenu(menuName = "Pool Data/Pool Data", order = 0)]
public class PoolData : ScriptableObject
{
    [SerializeField]
    private BasePEntity[] basePools;

    [SerializeField, Range(1,1000)]
    private uint stackEntityLength = 1;

    public BasePEntity[] GetEntities
    {
        get { return basePools; }
    }

    public uint StackLength
    {
        get { return stackEntityLength; }
    }
}

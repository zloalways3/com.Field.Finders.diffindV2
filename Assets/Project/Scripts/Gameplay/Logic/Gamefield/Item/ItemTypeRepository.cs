using System.Collections.Generic;
using UnityEngine;

public class ItemTypeRepository : MonoBehaviour
{
    private const int MinTargetCount = 3;
    private const int MaxTargetCount = 6;
    private const int ItemCount = 12;

    public int TargetCount { get; private set; }

    private readonly List<ItemType> _types = new List<ItemType>();

    public void Reset()
    {
        _types.Clear();

        TargetCount = Random.Range(MinTargetCount, MaxTargetCount + 1);

        for (int i = 0; i < ItemCount; i++)
        {
            if(TargetCount > i)
            {
                _types.Add(ItemType.Target);
                continue;
            }

            _types.Add(ItemType.Idle);
        }
    }

    public ItemType GetRandomType()
    {
        var index = Random.Range(0, _types.Count);

        var type = _types[index];
        _types.Remove(type);

        return type;
    }
}
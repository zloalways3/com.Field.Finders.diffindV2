using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ItemTypeViewRepository : MonoBehaviour
{
    [SerializeField] private List<ItemTypeSpritePair> _pairs;

    public Sprite GetSpriteByType(ItemType type)
    {
        var pair = _pairs.First((pairType) => pairType.Type == type);
        var sprite = pair.Sprite;

        return sprite;
    }
}
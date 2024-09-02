using System;
using UnityEngine;

[Serializable]
public struct ItemTypeSpritePair
{
    [SerializeField] private ItemType _type; 
    [SerializeField] private Sprite _sprite;

    public readonly ItemType Type => _type;
    public readonly Sprite Sprite => _sprite;
}
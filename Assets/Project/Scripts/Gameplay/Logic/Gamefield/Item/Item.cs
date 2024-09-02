using System;
using UnityEngine;

public class Item : MonoBehaviour
{
    public event Action Clicked;

    [SerializeField] private ItemTypeRepository _typeRepository;

    private bool _isClicked;

    public ItemType Type { get; private set; }

    public void Reset()
    {
        _isClicked = false;
        Type = _typeRepository.GetRandomType();
    }

    public bool TryClick()
    {
        if (Type != ItemType.Target) return false;
        if (_isClicked) return false;

        _isClicked = true;
        Clicked?.Invoke();

        return true;
    }
}
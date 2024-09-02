using System;
using UnityEngine;

public class ClickedItemsCounter : MonoBehaviour
{
    public Action AllClicked;

    [SerializeField] private ItemTypeRepository _typeRepository;
    [SerializeField] private Gamefield _gamefield;

    public int Count { get; private set; }

    private void Start()
    {
        Count = default;

        foreach(var itemView in _gamefield.Items)
            itemView.Item.Clicked += IncreaseCount;
    }

    private void IncreaseCount()
    {
        Count++;
        if (Count < _typeRepository.TargetCount) return;
        AllClicked?.Invoke();
        Reset();
    }

    private void Reset()
    {
        Count = 0;
    }

    private void OnDestroy()
    {
        foreach (var itemView in _gamefield.Items)
            itemView.Item.Clicked -= IncreaseCount;
    }
}
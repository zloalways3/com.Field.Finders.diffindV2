using System.Collections.Generic;
using UnityEngine;

public class Gamefield : MonoBehaviour
{
    [SerializeField] private List<ItemView> _items;
    [SerializeField] private ItemTypeRepository _typeRepository;
    [SerializeField] private ClickedItemsCounter _clickedItemsCounter;

    public IEnumerable<ItemView> Items => _items;

    public void Reset()
    {
        _typeRepository.Reset();

        foreach (var item in _items)
        {
            item.Actualize();
        }
    }

    private void Start()
    {
        Reset();

        _clickedItemsCounter.AllClicked += Reset;
    }

    private void OnDestroy()
    {
        _clickedItemsCounter.AllClicked -= Reset;        
    }
}
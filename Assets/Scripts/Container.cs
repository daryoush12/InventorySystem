using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container : MonoBehaviour
{
    [SerializeField] private Item[] _items;
    [SerializeField] private List<InventoryObserver> _observers;
    [SerializeField] private InventorySettings _settings;

    public delegate void InventorySlotEvents(Item item, int from, int to);
    public InventorySlotEvents onItemMoved;

    public delegate void InventoryEvent(Item item);
    public InventoryEvent onItemAdded;
    public InventoryEvent onItemRemoved;

    [SerializeField] private int lastOpenSlot = 0;

    private void Start()
    {
        _items = new Item[_settings.inventorySize];
    }

    public void AddItem(Item item, int index = 0)
    {
        if (_items[index] == null) {
            _items[index] = item;
            onItemAdded?.Invoke(item);
            NotifyObservers();
        }
        else
        {
            AddItem(item, index++);
        }
    }

    public void RemoveItem(int index)
    {
        _items[index] = null;
        NotifyObservers();
    }

    private void NotifyObservers()
    {
        foreach(InventoryObserver observer in _observers)
        {
            observer.Notify(_items);
        }
    }
 
}

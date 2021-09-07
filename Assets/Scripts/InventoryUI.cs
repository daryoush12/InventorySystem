using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : InventoryObserver
{

    [SerializeField] private InventorySettings _settings;
    [SerializeField] private GameObject _itemPrefab;
    [SerializeField] private Transform _parentTransform;
    [SerializeField] private List<ItemUI> _slots;
    private int nextAvailableSlot;

    private void Start()
    {
        nextAvailableSlot = 0;
        for(int x = 0; x < _settings.inventorySize; x++)
        {
            GameObject go = Instantiate(_itemPrefab);
            if(_parentTransform != null) {
                go.transform.SetParent(_parentTransform);
            }
            _slots.Add(go.GetComponent<ItemUI>());
        }
    }

    public override void Notify(Item[] inventory)
    {
        //TODO: update new entries in if length changed etc.
        Debug.Log(inventory.Length);
        int x = 0;
        while(inventory[x] != null)
        {
            _slots[x].SetItem(inventory[x]);
            x++;
        }
    }
}

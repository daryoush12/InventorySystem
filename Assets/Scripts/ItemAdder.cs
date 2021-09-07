using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAdder : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Item itemToAdd;
    [SerializeField] private Container inventory;

    void Start()
    {
        inventory.AddItem(itemToAdd);
    }
}

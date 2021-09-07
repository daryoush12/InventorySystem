using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InventoryObserver : MonoBehaviour
{
    public virtual void Notify(Item[] inventory)
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemUI : MonoBehaviour
{
    [SerializeField] private Text _text;

    public void SetItem(Item item)
    {
        _text.text = item.name;
    }
}

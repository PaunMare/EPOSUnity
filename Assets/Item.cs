using System;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string Name;
    public string Price;

    public void AddItem()
    {
        Order.Instance.items.Add(this);
    }
}
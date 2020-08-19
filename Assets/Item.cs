using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
public class Item : MonoBehaviour
{
    //public string Name;
    public string Price;
    public Text price;
    int currentPrice = 0;
   
    public void AddItem()
    {
       
        int nekibroj = int.Parse(price.text);
        currentPrice = int.Parse(this.Price);
        price.text = (nekibroj+currentPrice).ToString();
       
    }
   
}
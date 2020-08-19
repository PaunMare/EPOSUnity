using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class ListItem : MonoBehaviour
{
    public string Name;
    public string Price;
    public GameObject listholder;
     public void AddItem()
    {
        //OrderList.Instance.list.Add(this);
        
        listholder.GetComponent<Text>().text += Name+" " + Price + " RSD";
        listholder.GetComponent<Text>().text += "\n";

    }

}

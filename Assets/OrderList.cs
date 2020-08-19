using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;

public class OrderList : MonoBehaviour
{
    public static OrderList Instance;
    public  List<ListItem> list;

    public void Awake()
    {
       Instance = this;
    }

    public void Save()
    {

    }

   
}

using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class Order : MonoBehaviour
{
    public static Order Instance;
    
    public List<Item> items;

    private void Awake()
    {
        Instance = this;
        //DontDestroyOnLoad(Instance);
    }

    
    public string GenerateEmail()
    {
        return null;
    }
    
}
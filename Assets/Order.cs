using System.Collections.Generic;
using UnityEngine;

public class Order : MonoBehaviour
{
    public static Order Instance;
    
    public List<Item> items;

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }


    public string GenerateEmail()
    {
        return null;
    }
    
}
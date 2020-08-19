using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
public class orderSettings : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;
    public Text price;
    public GameObject listhandler;
    public GameObject pricehandler;
    void Awake()
    {
        DontDestroyOnLoad(listhandler);
        DontDestroyOnLoad(pricehandler);
        panel1.SetActive(true);
        panel2.SetActive(false);
    }
    public void Reset()
    {
        price.text = "0";
        listhandler.GetComponent<Text>().text = "";
    }
    public void ChangeToTotal()
    {
        if (price.text != "0")
        {
            pricehandler.GetComponent<Text>().text = price.text;
            SceneManager.LoadScene(2);
        }   
    }
    public void HandleInputData(int val)
    {
        if (val == 0)
        {
            panel1.SetActive(true);
            panel2.SetActive(false);
        }
        else
        {
            panel2.SetActive(true);
            panel1.SetActive(false);
        }
    }
    void Update()
    {
        
    }

}

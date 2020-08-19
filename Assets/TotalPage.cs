using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TotalPage : MonoBehaviour
{
    public Text list;
    string sum;
    void Awake()
    {
        list.text = GameObject.FindGameObjectWithTag("list").GetComponent<Text>().text;
        sum = GameObject.FindGameObjectWithTag("price").GetComponent<Text>().text;
    }
    void Start()
    {
        list.text += "_______________";
        list.text += "\n" + "Ukupna cena: "+sum;
    }
   public void NewOrder()
    {
        GameObject.Destroy(GameObject.FindGameObjectWithTag("mail"));
        GameObject.Destroy(GameObject.FindGameObjectWithTag("list"));
        GameObject.Destroy(GameObject.FindGameObjectWithTag("price"));
        SceneManager.LoadScene(0);
    }
}

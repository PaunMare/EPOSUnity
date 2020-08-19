using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class welcomePage : MonoBehaviour
{
    public GameObject mailhandler;
    public InputField mail;

    void Awake()
    {
        DontDestroyOnLoad(mailhandler);

    }
    public void AddMail()
    {
        if (mail.text != "")
        {
            mailhandler.GetComponent<Text>().text = mail.text;
            SceneManager.LoadScene(1);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

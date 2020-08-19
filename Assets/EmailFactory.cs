using UnityEngine;
using UnityEngine.UI;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using UnityEngine.SceneManagement;
using System;

public class EmailFactory : MonoBehaviour
{
    string recipientEmail;
    public Text text;
    //public Text dummy;
    string mail;
    public static EmailFactory Instance;
    private string senderMail = "eposprojekatunity@gmail.com";

    private void Awake()
    {
        Instance = this;
        recipientEmail= GameObject.FindGameObjectWithTag("mail").GetComponent<Text>().text;
        //DontDestroyOnLoad(this.gameObject);
    }
    public void AddMail()
    {
        //dummy.text = recipientEmail.text;
        //DontDestroyOnLoad(this.gameObject);
        //Console.WriteLine(dummy.text);
        SceneManager.LoadScene(1);
    }
    public void SendEmail()
    {
        MailMessage mail = new MailMessage();
        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
        SmtpServer.Timeout = 10000;
        SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
        SmtpServer.UseDefaultCredentials = false;
        SmtpServer.Port = 587;

        mail.From = new MailAddress(senderMail);
        mail.To.Add(new MailAddress(recipientEmail));
        
        mail.Subject = "Restoran \"Jadran\" narudžbina";
        mail.Body = text.text+"\n Hvala što naručujete kod nas";
        mail.IsBodyHtml = true;
        

        SmtpServer.Credentials = new System.Net.NetworkCredential(senderMail, "pauntrampa") as ICredentialsByHost; SmtpServer.EnableSsl = true;
        ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        };

        mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
        SmtpServer.Send(mail);
    }

    private void Update()
    {

    }
}
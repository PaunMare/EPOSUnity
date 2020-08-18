using UnityEngine;
using UnityEngine.UI;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

public class EmailFactory : MonoBehaviour
{
    public InputField recipientEmail;
    
    public static EmailFactory Instance;
    private string senderMail = "eposprojekatunity@gmail.com";

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
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
        mail.To.Add(new MailAddress(recipientEmail.text));
        
        mail.Subject = "Test Email through C Sharp App";
        mail.Body = "<h2>test mail</h2>";
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
        if (Input.GetKeyDown(KeyCode.S))
        {
            SendEmail();
        }
    }
}
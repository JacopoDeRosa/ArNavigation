using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net.Mail;
using System.Net;

public static class EmailSender
{
    public static void SendEmail(string subject, string content, params string[] to)
    {
        MailMessage mail = new MailMessage();
        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
        mail.From = new MailAddress("jacopo.derosa00@gmail.com");
        mail.To.Add("e.taddei@rbw-cgi.it");
        mail.To.Add("j.derosa@rbw-cgi.it");
        mail.Subject = subject;
        mail.Body = content;


        SmtpServer.Port = 587;
        SmtpServer.UseDefaultCredentials = false;
        SmtpServer.Credentials = new NetworkCredential("jacopo.derosa00@gmail.com", "zmegaeflteceqdjk");
        SmtpServer.EnableSsl = true;
        SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;

        SmtpServer.Send(mail);
    }
}

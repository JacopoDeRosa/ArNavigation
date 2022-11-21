using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net.Mail;
using System.Net;

public static class EmailSender
{
    public static void SendResultEmail(string subject, string content, params string[] to)
    {
        SendEmail("smtp.gmail.com", "jacopo.derosa00@gmail.com", "zmegaeflteceqdjk", subject, content, 587, "j.derosa@rbw-cgi.it");
    }

    public static void SendEmail(string Smtp, string from, string password, string subject, string content, int port, params string[] to)
    {

        MailMessage mail = new MailMessage();
        SmtpClient SmtpServer = new SmtpClient(Smtp);
        mail.From = new MailAddress(from);

        foreach (string receiver in to)
        {
            mail.To.Add(receiver);
        }

        mail.Subject = subject;
        mail.Body = content;

        SmtpServer.Port = port;
        SmtpServer.UseDefaultCredentials = false;
        SmtpServer.Credentials = new NetworkCredential(from, password);
        SmtpServer.EnableSsl = true;
        SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;

        SmtpServer.Send(mail);
    }
}

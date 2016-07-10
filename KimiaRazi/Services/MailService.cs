using KimiaRazi.DataAccess;
using KimiaRazi.Models;
using System;
using System.Web.Helpers;

namespace KimiaRazi.Services
{
    public class MailService : IMailService
    {
        public void SendMessageConfirmation(Message message)
        {
            /// insert message to database.

            DefaultConnection context = new DefaultConnection();
            context.Messages.Add(message);
            context.SaveChanges();

            /// Send email.
            var body = "You have received a message from " + message.Name + ".<br/>";
            body += "Email address: " + message.EmailAddress + "<br/>";
            var MailBodyText = message.MsgText;
            var customerEmail = message.EmailAddress;

            //Replace carriage returns with HTML breaks for HTML mail
            var formattedMessage = MailBodyText.Replace("\r\n", "<br/>");
            body += "Message: <br/>" + formattedMessage + "<br/>";
            body += "For more information, contact kimiarazi.com.";

            try
            {
                //SMTP Configuration for Hotmail
                WebMail.SmtpServer = "kimiarazi.ir";
                WebMail.SmtpPort = 25;
                WebMail.EnableSsl = false;

                //Enter your Hotmail credentials for UserName/Password and a "From" address for the e-mail
                WebMail.UserName = "contact@kimiarazi.ir";
                WebMail.Password = "9aU9e4kP";
                WebMail.From = "contact@kimiarazi.ir";
                WebMail.Send(to: "contactpage@kimiarazi.ir", subject: "New messsage from kimiarazi.com", body: body);
            }
            catch (Exception)
            {
                // only placed here to allow app to run without configuring email
            }
        }
    }
}
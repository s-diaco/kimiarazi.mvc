using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KimiaRazi.Services;
using KimiaRazi.Models;

namespace KimiaRazi.Services
{
    public class MessageService : IMessageService
    {
        public void ProcessMessage(Message message)
        {
            IMailService service = new MailService();
            service.SendMessageConfirmation(message);
        }
    }
}
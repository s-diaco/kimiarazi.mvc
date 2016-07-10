using KimiaRazi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimiaRazi.Services
{
    interface IMailService
    {
        void SendMessageConfirmation(Message order);
    }
}

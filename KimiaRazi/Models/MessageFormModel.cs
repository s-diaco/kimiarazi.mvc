using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KimiaRazi.Models
{
    public class MessageFormModel
    {
        [Required(ErrorMessageResourceName = "ErrorEmptyMsgText", ErrorMessageResourceType = typeof(Resources.Contact))]
        public string MsgText { get; set; }
        [Required(ErrorMessageResourceName = "ErrorEmptyMsgName", ErrorMessageResourceType = typeof(Resources.Contact))]
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        [Required(ErrorMessageResourceName = "ErrorEmptyMsgMail", ErrorMessageResourceType = typeof(Resources.Contact))]
        public string EmailAddress { get; set; }
    }
}
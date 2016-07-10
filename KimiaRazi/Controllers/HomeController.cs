using Bakery.Services;
using KimiaRazi.Models;
using KimiaRazi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KimiaRazi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.ActiveClass1 = "class = active";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.ActiveClass6 = "class = active";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Contact(MessageFormModel model)
        {
            if (ModelState.IsValid)
            {
                if(String.IsNullOrEmpty(model.PhoneNumber))
                {
                    model.PhoneNumber = "-";
                }
                Message message = new Message
                {
                    Name = model.Name,
                    PhoneNumber = model.PhoneNumber,
                    EmailAddress = model.EmailAddress,
                    MsgText = model.MsgText
                };
                MessageService service = new MessageService();
                service.ProcessMessage(message);
                return View("Success");
            }
            else
            {
                    return View("SendMessageFailed");
            }
        }
        public ActionResult Contact()
        {
            ViewBag.ActiveClass7 = "class = active";

            return View();
        }

        public ActionResult Digital_Printing()
        {
            ViewBag.ActiveClass2 = "class = active";

            return View();
        }

        public ActionResult Equipment()
        {
            ViewBag.ActiveClass3 = "class = active";

            return View();
        }

        public ActionResult Frits()
        {
            ViewBag.ActiveClass2 = "class = active";

            return View();
        }

        public ActionResult Glazes()
        {
            ViewBag.ActiveClass2 = "class = active";

            return View();
        }

        public ActionResult Services()
        {
            ViewBag.ActiveClass4 = "class = active";

            return View();
        }

        public ActionResult Third_Firing()
        {
            ViewBag.ActiveClass2 = "class = active";

            return View();
        }

        public ActionResult Special_Glazes()
        {
            ViewBag.ActiveClass2 = "class = active";

            return View();
        }

        // [Route("product/frit/{id:int}")]
        public ActionResult ProductDetail(int id)
        {
            ViewBag.ActiveClass2 = "class = active";
            IProductService service = new ProductService();
            ProductViewModel model = new ProductViewModel();
            Product TargetProduct = service.GetProduct(id);
            model.Name = TargetProduct.Name;
            model.subtitle = TargetProduct.subtitle;
            model.Description = TargetProduct.Description;
            model.ImageName = TargetProduct.ImageName;
            model.MinSinter = Helpers.PersianNumeralHelper.ConvertNumerals(TargetProduct.MinSinter.ToString());
            model.MaxSinter = Helpers.PersianNumeralHelper.ConvertNumerals(TargetProduct.MaxSinter.ToString());
            model.TECMax = Helpers.PersianNumeralHelper.ConvertNumerals(TargetProduct.TECMax.ToString());
            model.TECMin = Helpers.PersianNumeralHelper.ConvertNumerals(TargetProduct.TECMin.ToString());

            return View(model);
        }
        
        public ActionResult Powders()
        {
            ViewBag.ActiveClass2 = "class = active";

            return View();
        }
    }
}
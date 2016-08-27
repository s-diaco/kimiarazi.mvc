using Bakery.Services;
using KimiaRazi.Models;
using KimiaRazi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
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

        public ActionResult DigitalPrinting()
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

        public ActionResult ThirdFiring()
        {
            ViewBag.ActiveClass2 = "class = active";

            return View();
        }

        public ActionResult SpecialGlazes()
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
            if (TargetProduct != null)
            {

                model.ImageName = TargetProduct.ImageName;
                model.MinSinter = TargetProduct.MinSinter.ToString();
                model.MaxSinter = TargetProduct.MaxSinter.ToString();
                model.TECMax = TargetProduct.TECMax.ToString();
                model.TECMin = TargetProduct.TECMin.ToString();
                if (new string[] { "fa" }.Contains(Thread.CurrentThread.CurrentUICulture.Name))
                {
                    model.Name = TargetProduct.Name;
                    model.subtitle = TargetProduct.subtitle;
                    model.Description = TargetProduct.Description;
                }
                else
                {
                    switch (id)
                    {
                        case 1:
                            model.Name = Resources.Frit.Prod3H;
                            model.subtitle = Resources.Frit.Prod3Subhead;
                            model.Description = Resources.Frit.Prod3Text;
                            break;
                        case 2:
                            model.Name = Resources.Frit.Prod2H;
                            model.subtitle = Resources.Frit.Prod2Subhead;
                            model.Description = Resources.Frit.Prod2Text;
                            break;
                        case 3:
                            model.Name = Resources.Frit.Prod1H;
                            model.subtitle = Resources.Frit.Prod1Subhead;
                            model.Description = Resources.Frit.Prod1Text;
                            break;
                        case 4:
                            model.Name = Resources.Frit.Prod4H;
                            model.subtitle = Resources.Frit.Prod4Subhead;
                            model.Description = Resources.Frit.Prod4Text;
                            break;
                        default:
                            throw new HttpRequestValidationException();
                    }
                }

                return View(model);
            }
            else
            {
                throw new HttpException(404, "Product page not found.");
            }
        }

        public ActionResult Powders()
        {
            ViewBag.ActiveClass2 = "class = active";

            return View();
        }
    }
}
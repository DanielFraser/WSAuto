using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WSauto.ProdReference;

namespace WSauto.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Products()
        {
            return View();
        }


        public JsonResult getProducts(string prefix)
        {
            ProductsSoapClient psc = new ProductsSoapClient();
            return Json(psc.names(prefix), JsonRequestBehavior.AllowGet);
        }
    }
}
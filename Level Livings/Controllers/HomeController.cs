using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Level_Livings.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

      
           public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Buy()
        {
            ViewBag.Message = "Buy page.";

            return View();
        }

        public ActionResult Sell()
        {
            ViewBag.Message = "Sell page.";

            return View();

        }

        public ActionResult Services()
        {
            ViewBag.Message = "Services page.";

            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "About page.";

            return View();
        }


        public ActionResult FAQ()
        {
            ViewBag.Message = "FAQ";

            return View();
        }

        public ActionResult Rent()
        {
            ViewBag.Message = "Rent";

            return View();
        }


        public ActionResult Terms()
        {
            ViewBag.Message = "  Terms";

            return View();
        }

        public ActionResult Privacy()
        {
            ViewBag.Message = "Privacy";

            return View();
        }

        

    }
}
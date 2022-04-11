using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LawFirmWebsiteMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

       

        public ActionResult Services()
        {
            ViewBag.Message = "Our Services";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Meet our Team";

            return View();
        }
    }
}
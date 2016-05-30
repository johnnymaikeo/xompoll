using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XomPoll.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Home()
        {
            return View("Home");
        }

        public ActionResult Login()
        {
            return View("Login");
        }

        public ActionResult ViewTest()
        {
            ViewBag.Title = "TEST";
            return View();
        }
    }
}

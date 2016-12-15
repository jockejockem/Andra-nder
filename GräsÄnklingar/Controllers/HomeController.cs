using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace GräsÄnklingar.Controllers
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

        public ActionResult Ander()
        {
            ViewBag.Message = "Alla änder som är singlar och sökande!";

            return View();
        }

        public string visaNamn()
        {
            var hejsan =
                this.User.Identity.GetUserName();
            return hejsan;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppFootballClubs.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HomePage homePage = new homePage()
            {
                Headline = "Phew what a scorcher", 
                ByLine = "Ron Journo",
                Content = "People are obsessed with the weather";

            return View(homePage);
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
    }
}
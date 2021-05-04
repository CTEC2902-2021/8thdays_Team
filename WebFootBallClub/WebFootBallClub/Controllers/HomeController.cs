using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebFootBallClub.Controllers
{
    public class HomeController : Controller
    {
        Teams TeamsView = new TeamsViewsController();
        public ActionResult Index()
        {
            return View(TeamsView.getAllTeams());
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
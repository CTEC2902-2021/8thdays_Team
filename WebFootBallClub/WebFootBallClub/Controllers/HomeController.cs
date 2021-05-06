using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebFootBallClub.Controllers;

namespace WebFootBallClub.Controllers
{
    public class HomeController : Controller
    {
        DataInterface TeamsView = new PremierLeagueController();
        public ActionResult Index()
        {
            return View(TeamsView.getAllTeams());
        }

        public ActionResult Player (int ID)
        {

            return View(TeamsView.getTeamPlayers(ID));

        }

        public ActionResult About()
        {
            ViewBag.Message1 = "Quick preview of Premier League";
            ViewBag.Message2 = "Team:8thdays";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message1 = "P2617174@my365.dmu.ac.uk";
            ViewBag.Message2 = "P2617175@my365.dmu.ac.uk";
            ViewBag.Message3 = "P2617176@my365.dmu.ac.uk";
            ViewBag.Message4 = "P2617177@my365.dmu.ac.uk";
            ViewBag.Message5 = "P2617178@my365.dmu.ac.uk";

            return View();
        }
    }
}
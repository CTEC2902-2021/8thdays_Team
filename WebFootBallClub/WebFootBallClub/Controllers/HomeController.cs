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
        Database TeamsView = new PremierLeagueController();
        public ActionResult Index()
        {
            return View(TeamsView.getAllTeams());
        }

        public ActionResult TeamPlayer (int ID)
        {

            return View(getTeamPlayers(ID));

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
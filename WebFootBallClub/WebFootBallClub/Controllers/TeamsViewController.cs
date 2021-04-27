using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebFootBallClub.Models;

namespace WebFootBallClub.Controllers
{
    public class TeamsViewsController : Teams
    {
        public List<TeamsView> Team = new List<TeamsView>();
        public TeamsViewsController()
        {
            Team.Add(new TeamsView() { ID = 1, Name = "Man City", MP = 33, Win = 24, Draw = 5, Lose = 4, GF = 69, GA = 24, GD = 45, Pts = 77 });
            Team.Add(new TeamsView() { ID = 2, Name = "Man United", MP = 33, Win = 19, Draw = 10, Lose = 4, GF = 64, GA = 35, GD = 39, Pts = 67 });
        }

        public List<TeamsView> getAllTeams()
        {
            return Team;
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebFootBallClub.Models;

namespace WebFootBallClub.Controllers
{
    public class TeamsViewsController : Database
    {
        public List<TeamsView> Team = new List<TeamsView>();
        public TeamsViewsController()
        {
            Team.Add(new TeamsView() { ID = 1, Name = "Man City", MP = 33, Win = 24, Draw = 5, Lose = 4, GF = 69, GA = 24, GD = 45, Pts = 77 });

            Team.Add(new TeamsView() { ID = 2, Name = "Man United", MP = 33, Win = 19, Draw = 10, Lose = 4, GF = 64, GA = 35, GD = 39, Pts = 67 });

            Team.Add(new TeamsView() { ID = 3, Name = "Leicester City", MP = 33, Win = 19, Draw = 5, Lose = 9, GF = 60, GA = 38, GD = 22, Pts = 62 });

            Team.Add(new TeamsView() { ID = 4, Name = "Chelsea", MP = 33, Win = 16, Draw = 10, Lose = 7, GF = 51, GA = 31, GD = 20, Pts = 58 });

            Team.Add(new TeamsView() { ID = 5, Name = "West Ham", MP = 33, Win = 16, Draw = 7, Lose = 10, GF = 53, GA = 43, GD = 10, Pts = 55 });

            Team.Add(new TeamsView() { ID = 6, Name = "Liverpool", MP = 33, Win = 15, Draw = 9, Lose = 9, GF = 55, GA = 39, GD = 16, Pts = 54 });

            Team.Add(new TeamsView() { ID = 7, Name = "Tottenham", MP = 33, Win = 15, Draw = 8, Lose = 10, GF = 56, GA = 38, GD = 18, Pts = 53 });

            Team.Add(new TeamsView() { ID = 8, Name = "Everton", MP = 32, Win = 15, Draw = 7, Lose = 10, GF = 44, GA = 40, GD = 4, Pts = 52 });

            Team.Add(new TeamsView() { ID = 9, Name = "Leeds United", MP = 33, Win = 14, Draw = 5, Lose = 14, GF = 50, GA = 50, GD = 0, Pts = 47 });

            Team.Add(new TeamsView() { ID = 10, Name = "Arsenal", MP = 33, Win = 13, Draw = 7, Lose = 13, GF = 44, GA = 37, GD = 7, Pts = 46 });
        }

        public List<TeamsView> getAllTeams()
        {
            return Team;
        }

    }
}
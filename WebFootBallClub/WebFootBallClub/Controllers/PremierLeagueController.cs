using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebFootBallClub.Models;
using WebFootBallClub.Controllers;

namespace WebFootBallClub.Controllers
{
    public class PremierLeagueController : Database
    {
        public List<TeamsView> Team = new List<TeamsView>();
        public List<Player> Players = new List<Player>();
        public PremierLeagueController()
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

            LoadPlayerData();
        }

        public List<TeamsView> getAllTeams()
        {
            return Team;
        }

        public string getTeamName(int TeamId)
        {
            return Team.First(x => x.ID == TeamId).Name;
        }

        public List<Player> getTeamPlayers(int TeamId)
        {
            return Players.Where(x => x.TeamId == TeamId)?.ToList();
        }

        public void LoadPlayerData()
        {

            Players.Add(new Player() { ID = 1, TeamId = 1, Name = "Ilkay Gündogan", Goals = 16, Assist = 3, Played = 40, TotalShots = 48, GoalConversion = 33, ShotAccuracy = 52 });

            Players.Add(new Player() { ID = 2, TeamId = 1, Name = " Phil Foden", Goals = 14, Assist = 9, Played = 44, TotalShots = 67, GoalConversion = 21, ShotAccuracy = 55 });

            Players.Add(new Player() { ID = 3, TeamId = 1, Name = " Raheem Sterling", Goals = 13, Assist = 9, Played = 43, TotalShots = 69, GoalConversion = 19, ShotAccuracy = 61 });

            Players.Add(new Player() { ID = 4, TeamId = 1, Name = " Gabriel Jesus", Goals = 13, Assist = 3, Played = 35, TotalShots = 44, GoalConversion = 30, ShotAccuracy = 59 });

            Players.Add(new Player() { ID = 5, TeamId = 1, Name = " Riyad Mahrez", Goals = 11, Assist = 7, Played = 43, TotalShots = 64, GoalConversion = 17, ShotAccuracy = 56 });

            Players.Add(new Player() { ID = 6, TeamId = 1, Name = " Ferran Torres", Goals = 9, Assist = 3, Played = 31, TotalShots = 38, GoalConversion = 24, ShotAccuracy = 58 });

            Players.Add(new Player() { ID = 7, TeamId = 1, Name = " Kevin De Bruyne", Goals = 8, Assist = 17, Played = 36, TotalShots = 63, GoalConversion = 13, ShotAccuracy = 49 });

            Players.Add(new Player() { ID = 8, TeamId = 1, Name = " Bernardo Silva", Goals = 5, Assist = 9, Played = 40, TotalShots = 35, GoalConversion = 14, ShotAccuracy = 57 });

            Players.Add(new Player() { ID = 9, TeamId = 1, Name = " John Stones", Goals = 5, Assist = 0, Played = 30, TotalShots = 12, GoalConversion = 42, ShotAccuracy = 50 });

            Players.Add(new Player() { ID = 10, TeamId = 1, Name = " Sergio Agüero", Goals = 3, Assist = 0, Played = 15, TotalShots = 10, GoalConversion = 30, ShotAccuracy = 60 });

            Players.Add(new Player() { ID = 1, TeamId = 2, Name = " Bruno Fernandes", Goals = 24, Assist = 14, Played = 51, TotalShots = 108, GoalConversion = 22, ShotAccuracy = 62 });

            Players.Add(new Player() { ID = 2, TeamId = 2, Name = " Marcus Rashford", Goals = 20, Assist = 11, Played = 50, TotalShots = 81, GoalConversion = 25, ShotAccuracy = 72 });

            Players.Add(new Player() { ID = 3, TeamId = 2, Name = " Edinson Cavani", Goals = 10, Assist = 2, Played = 32, TotalShots = 34, GoalConversion = 29, ShotAccuracy = 56 });

            Players.Add(new Player() { ID = 4, TeamId = 2, Name = " Mason Greenwood", Goals = 9, Assist = 5, Played = 45, TotalShots = 61, GoalConversion = 15, ShotAccuracy = 54 });

            Players.Add(new Player() { ID = 5, TeamId = 2, Name = " Anthony Martial", Goals = 7, Assist = 5, Played = 36, TotalShots = 49, GoalConversion = 14, ShotAccuracy = 63 });

            Players.Add(new Player() { ID = 6, TeamId = 2, Name = " Scott McTominay", Goals = 9, Assist = 3, Played = 31, TotalShots = 38, GoalConversion = 24, ShotAccuracy = 58 });

            Players.Add(new Player() { ID = 7, TeamId = 2, Name = " Paul Pogba", Goals = 5, Assist = 6, Played = 36, TotalShots = 35, GoalConversion = 14, ShotAccuracy = 43 });

            Players.Add(new Player() { ID = 8, TeamId = 2, Name = " Daniel James", Goals = 5, Assist = 1, Played = 24, TotalShots = 17, GoalConversion = 29, ShotAccuracy = 71 });

            Players.Add(new Player() { ID = 9, TeamId = 2, Name = " Juan Mata", Goals = 2, Assist = 3, Played = 13, TotalShots = 10, GoalConversion = 20, ShotAccuracy = 90 });

            Players.Add(new Player() { ID = 10, TeamId = 2, Name = " Aaron Wan-Bissaka", Goals = 2, Assist = 3, Played = 48, TotalShots = 6, GoalConversion = 33, ShotAccuracy = 67 });
            Players.Add(new Player() { ID = 1, TeamId = 3, Name = " Kelechi Iheanacho ", Goals = 17, Assist = 5, Played = 33, TotalShots = 42, GoalConversion = 40, ShotAccuracy = 64 });

            Players.Add(new Player() { ID = 2, TeamId = 3, Name = " Jamie Vardy ", Goals = 15, Assist = 8, Played = 36, TotalShots = 65, GoalConversion = 23, ShotAccuracy = 57 });

            Players.Add(new Player() { ID = 3, TeamId = 3, Name = " Harvey Barnes ", Goals = 13, Assist = 4, Played = 35, TotalShots = 58, GoalConversion = 22, ShotAccuracy = 62 });

            Players.Add(new Player() { ID = 4, TeamId = 3, Name = " James Maddison ", Goals = 11, Assist = 7, Played = 36, TotalShots = 62, GoalConversion = 18, ShotAccuracy = 42 });

            Players.Add(new Player() { ID = 5, TeamId = 3, Name = " Youri Tielemans ", Goals = 8, Assist = 5, Played = 45, TotalShots = 38, GoalConversion = 21, ShotAccuracy = 61 });

            Players.Add(new Player() { ID = 6, TeamId = 3, Name = " James Justin ", Goals = 3, Assist = 1, Played = 31, TotalShots = 10, GoalConversion = 30, ShotAccuracy = 40 });

            Players.Add(new Player() { ID = 7, TeamId = 3, Name = " Ayoze PérezPérez ", Goals = 3, Assist = 0, Played = 30, TotalShots = 23, GoalConversion = 13, ShotAccuracy = 52 });

            Players.Add(new Player() { ID = 8, TeamId = 3, Name = " Timothy Castagne ", Goals = 2, Assist = 4, Played = 28, TotalShots = 5, GoalConversion = 40, ShotAccuracy = 60 });

            Players.Add(new Player() { ID = 9, TeamId = 3, Name = " Cengiz Ünder ", Goals = 2, Assist = 3, Played = 19, TotalShots = 25, GoalConversion = 8, ShotAccuracy = 56 });

            Players.Add(new Player() { ID = 10, TeamId = 3, Name = " Dennis Praet ", Goals = 2, Assist = 2, Played = 24, TotalShots = 9, GoalConversion = 22, ShotAccuracy = 56 });

            Players.Add(new Player() { ID = 1, TeamId = 4, Name = " Tammy Abraham", Goals = 12, Assist = 4, Played = 31, TotalShots = 42, GoalConversion = 29, ShotAccuracy = 50 });

            Players.Add(new Player() { ID = 2, TeamId = 4, Name = " Timo Werner", Goals = 11, Assist = 9, Played = 44, TotalShots = 73, GoalConversion = 15, ShotAccuracy = 58 });

            Players.Add(new Player() { ID = 3, TeamId = 4, Name = " Olivier Giroud", Goals = 11, Assist = 0, Played = 27, TotalShots = 35, GoalConversion = 31, ShotAccuracy = 60 });

            Players.Add(new Player() { ID = 4, TeamId = 4, Name = " Mason Mount", Goals = 8, Assist = 6, Played = 46, TotalShots = 60, GoalConversion = 13, ShotAccuracy = 45 });

            Players.Add(new Player() { ID = 5, TeamId = 4, Name = " Jorginho", Goals = 7, Assist = 2, Played = 35, TotalShots = 15, GoalConversion = 47, ShotAccuracy = 60 });

            Players.Add(new Player() { ID = 6, TeamId = 4, Name = " Kai Havertz", Goals = 6, Assist = 6, Played = 38, TotalShots = 31, GoalConversion = 19, ShotAccuracy = 65 });

            Players.Add(new Player() { ID = 7, TeamId = 4, Name = " Callum Hudson-Odoi", Goals = 5, Assist = 5, Played = 34, TotalShots = 23, GoalConversion = 22, ShotAccuracy = 52 });

            Players.Add(new Player() { ID = 8, TeamId = 4, Name = " Hakim Ziyech", Goals = 5, Assist = 4, Played = 32, TotalShots = 29, GoalConversion = 17, ShotAccuracy = 62 });

            Players.Add(new Player() { ID = 9, TeamId = 4, Name = " Christian Pulisic", Goals = 5, Assist = 2, Played = 35, TotalShots = 41, GoalConversion = 12, ShotAccuracy = 51 });

            Players.Add(new Player() { ID = 10, TeamId = 4, Name = " Kurt Zouma", Goals = 5, Assist = 0, Played = 32, TotalShots = 22, GoalConversion = 23, ShotAccuracy = 55 });

            Players.Add(new Player() { ID = 1, TeamId = 5, Name = " Jesse Lingard", Goals = 9, Assist = 3, Played = 11, TotalShots = 25, GoalConversion = 36, ShotAccuracy = 76 });

            Players.Add(new Player() { ID = 2, TeamId = 5, Name = " Tomas Soucek", Goals = 9, Assist = 1, Played = 36, TotalShots = 42, GoalConversion = 21, ShotAccuracy = 50 });

            Players.Add(new Player() { ID = 3, TeamId = 5, Name = " Jarrod Bowen", Goals = 8, Assist = 6, Played = 35, TotalShots = 29, GoalConversion = 28, ShotAccuracy = 48 });

            Players.Add(new Player() { ID = 4, TeamId = 5, Name = " Michail Antonio", Goals = 7, Assist = 5, Played = 22, TotalShots = 39, GoalConversion = 18, ShotAccuracy = 56 });

            Players.Add(new Player() { ID = 5, TeamId = 5, Name = " Sébastien Haller", Goals = 7, Assist = 0, Played = 19, TotalShots = 30, GoalConversion = 23, ShotAccuracy = 53 });

            Players.Add(new Player() { ID = 6, TeamId = 5, Name = " Pablo Fornals", Goals = 4, Assist = 3, Played = 31, TotalShots = 25, GoalConversion = 16, ShotAccuracy = 48 });

            Players.Add(new Player() { ID = 7, TeamId = 5, Name = " Craig Dawson", Goals = 4, Assist = 0, Played = 19, TotalShots = 13, GoalConversion = 31, ShotAccuracy = 46 });

            Players.Add(new Player() { ID = 8, TeamId = 5, Name = " Andriy Yarmolenko", Goals = 3, Assist = 4, Played = 20, TotalShots = 14, GoalConversion = 21, ShotAccuracy = 43 });

            Players.Add(new Player() { ID = 9, TeamId = 5, Name = " Robert Snodgrass", Goals = 2, Assist = 1, Played = 6, TotalShots = 7, GoalConversion = 29, ShotAccuracy = 57 });

            Players.Add(new Player() { ID = 10, TeamId = 5, Name = " Issa Diop ", Goals = 2, Assist = 0, Played = 17, TotalShots = 3, GoalConversion = 67, ShotAccuracy = 67 });

            Players.Add(new Player() { ID = 1, TeamId = 6, Name = " Mohamed Salah", Goals = 29, Assist = 4, Played = 46, TotalShots = 108, GoalConversion = 28, ShotAccuracy = 63 });

            Players.Add(new Player() { ID = 2, TeamId = 6, Name = " Sadio Mané", Goals = 13, Assist = 6, Played = 43, TotalShots = 84, GoalConversion = 15, ShotAccuracy = 55 });

            Players.Add(new Player() { ID = 3, TeamId = 6, Name = " Diogo Jota", Goals = 12, Assist = 1, Played = 27, TotalShots = 69, GoalConversion = 19, ShotAccuracy = 61 });

            Players.Add(new Player() { ID = 4, TeamId = 6, Name = " Roberto Firmino", Goals = 6, Assist = 7, Played = 43, TotalShots = 63, GoalConversion = 10, ShotAccuracy = 52 });

            Players.Add(new Player() { ID = 5, TeamId = 6, Name = " Curtis Jones", Goals = 4, Assist = 4, Played = 31, TotalShots = 25, GoalConversion = 16, ShotAccuracy = 76 });

            Players.Add(new Player() { ID = 6, TeamId = 6, Name = " Takumi Minamino", Goals = 4, Assist = 2, Played = 17, TotalShots = 12, GoalConversion = 33, ShotAccuracy = 75 });

            Players.Add(new Player() { ID = 7, TeamId = 6, Name = " Georginio Wijnaldum", Goals = 3, Assist = 0, Played = 46, TotalShots = 24, GoalConversion = 13, ShotAccuracy = 46 });

            Players.Add(new Player() { ID = 8, TeamId = 6, Name = " Trent Alexander-Arnold", Goals = 2, Assist = 7, Played = 40, TotalShots = 29, GoalConversion = 7, ShotAccuracy = 38 });

            Players.Add(new Player() { ID = 9, TeamId = 6, Name = " Andrew Robertson", Goals = 1, Assist = 5, Played = 45, TotalShots = 17, GoalConversion = 6, ShotAccuracy = 29 });

            Players.Add(new Player() { ID = 10, TeamId = 6, Name = " Xherdan Shaqiri", Goals = 1, Assist = 4, Played = 21, TotalShots = 7, GoalConversion = 14, ShotAccuracy = 14 });
            Players.Add(new Player() { ID = 1, TeamId = 7, Name = "Harry Kane", Goals = 26, Assist = 15, Played = 41, TotalShots = 119, GoalConversion = 22, ShotAccuracy = 50 });

            Players.Add(new Player() { ID = 2, TeamId = 7, Name = "Son Heung-Min", Goals = 19, Assist = 14, Played = 44, TotalShots = 61, GoalConversion = 31, ShotAccuracy = 67 });

            Players.Add(new Player() { ID = 3, TeamId = 7, Name = "Gareth Bale", Goals = 11, Assist = 3, Played = 29, TotalShots = 51, GoalConversion = 22, ShotAccuracy = 45 });

            Players.Add(new Player() { ID = 4, TeamId = 7, Name = "Carlos Vinicius", Goals = 10, Assist = 3, Played = 22, TotalShots = 27, GoalConversion = 37, ShotAccuracy = 63 });

            Players.Add(new Player() { ID = 5, TeamId = 7, Name = "Lucas Moura", Goals = 8, Assist = 7, Played = 45, TotalShots = 32, GoalConversion = 25, ShotAccuracy = 38 });

            Players.Add(new Player() { ID = 6, TeamId = 7, Name = "Tanguy Ndombele", Goals = 5, Assist = 4, Played = 41, TotalShots = 16, GoalConversion = 31, ShotAccuracy = 63 });

            Players.Add(new Player() { ID = 7, TeamId = 7, Name = "Giovani Lo Celso", Goals = 3, Assist = 1, Played = 22, TotalShots = 18, GoalConversion = 17, ShotAccuracy = 61 });

            Players.Add(new Player() { ID = 8, TeamId = 7, Name = "Erik Lamela", Goals = 3, Assist = 1, Played = 31, TotalShots = 29, GoalConversion = 10, ShotAccuracy = 66 });

            Players.Add(new Player() { ID = 9, TeamId = 7, Name = "Dele Alli", Goals = 2, Assist = 4, Played = 22, TotalShots = 16, GoalConversion = 13, ShotAccuracy = 69 });

            Players.Add(new Player() { ID = 10, TeamId = 7, Name = "Harry Winks", Goals = 2, Assist = 2, Played = 24, TotalShots = 13, GoalConversion = 15, ShotAccuracy = 31 });

            Players.Add(new Player() { ID = 1, TeamId = 8, Name = "Dominic Calvert-Lewin", Goals = 19, Assist = 1, Played = 33, TotalShots = 73, GoalConversion = 26, ShotAccuracy = 66 });

            Players.Add(new Player() { ID = 2, TeamId = 8, Name = "Richarlisom", Goals = 12, Assist = 3, Played = 34, TotalShots = 64, GoalConversion = 19, ShotAccuracy = 55 });

            Players.Add(new Player() { ID = 3, TeamId = 8, Name = "Gylfi sigurdsson", Goals = 8, Assist = 9, Played = 38, TotalShots = 36, GoalConversion = 22, ShotAccuracy = 53 });

            Players.Add(new Player() { ID = 4, TeamId = 8, Name = "James Rodriguez", Goals = 6, Assist = 8, Played = 25, TotalShots = 29, GoalConversion = 21, ShotAccuracy = 62 });

            Players.Add(new Player() { ID = 5, TeamId = 8, Name = "Michael Keane", Goals = 4, Assist = 2, Played = 36, TotalShots = 17, GoalConversion = 24, ShotAccuracy = 41 });

            Players.Add(new Player() { ID = 6, TeamId = 8, Name = "Abdoulaye Doucoure", Goals = 3, Assist = 3, Played = 30, TotalShots = 12, GoalConversion = 25, ShotAccuracy = 50 });

            Players.Add(new Player() { ID = 7, TeamId = 8, Name = "Bernard", Goals = 3, Assist = 1, Played = 15, TotalShots = 14, GoalConversion = 21, ShotAccuracy = 57 });

            Players.Add(new Player() { ID = 8, TeamId = 8, Name = "Yerry Mina", Goals = 3, Assist = 0, Played = 27, TotalShots = 15, GoalConversion = 20, ShotAccuracy = 40 });

            Players.Add(new Player() { ID = 9, TeamId = 8, Name = "Alex Iwobi", Goals = 2, Assist = 3, Played = 33, TotalShots = 11, GoalConversion = 18, ShotAccuracy = 36 });

            Players.Add(new Player() { ID = 10, TeamId = 8, Name = "Moise Kean", Goals = 2, Assist = 0, Played = 4, TotalShots = 6, GoalConversion = 33, ShotAccuracy = 33 });
            Players.Add(new Player() { ID = 1, TeamId = 9, Name = "Patrick Bamford", Goals = 14, Assist = 7, Played = 33, TotalShots = 81, GoalConversion = 17, ShotAccuracy = 49 });

            Players.Add(new Player() { ID = 2, TeamId = 9, Name = "Jack Harrison", Goals = 7, Assist = 6, Played = 32, TotalShots = 32, GoalConversion = 22, ShotAccuracy = 50 });

            Players.Add(new Player() { ID = 3, TeamId = 9, Name = "Stuart Dallas", Goals = 7, Assist = 2, Played = 33, TotalShots = 28, GoalConversion = 25, ShotAccuracy = 57 });

            Players.Add(new Player() { ID = 4, TeamId = 9, Name = "Raphinha", Goals = 6, Assist = 6, Played = 27, TotalShots = 46, GoalConversion = 13, ShotAccuracy = 48 });

            Players.Add(new Player() { ID = 5, TeamId = 9, Name = "Mateusz Klich", Goals = 3, Assist = 5, Played = 32, TotalShots = 25, GoalConversion = 12, ShotAccuracy = 36 });

            Players.Add(new Player() { ID = 6, TeamId = 9, Name = "Helder Costa", Goals = 3, Assist = 3, Played = 23, TotalShots = 13, GoalConversion = 23, ShotAccuracy = 54 });

            Players.Add(new Player() { ID = 7, TeamId = 9, Name = "Rodrigo Moreno", Goals = 3, Assist = 1, Played = 23, TotalShots = 30, GoalConversion = 10, ShotAccuracy = 47 });

            Players.Add(new Player() { ID = 8, TeamId = 9, Name = "Ezgjan Alioski", Goals = 3, Assist = 1, Played = 33, TotalShots = 18, GoalConversion = 17, ShotAccuracy = 44 });

            Players.Add(new Player() { ID = 9, TeamId = 9, Name = "Diego Llorente", Goals = 1, Assist = 0, Played = 11, TotalShots = 3, GoalConversion = 33, ShotAccuracy = 100 });

            Players.Add(new Player() { ID = 10, TeamId = 9, Name = "Pascal Struijk", Goals = 1, Assist = 0, Played = 24, TotalShots = 7, GoalConversion = 14, ShotAccuracy = 43 });

            Players.Add(new Player() { ID = 1, TeamId = 10, Name = "Alexandre Lacazette", Goals = 17, Assist = 3, Played = 39, TotalShots = 54, GoalConversion = 31, ShotAccuracy = 65 });

            Players.Add(new Player() { ID = 2, TeamId = 10, Name = "Pierre-Emerick Aubameyang", Goals = 14, Assist = 2, Played = 33, TotalShots = 59, GoalConversion = 24, ShotAccuracy = 53 });

            Players.Add(new Player() { ID = 3, TeamId = 10, Name = "Nicolas Pepe", Goals = 10, Assist = 5, Played = 41, TotalShots = 62, GoalConversion = 16, ShotAccuracy = 45 });

            Players.Add(new Player() { ID = 4, TeamId = 10, Name = "Bukayo Saka", Goals = 7, Assist = 6, Played = 40, TotalShots = 46, GoalConversion = 15, ShotAccuracy = 52 });

            Players.Add(new Player() { ID = 5, TeamId = 10, Name = "Eddie Nketiah", Goals = 6, Assist = 1, Played = 28, TotalShots = 31, GoalConversion = 19, ShotAccuracy = 48 });

            Players.Add(new Player() { ID = 6, TeamId = 10, Name = "Joseph Willock", Goals = 3, Assist = 3, Played = 17, TotalShots = 12, GoalConversion = 25, ShotAccuracy = 50 });

            Players.Add(new Player() { ID = 7, TeamId = 10, Name = "Gabriel Magalhaes", Goals = 3, Assist = 1, Played = 27, TotalShots = 13, GoalConversion = 23, ShotAccuracy = 46 });

            Players.Add(new Player() { ID = 8, TeamId = 10, Name = "Emile Smith Rowe", Goals = 2, Assist = 7, Played = 27, TotalShots = 10, GoalConversion = 20, ShotAccuracy = 60 });

            Players.Add(new Player() { ID = 9, TeamId = 10, Name = "Kieran Tierney", Goals = 2, Assist = 3, Played = 33, TotalShots = 13, GoalConversion = 15, ShotAccuracy = 31 });
            Players.Add(new Player() { ID = 10, TeamId = 10, Name = "Folarin Balogun", Goals = 2, Assist = 1, Played = 6, TotalShots = 3, GoalConversion = 67, ShotAccuracy = 67 });


        }

    }
}
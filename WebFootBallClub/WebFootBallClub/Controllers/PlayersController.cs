using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebFootBallClub.Models;

namespace WebFootBallClub.Controllers
{
    public class PlayersController : Controller
    {
        public List<Players> Team = new List<Players>();
        public PlayersController()
        {
            
        }

        private void LoanPlayerInformation()
        {

        }
    }
}
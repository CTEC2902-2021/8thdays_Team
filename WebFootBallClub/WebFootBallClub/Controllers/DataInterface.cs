using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFootBallClub.Models;

namespace WebFootBallClub.Controllers
{
    public interface DataInterface
    {
        List<TeamsView> getAllTeams();
        List<Player> getTeamPlayers(int TeamId);
        string getTeamName(int TeamId);
    }
}

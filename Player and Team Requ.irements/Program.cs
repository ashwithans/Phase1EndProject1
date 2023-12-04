using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_and_Team_Requ.irements
{
        internal class Program
        {
            static void Main(string[] args)
            {
                CricketTeam team = new CricketTeam();
                CricketTeamUI teamUI = new CricketTeamUI(team);
                teamUI.Run();
            }
        }
}










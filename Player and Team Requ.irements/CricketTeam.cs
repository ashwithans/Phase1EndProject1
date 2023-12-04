using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_and_Team_Requ.irements
{
    internal class CricketTeam
    {
        private List<Player> players;

        public CricketTeam()
        {
            players = new List<Player>();
        }

        public int PlayerCount => players.Count;

        public void AddPlayer(Player player)
        {
            players.Add(player);
            Console.WriteLine("Player added to the team.");
        }

        public void RemovePlayer(int playerId)
        {
            Player playerToRemove = players.FirstOrDefault(p => p.Id == playerId);
            if (playerToRemove != null)
            {
                players.Remove(playerToRemove);
                Console.WriteLine("Player removed from the team.");
            }
            else
            {
                Console.WriteLine("Player not found in the team.");
            }
        }

        public Player GetPlayerById(int playerId)
        {
            return players.FirstOrDefault(p => p.Id == playerId);
        }

        public List<Player> GetPlayersByName(string playerName)
        {
            return players.Where(p => p.Name.Equals(playerName, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Player> GetAllPlayers()
        {
            return players.ToList();
        }
    }
}

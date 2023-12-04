using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_and_Team_Requ.irements
{
    internal class CricketTeamUI
    {
        private readonly CricketTeam team;

        public CricketTeamUI(CricketTeam cricketTeam)
        {
            team = cricketTeam;
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add Player");
                Console.WriteLine("2. Remove Player");
                Console.WriteLine("3. Get Player by Id");
                Console.WriteLine("4. Get Players by Name");
                Console.WriteLine("5. Get All Players");
                Console.WriteLine("6. Exit");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            if (team.PlayerCount < 11)
                            {
                                Console.WriteLine("Enter Player Id:");
                                int playerId = int.Parse(Console.ReadLine());

                                Console.WriteLine("Enter Player Name:");
                                string playerName = Console.ReadLine();

                                Console.WriteLine("Enter Player Age:");
                                int playerAge = int.Parse(Console.ReadLine());

                                team.AddPlayer(new Player { Id = playerId, Name = playerName, Age = playerAge });
                            }
                            else
                            {
                                Console.WriteLine("Cannot add more players. Team already has 11 members.");
                            }
                            break;

                        case 2:
                            Console.WriteLine("Enter Player Id to remove:");
                            int playerIdToRemove = int.Parse(Console.ReadLine());

                            team.RemovePlayer(playerIdToRemove);
                            break;

                        case 3:
                            Console.WriteLine("Enter Player Id to get details:");
                            int playerIdToGet = int.Parse(Console.ReadLine());

                            Player playerById = team.GetPlayerById(playerIdToGet);
                            if (playerById != null)
                            {
                                Console.WriteLine($"Player Found: Id: {playerById.Id}, Name: {playerById.Name}, Age: {playerById.Age}");
                            }
                            else
                            {
                                Console.WriteLine("Player not found.");
                            }
                            break;

                        case 4:
                            Console.WriteLine("Enter Player Name to get details:");
                            string playerNameToGet = Console.ReadLine();

                            List<Player> playersByName = team.GetPlayersByName(playerNameToGet);
                            if (playersByName.Count > 0)
                            {
                                Console.WriteLine($"Players Found with name '{playerNameToGet}':");
                                foreach (Player player in playersByName)
                                {
                                    Console.WriteLine($"Id: {player.Id}, Name: {player.Name}, Age: {player.Age}");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"No players found with name '{playerNameToGet}'.");
                            }
                            break;

                        case 5:
                            List<Player> allPlayers = team.GetAllPlayers();
                            Console.WriteLine("All Players:");
                            foreach (Player player in allPlayers)
                            {
                                Console.WriteLine($"Id: {player.Id}, Name: {player.Name}, Age: {player.Age}");
                            }
                            break;

                        case 6:
                            Console.WriteLine("Exiting the program.");
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

                Console.ReadLine();
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CopaCabana
{
    public class DodgeballTeam
    {
        private int TeamID;
        private string TeamName;
        private List<DodgeballPlayer> Players;
        private int TeamPoints = 0;
       

        public void setTeamPoints()
        {
            TeamPoints += 3;
        }


        public int getTeamPoints()
        {
            return TeamPoints;
        }

        public void setTeamID(int id)
        {
            TeamID = id;
        }

        public int getTeamID()
        {
            return TeamID;
        }

        public void setTeamName(string name)
        {
            TeamName = name;
        }

        public string getTeamName()
        {
            return TeamName;
        }

        public List<DodgeballPlayer> getPlayers()
        {
            return Players;
        }

        public void AddPlayer(DodgeballPlayer playerID)
        {

            StreamWriter streamWriter = new StreamWriter("Players.txt", true);
            
            if (Players.Count >= 5)
            {
                Console.WriteLine("Druzyna ma zbyt wielu zawodnikow");
            }
            else
            {
                Players.Add(playerID);
            }
            foreach (DodgeballPlayer player in Players)
            {
                streamWriter.WriteLine(player);
            }
        }

        public void DeletePlayer(DodgeballPlayer playerID)
        {
            if (Players.Count <= 0)
            {
                Console.WriteLine("Druzyna nie ma zawodnikow");
            }
            else
            {
                StreamReader streamReader = new StreamReader("Players.txt");
                
                foreach (DodgeballPlayer player in Players)
                {
                    if(player == playerID)
                    {
                        Players.Remove(player);
                    }
                }
            }

        }

        public void ChangePlayer(DodgeballPlayer playerID)
        {

            DeletePlayer(playerID);
            AddPlayer(playerID);
        }
    }
}

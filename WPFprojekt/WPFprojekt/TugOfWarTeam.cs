using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CopaCabana
{
    public class TugOfWarTeam
    {
        private int TeamID;
        private string TeamName;
        private List<TugOfWarPlayer> Players;
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

        public List<TugOfWarPlayer> getPlayers()
        {
            return Players;
        }

        public void AddPlayer(TugOfWarPlayer playerID)
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
            foreach (TugOfWarPlayer player in Players)
            {
                streamWriter.WriteLine(player);
            }
        }

        public void DeletePlayer(TugOfWarPlayer playerID)
        {
            if (Players.Count <= 0)
            {
                Console.WriteLine("Druzyna nie ma zawodnikow");
            }
            else
            {
                StreamReader streamReader = new StreamReader("Players.txt");

                foreach (TugOfWarPlayer player in Players)
                {
                    if (player == playerID)
                    {
                        Players.Remove(player);
                    }
                }
            }
        }

        public void ChangePlayer(TugOfWarPlayer playerID)
        {
            DeletePlayer(playerID);
            AddPlayer(playerID);
        }


    }
}

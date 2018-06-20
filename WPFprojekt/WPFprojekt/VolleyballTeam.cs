using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WPFprojekt
{
    public class VolleyballTeam
    {
        
        private string TeamName;
        private List<VolleyballPlayer> Players;
        private int TeamPoints=0;


        public void setTeamPoints()
        {
            TeamPoints += 3;
        }

        public int getTeamPoints()
        {
            return TeamPoints;
        }


        public void setTeamName(string name)
        {
            TeamName = name;
        }

        public string getTeamName()
        {
            return TeamName;
        }

        public List<VolleyballPlayer> getPlayers()
        {
            return Players;
        }

        public VolleyballTeam(string name)
        {
            TeamName = name;
        }

        public void AddPlayer()
        {
            StreamWriter streamWriter = new StreamWriter("Players.txt", true);

         

            if (Players.Count >= 5)
            {
                Console.WriteLine("Druzyna ma zbyt wielu zawodnikow");
            }
            else
            {
                string imie;
                string nazwisko;
                imie = Console.ReadLine();
                nazwisko = Console.ReadLine();
                VolleyballPlayer player = new VolleyballPlayer(imie, nazwisko);
                Players.Add(player);
            }
            foreach (VolleyballPlayer player in Players)
            {
                streamWriter.WriteLine(player);
            }

        }

        public void DeletePlayer()
        {
            if (Players.Count <= 0)
            {
                Console.WriteLine("Druzyna nie ma zawodnikow");
            }
            else
            {
                StreamReader streamReader = new StreamReader("Players.txt");

                string imie;
                string nazwisko;
                imie = Console.ReadLine();
                nazwisko = Console.ReadLine();
                VolleyballPlayer newPlayer = new VolleyballPlayer(imie, nazwisko);

                foreach (VolleyballPlayer player in Players)
                {

                    if (player == newPlayer)
                    {
                        Players.Remove(player);
                    }
                }
            }
        }

        public void ChangePlayer()
        {
            DeletePlayer();
            AddPlayer();
        }



    }
}

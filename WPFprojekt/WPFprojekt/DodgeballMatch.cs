using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFprojekt
{
    public class DodgeballMatch
    {
        private int MatchID;
        private DodgeballReferee MainReferee;
        private DodgeballTeam Team1;
        private DodgeballTeam Team2;


        public DodgeballReferee getMainReferee()
        {
            return MainReferee;
        }

        public DodgeballTeam getTeam1()
        {
            return Team1;
        }

        public DodgeballTeam getTeam2()
        {
            return Team2;
        }

        public void setMatchID(int ID)
        {
            MatchID = ID;
        }

        public int getMatchID()
        {
            return MatchID;
        }

        public void AddMainReferee(DodgeballReferee referee)
        {
            MainReferee = referee;
        }

        public void AddTeam1(DodgeballTeam Team)
        {
            Team1 = Team;
        }
        public void AddTeam2(DodgeballTeam Team)
        {
            Team2 = Team;
        }

        public DodgeballTeam SetWinner()
        {
            int score1, score2;
            Console.WriteLine("Podaj wynik 1 druzyny: ");
            score1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wynik 2 druzyny: ");
            score2 = int.Parse(Console.ReadLine());

            if (score1 == score2)
            {
                Console.WriteLine("Nie moze byc remisu!");
                SetWinner();
            }
            if (score1 > score2)
            {
                Team1.setTeamPoints();
                return Team1;
            }
            else
            {
                Team2.setTeamPoints();
                return Team2;
            }


        }
    }
}

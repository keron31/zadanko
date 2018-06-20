using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopaCabana
{
    public class TugOfWarMatch
    {
        private int MatchID;
        private TugOfWarReferee MainReferee;
        private TugOfWarTeam Team1;
        private TugOfWarTeam Team2;


        public TugOfWarReferee getMainReferee()
        {
            return MainReferee;
        }


        public TugOfWarTeam getTeam1()
        {
            return Team1;
        }

        public TugOfWarTeam getTeam2()
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

        public void AddMainReferee(TugOfWarReferee Referee)
        {
            MainReferee = Referee;
        }

        public void AddTeam1(TugOfWarTeam Team)
        {
            Team1 = Team;
        }
        public void AddTeam2(TugOfWarTeam Team)
        {
            Team2 = Team;
        }
        public TugOfWarTeam SetWinner()
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

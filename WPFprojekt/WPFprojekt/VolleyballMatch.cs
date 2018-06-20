using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFprojekt
{
    public class VolleyballMatch
    {
        private VolleyballReferee MainReferee;
        private VolleyballAssistantReferee AssistantReferee1;
        private VolleyballAssistantReferee AssistantReferee2;
        private VolleyballTeam Team1;
        private VolleyballTeam Team2;



        public VolleyballReferee getMainReferee()
        {
            return MainReferee;
        }


        public VolleyballAssistantReferee getAssistantReferee1()
        {
            return AssistantReferee1;
        }


        public VolleyballAssistantReferee getAssistantReferee2()
        {
            return AssistantReferee2;
        }


        public VolleyballTeam getTeam1()
        {
            return Team1;
        }


        public VolleyballTeam getTeam2()
        {
            return Team2;
        }


        public void AddMainReferee()
        {
            string imie;
            string nazwisko;
            imie = Console.ReadLine();
            nazwisko = Console.ReadLine();
            VolleyballReferee mainReferee = new VolleyballReferee(imie, nazwisko);
            MainReferee = mainReferee;
        }

        public void AddTeam1(VolleyballTeam Team)
        {
            Team1 = Team;                              //PotrzebneZastanowienie
        }
        public void AddTeam2(VolleyballTeam Team)
        {
            Team2 = Team;
        }

        public void AddAssistantReferee1()
        {
            string imie;
            string nazwisko;
            imie = Console.ReadLine();
            nazwisko = Console.ReadLine();
            VolleyballAssistantReferee AssistantReferee = new VolleyballAssistantReferee(imie, nazwisko);
            AssistantReferee1 = AssistantReferee;
        }

        public void AddAssistantReferee2()
        {
            string imie;
            string nazwisko;
            imie = Console.ReadLine();
            nazwisko = Console.ReadLine();
            VolleyballAssistantReferee AssistantReferee = new VolleyballAssistantReferee(imie, nazwisko);
            AssistantReferee2 = AssistantReferee;
        }

        public VolleyballTeam SetWinner()
        {
            int score1, score2;
            Console.WriteLine("Podaj wynik 1 druzyny: ");
            score1= int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wynik 2 druzyny: ");
            score2 = int.Parse(Console.ReadLine());
            if (score1==score2)
            {
                Console.WriteLine("Nie moze byc remisu!");
                    SetWinner();
            }
            if  (score1 > score2)
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

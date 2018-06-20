using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CopaCabana
{
    public class VolleyballGroupStage
    {
        private List<VolleyballReferee> Referees;
        private List<VolleyballAssistantReferee> AssistantReferees;
        private List<VolleyballPlayer> Players;
        private List<VolleyballTeam> Teams;


        public List<VolleyballPlayer> getPlayers()
        {
            return Players;
        }

        public List<VolleyballReferee> getReferees()
        {
            return Referees;
        }

        public List<VolleyballAssistantReferee> getAssistantReferees()
        {
            return AssistantReferees;
        }

        public void CreateSchedule()
        {
            foreach (VolleyballTeam team in Teams)
            {
                Console.WriteLine(team);
            }
        }

        public void DisplayReferees()
        {
            foreach (VolleyballReferee person in Referees)
            {
                Console.WriteLine(person);
            }
        }

        public void DisplayAssistantReferees()
        {
            foreach (VolleyballAssistantReferee person in AssistantReferees)
            {
                Console.WriteLine(person);
            }
        }

        public void DisplayPlayers()
        {
            foreach (VolleyballPlayer person in Players)
            {
                Console.WriteLine(person);
            }
        }



        public void SortSchedule()
        {

            Teams.Sort((a, b) => a.getTeamPoints().CompareTo(b.getTeamPoints()));
        }

        public void AddReferee()
        {

            StreamWriter streamWriter = new StreamWriter("Referees.txt", true);



            if (Referees.Count >= 1)
            {
                Console.WriteLine("W grze moze byc tylko jeden sedzia glowny. ");
                Console.WriteLine("W meczu moze byc tylko jeden sedzia glowny. ");
            }
            else
            {

                string imie;
                string nazwisko;
                imie = Console.ReadLine();
                nazwisko = Console.ReadLine();
                VolleyballReferee referee = new VolleyballReferee(imie, nazwisko);
                Referees.Add(referee);
            }
            foreach (VolleyballReferee referee in Referees)
            {
                streamWriter.WriteLine(referee);
            }


        }


        public void AddAssistantReferee()
        {
            StreamWriter streamWriter = new StreamWriter("AssistantReferees.txt", true);

            if (AssistantReferees.Count >= 2)
            {

                Console.WriteLine("W meczu moze byc tylko dwoch sedziow pobocznych. ");
            }
            else
            {

                string imie;
                string nazwisko;
                imie = Console.ReadLine();
                nazwisko = Console.ReadLine();
                VolleyballAssistantReferee assistantReferee = new VolleyballAssistantReferee(imie, nazwisko);
                AssistantReferees.Add(assistantReferee);
            }
            foreach (VolleyballAssistantReferee assistantReferee in AssistantReferees)
            {
                streamWriter.WriteLine(assistantReferee);
            }


        }

        public void DeleteReferee()
        {

            if (Referees.Count <= 0)
            {
                Console.WriteLine("Brak sedziego");
            }
            else
            {
                StreamReader streamReader = new StreamReader("Referees.txt");

                string imie;
                string nazwisko;
                imie = Console.ReadLine();
                nazwisko = Console.ReadLine();
                VolleyballReferee newReferee = new VolleyballReferee(imie, nazwisko);

                foreach (VolleyballReferee referee in Referees)
                {

                    if (referee == newReferee)
                    {
                        Referees.Remove(referee);
                    }
                }
            }
        }


        public void DeleteAssistantReferee()
        {
            if (Players.Count <= 0)
            {
                Console.WriteLine("Brak sedziow pobocznych");
            }
            else
            {
                StreamReader streamReader = new StreamReader("Players.txt");

                string imie;
                string nazwisko;
                imie = Console.ReadLine();
                nazwisko = Console.ReadLine();
                VolleyballAssistantReferee newAssistantReferee = new VolleyballAssistantReferee(imie, nazwisko);

                foreach (VolleyballAssistantReferee assistantReferee in AssistantReferees)
                {

                    if (assistantReferee == newAssistantReferee)
                    {
                        AssistantReferees.Remove(assistantReferee);
                    }
                }
            }
        }

        public void SelectFinalFourTeams()
        {

        }



    }

}

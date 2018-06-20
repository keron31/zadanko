using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFprojekt
{
     public class DodgeballGroupStage
    {
        private List<DodgeballReferee> Referees;
        private List<DodgeballPlayer> Players;
        private List<DodgeballTeam> Teams;


        public List<DodgeballPlayer> getPlayers()
        {
            return Players;
        }

        public List<DodgeballReferee> getReferees()
        {
            return Referees;
        }


        public void CreateSchedule()
        {
            foreach (DodgeballTeam team in Teams)
            {
                Console.WriteLine(team);
            }
        }

        public void DisplayReferees()
        {

        }

        public void DisplayPlayers()
        {

        }


        public void SortSchedule()
        {

        }

        public void AddReferee()
        {

        }


        public void DeleteReferee()
        {

        }


        public void SelectFinalFourTeams()
        {

        }
    }
}

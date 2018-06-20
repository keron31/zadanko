using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFprojekt
{
    public class TugofWarGroupStage
    {
        private List<TugOfWarReferee> Referees;
        private List<TugOfWarPlayer> Players;
        private List<TugOfWarTeam> Teams;

        public List<TugOfWarPlayer> getPlayers()
        {
            return Players;
        }

        public List<TugOfWarReferee> getReferees()
        {
            return Referees;
        }

        public void CreateSchedule()
        {
            foreach (TugOfWarTeam team in Teams)
            {
                Console.WriteLine(team);
            }
        }

        public void DisplayReferees()
        {

        }

        public void DisplayAssistantReferees()
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
    }

        public void AddAssistantReferee()
        {

        }

        public void DeleteReferee()
        {

        }

        public void DeleteAssistantReferee()
        {

        }

        public void SelectFinalFourTeams()
        {

        }
    }
}

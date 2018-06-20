using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopaCabana
{
   public class VolleyballFinalFour
    {
        private VolleyballTeam Team1;
        private VolleyballTeam Team2;
        private VolleyballTeam Team3;
        private VolleyballTeam Team4;
        private VolleyballTeam WinnerOfSemiFinal1;
        private VolleyballTeam WinnerOfSemiFinal2;

        public VolleyballTeam getTeam1()
        {
            return Team1;
        }

        public VolleyballTeam getTeam2()
        {
            return Team2;
        }

        public VolleyballTeam getTeam3()
        {
            return Team3;
        }

        public VolleyballTeam getTeam4()
        {
            return Team4;
        }

        public VolleyballTeam getWinnerOfSemiFinal1()
        {
            return WinnerOfSemiFinal1;
        }
        public VolleyballTeam getWinnerOfSemiFinal2()
        {
            return WinnerOfSemiFinal2;
        }



        public void PlaySemiFinal1(VolleyballTeam Team1, VolleyballTeam Team4)
        { }
        public void PlaySemiFinal2(VolleyballTeam Team2, VolleyballTeam Team3)
        { }

        public void PlayFinal(VolleyballTeam WinnerOfSemiFinal1, VolleyballTeam WinnerOfSemiFinal2)
        { }

        public void DisplayChampion()
        { }
    }
}

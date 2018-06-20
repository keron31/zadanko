using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFprojekt
{
     public class DodgeballFinalFour
    {
        private DodgeballTeam Team1;
        private DodgeballTeam Team2;
        private DodgeballTeam Team3;
        private DodgeballTeam Team4;
        private DodgeballTeam WinnerOfSemiFinal1;
        private DodgeballTeam WinnerOfSemiFinal2;

        public DodgeballTeam getTeam1()
        {
            return Team1;
        }

        public DodgeballTeam getTeam2()
        {
            return Team2;
        }

        public DodgeballTeam getTeam3()
        {
            return Team3;
        }

        public DodgeballTeam getTeam4()
        {
            return Team4;
        }

        public DodgeballTeam getWinnerOfSemiFinal1()
        {
            return WinnerOfSemiFinal1;
        }
        public DodgeballTeam getWinnerOfSemiFinal2()
        {
            return WinnerOfSemiFinal2;
        }


        public void PlaySemiFinal1(DodgeballTeam Team1, DodgeballTeam Team4)
        { }
        public void PlaySemiFinal2(DodgeballTeam Team2, DodgeballTeam Team3)
        { }

        public void PlayFinal(DodgeballTeam WinnerOfSemiFinal1, DodgeballTeam WinnerOfSemiFinal2)
        { }

        public void DisplayChampion()
        { }
    }
}

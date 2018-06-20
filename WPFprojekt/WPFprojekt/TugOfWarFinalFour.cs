using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFprojekt
{
    public class TugOfWarFinalFour
    {
        private TugOfWarTeam Team1;
        private TugOfWarTeam Team2;
        private TugOfWarTeam Team3;
        private TugOfWarTeam Team4;
        private TugOfWarTeam WinnerOfSemiFinal1;
        private TugOfWarTeam WinnerOfSemiFinal2;

        public TugOfWarTeam getTeam1()
        {
            return Team1;
        }

        public TugOfWarTeam getTeam2()
        {
            return Team2;
        }

        public TugOfWarTeam getTeam3()
        {
            return Team3;
        }

        public TugOfWarTeam getTeam4()
        {
            return Team4;
        }

        public TugOfWarTeam getWinnerOfSemiFinal1()
        {
            return WinnerOfSemiFinal1;
        }
        public TugOfWarTeam getWinnerOfSemiFinal2()
        {
            return WinnerOfSemiFinal2;
        }


        public void PlaySemiFinal1(TugOfWarTeam Team1, TugOfWarTeam Team4)
        { }
        public void PlaySemiFinal2(TugOfWarTeam Team2, TugOfWarTeam Team3)
        { }

        public void PlayFinal(TugOfWarTeam WinnerOfSemiFinal1, TugOfWarTeam WinnerOfSemiFinal2)
        { }

        public void DisplayChampion()
        { }
    }
}

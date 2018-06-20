using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopaCabana
{
    public class TugOfWarPlayer
    {
        private string Name;
        private string Surname;
        private int PlayerID;

        public TugOfWarPlayer(string name, string surname, int playerID)
        {
            Name = name;
            Surname = surname;
            PlayerID = playerID;
        }

        public void setName(string name)
        {
            Name = name;
        }

        public string getName()
        {
            return Name;
        }

        public void setSurname(string surname)
        {
            Surname = surname;
        }

        public string getSurname()
        {
            return Surname;
        }

        public void setPlayerID(int ID)
        {
            PlayerID = ID;
        }

        public int getPlayerID()
        {
            return PlayerID;
        }
    }
}

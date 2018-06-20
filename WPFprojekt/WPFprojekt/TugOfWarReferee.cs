using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFprojekt
{
    public class TugOfWarReferee
    {
        private string Name;
        private string Surname;
        private int RefereeID;

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

        public void setRefereeID(int ID)
        {
            RefereeID = ID;
        }

        public int getRefereeID()
        {
            return RefereeID;
        }
    }
}

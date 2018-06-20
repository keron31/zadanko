using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFprojekt
{
    public class VolleyballReferee
    {
        private string Name;
        private string Surname;

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


        public VolleyballReferee(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CopaCabana
{
    public class VolleyballAssistantReferee
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



        public VolleyballAssistantReferee(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
}

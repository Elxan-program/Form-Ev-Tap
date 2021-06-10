using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anket_Home_Work
{
    class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Age { get; set; }
        public string Adress { get; set; }
        public string Father_Name { get; set; }
        public string Gmail { get; set; }

        public Human(string name, string surname, string age, string adress, string father_name, string gmail)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Adress = adress;
            Father_Name = father_name;
            Gmail = gmail;
        }

    }
}

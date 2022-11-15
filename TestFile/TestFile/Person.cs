using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFile
{
    public class Person
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string sexe { get; set; }
        public int BirthYear { get; set; }

        public  Person(string LastName,string FirstName,string sexe,int BirthYear)
        {
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.sexe = sexe;
            this.BirthYear=BirthYear;
          
        }


    }
}

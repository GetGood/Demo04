using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava3
{
    class Boss : Employee
    {
        public string Car { get; set; }
        public int Bonus { get; set; }
        // default constructor
        public Boss()
        {
        }

        // parametric constuctor calls base class constructor with parameters
        public Boss(string firstName, string lastName, string car, int salary)
            : base(firstName, lastName)
        {
            Car = car;
        }

        // just one method what Teacher can do 


        // override base class ToString()-method
        public override string ToString()
        {
            // Person-luokan ToString + Room
            // firstName + lastName ... + Room
            // base viittaa yliluokkaan eli nyt Person-luokkaan
            return base.ToString() + " Car:" + Car + " Bonus:" + Bonus;
        }
    }
}

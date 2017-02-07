using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava3
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Profession { get; set; }
        public int Salary { get; set; }

        // default constructor
        public Employee()
        {
        }

        // constructor takes person firstname and lastname as a parameter
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        


        // return Employee data as a one string, override Object class ToString()-method
        public override string ToString()
        {
            return FirstName + " " + LastName + " Profession:" + Profession + " Salary:" + Salary;
        }
    }
}
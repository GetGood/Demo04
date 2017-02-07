using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava3
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a one Person object
            Employee employee = new Employee();
            employee.FirstName = "Kirsi";
            employee.LastName = "Kernel";
            employee.Profession = "Kirjanpitaja";
            employee.Salary = 3670;
            Console.WriteLine(employee.ToString());

            // create a one Teacher Object
            Boss boss = new Boss();
            boss.FirstName = "Teppo";
            boss.LastName = "Konsoli";
            boss.Profession = "pomotus";
            boss.Salary = 40000;
            boss.Bonus = 12;
            boss.Car = "Datsun 100";
            Console.WriteLine(boss.ToString());


        }
    }
}

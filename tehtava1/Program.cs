using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava1
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator = new Elevator();
            elevator.PrintFloor();
            while(true)
             {
                 Console.Write("Give a new floor (1-5) > ");
                 string line = Console.ReadLine();
                 int number;
                 bool result = int.TryParse(line, out number);
                 elevator.Floor = number;
                 elevator.PrintFloor();
            }
                 Console.ReadLine();


        }
    }
}

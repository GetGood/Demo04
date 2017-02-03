using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava1
{
    class Elevator
    {
        private readonly int maxFloor = 6, minFloor = 1;

        private int floor = 1;
        public void PrintFloor()
        {
            Console.WriteLine("Elevator is now on floor: " + Floor);
        }
        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value >= maxFloor)
                    {
                    Console.WriteLine("Floor 6 is the top floor");
                    floor = maxFloor;
                    }
                else if (value <=minFloor)
                    {
                    Console.WriteLine("Floor 1 is the bottom floor");
                    floor = minFloor;
                    }
                else
                    {
                    floor = value;
                    }
            
                
            }
                
         }

        
    }
}

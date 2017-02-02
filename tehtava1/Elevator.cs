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

        private int floor;
        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value <= maxFloor && value >= minFloor) floor = value;
                else
                {
                    Console.WriteLine("No more rooms");
                    floor = maxFloor;
                }
            }
        }
    }
}

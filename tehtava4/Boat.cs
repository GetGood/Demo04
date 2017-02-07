using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava4
{
    class Boat : Vehicle
    {
        public string BoatType { get; set; }
        public int SeatNumber { get; set; }
        // default constructor
        public Boat()
        {
        }

        // parametric constuctor calls base class constructor with parameters
        public Boat(string name, string model, string color, string boatType, int seatNumber)
            : base(name, model, color)
        {
            BoatType = boatType;
            SeatNumber = seatNumber;
        }


        // override base class ToString()-method
        public override string ToString()
        {
            return base.ToString() + " Boat type:" + BoatType + " Seat number:" + SeatNumber;
        }
    }
}

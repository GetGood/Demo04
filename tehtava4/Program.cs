using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava4
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a one Person object
            Vehicle vehicle = new Vehicle();
            vehicle.Name = "kenka";
            vehicle.Model = "converse";
            vehicle.Color = "Black";
            vehicle.ModelYear = 1889;
            Console.WriteLine(vehicle.ToString());

            //create a one Bike Object
            Bike bike = new Bike();
            bike.Name = "Jopo";
            bike.Model = "Street";
            bike.Color = "sininen";
            bike.ModelYear = 1999;
            bike.GearWheels = true;
            bike.GearModel = "tuhat vaihdetta";
            Console.WriteLine(bike.ToString());
            //create a one Boat Object
            Boat boat = new Boat();
            boat.Name = "Boaty Mc. Boatface";
            boat.Model = "hinuri";
            boat.Color = "vihiria";
            boat.ModelYear = 1776;
            boat.BoatType = "Hoyryvene";
            boat.SeatNumber = 1111;
            Console.WriteLine(boat.ToString());


        }
    }
}

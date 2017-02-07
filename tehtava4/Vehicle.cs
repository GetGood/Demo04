using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava4
{
    class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int ModelYear { get; set; }


        // default constructor
        public Vehicle()
        {
        }

        // constructor takes vehicle name and model and color as a parameter
        public Vehicle(string name, string model, string color)
        {
            Name = name;
            Model = model;
            Color = color;
        }



        // return Vehicle data as a one string, override Object class ToString()-method
        public override string ToString()
        {
            return "Name:" + Name + " Model:" + Model + " Color:" + Color + " Model year:" + ModelYear;
        }
    }
}

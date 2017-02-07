using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava4
{
    class Bike : Vehicle
    {
        public bool GearWheels { get; set; }
        public string GearModel { get; set; }
        // default constructor
        public Bike()
        {
        }

        // parametric constuctor calls base class constructor with parameters
        public Bike(string name, string model, string color, bool gearWheels, string gearModel)
            : base(name, model, color)
        {
            GearWheels = gearWheels;
            GearModel = gearModel;
        }


        // override base class ToString()-method
        public override string ToString()
        {
            return base.ToString() + " Gear wheels:" + GearWheels + " Gear model:" + GearModel;
        }
    }
}

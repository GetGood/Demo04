using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava5
{
    class Radio
    {
        private readonly int maxVolume = 9, minVolume = 1;
        private readonly double maxFreg = 26000, minFreg = 2000;
        private int volume = 1;
        private double freg;
        public bool OnOff { get; set; }
        public void PrintVolume()
        {
            Console.WriteLine("The volume is set to " + Volume);
        }
        public void PrintFreguency()
        {
            Console.WriteLine("The freguency is set to " + Freg);
        }
        public void TurnOnOff()
        {
            if (OnOff == true)
            {
                OnOff = false;
            }
            else OnOff = true;

        }
        public void PrintOnOff()
        {
            if (OnOff == true) Console.WriteLine("the radio is on ");
            else Console.WriteLine("the radio is off ");
        }
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value >= maxVolume)
                {
                    Console.WriteLine("max volume 9");
                    volume = maxVolume;
                }
                else if (value <= minVolume)
                {
                    Console.WriteLine("min volume 1");
                    volume = minVolume;
                }
                else
                {
                    volume = value;
                }


            }

        }
        public double Freg
        {
            get
            {
                return freg;
            }
            set
            {
                if (value >= maxFreg)
                {
                    Console.WriteLine("max freguency 26 000");
                    freg = maxFreg;
                }
                else if (value <= minFreg)
                {
                    Console.WriteLine("min freguency 2000");
                    freg = minFreg;
                }
                else
                {
                    freg = value;
                }


            }

        }


    }
}

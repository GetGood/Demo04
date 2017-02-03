using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava2
{
    class Amplifier
    {
        private readonly int maxVolume = 100, minVolume = 1;

        private int volume = 1;
        public void PrintVolume()
        {
            Console.WriteLine("The volume is set to " + Volume);
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
                    Console.WriteLine("max volume 100");
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


    }
}

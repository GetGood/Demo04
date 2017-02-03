using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava2
{
    class Program
    {
        static void Main(string[] args)
        {
            Amplifier amp = new Amplifier();
            amp.PrintVolume();
            while (true)
            {
                Console.Write("Set the volume(1-100) > ");
                string line = Console.ReadLine();
                int number;
                bool result = int.TryParse(line, out number);
                amp.Volume = number;
                amp.PrintVolume();
            }
            Console.ReadLine();


        }
    }
}

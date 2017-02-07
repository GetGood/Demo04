using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava5
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio();
            int choice = 5;
            while (choice != 4)
            {
                radio.PrintOnOff();
                radio.PrintVolume();
                radio.PrintFreguency();
                Console.WriteLine("Type 1 to adjust volume, 2 to adjust freguency 0 to turn on/off, 4 to exit");
                string line = Console.ReadLine();
               // int choice;
                bool result = int.TryParse(line, out choice);
                switch (choice)
                {
                    case 1:
                        while (true)
                        {
                            Console.Write("give a new volume (1-9) type 0 to exit > ");
                            string line2 = Console.ReadLine();
                            int number;
                            bool result2 = int.TryParse(line2, out number);
                            if (number == 0)
                            {
                                break;
                            }
                            radio.Volume = number;
                            radio.PrintVolume();

                        }
                        break;
                    case 2:

                        while (true)
                        {
                            Console.Write("give a new freguency (2000-26 000) type 0 to exit > ");
                            string line2 = Console.ReadLine();
                            double number;
                            bool result2 = double.TryParse(line2, out number);
                            if (number == 0)
                            {
                                break;
                            }
                            radio.Freg = number;
                            radio.PrintFreguency();

                        }
                        break;
                    case 0:
                        radio.TurnOnOff();
                        radio.PrintOnOff();
                        break;
                }

            }
   
        Console.ReadLine();


        }
    }
}

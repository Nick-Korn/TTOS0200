using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Lab2.SaunaHeater harvia = new SaunaHeater();
            int userInput;
            harvia.HeaterState();
            Console.WriteLine("Press enter to turn the sauna on!");
            Console.ReadKey();
            harvia.TurnOn();
            do
            {
                Console.Clear();
                harvia.HeaterState();
                Console.WriteLine("\n\nPress 1 to increase heat \nPress 2 to decrease heat \nPress 3 to increase humidity. \nPress 4 to increase humidity\nPress 5 to shut the heater down!");
                userInput = int.Parse(Console.ReadLine());
                if (userInput == 1)
                {
                    harvia.IncreaseHeat();
                }
                else if (userInput == 2)
                {
                    harvia.DecreaseHeat();
                }
                else if (userInput == 3)
                {
                    harvia.IncreaseHumidity();
                }
                else if (userInput == 4)
                {
                    harvia.DecreaseHumidity();
                }
                else if (userInput == 5)
                {
                    harvia.TurnOff();
                }
                else
                {
                    Console.WriteLine("Invalid input!!");
                }

            } while (harvia.powerState == true);

        }
    }
}

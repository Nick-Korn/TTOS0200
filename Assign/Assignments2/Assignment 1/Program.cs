/*
 * lab2
 * 
 * Created by: Niko Liimatainen 20/09/2017
 * Modifeid by: Niko Liimatainen 21/09/2017
 * 
 * Assignments of lab #2
 */



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
            //UseSauna();
            //UseWashingMachine();
            SpecifyCar();
        }

        static void UseSauna()
        {

            //Assignment 1
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

            } while (harvia.PowerState == true);
        }
        static void UseWashingMachine()
        {
            // Assignment 2
            int userInput;
            Lab2.WashingMachine siemens = new WashingMachine();
            Console.Clear();
            Console.WriteLine("Please Input the washing mode you wish to select: ");
            for (int i = 0; i < siemens.WashingProgram.Length; i++)
            {
                Console.WriteLine("Program {0}. {1}", i, siemens.WashingProgram[i]);
            }
            userInput = int.Parse(Console.ReadLine());
            siemens.SelectMode(userInput);
            Console.Clear();
            siemens.TurnPowerOn();
            siemens.TurnWaterOn();
            siemens.AddSoftener();
            siemens.AddWashingPowder();
            siemens.StartWash();
            siemens.TurnPowerOff();
            siemens.TurnWaterOff();
        }
        static void SpecifyCar()
        {
            // Assignment 4
            Lab2.Vehicle porsche = new Vehicle();
            porsche.Name = "Porsche";
            porsche.Speed = 260;
            porsche.Tyres = 4;
            porsche.PrintData();
            porsche.ToString();

            Lab2.Vehicle triCycle = new Vehicle();
            triCycle.Name = "Tricycle";
            triCycle.Speed = 15;
            triCycle.Tyres = 3;
            triCycle.PrintData();
            triCycle.ToString();

            Lab2.Vehicle harleyDavidson = new Vehicle();
            harleyDavidson.Name = "Harley-Davidson";
            harleyDavidson.Speed = 200;
            harleyDavidson.Tyres = 2;
            harleyDavidson.PrintData();
            harleyDavidson.ToString();
        }
    }
}

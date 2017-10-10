/*
 * lab4
 * 
 * Created by: Niko Liimatainen 9/10/2017
 * Modifeid by: Niko Liimatainen 10/10/2017
 * 
 * OOP TTOS0200 Assignments of lab #4
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreateVehicle();
            //OpenFridge();
            UseHockeyTeams();
        }
        static void CreateVehicle()
        {
            Vehicle porsche = new Vehicle("Porsche", "911");
            Console.WriteLine(porsche.VehicleData());
            Tyre nokia = new Tyre("Hakkapeliitta", "Nokia", "205R16");
            porsche.Tyres.Add(nokia);
            Console.WriteLine(porsche.AddedTyre(nokia.TyreName));
            porsche.Tyres.Add(nokia);
            Console.WriteLine(porsche.AddedTyre(nokia.TyreName));
            porsche.Tyres.Add(nokia);
            Console.WriteLine(porsche.AddedTyre(nokia.TyreName));
            porsche.Tyres.Add(nokia);
            Console.WriteLine(porsche.AddedTyre(nokia.TyreName));
            Console.WriteLine(porsche.ToString());
            Vehicle ducati = new Vehicle("Ducati", "Diavel");
            Console.WriteLine(ducati.VehicleData());
            Tyre mic1 = new Tyre("Pilot", "MIC", "160R17");
            ducati.Tyres.Add(mic1);
            Console.WriteLine(ducati.AddedTyre(mic1.TyreName));
            Tyre mic2 = new Tyre("Pilot", "MIC", "140R16");
            ducati.Tyres.Add(mic2);
            Console.WriteLine(ducati.AddedTyre(mic2.TyreName));
            Console.WriteLine(ducati.ToString());
        }
        static void OpenFridge()
        {
            Fridge samsung = new Fridge("Samsung ");
            samsung.Products.Add(new Bread("bread", "Vaasan", 1, "Ryebread"));
            samsung.Products.Add(new Bread("bread", "Fazer", 1, "Whitebread"));
            samsung.Products.Add(new Meat("meat", "Kariniemen", 2, "Chicken", 800));
            samsung.Products.Add(new Meat("meat", "Snellman", 2, "Pork", 800));
            samsung.Products.Add(new Drink("drink", "Valio", 3, "milk", 1.5f));
            samsung.Products.Add(new Drink("drink", "Good Morgon", 3, "orange juice", 1.75f));
            Console.WriteLine(samsung.ToString());
        }
        static void UseHockeyTeams()
        {
            Team kalpa = new Team("Kalpa", "Kuopio");
            kalpa.Players.Add(new Player("Denis", "Godla", "Goalie", "L"));
            kalpa.Players.Add(new Player("Santeri", "Lukka", "Defenceman", "R"));
            kalpa.Players.Add(new Player("Sami", "Mutanen", "Forward", "L"));
            kalpa.Players.Add(new Player("Janne", "Tavi", "Forward", "L"));
            Team tappara = new Team("Tappara", "Tampere");
            tappara.Players.Add(new Player("Dominik", "Heljanko", "Goalie", "L"));
            tappara.Players.Add(new Player("Otso", "Rantakari", "Defenceman", "R"));
            tappara.Players.Add(new Player("Toni", "Utunen", "Defenceman", "L"));
            tappara.Players.Add(new Player("Joona", "Luoto", "Forward", "L"));

            while (true)
            {
                Console.WriteLine("Available Teams: Kalpa and Tappara");
                Console.WriteLine("1. Print Kalpa info");
                Console.WriteLine("2. Print Tappara info");
                Console.WriteLine("3. Save kalpa as csv");
                Console.WriteLine("4. Read kalpa from csv");
                Console.WriteLine("5. Save tappara as csv");
                Console.WriteLine("6. Read tappara from csv");
                Console.WriteLine("0. Exit");
                int input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    Console.Clear();
                    Console.WriteLine(kalpa.ToString());
                }
                else if (input == 2)
                {
                    Console.Clear();
                    Console.WriteLine(tappara.ToString());
                }
                else if (input == 3)
                {
                    kalpa.SaveCsv();
                    Console.Clear();
                    Console.WriteLine("SAVED!");
                }
                else if (input == 4)
                {
                    Console.Clear();
                    Console.WriteLine("READ!");
                    kalpa.ReadCsv();
                }
                else if (input == 5)
                {
                    Console.Clear();
                    Console.WriteLine("SAVED!");
                    tappara.SaveCsv();
                }
                else if (input == 6)
                {
                    Console.Clear();
                    Console.WriteLine("READ!");
                    tappara.ReadCsv();
                }

                else if (input == 0)
                    break;
                else
                    Console.WriteLine("Invalid input");
            }
        }
    }
}

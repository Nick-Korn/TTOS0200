/*
 * lab4
 * 
 * Created by: Niko Liimatainen 9/10/2017
 * Modifeid by: Niko Liimatainen 10/10/2017
 * 
 * OOP TTOS0200 Assignments of lab #3
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
            OpenFridge();
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
            Fridge samsung = new Fridge("Samsung");
            samsung.Products.Add(new Bread("bread", "Vaasan", 1, "Ryebread"));
            samsung.Products.Add(new Bread("bread", "Fazer", 1, "Whitebread"));
            samsung.Products.Add(new Meat("meat", "Kariniemen", 2, "Chicken", 800));
            samsung.Products.Add(new Meat("meat", "Snellman", 2, "Pork", 800));
            samsung.Products.Add(new Drink("drink", "Valio", 3, "milk", 1.5f));
            samsung.Products.Add(new Drink("drink", "Good Morgon", 3, "orange juice", 1.75f));
            Console.WriteLine(samsung.ToString());
        }
    }
}

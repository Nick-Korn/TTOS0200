using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Vehicle
    {
        private string name;
        private int speed;
        private int tyres;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        } 

        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }

        public int Tyres
        {
            get
            {
                return tyres;
            }
            set
            {
                tyres = value;
            }
        }

        public void PrintData()
        {
            Console.WriteLine("Vehicle data: ");
            Console.WriteLine("Name of the vehicle: {0}", Name);
            Console.WriteLine("How fast can it go: {0} km/h", Speed);
            Console.WriteLine("How many tyres does it have: {0}", Tyres);
        }

        public void ToString()
        {
            string vehicleSpecs = String.Format("Name of the car: {0}, max speed: {1} km/h, amount of tyres: {2}.", Name, Speed, Tyres);
            Console.WriteLine(vehicleSpecs);
            Console.WriteLine();
        }
    }
}

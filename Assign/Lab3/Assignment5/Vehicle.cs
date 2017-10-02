using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }

        public Vehicle(string name, string model, string color, int year)
        {
            Name = name;
            Model = model;
            Color = color;
            Year = year;
        }
        public virtual string PrintVehicleData ()
        {
            string outPut = string.Format("Name: {0}, Model: {1}, Year: {2}, Color: {3}", Name, Model, Year, Color);
            return outPut;
        }
    }
}

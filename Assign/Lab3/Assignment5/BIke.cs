using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Bike : Vehicle
    {
        public bool GearWheels { get; set; }
        public string GearName { get; set; }

        public Bike(string name, string model, string color, int year, bool gearWheels, string gearName) 
            : base(name, model, color, year)
        {
            GearWheels = gearWheels;
            GearName = gearName;
        }
        public override string PrintVehicleData()
        {
            string outPut = string.Format("Gearwheels: {0}, GearName: {1}" ,GearWheels, GearName);
            return base.PrintVehicleData() + ", "+ outPut;
        }
    }
}

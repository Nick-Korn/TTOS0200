using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Boat: Vehicle
    {
        public int SeatCount { get; set; }
        public string BoatType { get; set; }

        public Boat(string name, string model, string color, int year, int seatCount, string boatType) 
            : base(name, model, color, year)
        {
            SeatCount = seatCount;
            BoatType = boatType;
        }
        public override string PrintVehicleData()
        {
            string outPut = string.Format("SeatCount: {0}, BoastType: {1}", SeatCount, BoatType);
            return base.PrintVehicleData() + ", " + outPut;
        }
    }
}

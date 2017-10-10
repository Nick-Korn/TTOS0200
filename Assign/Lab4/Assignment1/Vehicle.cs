using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Vehicle
    {
        public string VehicleName { get; set; }
        public string VehicleModel { get; set; }
        public List<Tyre> Tyres;

        public Vehicle (string vehicleName, string vehicleModel)
        {
            Tyres = new List<Tyre>();
            VehicleModel = vehicleModel;
            VehicleName = vehicleName;
        }
        public string VehicleData()
        {
            return string.Format("Created new Vehicle {0} model {1}", VehicleName, VehicleModel);
        }
        public string AddedTyre(string tyreName)
        {
            return string.Format("Tyre {0} added to vehicle {1}",tyreName, VehicleName);
        }

        public override string ToString()
        {
            Console.WriteLine("\nTyres:");
            string retval = string.Format("Vehicle Name: {0} Model: {1} \n", VehicleName, VehicleModel);
            foreach (Tyre tyre in Tyres)
            {
                retval += tyre.ToString() + '\n';
            }
            return retval;
        }

    }
}

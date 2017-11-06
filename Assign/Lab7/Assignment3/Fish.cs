using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Fish
    {
        public string Species { get; set; }
        public string Place { get; set; }
        public string Location { get; set; }
        public int Lenght { get; set; }
        public float Weight { get; set; }

        public Fish(string species, string place, string location, int lenght, float weight)
        {
            Species = species;
            Place = place;
            Location = location;
            Lenght = lenght;
            Weight = weight;
        }


    }
}

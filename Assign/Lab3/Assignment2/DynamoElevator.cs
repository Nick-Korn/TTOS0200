using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class DynamoElevator
    {
        private readonly int HighestFloor = 5;
        private readonly int LowestFloor = 1;
        private int floor = 1;
        

        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value <= HighestFloor && value >= LowestFloor) floor = value;
                else
                {
                    Console.WriteLine("Invalid floor number!");
                }
            }
        }
    }
}

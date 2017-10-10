using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Adult : Human
    {
        public string Car { get; set; }

        public Adult(int age, float weight, float height, string name, string car ) : 
            base(age, weight, height, name)
        {
            Car = car;
        }

        public override void Move()
        {
            Console.WriteLine("Walking");
        }

        public override string ToString()
        {
            return base.ToString() + " " + string.Format("Car: {0}", Car);
        }
    }
}

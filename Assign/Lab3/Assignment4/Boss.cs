using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Boss : Employee
    {
        public string Car { get; set; }
        public int Bonus { get; set; }

        public Boss(string name, string profession, int salary, string car, int bonus) 
            : base(name, profession, salary)
        {
            Car = car;
            Bonus = bonus;
        }
        public override String PrintDataBase()
        {
            string outPut = string.Format("Car: {0}, Bonus: {1}", Car, Bonus);
            return base.PrintDataBase() + ", " + outPut;
        }
    }
}

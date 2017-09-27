using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Employee
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public int Salary { get; set; }

        public Employee (string name, string profession, int salary)
        {
            Name = name;
            Profession = profession;
            Salary = salary;
        }
    }
}

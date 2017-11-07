using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    abstract class Shape
    {
        public string Name { get; set; }

        public Shape(string name)
        {
            Name = name;
        }

        public abstract double CalcualteArea();

        public abstract double CalculateCircumference();
    }
}

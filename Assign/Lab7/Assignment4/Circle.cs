using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(string name, double radius) :
            base(name)
        {
            Radius = radius;
        }
        public override double CalcualteArea()
        {
            try
            {
                double area = 0;
                area = Math.PI * Math.Pow(Radius, 2);
                return area;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public override double CalculateCircumference()
        {
            try
            {
                double circu = 0;
                circu = 2 * Math.PI * Radius;
                return circu;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override string ToString()
        {
            try
            {
                string retval = "";
                retval += string.Format("{0} Radius={1} Area={2} Circumference={3} \n",
                    Name, Radius, CalcualteArea().ToString("n2"), CalculateCircumference().ToString("n2"));
                return retval;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

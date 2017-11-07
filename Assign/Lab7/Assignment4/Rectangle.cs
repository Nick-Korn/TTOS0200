using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Rectangle : Shape
    {
        public Double Height { get; set; }
        public Double Width { get; set; }

        public Rectangle(string name, double height, double width) :
            base(name)
        {
            Height = height;
            Width = width;
        }

        public override double CalcualteArea()
        {
            try
            {
                double area = 0;
                area = Height * Width;
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
                circu = (2 * Width) + (2 * Height);
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
                retval += string.Format("{0} Width={1} Height={2} Area={3} Circumference={4} \n",
                    Name, Width, Height, CalcualteArea().ToString("n2"), CalculateCircumference().ToString("n2"));
                return retval;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

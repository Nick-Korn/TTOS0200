using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Shapes
    {
        public List<Shape> ShapeList { get; set; }

        public Shapes()
        {
            ShapeList = new List<Shape>();
        }

        public override string ToString()
        {
            try
            {
                string retval = "";
                foreach (Shape shape in ShapeList)
                {
                    retval += shape.ToString();
                }
                return retval;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

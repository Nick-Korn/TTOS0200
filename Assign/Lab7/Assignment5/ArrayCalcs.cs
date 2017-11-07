using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public class ArrayCalcs
    {
        public ArrayCalcs()
        {

        }
        public static double Sum(double[] Numberarray)
        {
            double result = 0;
            result = Numberarray.Sum();
            result = Math.Round(result, 2);
            return result;
        }
        public static double Avg(double[] Numberarray)
        {
            double result = 0;
            result = Numberarray.Average();
            result = Math.Round(result, 2);
            return result;
        }
        public static double Max(double[] Numberarray)
        {
            double result = 0;
            result = Numberarray.Max();
            return result;
        }
        public static double Min(double[] Numberarray)
        {
            double result = 0;
            result = Numberarray.Min();
            return result;
        }
    }
}

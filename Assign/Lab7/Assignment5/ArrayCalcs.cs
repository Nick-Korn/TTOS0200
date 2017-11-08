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
            try
            {
                double result = 0;
                result = Numberarray.Sum();
                result = Math.Round(result, 2);
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static double Avg(double[] Numberarray)
        {
            try
            {
                double result = 0;
                result = Numberarray.Average();
                result = Math.Round(result, 2);
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static double Max(double[] Numberarray)
        {
            try
            {
                double result = 0;
                result = Numberarray.Max();
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static double Min(double[] Numberarray)
        {
            try
            {
                double result = 0;
                result = Numberarray.Min();
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

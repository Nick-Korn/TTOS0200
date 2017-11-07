using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.Tests
{
    [TestClass()]
    public class ArrayCalcsTests
    {

        [TestMethod()]
        public void SumTest()
        {
            try
            {
                //Arrange
                double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
                double expected = 25.60;

                //Act 
                double actual = ArrayCalcs.Sum(array);

                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [TestMethod()]
        public void AvgTest()
        {
            try
            {
                //Arrange
                double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
                double expected = 3.66;

                //Act 
                double actual = ArrayCalcs.Avg(array);

                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [TestMethod()]
        public void MaxTest()
        {
            try
            {
                //Arrange
                double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
                double expected = 12.00;

                //Act 
                double actual = ArrayCalcs.Max(array);

                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [TestMethod()]
        public void MinTest()
        {
            try
            {
                //Arrange
                double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
                double expected = -4.50;

                //Act 
                double actual = ArrayCalcs.Min(array);

                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (Exception)
            {

                throw;
            }
        }
        // If there is no content in the array, all except sum method fail with 'System.InvalidOperationException: Sequence contains no elements'.
        // Sum method fails with 'Message: Assert.AreEqual failed. Expected:<25,6>. Actual:<0>.'
    }
}
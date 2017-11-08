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
    public class InvoiceTests
    {
        [TestMethod()]
        public void CalculateTotalCostTest()
        {
            try
            {
                //Arrange
                Invoice kirsi = new Invoice("Kirsi Kernel");
                kirsi.Items.Add(new InvoiceItem("Milk", 1.75, 1));
                kirsi.Items.Add(new InvoiceItem("Beer", 5.25, 1));
                kirsi.Items.Add(new InvoiceItem("Milk", 2.50, 2));
                double expected = 12.00;

                //Act 
                double actual = kirsi.CalculateTotalCost();

                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
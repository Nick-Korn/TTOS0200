using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Product
    {
        public string ProductType { get; set; }
        public string ProductProducer { get; set; }
        public int ProductAmount { get; set; }

        public Product(string pType, string pProducer, int pAmount)
        {
            ProductType = pType;
            ProductProducer = pProducer;
            ProductAmount = pAmount;
        }
        public override string ToString()
        {
            return string.Format(" -Type of product: {0}, Product producer: {1}, Amount of product in fridge: {2},", ProductType, ProductProducer, ProductAmount);
        }
    }
}

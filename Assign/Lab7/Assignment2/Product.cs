using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Product
    {
        public string ProductName { get; set; }
        public float ProductPrize { get; set; }

        public Product(string pName, float pPrize)
        {
            ProductName = pName;
            ProductPrize = pPrize;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public class InvoiceItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public InvoiceItem(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double CalculateTotal()
        {
            double total = 0;
            total = Price * Quantity;
            return total;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} pieces {3} total\n", Name, Price, Quantity, CalculateTotal().ToString("n2"));
        }
    }
}

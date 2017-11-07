using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public class Invoice
    {
        public string Customer { get; set; }
        public List<InvoiceItem> Items { get; set; }

        public Invoice(string customer)
        {
            Customer = customer;
            Items = new List<InvoiceItem>();
        }

        public double CalculateTotalCost()
        {
            double total = 0;
            foreach (InvoiceItem item in Items)
            {
                total += item.CalculateTotal();
            }
            total = Math.Round(total, 2);
            return total;
        }

        public string PrintInvoice()
        {
            string retval = "";
            retval = string.Format("Customer {0}'s Invoice: \n", Customer);
            retval += "===============================\n";
            foreach (InvoiceItem item in Items)
            {
                retval += item.ToString();
            }
            retval += "===============================\n";
            retval += string.Format("Total: {0} euro", CalculateTotalCost().ToString("n2"));
            return retval;
        }
    }
}

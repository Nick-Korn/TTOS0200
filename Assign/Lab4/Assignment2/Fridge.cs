using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Fridge
    {
        public string FridgeModel { get; set; }
        public List<Product> Products { get; set; }
        public Fridge(string fModel)
        {
            Products = new List<Product>();
            FridgeModel = fModel;
        }
        public override string ToString()
        {
            Console.WriteLine(string.Format("\nContents of the {0} fridge: ", FridgeModel));
            string retval = "";
            foreach (Product product in Products)
            {
                retval += product.ToString() + '\n';
            }
            return retval;
        }

    }
}

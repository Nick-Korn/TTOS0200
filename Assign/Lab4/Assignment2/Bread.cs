using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Bread : Product
    {
        string BreadType { get; set; }
        public Bread(string pType, string pProducer, int pAmount, string bType) :
            base(pType, pProducer, pAmount)
        {
            BreadType = bType;
        }
        public override string ToString()
        {
            return base.ToString() + " " + string.Format("Type of bread: {0} ", BreadType); 
        }
    }
}

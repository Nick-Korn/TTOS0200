using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Meat : Product 
    {
        public string MeatAnimal { get; set; }
        public int MeatWeight { get; set; }
        public Meat (string pType, string pProducer, int pAmount, string mAnimal, int mWeight) : 
            base(pType, pProducer, pAmount)
        {
            MeatAnimal = mAnimal;
            MeatWeight = mWeight;
        }
        public override string ToString()
        {
            return base.ToString() + " " + string.Format("From which animal:{0}, Weight of meat: {1}g", MeatAnimal, MeatWeight);
        }
    }
}

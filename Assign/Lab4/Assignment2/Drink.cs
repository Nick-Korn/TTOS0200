using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Drink : Product
    {
        public string DrinkType { get; set; }
        public float DrinkVelocity { get; set; }
        public Drink(string pType, string pProducer, int pAmount, string dType, float dVelocity) : 
            base(pType, pProducer, pAmount)
        {
            DrinkType = dType;
            DrinkVelocity = dVelocity;
        }
        public override string ToString()
        {
            return base.ToString() + " " + string.Format("What type of drink:{0}, Amount of drink in fridge: {1}L", DrinkType, DrinkVelocity);
        }
    }
}

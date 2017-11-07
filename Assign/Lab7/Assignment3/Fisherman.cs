using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Fisherman
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public List<Fish> CatchList { get; set; }
        
        public Fisherman(string name, string phone)
        {
            Name = name;
            PhoneNumber = phone;
            CatchList = new List<Fish>();
        }

        public override string ToString ()
        {
            try
            {
                string retval = "";
                retval += string.Format("All Fishes in the register: \n\n Fisherman {0} has got the following fishes:\n", Name);
                foreach (Fish fish in CatchList)
                {
                    retval += string.Format(" - species: {0} {1} cm {2} kg \n - place: {3} \n - location: {4} \n\n",
                        fish.Species, fish.Lenght, fish.Weight, fish.Place, fish.Location);
                }
                return retval;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public string ReversePrint()
        {

            try
            {
                string retval = "";
                var newList = CatchList.OrderByDescending(x => x.Weight).ToList();
                retval += string.Format("All Fishes in the register: \n\n Fisherman {0} has got the following fishes:\n", Name);
                foreach (var item in newList)
                {
                    retval += string.Format(" - species: {0} {1} cm {2} kg \n - place: {3} \n - location: {4} \n\n",
                        item.Species, item.Lenght, item.Weight, item.Place, item.Location);
                }
                return retval;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

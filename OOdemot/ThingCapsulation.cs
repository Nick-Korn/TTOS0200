using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOdemot
{
    class Thing
    {
        //public string Name;
        //public string Name { get; set; }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Thing()
        {
            name = "Nobody here";
        }

        public override string ToString()
        {
            return string.Format("My name is {0}", Name);
        }
    }
    
}

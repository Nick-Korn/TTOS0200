using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Tyre
    {
        public string TyreName { get; set; }
        public string TyreType { get; set; }
        public string TyreSize { get; set; }

        public Tyre() { }
        public Tyre(string tyreType, string tyreName, string tyreSize)
        {
            TyreType = tyreType;
            TyreName = tyreName;
            TyreSize = tyreSize;
        }
        public override string ToString()
        {
            return string.Format("-Name: {0} Model: {1} TyreSize: {2}", TyreName, TyreType, TyreSize);
        }

    }
}

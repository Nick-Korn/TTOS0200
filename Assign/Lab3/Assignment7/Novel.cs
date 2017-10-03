using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Novel : Readable
    {
        public string Author { get; set; }
        public bool IsSeries { get; set; }
        public Novel(string name, string type, string format, string publisher, int numberOfPages, int publicationYear, string author, bool isSeries) : 
            base (name, type, format, publisher, numberOfPages, publicationYear)
        {
            Author = author;
            IsSeries = isSeries;
        }
        public override string PrintData()
        {
            return base.PrintData() + " " + string.Format("Author: {0}, Is series: {1}", Author, IsSeries);
        }
    }
}

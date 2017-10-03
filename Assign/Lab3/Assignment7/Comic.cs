using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Comic : Readable
    {
        public string Author { get; set; }
        public string Illustrator { get; set; }
        public bool IsManga { get; set; }

        public Comic (string name, string type, string format, string publisher, int numberOfPages, int publicationYear, string author, string illustrator, bool isManga) : 
            base (name, type, format, publisher, numberOfPages, publicationYear)
        {
            Author = author;
            IsManga = isManga;
            Illustrator = illustrator;
        }
        public override string PrintData()
        {
            return base.PrintData() + " " + string.Format("Author: {0}, Illustrator: {1}, Is manga: {2}", Author, Illustrator, IsManga);
        }
    }
}

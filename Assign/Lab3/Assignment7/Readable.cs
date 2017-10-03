using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Readable
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Format { get; set; }
        public string Publisher { get; set; }
        public int NumberOfPages { get; set; }
        public int PublicationYear { get; set; }
        public Readable(string name, string type, string format, string publisher, int numberOfPages, int publicationYear)
        {
            Name = name;
            Type = type;
            Format = format;
            Publisher = publisher;
            NumberOfPages = numberOfPages;
            PublicationYear = publicationYear;
        }
        public virtual string PrintData()
        {
            string outPut = string.Format("Name: {5}, Type of readable: {0}, Format: {1}, Publisher: {2}, Number Of Pages: {3} Publication Year: {4}",
                Type, Format, Publisher, NumberOfPages, PublicationYear, Name);
            return outPut;
        }
    }
}

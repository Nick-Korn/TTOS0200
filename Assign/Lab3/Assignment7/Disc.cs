using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Disc
    {
        public string DiscType { get; set; }
        public string ContentType { get; set; }
        public string DiscFormat { get; set; }
        public string DiscName { get; set; }
        public string Genre { get; set; }
        public int Lenght { get; set; }

        public Disc(string discName, string discType, string contentType, string discFormat, string genre, int lenght)
        {
            DiscName = discName;
            DiscType = discType;
            ContentType = contentType;
            DiscFormat = discFormat;
            Genre = genre;
            Lenght = lenght;
        }

        public string PrintData()
        {
            string outPut = string.Format("Name of the disc: {0}, Type of content: {1}, Type of disc: {2}, Format of disc: {3}, Genre: {4}, Lenght: {5}", 
                DiscName, ContentType, DiscType, DiscFormat, Genre, Lenght);
            return outPut;
        }
    }
}

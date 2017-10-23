using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Song
    {
        public string SongName { get; set; }
        public float SongLenght { get; set; }

        public Song(string name, float lenght)
        {
            SongName = name;
            SongLenght = lenght;
        }

        public override string ToString()
        {
            return string.Format("  - {0}, {1}",SongName, SongLenght);
        }
    }
}

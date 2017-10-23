using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Cd
    {
        public string CdName { get; set; }
        public string CdArtist { get; set; }
        public List<Song> CdSongs { get; set; }

        public Cd(string name, string artist)
        {
            CdSongs = new List<Song>();
            CdName = name;
            CdArtist = artist;
        }

        public override string ToString()
        {
            string retval;
            retval = string.Format("CD data: \n- Name:{0} \n- Artist:{1} \n- Songs: \n", CdName, CdArtist);
            foreach (Song song in CdSongs)
            {
                retval += song.ToString() + "\n";
            }
            return retval;
        }
    }
}

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Team
    {
        public string Name { get; set; }
        public string City { get; set; }
        public List<Player> Players { get; set; }
        public Team(string name, string city)
        {
            Players = new List<Player>();
            Name = name;
            City = city;
        }
        public override string ToString()
        {
            Console.WriteLine(string.Format("\nName of the team: {0}, Teams home city: {1}", Name, City));
            string retval = "";
            foreach (Player player in Players)
            {
                retval += player.ToString() + '\n';
            }
            return retval;
        }
        public void SaveCsv()
        {
            StringBuilder csvcontent = new StringBuilder();
            string csvPath = string.Format("D:\\{0}.csv", Name);
            string retval = "";
            foreach (Player player in Players)
            {
                retval += player.ToString() + (string.Format("Name of the team: {0}, Teams home city: {1}", Name, City) + '\n');
            }
            csvcontent.Append(retval);
            File.AppendAllText(csvPath, csvcontent.ToString());
        }
        public void ReadCsv()
        {
            try
            {
                String st = File.ReadAllText(string.Format("D:\\{0}.csv", Name));
                Console.WriteLine(st);
            }
            catch (Exception e)
            {
                Console.WriteLine("This file could not be read: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}

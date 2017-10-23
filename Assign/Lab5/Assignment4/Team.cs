using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
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
        public void GetPlayers()
        {
            Players.Add(new Player("Eetu", "Laurikainen", "Goalie", "L"));
            Players.Add(new Player("Juho", "Olkinuora", "Goalie", "L"));
            Players.Add(new Player("Anttoni", "Honka", "Defenceman", "R"));
            Players.Add(new Player("Juuso", "Vainio", "Defenceman", "L"));
            Players.Add(new Player("Mikko", "Kalteva", "Defenceman", "L"));
            Players.Add(new Player("Jaakko", "Jokinen", "Defenceman", "L"));
            Players.Add(new Player("Alex", "Lindroos", "Defenceman", "L"));
            Players.Add(new Player("Ronj", "Allen", "Defenceman", "L"));
            Players.Add(new Player("Ossi", "Ikonen", "Defenceman", "L"));
            Players.Add(new Player("Nolan", "Yonkman", "Defenceman", "R"));
            Players.Add(new Player("Mikko", "Mäenpää", "Defenceman", "L"));
            Players.Add(new Player("Joona", "Erving", "Defenceman", "L"));
            Players.Add(new Player("Olli", "Aitola", "Defenceman", "L"));
            Players.Add(new Player("Tuomas", "Salmela", "Defenceman", "L"));
            Players.Add(new Player("Mikko", "Kuukka", "Defenceman", "L"));
            Players.Add(new Player("Joonas", "Nättinen", "Forward", "R"));
            Players.Add(new Player("Samuli", "Ratinen", "Forward", "L"));
            Players.Add(new Player("Jani", "Tappurainen", "Forward", "L"));
            Players.Add(new Player("Antti", "Suomela", "Forward", "L"));
            Players.Add(new Player("Juha-Pekka", "Hytönen", "Forward", "L"));
            Players.Add(new Player("Juuso", "Puustinen", "Forward", "R"));
            Players.Add(new Player("Valtteri", "Hotakainen", "Forward", "L"));
            Players.Add(new Player("Ossi", "Louhivaara", "Forward", "R"));
            Players.Add(new Player("Jarkko", "Immonen", "Forward", "R"));
            Players.Add(new Player("Riku", "Tiainen", "Forward", "L"));
            Players.Add(new Player("Miika", "Lahti", "Forward", "L"));
            Players.Add(new Player("Joel", "Sund", "Forward", "R"));
            Players.Add(new Player("Arttu", "Likola", "Forward", "L"));
            Players.Add(new Player("Jerry", "Turkulainen", "Forward", "R"));
            Players.Add(new Player("Micke", "Saari", "Forward", "L"));
            Players.Add(new Player("Janne", "Kolehmainen", "Forward", "L"));
            Players.Add(new Player("Henri", "Kanninen", "Forward", "L"));
            Players.Add(new Player("Robert", "Rooba", "Forward", "L"));
        }
        public void RemovePlayer(string name)
        {
            int i = 0;
            foreach (Player player in Players)
            {
                if (player.LastName == name)
                {
                    Console.WriteLine("Removing: " + player.ToString());
                    Players.Remove(player);
                    break;
                }
                else
                {
                    i++;
                }
            }

        }
        public void AddPlayer(string fname, string lname, string posit, string hand)
        {
            Players.Add(new Player (fname, lname, posit, hand));
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
                retval += string.Format("{0},{1},{2},{3},{4},{5}\n", player.FirstName, player.LastName, player.PlayPosition, player.Handedness, Name, City);
            }
            csvcontent.Append("Firstname, Lastname, Position, Handedness, Team, City\n");
            csvcontent.Append(retval);
            File.AppendAllText(csvPath, csvcontent.ToString());
            //Other save methods include: plain text, .json file, 
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

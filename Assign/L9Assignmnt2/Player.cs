using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9Assignmnt2
{
    class Player
    {
        public static List<Player> GetPlayers()
        {
            try
            {
                List<Player> players = new List<Player>();
                players.Add(new Player("Eetu", "Laurikainen", "Goalie", "L", 41));
                players.Add(new Player("Juho", "Olkinuora", "Goalie", "L", 45));
                players.Add(new Player("Anttoni", "Honka", "Defenceman", "R", 3));
                players.Add(new Player("Juuso", "Vainio", "Defenceman", "L", 5));
                players.Add(new Player("Mikko", "Kalteva", "Defenceman", "L", 7));
                players.Add(new Player("Jaakko", "Jokinen", "Defenceman", "L", 16));
                players.Add(new Player("Alex", "Lindroos", "Defenceman", "L", 34));
                players.Add(new Player("Ronj", "Allen", "Defenceman", "L", 35));
                players.Add(new Player("Ossi", "Ikonen", "Defenceman", "L", 37));
                players.Add(new Player("Nolan", "Yonkman", "Defenceman", "R", 43));
                players.Add(new Player("Mikko", "Mäenpää", "Defenceman", "L", 47));
                players.Add(new Player("Joona", "Erving", "Defenceman", "L", 53));
                players.Add(new Player("Olli", "Aitola", "Defenceman", "L", 60));
                players.Add(new Player("Tuomas", "Salmela", "Defenceman", "L", 61));
                players.Add(new Player("Mikko", "Kuukka", "Defenceman", "L", 91));
                players.Add(new Player("Joonas", "Nättinen", "Forward", "R", 9));
                players.Add(new Player("Samuli", "Ratinen", "Forward", "L", 11));
                players.Add(new Player("Jani", "Tappurainen", "Forward", "L", 12));
                players.Add(new Player("Antti", "Suomela", "Forward", "L", 14));
                players.Add(new Player("Juha-Pekka", "Hytönen", "Forward", "L", 15));
                players.Add(new Player("Juuso", "Puustinen", "Forward", "R", 17));
                players.Add(new Player("Valtteri", "Hotakainen", "Forward", "L", 18));
                players.Add(new Player("Ossi", "Louhivaara", "Forward", "R", 23));
                players.Add(new Player("Jarkko", "Immonen", "Forward", "R", 26));
                players.Add(new Player("Riku", "Tiainen", "Forward", "L", 27));
                players.Add(new Player("Miika", "Lahti", "Forward", "L", 28));
                players.Add(new Player("Joel", "Sund", "Forward", "R", 29));
                players.Add(new Player("Arttu", "Likola", "Forward", "L", 31));
                players.Add(new Player("Jerry", "Turkulainen", "Forward", "R", 32));
                players.Add(new Player("Micke", "Saari", "Forward", "L", 40));
                players.Add(new Player("Janne", "Kolehmainen", "Forward", "L", 55));
                players.Add(new Player("Henri", "Kanninen", "Forward", "L", 71));
                players.Add(new Player("Robert", "Rooba", "Forward", "L", 88));
                return players;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PlayPosition { get; set; }
        public string Handedness { get; set; }
        public int Number { get; set; }
        public Player(string firstName, string lastName, string playPosition, string handedness, int number)
        {
            Number = number;
            FirstName = firstName;
            LastName = lastName;
            PlayPosition = playPosition;
            Handedness = handedness;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Player
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PlayPosition { get; set; }
        public string Handedness { get; set; }
        public Player (string firstName, string lastName, string playPosition, string handedness)
        {
            FirstName = firstName;
            LastName = lastName;
            PlayPosition = playPosition;
            Handedness = handedness;
        }
        public override string ToString()
        {
            return string.Format("First name: {0}, Last Name: {1}, Play position: {2}, Handedness: {3}", FirstName, LastName, PlayPosition, Handedness);
        }
    }
}

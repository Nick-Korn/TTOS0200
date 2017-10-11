using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Student
    {
        #region PROPERTIES
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AsioId { get; set; }
        public string Group { get; set; }
        #endregion
        #region CONSTRUCTORS
        public Student()
        {

        }
        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public Student(string firstName, string lastName, string asioId) :this (firstName, lastName)
        {
            AsioId = asioId;
        }
        public Student(string firstName, string lastName, string asioId, string group) : this(firstName, lastName, asioId)
        {
            Group = group;
        }
        #endregion
        #region METHODS
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", FirstName, LastName, AsioId, Group);
        }
        #endregion

    }
}

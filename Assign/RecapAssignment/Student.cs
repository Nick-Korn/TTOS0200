using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapAssignment
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentID { get; set; }

        public Student( string firstName, string lastName, string studentID)
        {
            FirstName = firstName;
            LastName = lastName;
            StudentID = studentID;
        }
    }
}

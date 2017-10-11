using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOdemot
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AsioID { get; set; }
        public Student() { }
        public Student(string fname, string lname)
        {
            FirstName = fname;
            LastName = lname;
        }
    }
}

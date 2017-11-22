using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapAssignment
{
    class Programme
    {
        public string Name { get; set; }
        public string Abbrevation { get; set; }
        public List<Course> CourseList { get; set; }

        public Programme(string name, string abbrevation)
        {
            Name = name;
            Abbrevation = abbrevation;
            CourseList = new List<Course>();
        }
        public void AddCouresList(Course course)
        {
            this.CourseList.Add(course);
        }
    }
}

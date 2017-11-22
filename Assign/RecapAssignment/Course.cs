using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapAssignment
{
    class Course
    {
        public string Name { get; set; }
        public string CourseID { get; set; }
        public List<Student> StudentList { get; set; }
        public List<Teacher> TeacherList { get; set; }

        public Course (string name, string courseID)
        {
            CourseID = courseID;
            Name = name;
            StudentList = new List<Student>();
            TeacherList = new List<Teacher>();
        }

        public void addStudentList(Student stude)
        {
            this.StudentList.Add(stude);
        }

        public void addTeacherList(Teacher teache)
        {
            this.TeacherList.Add(teache);
        }

    }
}

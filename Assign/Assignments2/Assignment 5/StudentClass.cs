using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Student
    {

        private string name;
        private string studentId;
        private string nationality;
        private string fieldOfStudy;
        private bool present;
        private int credits;
        private List<string> studentsList = new List<string>();


        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string StudentId
        {
            get
            {
                return studentId;
            }
            set
            {
                studentId = value;
            }
        }
        public string Nationality
        {
            get
            {
                return nationality;
            }
            set
            {
                nationality = value;
            }
        }
        public string FieldOfStudy
        {
            get
            {
                return fieldOfStudy;
            }
            set
            {
                fieldOfStudy = value;
            }
        }
        public bool Present { get; set; }

        public int Credits
        {
            get
            {
                return credits;
            }
            set
            {
                credits = value;
            }
        }
        public List<string> StudentsList
        {
            get
            {
                return studentsList;
            }
            set
            {
                studentsList = value;
            }
        }

        public List<string> addToDataBase()
        {
            string student = string.Format("Name: {0}, StudentID: {1}, Nationality: {2}, Field of Study: {3}, Present: {4}, Amount of ECTS: {5}", Name, StudentId, Nationality, FieldOfStudy, present, Credits);
            StudentsList.Add(student);
            return StudentsList;
        }

        public void printDataBase()
        {
            string[] studentArray = StudentsList.ToArray();
            for (int i = 0; i < studentArray.Length; i++)
            {
                Console.WriteLine(studentArray[i]);
            }
        }
    }
}

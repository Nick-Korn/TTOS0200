﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            TestMiniAsio();
        }
        static void TestMiniAsio()
        {
            List<Student> students = new List<Student>();
            Student masa = new Student("Masa", "Niemi");
            students.Add(masa);
            students.Add(new Student("Allan", "Aalto", "A1234"));
            students.Add(new Student{ FirstName = "Hanna", LastName = "Husso", AsioId = "H5678" });
            students.Add(new Student{ FirstName = "Hanna", LastName = "Husso", AsioId = "H5678", Group= "TTV17S1" });
            Student kalle = new Student();
            kalle.FirstName = "Kalle"; kalle.LastName = "Ankka"; kalle.AsioId = "K6789";
            students.Add(kalle);
            Console.WriteLine("Pelase input a number from 1-{0}:\n", students.Count);
            int i = int.Parse(Console.ReadLine());
            if (i - 1 < students.Count)
            {
                Console.WriteLine("\nMiniAsios. {0} student: {1}\n", i, students[i].ToString());
            }
            else Console.WriteLine("MiniASIO only has {0} students", students.Count);
            Console.WriteLine("All the students in miniASIO:");
            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }

            students.Sort((x, y) => x.LastName.CompareTo(y.LastName));
            Console.WriteLine("\nMiniASIOs studnets sorted in alphabetical order:");
            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine("Please input an ASIOid for the new student");
            string asioid = Console.ReadLine();
            bool lippu = false;
            foreach (var student in students)
            {
                if (asioid == student.AsioId)
                {
                    lippu = true;
                    break;
                }
            }
            if (lippu)
            {
                Console.WriteLine("ASIOid already in use.");
            }
            else
            {
                Console.WriteLine("Pleas input first name for the new student");
                string firstname = Console.ReadLine();
                Console.WriteLine("Pleas input last name for the new student") ;
                string lastname = Console.ReadLine();
                Console.WriteLine("Pleas input group name for the new student");
                string group = Console.ReadLine();
                Student newStudent = new Student(firstname, lastname, asioid, group);
                students.Add(newStudent);
                Console.WriteLine("All the students in miniASIO:");
                foreach (var student in students)
                {
                    Console.WriteLine(student.ToString());
                }
            }
        }
    }
}
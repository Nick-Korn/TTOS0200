/*
 * lab5
 * 
 * Created by: Niko Liimatainen 11/10/2017
 * Modifeid by: Niko Liimatainen 23/10/2017
 * 
 * OOP TTOS0200 Assignments of lab #4
 */
using System;
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
            //TestMiniAsio();
            //CreateCd();
            //PlayCards();
            UseHockeyTeam();
        }
        //Assignment 1
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
        //Assignment 2
        static void CreateCd()
        {
            Cd rosenrot = new Cd("Rosenrot","Rammstein");
            rosenrot.CdSongs.Add(new Song("Benzin", 3.46f));
            rosenrot.CdSongs.Add(new Song("Mann gegen Mann", 3.50f));
            rosenrot.CdSongs.Add(new Song("Rosenrot", 3.54f));
            rosenrot.CdSongs.Add(new Song("Spring", 5.24f));
            rosenrot.CdSongs.Add(new Song("Wo Bist Du?", 3.55f));
            rosenrot.CdSongs.Add(new Song("Stirb nicht vor mir", 4.05f));
            rosenrot.CdSongs.Add(new Song("Zerstören", 5.28f));
            rosenrot.CdSongs.Add(new Song("Hilf mir", 4.43f));
            rosenrot.CdSongs.Add(new Song("Te quiero Puta!", 3.55f));
            rosenrot.CdSongs.Add(new Song("Feuer und Wasser", 5.17f));
            rosenrot.CdSongs.Add(new Song("Ein Leid", 3.43f));
            Console.WriteLine(rosenrot.ToString());
        }
        //Assignment 3
        static void PlayCards()
        {
            CardDeck cards = new CardDeck();
            cards.AddCards();
            cards.ToString();
        }
        //Assignment 4
        static void UseHockeyTeam()
        {
            Team jyp = new Team("JYP", "Jyväskylä");
            jyp.GetPlayers();
            Console.WriteLine(jyp.ToString());
            jyp.RemovePlayer("Laurikainen");
            Console.WriteLine(jyp.ToString());
            jyp.RemovePlayer("Allen");
            Console.WriteLine(jyp.ToString());
            jyp.AddPlayer("Random", "Hokkanne", "Mestari", "B");
            Console.WriteLine(jyp.ToString());
            jyp.SaveCsv();
            jyp.ReadCsv();
        }
    }
}

using JAMK.IT; //helpottaa meidän tekemien luokkien löytämistä
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOdemot
{
  class Program
  {
    static void Main(string[] args)
    {
            //TestaaKiuas();
            //JAMK.IT.TestCat.Testaa();
            //TestThing();
            TestStudent();
    }

    //Lab3 Tehtävä 1: Kiuas-luokan testaus
    static void TestaaKiuas()
    {
      //luodaan kiuas olio
      Kiuas kiuas = new JAMK.IT.Kiuas();
      //pistetään kiuas lämpenemään ja asetetaan lämpöä&kosteutta
      kiuas.OnkoPäällä = true;
      kiuas.Lämpötila = 90;
      kiuas.Kosteus = 50;
      //näytetään konsolilla
      Console.WriteLine("Kiuas on päällä {0}", kiuas.OnkoPäällä);
      Console.WriteLine("Kiukaan lämpötila {0}", kiuas.Lämpötila);
      Console.WriteLine("Kiukaan kosteus {0}", kiuas.Kosteus);
      //mitä tapahtuu jos kosteus yli rajojen
      kiuas.Kosteus = 101;
      Console.WriteLine("Kiukaan kosteus {0}", kiuas.Kosteus);
    }
    static void TestThing()
    {
        OOdemot.Thing t = new Thing();
        Console.WriteLine(t.ToString());
        t.Name = "Something";
        Console.WriteLine(t.Name);
        Console.WriteLine(t.ToString());
    }
    static void TestStudent()
    {
            OOdemot.Student s = new Student();
            s.FirstName = "Niko";
            s.LastName = "Liimatainen";
            OOdemot.Student s2 = new Student("Jaska", "Jokunen");
            List<OOdemot.Student> students = new List<OOdemot.Student>();
            students.Add(s);
            students.Add(s2);
            students.Add(new Student("Arska", "Aaltonen"));
            Console.WriteLine("Class of students");
            foreach (Student item in students)
            {
                Console.WriteLine(item.ToString());
            }

    }
  }
}

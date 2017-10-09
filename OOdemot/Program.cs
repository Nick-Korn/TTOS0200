using JAMK.IT; //helpottaa meidän tekemien luokkien löytämistä
using System;

namespace OOdemot
{
  class Program
  {
    static void Main(string[] args)
    {
            //TestaaKiuas();
            //JAMK.IT.TestCat.Testaa();
            TestThing();
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
  }
}

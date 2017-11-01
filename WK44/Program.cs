using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public struct Guider
    {
        public string Name;
        public int Starts;
        public int Wins;
        public float WinPercentage;
    }
    class Program
    {
        static void ReadGuidersVer1()
        {
            try
            {
                int counter = 0;
                string line;
                StreamReader stream = new StreamReader(@"D:\K8908\Data\tilastot2017.txt");
                while ((line = stream.ReadLine()) != null)
                {
                    Console.WriteLine("{0} : {1}", counter, line);
                    counter++;
                }
                stream.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
        static void ReadGuidersVer2()
        {
            try
            {
                string seperator = ";";
                string[] lines = File.ReadAllLines(@"D:\K8908\Data\tilasto2017.csv");
                Guider driver;
                int amount = lines.Length;
                Console.WriteLine("Amount of guiders {0}", amount - 1);
                for (int i = 1; i < amount; i++)
                {
                    string[] words = lines[i].Split(seperator.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    if (int.TryParse(words[2], out int help))
                    {
                        driver.Name = words[0] + " " + words[1];
                        driver.Starts = int.Parse(words[2]);
                        driver.Wins = int.Parse(words[3]);
                        driver.WinPercentage = (100f * driver.Wins / driver.Starts);
                    }
                    else
                    {
                        driver.Name = words[0] + " " + words[1] + " " + words[2];
                        driver.Starts = int.Parse(words[3]);
                        driver.Wins = int.Parse(words[4]);
                        driver.WinPercentage = (100f * driver.Wins / driver.Starts);
                    }
                    Console.WriteLine("{0}: {1} - starts = {2}, wins = {3}, win percentage = {4}", i, driver.Name, driver.Starts, driver.Wins, driver.WinPercentage);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        static void Main(string[] args)
        {
            try
            {
                //ReadGuidersVer1();
                ReadGuidersVer2();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}

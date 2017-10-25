using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadWriteSimple();
        }
        static void ReadWriteSimple()
        {
            try
            {
                Console.WriteLine("Please input some text to be saved: \n");
                string input = Console.ReadLine();
                FileIO fileIO = new FileIO();
                fileIO.WriteFile(input);
                fileIO.ReadFile();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

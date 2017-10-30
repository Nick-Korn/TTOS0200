using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReadWriteSimple();
            ReadWriteNames();
        }
        static void ReadWriteSimple()
        {
            try
            {
                string input;
                FileIO fileIO = new FileIO();
                do
                {
                    Console.WriteLine("Please input some text to be saved: \n");
                    input = Console.ReadLine();
                    
                    if (input.Length > 0)
                    {
                        fileIO.WriteFile(input);
                    }
                } while (input.Length != 0);
                fileIO.InputFile.Close();
                if (File.Exists(fileIO.Filee))
                {
                    fileIO.ReadFile();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void ReadWriteNames()
        {
            try
            {
                NameIO test = new NameIO();
                if (File.Exists(test.Filee))
                {
                    test.ReadFile();
                }
            }
            catch (Exception e)
            {
                throw e ;
            }
        }
    }
}

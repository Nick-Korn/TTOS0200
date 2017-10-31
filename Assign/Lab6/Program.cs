using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
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
            //ReadWriteNames();
            //ReadWriteNumbers();
            ReadWriteObjects();
        }
        // Assignemt 1
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
        // Assignment 2
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
                Console.WriteLine(e.Message);
            }
        }
        // Assignmnet 3
        static void ReadWriteNumbers()
        {
            try
            {
                string userInput = "";
                NumbersIO test = new NumbersIO();
                do
                {
                    Console.WriteLine("Please input a number: ");
                    userInput = Console.ReadLine();
                    test.WriteNumbers(userInput);
                } while (int.TryParse(userInput, out int numbInt) || float.TryParse(userInput, out float numbFloat));
                Console.WriteLine("The integers: \n");
                test.ReadIntFile();
                Console.WriteLine("The floats: \n");
                test.ReadFloatFile();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
        // Assignment 4
        static void ReadWriteObjects()
        {
            try
            {
                List<TVProgram> programs = new List<TVProgram>();
                string FilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string Filee = FilePath + @"\tvshows.bin";
                programs.Add(new TVProgram("Top Gear", "MTV 3", 20.00d, 21.00d, "A show about motorized vehicles, primarly cars."));
                programs.Add(new TVProgram("Doctor Who", "TV2", 19.30d, 20.30d, "A show about an alien travling through time and space."));
                programs.Add(new TVProgram("Game of Thrones", "TV2", 22.30d, 23.15d, "An award winning fantasy sereis about the world of Westeros."));
                Stream writeStream = new FileStream(Filee, FileMode.Create, FileAccess.Write, FileShare.None);
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(writeStream, programs);
                writeStream.Close();

                Stream openStream = new FileStream(Filee, FileMode.Open, FileAccess.Read, FileShare.Read);
                List<TVProgram> readPrograms = (List<TVProgram>)formatter.Deserialize(openStream);
                openStream.Close();

                Console.WriteLine("A small catalog of tv shows:");
                foreach (var program in readPrograms)
                {
                    Console.WriteLine( " - Name: {0}\n - Channel: {1}\n - Starting time: {2}\n - Ending time: {3}\n - Description: {4}\n", 
                        program.ProgramName, program.ProgramChannel, program.ProgramStart, program.ProgramEnd, program.ProgramInfo);
                }

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}

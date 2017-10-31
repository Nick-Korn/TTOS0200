using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab6
{
    class NumbersIO
    {
        public string FileInt { get; set; }
        public string FileFloat { get; set; }
        public string FilePath { get; set; }
        public StreamWriter FileInput { get; set; }

        public NumbersIO()
        {
            FilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            FileInt = FilePath + @"\ints.txt";
            FileFloat = FilePath + @"\floats.txt";
        }
        public void WriteNumbers(string userInput)
        {
            try
            {
                if (int.TryParse(userInput, out int numberInt))
                {
                    FileInput = new StreamWriter(FileInt, append: true);
                    FileInput.WriteLine(userInput);
                    FileInput.Close();
                }
                else if (float.TryParse(userInput, out float numberFloat))
                {
                    FileInput = new StreamWriter(FileFloat, append: true);
                    FileInput.WriteLine(userInput);
                    FileInput.Close();
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public void ReadIntFile()
        {
            if (File.Exists(FileInt))
            {
                string outPut = File.ReadAllText(FileInt);
                Console.WriteLine(outPut);
            }
            else
            {
                throw new FileNotFoundException("File not found!");
            }
        }
        public void ReadFloatFile()
        {
            if (File.Exists(FileFloat))
            {
                string outPut = File.ReadAllText(FileFloat);
                Console.WriteLine(outPut);
            }
            else
            {
                throw new FileNotFoundException("File not found!");
            }
        }
    }
}

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class FileIO
    {
        public string FileInput { get; set; }
        public string FilePath { get; set; }

        public FileIO ()
        {
            FilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }
        public void WriteFile(string input)
        {
            try
            {
                FileInput = input;
                StreamWriter outputFile = new StreamWriter(FilePath + @"\test.txt");
                outputFile.Write(FileInput);
                outputFile.Close();
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public void ReadFile()
        {
            try
            {
                string outPut = File.ReadAllText(FilePath + @"\test.txt");
                Console.WriteLine(outPut);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}

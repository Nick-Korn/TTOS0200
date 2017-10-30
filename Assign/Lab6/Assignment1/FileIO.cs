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
        public string Filee { get; set; }
        public string FilePath { get; set; }
        public StreamWriter InputFile { get; set; }

        public FileIO ()
        {
            
            FilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Filee = FilePath + @"\test.txt";
            InputFile = new StreamWriter(Filee);
        }
        public void WriteFile(string input)
        {
            try
            {
                FileInput = input;
                InputFile.WriteLine(FileInput);
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
                string outPut = File.ReadAllText(Filee);
                Console.WriteLine(outPut);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}

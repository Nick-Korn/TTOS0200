using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class NameIO
    {
        #region PROPERTIES
        public string Filee { get; set; }
        public string FilePath { get; set; }
        public List<string> Data { get; set; }
        public List<string> CheckNames { get; set; }
        #endregion
        #region CONSTRUCTORS
        public NameIO()
        {
            try
            {
                FilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                Filee = FilePath + @"\names.txt";
                Data = new List<string>(File.ReadAllLines(Filee));
                CheckNames = new List<string>();
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        #endregion
        #region METHODS
        public void ReadFile()
        {
            try
            {
                int counter = 0;
                foreach (string name in Data)
                {
                    if (CheckNames.Contains(name))
                    {

                    }
                    else
                    {
                        CheckNames.Add(name);
                    }
                    counter++;
                }
                counter++;
                Console.WriteLine("There were {0} lines. And {1} names.", counter, CheckNames.Count);
                foreach (string name in CheckNames)
                {
                    counter = 0;
                    foreach (string name1 in Data)
                    {
                        if (name == name1)
                        {
                            counter++;
                        }
                    }
                    Console.WriteLine("Name {0} appears {1} times", name, counter);
                }
                Console.WriteLine('\n');
                // Bonus assignment, alphabetical sort
                CheckNames.Sort();
                foreach (string name in CheckNames)
                {
                    counter = 0;
                    foreach (string name1 in Data)
                    {
                        if (name == name1)
                        {
                            counter++;
                        }
                    }
                    Console.WriteLine("Name {0} appears {1} times", name, counter);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        } 
        #endregion
    }
}

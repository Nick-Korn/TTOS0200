using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lab5
{
    class RandomDict
    {
        public long Time { get; set; }
        public int PersonCount { get; set; }
        public Dictionary<string, Person> PersonDict { get; set; }

        public RandomDict()
        {
            PersonDict = new Dictionary<string, Person>();
        }

        public void PopulateDict()
        {
            var watch = Stopwatch.StartNew();
            do
            {
                Person person = new Person();
                person.GenerateRandomName();
                if (PersonDict.ContainsKey(person.FirstName)) { }
                else
                {
                    PersonDict.Add(person.FirstName, person);
                }

            } while (PersonDict.Count < 10000);
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Time = elapsedMs;
            PersonCount = PersonDict.Count();

        }
        public string FindThousandRandom()
        {
            string retval = "";
            var watch = Stopwatch.StartNew();
            for (int i = 0; i < 1000; i++)
            {
                
                Person person = new Person();
                person.GenerateRandomName();
                if (PersonDict.ContainsKey(person.FirstName))
                {
                    retval += string.Format(" - Found person with {0} firstname: {1} \n", person.FirstName, person.ToString());
                }
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Time = elapsedMs;
            return retval;
        }
    }
}

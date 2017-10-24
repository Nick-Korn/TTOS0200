using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lab5
{
    class RandomList
    {
        public long Time { get; set; }
        public int PersonCount { get; set; }
        public List<Person> PersonList { get; set; }

        public RandomList()
        {
            PersonList = new List<Person>();
        }
        
        public void PopulateList()
        {
            var watch = Stopwatch.StartNew();
            for (int i = 0; i < 10000; i++)
            {
                Person person = new Person();
                person.GenerateRandomName();
                PersonList.Add(person);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Time = elapsedMs;
            PersonCount = PersonList.Count();
        }
        public string FindThousandRandom()
        {
            string retval = "";
            var watch = Stopwatch.StartNew();
            for (int i = 0; i < 1000; i++)
            {
                Person person = new Person();
                person.GenerateRandomName();
                foreach (Person persona in PersonList)
                {
                    if (persona.FirstName == person.FirstName)
                    {
                        retval += string.Format(" - Found person with {0} firstname: {1} \n", person.FirstName, person.ToString());
                    }
                }
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Time = elapsedMs;
            return retval;
        }
    }
}

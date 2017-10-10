using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Baby : Human
    {
        public string Diaper { get; set; }

        public Baby(int age, float weight, float height, string name, string diaper) : 
            base(age, weight, height, name)
        {
            Diaper = diaper;
        }

        public override void Move()
        {
            Console.WriteLine("Crawling");
        }

        public override string ToString()
        {
            return base.ToString() + " " + string.Format("Diaper: {0}", Diaper);
        }
    }
}

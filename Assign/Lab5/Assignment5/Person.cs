using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Person
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        static Random RandomStr { get; set; }

        static Person()
        {
            RandomStr = new Random();
        }
        public char GenerateLetter()
        {
            
            int num = RandomStr.Next(0, 26);
            char let = (char)('A' + num);
            return let;

        }
        public void GenerateRandomName()
        {
            string retval = "";
            for (int i = 0; i < 4; i++)
            {
                retval += GenerateLetter();
            }
            FirstName = retval;
            retval = null;
            for (int i = 0; i < 10; i++)
            {
                retval += GenerateLetter();
            }
            Lastname = retval;
        }
        public override string ToString()
        {
            return string.Format("{0} {1}", FirstName, Lastname);
        }

    }
}

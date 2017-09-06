using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreeNumbers();
        }

        static void ThreeNumbers()
        {
            float input = 0;
            float loopage = 0;
            float added = 0;
            float amount = 0;
            float avg = 0;
            Console.WriteLine("Please input three numbers: ");
            for (int i = 0; i < 3; i++)
            {
                input = float.Parse(Console.ReadLine());
                added = loopage + input;
                Console.WriteLine(added);
                loopage = added;
                amount = i + 1;
            }
            avg = loopage / amount;
            Console.WriteLine(avg);
        }
        static void AskAge()
        {
            int age = 0;
            Console.WriteLine("Please input your age: ");
            age = int.Parse(Console.ReadLine());
            switch (age)
            {
                case age > 0: ;
            }
        }
    }
}

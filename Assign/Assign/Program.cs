/*
 * 
 * Created by Niko Liimatainen 6.9.2017 
 * 
 * OOP TTOS0200 Assignments 3, 4
*/

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
            //ThreeNumbers();
            AskAge();
        }

        static void ThreeNumbers()
        {
            // Assginment 3
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
            do
            {
                // Assgiment 4
                int age = 0;
                Console.WriteLine("Please input your age: ");
                age = int.Parse(Console.ReadLine());

                if (age >= 0 && age < 18)
                {
                    Console.WriteLine("Underage!");
                }
                else if (age >= 18 && age <= 65)
                {
                    Console.WriteLine("Adult!");
                }
                else if (age > 65)
                {
                    Console.WriteLine("Senior!");
                }
            } while (true);
        }
    }
}

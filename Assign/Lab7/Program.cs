using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void ThrowDice()
        {
            int rollAmounts;
            int roll;
            List<int> numberList = new List<int>();
            Dice test = new Dice();
            Console.WriteLine("How many dice throws?");
            rollAmounts = int.Parse(Console.ReadLine());
            for (int i = 0; i < rollAmounts; i++)
            {
                roll = test.ThrowDice();
                numberList.Add(roll);
            }
            double avg = numberList.Average();
            Console.WriteLine("The average of the throws is: {0}", avg);
            for (int i = 1; i < 7; i++)
            {
                int x = 0;
                foreach (int number in numberList)
                {
                    if (i == number)
                    {
                        x++;
                    }
                }
                Console.WriteLine("The number {0} appears {1} times", i, x);
            }

        }
        static void Main(string[] args)
        {
            ThrowDice();
        }
    }
}

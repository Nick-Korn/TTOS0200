using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{

    class TestBed
    {
        static void Main(string[] args)
        {
            UseInputTester();
        }

        static void UseInputTester ()
        {
            string userInput;
            Lab3.InputTester test = new InputTester();
            while (true)
            {
                Console.WriteLine("Pleas input");
                userInput = Console.ReadLine();
                bool numberResult = test.IsItAInteger(userInput);
                Console.WriteLine("Your input {0} is a number: {1}\n", userInput, numberResult);
                bool dateResult = test.IsItADate(userInput);
                Console.WriteLine("Your input {0} is a date: {1}\n", userInput, dateResult);
            }

        }
    }
}

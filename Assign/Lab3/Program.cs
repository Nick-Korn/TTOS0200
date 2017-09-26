/*
 * lab3
 * 
 * Created by: Niko Liimatainen 25/09/2017
 * Modifeid by: Niko Liimatainen 26/09/2017
 * 
 * OOP TTOS0200 Assignments of lab #3
 */
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
            //UseInputTester();
            //UseElevator();
            UseAmplifier();
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
        static void UseElevator ()
        {
            Lab3.DynamoElevator leftElevator = new DynamoElevator();
            while (true)
            {
                Console.WriteLine("You are on floor {0}", leftElevator.Floor);
                Console.WriteLine("Please Input the floor you'd like to go: ");
                leftElevator.Floor = int.Parse(Console.ReadLine());
            }
        }
        static void UseAmplifier()
        {
            Lab3.Amplifier ahuja = new Amplifier();
            while (true)
            {
                Console.WriteLine("Amplifier volume is: {0}", ahuja.Volume);
                Console.Write("Set amplifier volume to: ");
                ahuja.Volume = int.Parse(Console.ReadLine());
            }
        }
    }
}

﻿/*
 * 
 * Created by Niko Liimatainen 6.9.2017 
 * Modified by Niko Liimatainen 12.9.2017
 * 
 * OOP TTOS0200 Assignments for Lab1 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Assignments
    {
        static void Main(string[] args)
        {
            //Asker();
            //Grading();
            //ThreeNumbers();
            //AskAge();
            ConvertSeconds();
        }

        static void Asker()
        {
            do
            {
                //Assignment 1
                string userInput;
                int parsedNum;

                Console.WriteLine("Please input a number: ");
                userInput = Console.ReadLine();

                parsedNum = Int32.Parse(userInput);

                if (parsedNum > 0 && parsedNum <= 3)
                {
                    Console.WriteLine("You inputted the number {0}", userInput);
                }
                else
                {
                    Console.WriteLine("A different number.");
                }
            } while (true);
        }

        static void Grading()
        {
            //Asignment 2
            string userInput;
            int parsedNum;
            do
            {
                Console.WriteLine("Amount of points:");
                userInput = Console.ReadLine();
                parsedNum = Int32.Parse(userInput);

                if (parsedNum >= 0 & parsedNum <= 1)
                {
                    Console.WriteLine("The grade is 0");
                }
                else if (parsedNum >= 2 & parsedNum <= 3)
                {
                    Console.WriteLine("The grade is 1");
                }
                else if (parsedNum >= 4 & parsedNum <= 5)
                {
                    Console.WriteLine("The grade is 2");
                }
                else if (parsedNum >= 6 & parsedNum <= 7)
                {
                    Console.WriteLine("The grade is 3");
                }
                else if (parsedNum >= 8 & parsedNum <= 9)
                {
                    Console.WriteLine("The grade is 4");
                }
                else if (parsedNum >= 10 & parsedNum <= 12)
                {
                    Console.WriteLine("The grade is 5");
                }
                else
                {
                    Console.WriteLine("Invalid input for grading");
                }


            } while (true);
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
            // Assgiment 4
            int age = 0;
            do
            {
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
        
        static void ConvertSeconds()
        {
            // Assignment 5
            int inputSeconds = 0;
            int hours = 0;
            int minutes = 0;
            int seconds = 0;
            do
            {
                Console.WriteLine("Input seconds to be converted: ");
                inputSeconds = int.Parse(Console.ReadLine());
                if (inputSeconds >= 0 && inputSeconds < 60)
                {
                    Console.WriteLine("Seconds: " + inputSeconds);
                }
                else if (inputSeconds < 3600 && inputSeconds > 60)
                {
                    minutes = inputSeconds / 60;
                    seconds = inputSeconds % 60;
                    Console.WriteLine("Minutes: " + minutes + "\nSeconds: " + seconds);
                }
                else if (inputSeconds >= 3600)
                {
                    hours = inputSeconds / 3600;
                    minutes = (inputSeconds % 3600) / 60;
                    seconds = (inputSeconds % 3600) % 60;
                    Console.WriteLine("Hours:" + hours + "\nMinutes:" + minutes + "\nSeconds:" + seconds);
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            } while (true);
        }
        static void
    }
}

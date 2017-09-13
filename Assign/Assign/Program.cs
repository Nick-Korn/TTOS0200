/*
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
            //ConvertSeconds();
            //CalculateConsumption();
            //CheckLeapYear();
            //CheckMax();
            //AskSumNumbers();
            //CheckEvenNumber();
            //DoStarTree();
            //ReverseArray();
            //GradeSkiJump();
            //StarTheGrades();
            //GenerateStarSpruce();
            GuessRandomNumber();
            //JoinAndArrangeArrays();
            //CheckPalindrome();
            //PlayHangMan();
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
                    Console.WriteLine("Seconds: {0}", inputSeconds);
                }
                else if (inputSeconds < 3600 && inputSeconds > 60)
                {
                    minutes = inputSeconds / 60;
                    seconds = inputSeconds % 60;
                    Console.WriteLine("Minutes: {0} \nSeconds: {1}", minutes, seconds);
                }
                else if (inputSeconds >= 3600)
                {
                    hours = inputSeconds / 3600;
                    minutes = (inputSeconds % 3600) / 60;
                    seconds = (inputSeconds % 3600) % 60;
                    Console.WriteLine("Hours: {0} \nMinutes: {1} \nSeconds: {2}", hours, minutes, seconds);
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            } while (true);
        }
        static void CalculateConsumption()
        {
            //Assignment 6
            float consumptionPer100km = 7.02F;
            float fuelCostPerLitre = 1.595F;
            float consumption;
            float totalCost;
            float distance;
            do
            {
                Console.WriteLine("Please input the distance travelled: ");
                distance = int.Parse(Console.ReadLine());
                consumption = (distance / 100) * consumptionPer100km;
                totalCost = consumption * fuelCostPerLitre;
                Console.WriteLine("Fuel consumed: {0} litres \nCost of fuel for said distance: {1:c2} euros", consumption, totalCost);
            } while (true);


        }
        static void CheckLeapYear()
        {
            //Assignment 7
            float inputYear;
            float check4;
            float check400;
            float check100;
            do
            {
                Console.WriteLine("Please input a year number: ");
                inputYear = float.Parse(Console.ReadLine());
                check4 = inputYear % 4;
                check400 = inputYear % 400;
                check100 = inputYear % 100;
                if (check400 == 0)
                {
                    Console.WriteLine("Inputted year is a leap year.");
                }
                else if (check100 == 0)
                {
                    Console.WriteLine("Inputted year is not a leap year.");
                }
                else if (check4 == 0)
                {
                    Console.WriteLine("Inputted year is a leap year.");
                }
                else
                {
                    Console.WriteLine("Inputted year is not a leap year.");
                }
            } while (true);

        }
        static void CheckMax()
        {
            //Assignment 8
            int[] threeNumbers = new int[3];
            int inputNumber;
            int maxValue;
            Console.WriteLine("Please input three integers");
            for (int i = 0; i < threeNumbers.Length; i++)
            {
                inputNumber = int.Parse(Console.ReadLine());
                threeNumbers[i] = inputNumber;
            }
            maxValue = threeNumbers.Max();
            Console.WriteLine("The largest of the inputted numbers was: {0}", maxValue);
        }
        static void AskSumNumbers()
        {
            //Assignment 9
            int inputNumber;
            List<int> numList = new List<int>();
            int sum = 0;
            do
            {
                Console.WriteLine("Please input an integer");
                inputNumber = int.Parse(Console.ReadLine());
                numList.Add(inputNumber);
            } while (inputNumber != 0);
            foreach (int number in numList)
            {
                sum = number + sum;
            }
            Console.WriteLine("The sum of the inputted numbers is: {0}", sum);
        }
        static void CheckEvenNumber()
        {
            //Assignment 10
            int[] numberArray = { 1, 2, 33, 44, 55, 68, 77, 96, 100 };
            foreach (int number in numberArray)
            {
                if (number%2 == 0)
                {
                    Console.WriteLine("HEP! {0} is an even number!", number);
                }
            }
        }
        static void DoStarTree()
        {
            // Assignment 11
            int inputtedNumber;
            char star = '*';
            Console.WriteLine("Please input a number: ");
            inputtedNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < inputtedNumber +1; i++)
            {
                for (int j = 0; j < i; j++) Console.Write(star);

               Console.WriteLine("\n");
                
            }
        }
        static void ReverseArray()
        {
            //Assignment 12
            int[] numberArray = new int[5];
            int inputNumber;
            for (int i = 0; i < numberArray.Length; i++)
            {
                Console.WriteLine("Please input a number: ");
                inputNumber = int.Parse(Console.ReadLine());
                numberArray[i] = inputNumber;
            }
            Array.Reverse(numberArray);
            for (int i = 0; i < numberArray.Length; i++)
            {
                Console.WriteLine(numberArray[i]);
            }
        }
        static void GradeSkiJump()
        {
            // Assignment 13
            int[] jumpScore = new int[5];
            int inputtedNumber;
            int totalScore = 0;
            for (int i = 0; i < jumpScore.Length; i++)
            {
                Console.WriteLine("Please input the score: ");
                inputtedNumber = int.Parse(Console.ReadLine());
                jumpScore[i] = inputtedNumber;
            }
            jumpScore = jumpScore.Where(val => val != jumpScore.Max()).ToArray();
            jumpScore = jumpScore.Where(val => val != jumpScore.Min()).ToArray();
            foreach (int jump in jumpScore)
            {
                totalScore = jump + totalScore;
            }
            Console.WriteLine("The total score for the jump is: {0}", totalScore);
        }
        static void StarTheGrades()
        {
            // Assignment 14
            int inputtedValue;
            int[] gradeArray = new int[11];
            char star = '*';
            List<int> gradeList = new List<int>();
            for (int i = 0; i < gradeArray.Length; i++)
            {
                Console.WriteLine("Please input a grade: ");
                inputtedValue = int.Parse(Console.ReadLine());
                if (inputtedValue >= 0 && inputtedValue < 6)
                {
                    gradeArray[i] = inputtedValue;
                }
                else
                {
                    Console.WriteLine("Invalid Grade!!");
                    break;
                }            }
            for (int i = 0; i < 6; i++)
            {
                gradeList = gradeArray.Where(val => val == i).ToList();
                Console.Write("{0}:", i);
                foreach  (int grade in gradeList)
                {
                    Console.Write(star);
                }
                Console.Write("\n");
            }
        }
        static void GenerateStarSpruce()
        {
            // Assignment 15
            int inputtedValue;
            int root = 2;
            int starCount = 1;
            char star = '*';
            Console.WriteLine("Please input a number: ");
            inputtedValue = int.Parse(Console.ReadLine());
            for (int i = 0; i < inputtedValue - 2; i++)
            {
                for (int j = 0; j < (inputtedValue - 2 - i); j++) Console.Write(" ");
                
                for (int j = 0; j < starCount; j++) Console.Write(star);
                
                starCount = starCount + 2;
                Console.Write("\n");
            }
            for (int i = 0; i < root; i++)
            {
                for (int j = 0; j < (inputtedValue - 2); j++) Console.Write(" ");
                
                Console.WriteLine(star);
            }
        }
        static void GuessRandomNumber()
        {
            // Assignment 16
            int userInput;
            int attempts = 0;
            int nro;
            Random rnd;
            rnd = new Random();
            nro = rnd.Next(0, 100);
            do
            {
                Console.WriteLine("Guess a number: ");
                userInput = int.Parse(Console.ReadLine());
                attempts += 1;
                if(nro == userInput)
                {
                    Console.WriteLine("Excellent, you guessed the number after {0} guesses.", attempts);
                    break;
                }
                else if (nro != userInput)
                {
                    if (nro > userInput)
                    {
                        Console.WriteLine("The random number is larger then what you guessed!");
                    }
                    else if (nro < userInput)
                    {
                        Console.WriteLine("The random number is smaller than waht you guessed!");
                    }
                }
            } while (true);
        }
        static void JoinAndArrangeArrays()
        {
            // Assignment 17
            int[] firstArray = { 10, 20, 30, 40, 50 };
            int[] secondArray = { 5, 15, 25, 35, 45 };
            int[] mergedArray = new int [firstArray.Length + secondArray.Length];
            Console.Write("Numbers in the first array : ");
            foreach (int number in firstArray) Console.Write("{0}, ", number);
            Console.Write("\nNumbers in the second array : ");
            foreach (int number in secondArray) Console.Write("{0}, ", number);
            Array.Copy(firstArray, mergedArray, firstArray.Length);
            Array.Copy(secondArray, 0, mergedArray, firstArray.Length, secondArray.Length);
            Array.Sort(mergedArray);
            Console.Write("\nNumbers in the merged array : ");
            foreach (int number in mergedArray) Console.Write("{0}, ", number);
        }
        static void CheckPalindrome()
        {
            // Assignment 18
            string userInput;
            string reverse;
            Console.WriteLine("Please input a string:");
            userInput = Console.ReadLine();
            char[] charArray = userInput.ToCharArray();
            Array.Reverse(charArray);
            reverse = new string(charArray);
            if (userInput == reverse)
            {
                Console.WriteLine("You inputted a palindrome!");
            }
            else
            {
                Console.WriteLine("The string you inputted wasn't a palindrome!!");
            }
        }
        static void PlayHangMan()
        {
            // Assignment 19
            char[] guessesArray = { '_', '_', '_', ' ', '_', '_', '_'};
            string hangWord = "git gud";
            char userInput;
            int wrongGuesses = 0;
            int tick = 0;
            Console.WriteLine("HANG MAN - THE GAME");
            char[] hangArray = hangWord.ToCharArray();
            do
            {
                foreach (char letter in guessesArray) Console.Write(letter);
                if (guessesArray.SequenceEqual(hangArray))
                {
                    Console.WriteLine("\nYOU WON!!");
                    Environment.Exit(0);
                }
                Console.WriteLine("\nGuess a letter!");
                userInput = char.Parse(Console.ReadLine());
                for (int i = 0; i < hangArray.Length; i++)
                {
                    if (hangArray[i] == userInput)
                    {
                        Console.Clear();
                        Console.WriteLine("Correct");
                        guessesArray[i] = userInput;
                        tick = 0;
                    }
                    else
                    {
                        tick += 1;
                        if (tick == guessesArray.Length)
                        {
                            Console.Clear();
                            wrongGuesses += 1;
                            Console.WriteLine("Wrong! You have guessed wrong {0} times!", wrongGuesses);
                            tick = 0;
                        }
                    }
                }
            } while (wrongGuesses < 10);
            Console.WriteLine("Now you hang with the best of them!!");
        }
    }
}

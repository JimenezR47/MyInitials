using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseDigits
{
    // Author: Rigoberto Jimenez    Purpose: Reverse numbers with user input.   Date: 10/11/18
    class Program
    {
        static double GetTerm(double userInput)
        {
            // Part 1: Accepting user input.
            bool badData = true;

            while (badData)
            {
                Console.WriteLine("Acceptable range is between 1 & 999,999,999");
                Console.Write("\nEnter an integar number: ");
                userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput > 0 && userInput < 1000000)
                {
                    badData = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n<Error> Invalid data. Number is not within acceptable range. \n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
            double oriNum = userInput;
            return oriNum;
        }

        static double ExecuteTerm(double oriNum)
        {
            // Part 2: Processing the user input through the formula for reversing it.
            int n = Convert.ToInt32(oriNum);
            int left = n;
            int rev = 0;
            int r = 0;

            while (left > 0)
            {
                r = left % 10;
                rev = rev * 10 + r;
                left = left / 10;  //left = Math.floor(left / 10); 
            }
            double revNum =  rev;
            return revNum;
        }

        static void ResultTerm(double oriNum, double revNum)
        {
            // Part 3: Showing the results to the user.
            Console.WriteLine("\nOriginal Number: {0}", oriNum);
            Console.WriteLine("Reversed number: {0}\n", revNum);
        }

        static void Main(string[] args)
        {
            // Organizing the process so the user input will travel through all 3 parts.

            string userData;
            bool runAgain;
            runAgain = true;
            double userInput = 0;

            while (runAgain)
            {
                try
                {
                    // Checking after each method call to see if the value was being passed through.
                    double oriNum = GetTerm(userInput);
                    // Console.WriteLine("Original: {0}", oriNum); // Checking if original went through.
                    double revNum = ExecuteTerm(oriNum);
                    // Console.WriteLine("reverse: {0}", revNum); // Checking if reversed went through.
                    ResultTerm(oriNum, revNum);
                    // Console.WriteLine("Original: {0}, reverse: {1}", oriNum, revNum); // Final check for both original and reversed.
                }

                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n<Error> Invalid data. Number is not within acceptable range. \n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

                Console.Write("Would you like to run it again ? (Y / N)");
                userData = Console.ReadLine();
                userData = userData.ToUpper();

                if (userData != "Y")
                {
                    runAgain = false;
                }
            }
        }
    }
}

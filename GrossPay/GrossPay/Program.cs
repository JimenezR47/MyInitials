using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrossPay
{
    class Program
    {
        public static double PR { get; private set; }
        public static double HW { get; private set; }
        public static double OW { get; private set; }

        static double Money(double PR, double HW, double OW)
        {
            double M;
            M = ((PR * HW) + ((PR * 1.5) * OW));
            return M;
        }
        static void Main(string[] args)
        {
            string userData;
            bool badData;
            bool runAgain;

            runAgain = true;
            while (runAgain)
            {
                badData = true;
                while (badData)
                    try
                    {
                        double PR, HW, OW;
                        Console.WriteLine("Gross Pay Calculator: ");
                        Console.Write("Enter your current Pay Rate: ");
                        userData = Console.ReadLine();
                        PR = double.Parse(userData);

                        Console.Write("Enter your current Hours Worked: ");
                        userData = Console.ReadLine();
                        HW = double.Parse(userData);

                        Console.Write("Enter your current Over Time: ");
                        userData = Console.ReadLine();
                        OW = double.Parse(userData);

                        Console.WriteLine("");
                        Console.WriteLine("You earned ${0} this week.", Money(PR, HW, OW));

                        badData = false;
                    }
                    catch
                    {
                        Console.WriteLine("Invalid Data, try again.");
                        Console.WriteLine("");
                    }
                Console.WriteLine("");
                Console.Write("Would you like to run again? (y/n) ");

                userData = Console.ReadLine();
                userData = userData.ToLower();

                if (userData != "y")
                {
                    runAgain = false;
                }
            }

        }
    }
}

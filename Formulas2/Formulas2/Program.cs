using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulas2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Author: Rigoberto Jimenez    Purpose: Code to solve a few formulas.  Date: 9/18/2018
            
            bool runAgain = true;

            string userdata;
            // Surface Area of a Cube
            while (runAgain)
            {
                bool BadData = true;
                while (BadData)
                try
                    {
                          double SA, S;
                          Console.WriteLine("Surface area of a cube: SA = 6s^2");
                          Console.Write("Enter a Number for S: ");
                          userdata = Console.ReadLine();
                          S = double.Parse(userdata);
                          BadData = false;
                          SA = 6 * S * S;
                          Console.WriteLine("The Surface Area of the cube is: {0}", SA);
                          Console.WriteLine();
                    }
                catch
                    {
                        Console.WriteLine("Invalid number.");
                        Console.WriteLine();
                    }
                // Volume of a sphere
                BadData = true;
                while (BadData)
                try
                    {
                         double V, r, π;
                         π = 3.14;
                         Console.WriteLine("Volume of a sphere: V = (4/3)πr^3");
                         Console.Write("Enter a Number for r: ");
                         userdata = Console.ReadLine();
                         r = double.Parse(userdata);
                         BadData = false;
                         V = ((4 * π * r * r * r)/3);
                         Console.WriteLine("The Volume of the sphere is: {0:N4}", V);
                         Console.WriteLine();
                    }
                catch
                    {
                        Console.WriteLine("Invalid number.");
                        Console.WriteLine();
                    }
                // Slope of a line
                BadData = true;
                while (BadData)
                try
                    {
                        double x1, y1, x2, y2, M;

                        Console.WriteLine("The slope of a line is: M = ((y2-y1)/(x2-x2))");
                        Console.Write("Enter a Number for x1: ");
                        userdata = Console.ReadLine();
                        x1 = double.Parse(userdata);

                        Console.Write("Enter a Number for y1: ");
                        userdata = Console.ReadLine();
                        y1 = double.Parse(userdata);

                        Console.Write("Enter a Number for x2: ");
                        userdata = Console.ReadLine();
                        x2 = double.Parse(userdata);

                        Console.Write("Enter a Number for y2: ");
                        userdata = Console.ReadLine();
                        y2 = double.Parse(userdata);

                        BadData = false;
                        M = ((y2 - y1) / (x2 - x1));
                        Console.WriteLine("The slope of the line is: {0}", M);
                        Console.WriteLine();
                    }
                catch
                    {
                        Console.WriteLine("Invalid number.");
                        Console.WriteLine();
                    }
                // Population proportion
                BadData = true;
                while (BadData)
                try
                    {
                        double z, p, n, pop1, pop2;

                        Console.WriteLine("The proportion of a population is: pop = +-z √(p(1-P))/n");
                        Console.Write("Enter the number for z: ");
                        userdata = Console.ReadLine();
                        z = double.Parse(userdata);

                        Console.Write("Enter the number for p: ");
                        userdata = Console.ReadLine();
                        p = double.Parse(userdata);

                        Console.Write("Enter the number for n: ");
                        userdata = Console.ReadLine();
                        n = double.Parse(userdata);

                        BadData = false;
                        pop1 = (z) * Math.Sqrt((p * (1 - p)) / n);
                        pop2 = -(z) * Math.Sqrt((p * (1 - p)) / n);

                        Console.WriteLine("The proportion of the population is: {0:N4} and {1:N4}", pop1, pop2);
                        Console.WriteLine();
                }
                catch
                {
                        Console.WriteLine("Invalid number.");
                        Console.WriteLine();
                }
                Console.Write("Would you like to run it again? (Y/N)");
                userdata = Console.ReadLine();

                userdata = userdata.ToUpper();

                if (userdata != "Y")
                {
                    runAgain = false;
                }
            }
        }
    }
}

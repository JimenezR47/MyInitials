using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchedule
{
    class Program
    {
        static void Main(string[] args)
        {
            // Author: Rigoberto Jimenez    purpose: Display my schedule for F18    Date: 9/18/2018

            Console.WriteLine("Class schedule for Rigoberto Jimenez:");
            Console.WriteLine();
            // CL = Class
            string CL1 = ("ART 351 01 Sculpture");
            string CL2 = ("ART 428 01 Compositing");
            string CL3 = ("ART 498 03 Sen Proj Animatn");
            string CL4 = ("CSCI 105 01 Intro Program 1");
            string CL5 = ("PHES 128 01 A MND/BD FT Yoga");
            // T = Teacher
            string T1 = ("Mary E. Klopfer");
            string T2 = ("Ronald Lewis");
            string T3 = ("Matthew White");
            string T4 = ("Richard B. Miller");
            string T5 = ("Barbara S Ceresa");
            // C = Credits
            int C3 = 3;
            int C2 = 2;

            Console.WriteLine("+-------------------------------------+---------------------+---+");
            Console.WriteLine("| {0}                | {1}     | {2} |",             CL1, T1, C3);
            Console.WriteLine("| {0}              | {1}        | {2} |",            CL2, T2, C3);
            Console.WriteLine("| {0}         | {1}       | {2} |",                  CL3, T3, C3);
            Console.WriteLine("| {0}         | {1}   | {2} |",                      CL4, T4, C3);
            Console.WriteLine("| {0}        | {1}    | {2} |",                      CL5, T5, C2);
            Console.WriteLine("+-------------------------------------+---------------------+---+");
            Console.WriteLine();
        }
    }
}

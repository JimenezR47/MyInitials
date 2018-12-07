using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleDamage
{
    class Program
    {
        static double WeaponDamage()
        // Weapon Damage number input
        {
            Console.Write("Enter your Weapon Damage (10 - 500): ");
            string userData = Console.ReadLine();

            double WD;

            bool badData = true;
            while (badData)
                try
                {
                    WD = double.Parse(userData);

                    /*Console.Write("Enter your Weapon Damage (10 - 500): ");
                    userData = Console.ReadLine();
                    WD = double.Parse(userData); */

                    if (WD >= 10 && WD <= 500)
                    {
                        badData = false;
                        return WD;
                    }
                    else
                    {
                        Console.WriteLine("Please input a number between 10 to 500 for Weapon Damage.");
                        Console.WriteLine("");
                        return WeaponDamage();
                    }

                }
                catch
                {
                    Console.WriteLine("Please input a number between 10 to 500 for Weapon Damage.");
                    Console.WriteLine("");
                    return WeaponDamage();
                }
            return 0;

        }
        static double AttackPower()
        // Attack Power number input
        {
            Console.Write("Enter your Attack Power (1 - 10): ");
            string userData = Console.ReadLine();

            double AP = double.Parse(userData);

            bool badData = true;
            while (badData)
                try
                {

                    if (AP >= 1 && AP <= 10)
                    {
                        badData = false;
                        return AP;
                    }
                    else
                    {
                        Console.WriteLine("Please input a number between 1 to 10 for Attack Power.");
                        Console.WriteLine("");
                        return AttackPower();
                    }

                }
                catch
                {
                    Console.WriteLine("Please input a number between 1 to 10 for Attack Power.");
                    Console.WriteLine("");
                    return AttackPower();
                }

            return 0;
        }
        static double WeaponSpeed()
        // Weapon Speed number input
        {
            Console.Write("Enter your Weapon Speed (1.0 - 5.0): ");
            string userData = Console.ReadLine();
            double WS;
            bool badData = true;
            while (badData)
                try
                {
                    WS = double.Parse(userData);
                    if (WS >= 1 && WS <= 5)
                    {
                        badData = false;
                        return WS;
                    }
                    else
                    {
                        Console.WriteLine("Please input a number between 1.0 to 5.0 for Weapon Speed.");
                        Console.WriteLine("");
                        return WeaponSpeed();
                    }
                }
                catch
                {
                    Console.WriteLine("Please input a number between 1.0 to 5.0 for Weapon Speed.");
                    Console.WriteLine("");
                    return WeaponSpeed();
                }
            return 0;
        }
        static double DamageMultiplier()
        // Damage Multiplier number input
        {
            Console.Write("Enter your Damage Multiplier (1.0 - 4.0): ");
            string userData = Console.ReadLine();
            bool badData = true;
            double DM;
            while (badData)
                try
                {
                    DM = double.Parse(userData);

                    if (DM >= 1 && DM <= 4)
                    {
                        badData = false;
                        return DM;

                    }
                    else
                    {
                        Console.WriteLine("Please input a number between 1.0 to 4.0 for Damage Multiplier.");
                        Console.WriteLine("");
                        return DamageMultiplier();
                    }
                }
                catch
                {
                    Console.WriteLine("Please input a number between 1.0 to 4.0 for Damage Multiplier.");
                    Console.WriteLine("");
                    return DamageMultiplier();
                }
            return 0;
        }

        static void Main(string[] args)
        {
            // Author: Rigoberto Jimenez    Purpose: Code to caclulate battle damage based on user input.   Date: 9/27/18
            bool runAgain = true;
            string userData;
            double WD;
            double AP;
            double WS;
            double DM;

            while (runAgain)
            {
                Console.WriteLine("");
                Console.WriteLine("Welcome to a damage calculator, restrictions are as followed.");
                Console.WriteLine("Weapon Damage: 10 to 500");
                Console.WriteLine("Attack Power: 1 to 10");
                Console.WriteLine("Weapon Speed: 1.0 to 5.0");
                Console.WriteLine("Damage Multiplier: 1.0 to 4.0");

                WD = WeaponDamage();
                AP = AttackPower();
                WS = WeaponSpeed();
                DM = DamageMultiplier();

                Console.WriteLine();
                Console.WriteLine("Weapon Damage: {0}", WD);
                Console.WriteLine("Attack Power: {0}", AP);
                Console.WriteLine("Weapon Speed: {0:N1}", WS);
                Console.WriteLine("Damage Multiplier: {0:N1}", DM);

                double D;
                D = ((WD + AP / 3.5 * WS) * DM);
                Console.WriteLine();
                Console.WriteLine("Your damage is: {0:N2}", D);
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

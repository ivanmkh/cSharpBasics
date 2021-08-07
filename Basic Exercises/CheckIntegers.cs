using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpBasics.Basic_Exercises
{
    public static class CheckIntegers
    {
        /*
         *   Write a C# program to check two given integers and return true if one is negative and one is positive.
         */
        public static void Run()
        {
            Console.Write("Enter the first integer: ");
            var firstInteger = int.Parse(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            var secondInteger = int.Parse(Console.ReadLine());

            var result = (firstInteger > 0 && secondInteger < 0);

            Console.WriteLine("Check result for condition `if one is negative and one is positive`: {0}", result);
        }
    }
}

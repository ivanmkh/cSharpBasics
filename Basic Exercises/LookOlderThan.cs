using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpBasics.Basic_Exercises
{
    public static class LookOlderThan
    {
        /**
         * Write a C# program to print the sum of two numbers.
         */
        public static void Run()
        {
            Console.WriteLine("Enter your age, please: ");
            var age = Console.ReadLine();

            Console.WriteLine("You look alder than {0}", age);
        }
    }
}

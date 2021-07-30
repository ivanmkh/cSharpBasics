using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpBasics.Basic_Exercises
{
    public static class DivisionOfTwoNumbers
    {
        /**
         * Write a C# program to print the result of dividing two numbers.
         */
        public static void Run()
        {
            Console.WriteLine("The division of two numbers. \n");

            var a = 0;
            var b = 0;
            decimal division = 0;

            Console.Write("Enter the first number, please: ");
            int.TryParse(Console.ReadLine(), out a);

            Console.Write("Enter the second number, please: ");
            int.TryParse(Console.ReadLine(), out b);

            division = a/b;

            Console.WriteLine("The division a/b is: {0}\n", division);
        }
    }
}

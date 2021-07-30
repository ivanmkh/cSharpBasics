using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpBasics.Basic_Exercises
{
    public static class SumOfTwoNumbers
    {
        /*
         * Write a C# program to print the sum of two numbers.
         */
        public static void Run()
        {
            Console.WriteLine("The sum of two numbers. \n");

            var a = 0;
            var b = 0;
            var sum = 0;

            Console.Write("Enter the first number, please: ");
            int.TryParse(Console.ReadLine(), out a);

            Console.Write("Enter the second number, please: ");
            int.TryParse(Console.ReadLine(), out b);

            sum = a + b;
            
            Console.WriteLine("The sum is: {0}\n", sum);
        }
    }
}

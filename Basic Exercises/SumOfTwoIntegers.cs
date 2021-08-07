using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpBasics.Basic_Exercises
{
    public static class SumOfTwoIntegers
    {
        /*
         *  Write a C# program to compute the sum of two given integers, if 
         *  two values are equal then return the triple of their sum. 
         */

        public static void Run()
        {
            Console.Write("Enter the first integer: ");
            var firstInteger = int.Parse(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            var secondInteger = int.Parse(Console.ReadLine());

            var areEqual = firstInteger == secondInteger;

            double sum = firstInteger + secondInteger;
            sum = areEqual ? Math.Pow(sum, 3) : sum;

            Console.WriteLine("The result is {0}", sum);
        }

    }
}

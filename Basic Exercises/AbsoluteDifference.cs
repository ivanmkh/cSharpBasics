using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpBasics.Basic_Exercises
{
    public static class AbsoluteDifference
    {
        /*
         * Write a C# program to get the absolute value of the difference between two given numbers. 
         * Return double the absolute value of the difference if the first number is greater than second number. 
         */

        public static void Run()
        {
            Console.Write("Enter the first number: ");
            var firstNumber = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            var secondNumber= double.Parse(Console.ReadLine());

            var firstIsGreater = firstNumber > secondNumber;

            double difference = Math.Abs(firstNumber - secondNumber);
            difference = firstIsGreater ? difference * 2 : difference;

            Console.WriteLine("The result is {0}", difference);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpBasics.Basic_Exercises
{
    public static class SpecifiedOperation
    {
        /*
         * Write a C# program to print the result of the specified operations.
         * Test data:
         * -1 + 4 * 6
         * ( 35+ 5 ) % 7
         * 14 + -4 * 6 / 11
         * 2 + 15 / 6 * 1 - 7 % 2
         * Expected Output:
         * 23
         * 5
         * 12
         * 3
         */
        public static void Run()
        {
            Console.WriteLine(-1 + 4 * 6);
            //-1 + 24 = 23
            Console.WriteLine((35 + 5) % 7);
            //40 % 7 = 5 (remainder of 40/7)
            Console.WriteLine(14 + -4 * 6 / 11);
            //14 - (24/11)= 14 - 2 = 12
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
            //2 + (15/6) - remainder of (7/2) = 2 + 2 - 1 = 4 - 1 = 3
        }
    }
}

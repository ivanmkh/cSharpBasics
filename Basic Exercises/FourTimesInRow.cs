using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpBasics.Basic_Exercises
{
    public static class FourTimesInRow
    {
        /**
         * Write a C# program to that takes a number as 
         * input and display it four times in a row (separated by blank spaces), 
         * and then four times in the next row, with no separation. 
         */
        public static void Run()
        {
            Console.WriteLine("Enter the number, please: ");
            var num = Console.ReadLine();

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("{0} {0} {0} {0}", num);
                Console.WriteLine("{0}{0}{0}{0}", num);
            }
        }
    }
}

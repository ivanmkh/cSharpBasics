using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpBasics.Basic_Exercises
{
    public static class ShowRectangle
    {
        /*
         * Write a C# program that takes a number as input and then displays
         * a rectangle of 3 columns wide and 5 rows tall using that digit. 
         */
        public static void Run()
        {
            Console.WriteLine("Enter the number, please: ");
            var theNumber = Console.ReadLine();
            Console.WriteLine("The rectangle: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}{0}{0}", theNumber);
            }
        }

    }
}

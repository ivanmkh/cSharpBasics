using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpBasics.Basic_Exercises
{
    public static class ReplaceFirstAndLastChars
    {
        /*
         *   Write a C# program to create a new string from a given string where the first and last 
         *   characters will change their positions. 
         */
        public static void Run()
        {
            Console.Write("Enter the string: ");
            var inputString = Console.ReadLine();

            if (string.IsNullOrEmpty(inputString)) return;
            var length = inputString.Length;

            Console.WriteLine("Processed string: {0}",
                inputString.Substring(length - 1, 1)
                + inputString.Substring(1, length - 2)
                + inputString.Substring(0, 1)
                );
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpBasics.Basic_Exercises
{
    public static class RemoveCharByIndex
    {
        /*
         *  Write a C# program remove specified a character from a non-empty string using index of a character.
         */
        public static void Run()
        {
            var isEmpty = true;
            var inputString = "";

            while (isEmpty) 
            {
                Console.WriteLine("Enter the string: ");
                inputString = Console.ReadLine();
                isEmpty = String.IsNullOrEmpty(inputString);
            }

            Console.WriteLine("Enter the index of a character that needs to be removed");
            var idx = int.Parse(Console.ReadLine());

            if (idx < 0)
            {
                Console.WriteLine("The index cannot be negative!");
            }

            if (idx > inputString.Length)
            {
                Console.WriteLine("The index is over the string's length!");
            }

            Console.WriteLine("The string after removing character: {0}", inputString.Remove(idx, 1));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpBasics.Basic_Exercises
{
    public static class MultiplicationTable
    {
        /*
         * Write a C# Sharp program that takes a number as input and print its multiplication table.
         * Test Data:
         * Enter the number: 5
         * Expected Output:
         * 5 * 0 = 0
         * 5 * 1 = 5
         * 5 * 2 = 10
         * 5 * 3 = 15
         * ....
         * 5 * 10 = 50
         */
        private class Number 
        {
            public int a;

            public void getTheNumber()
            {
                Console.Write("Input the first number, please: ");
                int.TryParse(Console.ReadLine(), out this.a);
            }

            public void showMultiplicationTable()
            {
                for (var i = 0; i < 11; i++)
                    Console.WriteLine("{0} x {1} = {2}", this.a, i, this.a * i);
            }

        }

        public static void Run()
        {
            var number = new Number();
            number.getTheNumber();
            number.showMultiplicationTable();
        }

    }
}

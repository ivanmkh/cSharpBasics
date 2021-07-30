using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpBasics.Basic_Exercises
{
    public static class AverageOfFourNumbers
    {
        /*
         * Write a C# Sharp program that takes four numbers as input to calculate and print the average.
         * Test Data:
         * Enter the First number: 10
         * Enter the Second number: 15
         * Enter the third number: 20
         * Enter the four number: 30
         * 
         * Expected Output:
         * The average of 10 , 15 , 20 , 30 is: 18
         */
        private class Numbers 
        {
            public int a;
            public int b;
            public int c;
            public int d;

            public void getNumbers()
            {
                Console.Write("Input the first number, please: ");
                int.TryParse(Console.ReadLine(), out this.a);
                Console.Write("Input the second number, please: ");
                int.TryParse(Console.ReadLine(), out this.b);
                Console.Write("Input the third number, please: ");
                int.TryParse(Console.ReadLine(), out this.c);
                Console.Write("Input the fourth number, please: ");
                int.TryParse(Console.ReadLine(), out this.d);
            }

            public void average()
            {
                var result = (this.a + this.b + this.c + this.d) / 4;
                Console.WriteLine("The average of {0} , {1} , {2} , {3} is: {4}", this.a, this.b, this.c, this.d, result);
            }

        }

        public static void Run()
        {
            var numbers = new Numbers();

            numbers.getNumbers();
            numbers.average();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpBasics.Basic_Exercises
{
    public static class MultiplicationOfThreeNumbers
    {
        /*
         *  Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user.
         *  Test Data:
         *  Input the first number to multiply: 2
         *  Input the second number to multiply: 3
         *  Input the third number to multiply: 6
         *  Expected Output:
         *  2 x 3 x 6 = 36
         */
        private class Numbers 
        {
            public int a;
            public int b;
            public int c;

            public void getNumbers()
            {
                Console.Write("Input the first number, please: ");
                int.TryParse(Console.ReadLine(), out this.a);
                Console.Write("Input the second number, please: ");
                int.TryParse(Console.ReadLine(), out this.b);
                Console.Write("Input the third number, please: ");
                int.TryParse(Console.ReadLine(), out this.c);
            }

            public void multiply()
            {
                var result = this.a * this.b * this.c;
                Console.WriteLine("{0} x {1} x {2} = {3}", this.a, this.b, this.c, result);
            }

        }

        public static void Run()
        {
            var numbers = new Numbers();

            numbers.getNumbers();
            numbers.multiply();
        }

    }
}

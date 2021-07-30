using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpBasics.Basic_Exercises
{
    public static class OperationsOverTwoNumbers
    {
        /*
         * Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user.
         * Test Data:
         * Input the first number: 25
         * Input the second number: 4
         * Expected Output:
         * 25 + 4 = 29
         * 25 - 4 = 21
         * 25 x 4 = 100
         * 25 / 4 = 6
         * 25 mod 4 = 1
         */
        private class Numbers 
        {
            public int a;
            public int b;

            public void getNumbers()
            {
                Console.Write("Input the first number, please: ");
                int.TryParse(Console.ReadLine(), out this.a);
                Console.Write("Input the second number, please: ");
                int.TryParse(Console.ReadLine(), out this.b);
            }

            public void sum()
            {
                var result = this.a + this.b;
                Console.WriteLine("{0} + {1} = {2}", this.a, this.b, result);
            }
            public void substraction()
            {
                var result = this.a - this.b;
                Console.WriteLine("{0} - {1} = {2}", this.a, this.b, result);
            }
            public void multiply()
            {
                var result = this.a * this.b;
                Console.WriteLine("{0} x {1} = {2}", this.a, this.b, result);
            }
            public void division()
            {
                var result = this.a / this.b;
                Console.WriteLine("{0} / {1} = {2}", this.a, this.b, result);
            }
            public void modulation()
            {
                var result = this.a % this.b;
                Console.WriteLine("{0} mod {1} = {2}", this.a, this.b, result);
            }

        }

        public static void Run()
        {
            var numbers = new Numbers();

            numbers.getNumbers();
            numbers.sum();
            numbers.substraction();
            numbers.multiply();
            numbers.division();
            numbers.modulation();
        }

    }
}

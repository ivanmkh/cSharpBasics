using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpBasics.Basic_Exercises
{
    public static class SwapOfTwoNumbers
    {
        /*
         * Write a C# Sharp program to swap two numbers. 
         * Test Data:
         * Input the First Number : 5
         * Input the Second Number : 6
         * Expected Output:
         * After Swapping :
         * First Number : 6
         * Second Number : 5
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

            public void showNumbers()
            {
                Console.WriteLine("The first number is {0}", this.a);
                Console.WriteLine("The second number is {0}", this.b);
            }
            public void swap()
            {
                var temp = this.a;
                this.a = this.b;
                this.b = temp;
            }

        }

        public static void Run()
        {
            var numbers = new Numbers();

            numbers.getNumbers();
            numbers.swap();
            numbers.showNumbers();
        }

    }
}

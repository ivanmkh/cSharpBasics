using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpBasics.Basic_Exercises
{
    public static class OperationsOverThreeNumbers
    {
        /*
         *  Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y)*z and x*y + y*z.
         *  Test Data:
         *  Enter first number - 5
         *  Enter second number - 6
         *  Enter third number - 7
         *  
         *  Expected Output:
         *  Result of specified numbers 5, 6 and 7, (x+y)*z is 77 and x*y + y*z is 72
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

            public void executeOperations()
            {
                var expressionOne = (this.a + this.b) * this.c;
                var expressionTwo = this.a * this.b + this.b * this.c;
                Console.WriteLine("Result of specified numbers {0}, {1} and {2}, (x+y)*z is {3} and x*y + y*z is {4}", 
                    this.a, this.b, this.c, expressionOne, expressionTwo);
            }

        }

        public static void Run()
        {
            var numbers = new Numbers();

            numbers.getNumbers();
            numbers.executeOperations();
        }

    }
}

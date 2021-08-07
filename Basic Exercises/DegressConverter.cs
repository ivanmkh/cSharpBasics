using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpBasics.Basic_Exercises
{
    /*
     * Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit.
     */
    public static class DegreesConverter
    {
       class Degrees
        {
            float celsiusDegrees;

            public Degrees()
            {
                Console.WriteLine("Enter the degrees amount in celsius, please : ");
                var celsiusDegees = float.Parse(Console.ReadLine());
                this.celsiusDegrees = celsiusDegees;
            }

            public void ConvertToKelvin()
            {
                var degreesInKelvin = this.celsiusDegrees + 273.15f;
                Console.WriteLine("Degrees in Kelvin are {0}", degreesInKelvin); 
            }

            public void ConvertToFahrenheit()
            {
                var degreesInFahrenheit = (this.celsiusDegrees * 9 / 5) + 32;
                Console.WriteLine("Degrees in Fahrenheit are {0}", degreesInFahrenheit);
            }
        }

        public static void Run()
        {
            var degrees = new Degrees();
            degrees.ConvertToFahrenheit();
            degrees.ConvertToKelvin();
        }
    }
}

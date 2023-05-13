using System;

namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WHat's the temperature in F that you need to convert to C?");
            var input=int.Parse(Console.ReadLine());
            Console.WriteLine("The temperature is "+TempConverter.FarenheitToCelsius(input) +" farenheit");
            Console.WriteLine( "What is the temperature in Celsius that needs converting into Farenheit?");
            var inputC=int.Parse( Console.ReadLine());
            Console.WriteLine("The temperature is " + TempConverter.CelsiusToFarenheit(inputC) + " Faerenheit");
        }
    }
}
/*Now create a static class called TempConverter.The class should have at least 2 methods, one called FahrenheitToCelsius that will require a double as a parameter and return a double, the other CelsiusToFahrenheit which will also require a double as a parameter and return a double.

Fill out these methods and call them in your Program.cs file. Make sure they’re accurate!

For reference:*/

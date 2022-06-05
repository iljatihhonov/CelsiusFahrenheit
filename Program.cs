using System;

namespace CelsiusFahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ToFahrenheit();
            ToCelsius();
        }
       
        public static void ToFahrenheit()
        {
            Console.WriteLine("Enter temerature in Celsius:");
            int celsius = Convert.ToInt32(Console.ReadLine());
            int fahrenheit = (celsius * 9) / 5 + 32;
            Console.WriteLine(fahrenheit);
        }
        public static void ToCelsius()
        {
            Console.WriteLine("Enter temerature in Fahrenheit:");
            int fahrenheit = Convert.ToInt32(Console.ReadLine());
            int celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine(celsius);
        }
    }
}

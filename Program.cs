using System;

namespace CelsiusFahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start:
            Console.WriteLine("Lets convert temperature!");
            Console.WriteLine("To convert Celsius to Fahrenheit write '2f'. And if you want to convert Fahrenheit to Celsius, write '2c'. To quit write 'quit'");
            string UsersChoise = Console.ReadLine();

            if (UsersChoise == "2f")
                {
                    ToFahrenheit();
                }
            else if (UsersChoise == "2c")
                {
                    ToCelsius();
                }
            else if (UsersChoise == "quit")
            {
                Console.WriteLine("Bye!");
            }
            else
            {
                Console.WriteLine("What??? Just try again.");
                    goto Start;
            }
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

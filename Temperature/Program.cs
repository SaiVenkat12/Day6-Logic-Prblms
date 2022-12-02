using System;
namespace Temperature
{
    internal class program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Temperature Conversion");
            Console.WriteLine("To convert Celsius to Faherheit Select : 1");
            Console.WriteLine("To convert Faherheit to Celsius Select : 2");

                 int choice = Convert.ToInt16(Console.ReadLine());
            double celsius;
            double fahrenheit;
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the Temperature in Celsius");
                    celsius = double.Parse(Console.ReadLine());
                    
                    fahrenheit = (celsius * 9) / 5 + 32;
                    Console.WriteLine(celsius + " Celsius to Fahrernheit : " + fahrenheit);
                    
                    break;

                    case 2:
                    Console.WriteLine("Enter the Temperature in Fahrenheit :");
                    fahrenheit = double.Parse(Console.ReadLine());

                    celsius = (fahrenheit - 32) * 5 / 9;
                    Console.WriteLine(fahrenheit + " faherhheit to Celsius: " + celsius);

                    break;

                    default:
                    Console.WriteLine("Enter the correct option");
                    break;

             
            }
        }
    }
}
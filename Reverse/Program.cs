using System;
namespace Reverse
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to Reverse : ");
            int n = int.Parse(Console.ReadLine());
            int reverse = 0;
            int rem;
            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n = n / 10;
            }
            Console.Write("Reversed Number: " + reverse);

        }
    }
}
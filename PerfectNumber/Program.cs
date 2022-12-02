using System;
namespace PerfectNumber
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to check : ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i < n; i++)
            { 
                if( n % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (n == sum)
            {
                Console.WriteLine(n + " is a Perfect Number.");
            }
            else
            {
                Console.WriteLine(n + " is Not a Perfect Number.");
            }

        }
    }
}
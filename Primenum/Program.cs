using System;
namespace Primenum
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to check : ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            if (n == 2)
            {
                Console.WriteLine("2 is a Even Prime Number.");
            }
            else if (n == 1)
            {
                Console.WriteLine("1 is Prime Number");
            }
            else if (n == 0)
            {
                Console.WriteLine("0 is neither Prime nor composite");
            }
            else if (n > 2)
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        
                        Console.WriteLine(n + " is Not a Prime number ");
                        break;
                    }
                    else
                    {
                        
                        Console.WriteLine(n + " is a Prime number");
                        break;

                    }

                }
            }
           
        }
    }
}
using System;
namespace Sqrt
{
    internal class program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the Non Negitive Integer to find the Square Root :");
            int c = int.Parse(Console.ReadLine());
            if (c > 0 ) 
            {
                double t = c;
                double epsilon = 1e-15;
                while (Math.Abs(t - c / t) > epsilon*t)
                {
                    t = (c / t + t) / 2;
                }
                Console.WriteLine("Square Root of {0} is {1}", c, t);
            }
            else
            {
                Console.WriteLine("The Number entered {0} is not applicable.", c);
                Console.WriteLine("Enter only Non negitive integers");
            }
        }
    }
}
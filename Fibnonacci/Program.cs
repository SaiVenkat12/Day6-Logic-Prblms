using System;
namespace Fibnonacci
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the of number : ");
            int n = int.Parse(Console.ReadLine());
            int a=0; 
            int b=1;
            int sum=0;
            if (n==0)
            {
                Console.WriteLine("The Value of Fibonancci Series = 0");
            }
            else if (n==1)
            {
                Console.WriteLine("The Value of Fibonancci Series = 1");
            }
            else if (n > 0)
            {
                for (int i = 2; i <= n; i++)
                {
                    sum = a + b;
                    a = b;
                    b = sum;
                }
                Console.WriteLine("The Value of Fibonancci Series = " + sum);
            }

            else
            {
                Console.WriteLine("Enter the approriate value. ");
            }
                      


        }
    }
}
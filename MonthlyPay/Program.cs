using System;
namespace monthlyPay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n, r, pay;
            
            Console.WriteLine("Enter principle Loan Amount :");
            int P = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the numbers of Years on the Loan :");
            int Y = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter the percentage of compounded interest monthly :");
            int R = Convert.ToInt32(Console.ReadLine());

            n = 12 * Y;
            r = (R / 12 * 100);
            pay = (P * r) / (1 - Math.Pow(1 + r, -n));
            
            Console.WriteLine(" Monthly Payment of the Loan is " + pay);
        }
    }
}
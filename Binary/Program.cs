using System;
namespace Binary
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Number : ");
            double n = Convert.ToDouble(Console.ReadLine());
            string bi = Convert.ToString((byte)n, 2);
            Console.WriteLine(n + " in binary = " + bi);
        }
    }
}

using System;
using System.Diagnostics;

namespace StopWatch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number to start the Stopwatch: ");
            int Start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter any number toend the Stopwatch: ");
            int Stop = Convert.ToInt32(Console.ReadLine());
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            stopwatch.Stop();
            Console.WriteLine("Time Elapsed : {0}",
            stopwatch.Elapsed);

        }

    }
}
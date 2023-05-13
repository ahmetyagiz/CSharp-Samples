using System;
using System.Collections.Generic;
using System.Linq;

namespace FibonacciAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxFibonacciNumber = int.Parse(Console.ReadLine());
            
            int A = 0;
            int B = 1;
            int C = 1;

            List<int> fibonacciNumbers = new List<int>();

            for (int i = 0; i < maxFibonacciNumber; i++)
            {
                fibonacciNumbers.Add(C);
                Console.WriteLine(C);
                C = A + B;
                A = B;
                B = C;
            }
                
            Console.WriteLine(fibonacciNumbers.Average());
        }
    }
}
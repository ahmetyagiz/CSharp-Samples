using System;

namespace CalculateSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sumPerPow = 0;
            double sumTotalPow = 0;

            // per pow
            for (int i = 1; i <= 50; i++)
            {
                sumPerPow += Math.Pow(i, 2);
            }

            // total pow
            for (int i = 1; i <= 50; i++)
            {
                sumTotalPow += i;
            }

            sumTotalPow = Math.Pow(sumTotalPow, 2);

            Console.WriteLine(sumTotalPow - sumPerPow);
        }
    }
}
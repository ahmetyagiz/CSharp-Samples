using System;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            PositiveCheck(n);

            Console.Write("Enter the second number: ");
            int m = Convert.ToInt32(Console.ReadLine());
            PositiveCheck(m);

            int[] evenNumbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter a number: ");
                evenNumbers[i] = Convert.ToInt32(Console.ReadLine());

                PositiveCheck(evenNumbers[i]);
            }

            for (int i = 0; i < n; i++)
            {
                if (((double)m / evenNumbers[i]) % 2 == 0)
                {
                    Console.WriteLine(evenNumbers[i]);
                }
            }
        }

        static void PositiveCheck(int value)
        {
            while (value < 0) //positive check
            {
                Console.Write("Please enter a positive number: ");
                value = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}

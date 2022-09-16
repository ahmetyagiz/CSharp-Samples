using System;

namespace AlgorithmAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers do you want to enter?, Please enter a positive number: ");

            int n = Convert.ToInt32(Console.ReadLine());
            PositiveCheck(n);
            
            int[] evenNumbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter a number: ");
                evenNumbers[i] = Convert.ToInt32(Console.ReadLine());

                PositiveCheck(evenNumbers[i]);
            }

            Console.Write("Even numbers are: ");

            for (int i = 0; i < n; i++)
            {
                if (evenNumbers[i] % 2 == 0)
                {
                    Console.Write(evenNumbers[i] + " ");
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

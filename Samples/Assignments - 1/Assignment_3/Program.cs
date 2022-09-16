using System;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many sentences do you want to enter?, Please enter a positive number: ");

            int n = Convert.ToInt32(Console.ReadLine());
            PositiveCheck(n);

            string[] sentences = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter a text: ");
                sentences[i] = Console.ReadLine();
            }

            Array.Reverse(sentences);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(sentences[i]);
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

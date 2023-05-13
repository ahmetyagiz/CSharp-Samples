using System;

namespace Triangle
{
    internal class Program
    {
        static int triangleSize;

        static void Main(string[] args)
        {
            UserInput();
            DrawTriangle();
        }

        static void UserInput()
        {
            Console.Write("Enter the size of the triangle: ");
            triangleSize = Int32.Parse(Console.ReadLine());
        }

        static void DrawTriangle()
        {
            for (int i = 0; i < triangleSize - 1; i++)
            {
                Console.Write("*");

                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }
                if (i > 0)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            for (int i = 0; i < triangleSize; i++)
            {
                Console.Write("*");
            }
        }
    }
}
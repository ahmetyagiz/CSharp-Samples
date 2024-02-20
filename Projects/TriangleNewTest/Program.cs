using System;

class TriangleNewTest
{
    static void Main(string[] args)
    {
        CalculateArea();
    }

    public static void CalculateArea()
    {
        Console.Write("Enter the base of the triangle: ");
        int width = int.Parse(Console.ReadLine());

        Console.Write("Enter the height of the triangle: ");
        int height = int.Parse(Console.ReadLine());

        Console.WriteLine("\nArea of the triangle is: " + (width * height) / 2);
    }
}
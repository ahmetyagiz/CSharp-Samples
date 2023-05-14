using System;

namespace CalculateShapeArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainShapeCalculationFunction();
        }

        static void MainShapeCalculationFunction()
        {
            Console.Write("Enter the shape you want to know the area of \n(Square, Rectangular, Triangle, Circle): ");
            string selectedShape = Console.ReadLine().ToLower();

            Console.WriteLine();

            switch (selectedShape)
            {
                case "square":
                    CalculateSquareArea();
                    break;

                case "rectangular":
                    CalculateRectangularArea();
                    break;

                case "triangle":
                    CalculateTriangleArea();
                    break;

                case "circle":
                    CalculateCircleArea();
                    break;
            }
        }

        static void CalculateSquareArea()
        {
            Console.Write("Enter the side length of the square: ");
            int sideLength = int.Parse(Console.ReadLine());

            Console.WriteLine("Area of the square is: " + Math.Pow(sideLength, 2));
        }

        static void CalculateRectangularArea()
        {
            Console.Write("Enter the short side length of the rectangular: ");
            int shortSideLength = int.Parse(Console.ReadLine());

            Console.Write("Enter the long side length of the rectangular: ");
            int longSideLength = int.Parse(Console.ReadLine());

            Console.WriteLine("Area of the rectangular is: " + shortSideLength * longSideLength);
        }

        static void CalculateTriangleArea()
        {
            Console.Write("Enter the base of the triangle: ");
            int width = int.Parse(Console.ReadLine());

            Console.Write("Enter the height of the triangle: ");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Area of the triangle is: " + (width * height) / 2);
        }

        static void CalculateCircleArea()
        {
            Console.Write("Enter the radius of the circle: ");
            int radius = int.Parse(Console.ReadLine());

            Console.WriteLine("Area of the circle is: " + Math.PI * Math.Pow(radius, 2));
        }
    }
}
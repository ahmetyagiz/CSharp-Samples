using System;

namespace CalculateShapeArea
{
    class Program
    {
        static void Main(string[] args)
        {
            MainShapeCalculation();
        }

        static void MainShapeCalculation()
        {
            string selectedShape;

            while (true)
            {
                Console.Write("Please enter the shape you want to know the area or perimeter of\n(Square, Rectangle, Triangle, Circle): ");
                selectedShape = Console.ReadLine().ToLower();

                if (selectedShape == "square" || selectedShape == "rectangle" || selectedShape == "triangle" || selectedShape == "circle")
                {
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.WriteLine("\nPlease enter a valid value.\n");
                }
            }

            switch (selectedShape)
            {
                case "square":
                    Square.Calculate();
                    break;

                case "rectangle":
                    Rectangle.Calculate();
                    break;

                case "triangle":
                    Triangle.Calculate();
                    break;

                case "circle":
                    Circle.Calculate();
                    break;
            }
        }
    }
}
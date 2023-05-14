using System;

class Rectangle
{
    public static void Calculate()
    {
        while (true)
        {
            Console.Write("Do you want the area or the perimeter of the rectangle? \n(Area, Perimeter): ");
            string process = Console.ReadLine().ToLower();

            if (process == "area")
            {
                CalculateArea();
                break;
            }
            else if (process == "perimeter")
            {
                CalculatePerimeter();
                break;
            }
            else
            {
                Console.WriteLine("\nPlease enter a valid value\n");
            }
        }
    }

    public static void CalculateArea()
    {
        Console.Write("\nEnter the short side length of the rectangle: ");
        int shortSideLength = int.Parse(Console.ReadLine());

        Console.Write("Enter the long side length of the rectangle: ");
        int longSideLength = int.Parse(Console.ReadLine());

        Console.WriteLine("\nArea of the rectangle is: " + shortSideLength * longSideLength);
    }

    public static void CalculatePerimeter()
    {
        Console.Write("\nEnter the short side length of the rectangle: ");
        int shortSideLength = int.Parse(Console.ReadLine());

        Console.Write("Enter the long side length of the rectangle: ");
        int longSideLength = int.Parse(Console.ReadLine());

        Console.WriteLine("\nPerimeter of the rectangle is: " + 2 * (shortSideLength + longSideLength));
    }
}
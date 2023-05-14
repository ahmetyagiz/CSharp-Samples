using System;

class Square
{
    public static void Calculate()
    {
        while (true)
        {
            Console.Write("Do you want the area or the perimeter of the square? \n(Area, Perimeter): ");
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
        Console.Write("\nPlease enter the side length of the square: ");
        int sideLength = int.Parse(Console.ReadLine());

        Console.WriteLine("\nArea of the square is: " + Math.Pow(sideLength, 2));
    }

    public static void CalculatePerimeter()
    {
        Console.Write("\nPlease enter the side length of the square: ");
        int sideLength = int.Parse(Console.ReadLine());

        Console.WriteLine("\nPerimeter of the square is: " + 4 * sideLength);
    }
}
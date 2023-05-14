using System;

class Triangle
{
    public static void Calculate()
    {
        while (true)
        {
            Console.Write("Do you want the area or the perimeter of the triangle? \n(Area, Perimeter): ");
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
        Console.Write("\nEnter the base of the triangle: ");
        int width = int.Parse(Console.ReadLine());

        Console.Write("Enter the height of the triangle: ");
        int height = int.Parse(Console.ReadLine());

        Console.WriteLine("\nArea of the triangle is: " + (width * height) / 2);
    }

    public static void CalculatePerimeter()
    {
        Console.Write("\nEnter the first side length of the triangle: ");
        int triangleFirstLength = int.Parse(Console.ReadLine());

        Console.Write("Enter the second side length of the triangle: ");
        int triangleSecondLength = int.Parse(Console.ReadLine());

        Console.Write("Enter the third side length of the triangle: ");
        int triangleThirdLength = int.Parse(Console.ReadLine());

        Console.WriteLine("\nPerimeter of the triangle is: " + (triangleFirstLength + triangleSecondLength + triangleThirdLength));
    }
}
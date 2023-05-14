using System;

class Circle
{
    public static void Calculate()
    {
        while (true)
        {
            Console.Write("Do you want the area or the perimeter of the circle? \n(Area, Perimeter): ");
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
        Console.Write("\nEnter the radius of the circle: ");
        int radius = int.Parse(Console.ReadLine());

        Console.WriteLine("\nArea of the circle is: " + Math.PI * Math.Pow(radius, 2));
    }

    public static void CalculatePerimeter()
    {
        Console.Write("\nEnter the radius of the circle: ");
        int radius = int.Parse(Console.ReadLine());

        Console.WriteLine("\nPerimeter of the circle is: " + 2 * Math.PI * radius);
    }
}
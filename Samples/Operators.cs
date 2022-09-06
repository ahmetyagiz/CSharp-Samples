using System;

class Operators
{
    static void Main(string[] args)
    {
        //Assignment
        Console.WriteLine("***** Assignment Operators *****");
        int x = 3;
        int y = 3;
        y = y + 2;

        Console.WriteLine(y);
        y += 2;
        Console.WriteLine(y);
        y /= 1;
        Console.WriteLine(y);
        x *= 2;
        Console.WriteLine(x);

        //Logical Operators
        Console.WriteLine("***** Logical Operators *****");

        bool isSuccess = true;
        bool isCompleted = false;

        if (isSuccess && isCompleted)
        {
            Console.WriteLine("Perfect!");
        }
        if (isSuccess || isCompleted)
        {
            Console.WriteLine("Great!");
        }
        if (isSuccess && !isCompleted)
        {
            Console.WriteLine("Fine!");
        }

        //Relational Operators
        Console.WriteLine("***** Relational Operators *****");

        int a = 3;
        int b = 4;

        bool result = a < b;

        Console.WriteLine(result);
        result = a > b;
        Console.WriteLine(result);
        result = a >= b;
        Console.WriteLine(result);
        result = a <= b;
        Console.WriteLine(result);
        result = a == b;
        Console.WriteLine(result);
        result = a != b;
        Console.WriteLine(result);

        Console.WriteLine("***** Arithmetic Operators *****");

        int value1 = 10;
        int value2 = 5;
        int result1 = value1 / value2;

        Console.WriteLine(result1);

        result1 = value1 * value2;
        Console.WriteLine(result1);

        result1 = value1 * value2;
        Console.WriteLine(result1);

        result1 += value1++;
        Console.WriteLine(result1);

        // % : mod
        int result2 = 20 % 3;
        Console.WriteLine(result2);
    }
}
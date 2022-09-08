using System;

class WhileForeach
{
    static void Main(string[] args)
    {
        //while
        //Average of numbers from 1 to 10
        Console.Write("Please enter a value: ");

        int value = int.Parse(Console.ReadLine());
        int counter = 1;
        int sum = 0;

        while (counter <= value)
        {
            sum += counter;
            counter++;
        }

        Console.WriteLine(sum / value);

        // Print letters from 'a' to 'z'
        char character = 'a';
        while (character <= 'z')
        {
            Console.Write(character);
            character++;
        }

        Console.Write("***** Foreach *****");
        string[] arabalar = { "BMW", "Ford", "Toyota", "Nissan" };

        foreach (var araba in arabalar)
        {
            Console.WriteLine(araba);
        }
    }
}
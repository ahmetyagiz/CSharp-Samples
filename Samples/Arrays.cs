using System;

class Arrays
{
    static void Main(string[] args)
    {
        //Declare a string array
        string[] colors = new string[5];

        string[] animals = { "Cat", "Dog", "Bird", "Monkey" };

        int[] arr;
        arr = new int[5];

        //Value assignment to array
        colors[0] = "Blue";
        arr[3] = 10;
        Console.WriteLine(animals[0]);
        arr[3] = 10;

        Console.WriteLine(animals[1]);
        Console.WriteLine(arr[3]);
        Console.WriteLine(colors[0]);

        //Array in loop
        Console.Write("Please enter a value: ");
        int arrLength = int.Parse(Console.ReadLine());
        int[] arrNum = new int[arrLength];

        for (int i = 0; i < arrLength; i++)
        {
            Console.Write("Please {0}. enter a value:", i + 1);
            arrNum[i] = int.Parse(Console.ReadLine());
        }

        int sum = 0;
        foreach (var arrItem in arrNum)
        {
            sum += arrItem;
        }

        Console.WriteLine("Average of the number is: " + (double)sum / arrLength);
    }
}
using System;

public class FactorialExample
{
    public static void Main(string[] args)
    {
        int factorial = 1;

        Console.Write("Bir sayı giriniz: ");
        int input = int.Parse(Console.ReadLine());

        for (int i = 1; i <= input; i++)
        {
            factorial = factorial * i;
        }

        Console.Write(input + " faktoriyeli: " + factorial);
    }
}
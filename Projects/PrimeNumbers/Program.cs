using System;

class Program
{
    static void Main(string[] args)
    {
        int inputValue = 0;
        bool formatCheck = true;
        bool primeCheck = true;

        while (formatCheck || inputValue < 0)
        {
            try
            {
                Console.Write("Sayıyı giriniz: ");
                inputValue = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Yanlış bir değer girdiniz");
                continue;
            }
            if (inputValue < 0)
            {
                Console.WriteLine("Yanlış bir değer girdiniz");
            }
            formatCheck = false;
        }

        for (int m = 2; m < inputValue; m++)
        {
            if (inputValue % m == 0)
            {
                primeCheck = false;
                break;
            }
        }

        if (primeCheck == true)
        {
            Console.WriteLine(inputValue + " sayı asal sayıdır.");
        }
        else
        {
            Console.WriteLine(inputValue + " sayı asal değildir.");
        }
    }
}
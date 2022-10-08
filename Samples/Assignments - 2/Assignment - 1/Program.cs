using System;
using System.Collections.Generic;
using System.Collections;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList nonPrimeNumbers = new ArrayList();
            ArrayList primeNumbers = new ArrayList();

            int primeNumbersSum = 0;
            int nonPrimeNumbersSum = 0;

            //input values
            for (int i = 0; i < 20; i++)
            {
                int inputValue = 0;
                bool formatCheck = true;
                bool primeCheck = true;

                while (formatCheck || inputValue < 0)
                {
                    try
                    {
                        Console.Write($"{i + 1}. sayıyı giriniz: ");
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
                    primeNumbersSum += inputValue;
                    primeNumbers.Add(inputValue);
                }
                else
                {
                    nonPrimeNumbersSum += inputValue;
                    nonPrimeNumbers.Add(inputValue);
                }
            }
            
            // sort values
            primeNumbers.Sort();
            primeNumbers.Reverse();

            nonPrimeNumbers.Sort();
            nonPrimeNumbers.Reverse();

            // print values
            Console.WriteLine("\nAsal sayılar:");
            foreach (var item in primeNumbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Asal olmayan sayılar:");
            foreach (var item in nonPrimeNumbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"\nAsal sayıların sayısı: {primeNumbers.Count}");
            Console.WriteLine($"Asal sayıların ortalaması: {primeNumbersSum / (float)primeNumbers.Count} ");

            Console.WriteLine($"Asal olmayan sayıların sayısı: {nonPrimeNumbers.Count}");
            Console.WriteLine($"Asal olmayan sayıların ortalaması: {nonPrimeNumbersSum / (float)nonPrimeNumbers.Count} ");
        }
    }
}
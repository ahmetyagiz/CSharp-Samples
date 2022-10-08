using System;
using System.Collections.Generic;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = new int[6];
            int smallestSum = 0;
            int biggestSum = 0;

            for (int i = 0; i < 6; i++)
            {
                Console.Write($"{i + 1}. Sayıyı giriniz: ");
                values[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(values);

            int[] smallestNumbers = new int[3];

            Console.WriteLine("\nEn küçük 3 sayı: ");
            for (int i = 0; i < 3; i++)
            {
                smallestNumbers[i] = values[i];
                smallestSum += smallestNumbers[i];
                Console.WriteLine(values[i]);
            }

            Array.Reverse(values);

            int[] biggestNumbers = new int[3];

            for (int i = 0; i < 3; i++)
            {
                biggestNumbers[i] = values[i];
                biggestSum += biggestNumbers[i];
            }

            Array.Reverse(values);

            Console.WriteLine("En büyük 3 sayı: ");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(values[i]);
            }

            //result
            float smallestAverage = (float)smallestSum / 3;
            float biggestAverage = (float)biggestSum / 3;

            Console.WriteLine($"\nEn büyük sayıların ortalaması {smallestAverage}");
            Console.WriteLine($"En küçük sayıların ortalaması {biggestAverage}");
            Console.WriteLine("Ortalama toplamları: " + (smallestAverage + biggestAverage));
        }
    }
}
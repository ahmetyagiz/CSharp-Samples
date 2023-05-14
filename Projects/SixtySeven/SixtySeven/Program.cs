using System;
using System.Collections.Generic;
using System.Linq;

namespace SixtySeven
{
    internal class Program
    {
        /// <summary>
        /// Ekrandan girilen n tane sayının 67'den küçük yada büyük olduğuna bakan. Küçük olanların farklarının toplamını, büyük ise de farkların mutlak karelerini alarak toplayıp ekrana yazdıran console uygulamasını yazınız.
        /// Örnek: Input: 56 45 68 77
        /// Output: 33 101
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> smallerThanSixtySevenNumbers = new List<int>();
            List<int> biggerThanSixtySevenNumbers = new List<int>();

            foreach (int number in inputNumbers)
            {
                if (number < 67)
                {
                    smallerThanSixtySevenNumbers.Add(67 - number);
                }
                else if (number > 67)
                {
                    biggerThanSixtySevenNumbers.Add((int)Math.Pow(67 - number, 2));
                }
            }

            Console.Write(smallerThanSixtySevenNumbers.Sum() + " " + biggerThanSixtySevenNumbers.Sum());
        }
    }
}
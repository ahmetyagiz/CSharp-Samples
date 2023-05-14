using System;
using System.Collections.Generic;
using System.Linq;

namespace IntSum
{
    internal class Program
    {
        /// <summary>
        /// Ekrandan girilen n tane integer ikililerin toplamını alan, eğer sayılar birbirinden farklıysa toplamlarını ekrana yazdıran, sayılar aynıysa toplamının karesini ekrana yazdıran console uygulamasını yazınız.
        /// Örnek Input: 2 3 1 5 2 5 3 3
        /// Output: 5 6 7 36
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Please enter at least two numbers: ");
            List<int> numberList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            if (numberList.Count > 1)
            {
                for (int i = 0; i < numberList.Count; i += 2)
                {
                    if (numberList[i] == numberList[i + 1])
                    {
                        Console.Write(Math.Pow(numberList[i] + numberList[i], 2) + " ");
                    }
                    else
                    {
                        Console.Write(numberList[i] + numberList[i + 1] + " ");
                    }
                }
            }
        }
    }
}
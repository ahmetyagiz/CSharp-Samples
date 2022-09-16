using System;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please write a senctence: ");

            string n = Console.ReadLine();
            Console.WriteLine("Word count: " + n.Split(' ').Length); //Kelime sayısı sayısı

            n.Replace(" ", "");
            Console.WriteLine("Letter counts: " + n.Length); //Harf sayısı/
        }
    }
}
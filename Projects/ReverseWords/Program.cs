using System;

namespace ReverseString
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Lütfen bir metin giriniz : ");

            string input = Console.ReadLine();

            var array = input.Split(' ');

            string[] newArray = new string[array.Length];

            string memberOfArray = null;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = array[i].Length - 1; j >= 0; j--)
                {
                    memberOfArray += array[i][j];
                    newArray[i] = memberOfArray;
                }

                memberOfArray = null;
            }

            foreach (var item in newArray)
            {
                Console.Write(item + " ");
            }
        }
    }
}
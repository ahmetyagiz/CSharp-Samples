using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            Console.Write("Metni giriniz: ");
            string input = Console.ReadLine();

            // separate words
            string[] inputSpltArr = input.Split(' ');

            for (int i = 0; i < inputSpltArr.Length; i++)
            {
                // convert word to char array
                Char[] charArray = inputSpltArr[i].ToCharArray();

                // reverse the char array
                Array.Reverse(charArray);

                for (int j = 0; j < charArray.Length; j++)
                {
                    // print letters
                    Console.Write(charArray[j]);
                }

                // space after word
                Console.Write(" ");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm
{
    internal class Program
    {
        static string input;
        static string[] veriler;

        static void Main()
        {
            UserInput();
            StringRemover();
        }

        static void UserInput()
        {
            Console.WriteLine("Please enter the word to be deleted and the letter number you want to delete. ");
            Console.Write("\n(e.g. input \"Algorithm, 3\" -> output \"Algrithm\"): ");
            input = Console.ReadLine();
            veriler = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }

        static void StringRemover()
        {
            for (int i = 0; i < veriler.Length; i += 2)
            {
                string strValue = veriler[i];
                int deletedLetterNumber = int.Parse(veriler[i + 1]);

                if (deletedLetterNumber < strValue.Length)
                {
                    Console.Write(strValue.Remove(deletedLetterNumber, 1) + " ");
                }
                else
                {
                    Console.Write(strValue + " ");
                }
            }
        }
    }
}

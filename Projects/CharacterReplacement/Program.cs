using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CharacterReplacement
{
    internal class Program
    {
        /// <summary>
        /// Verilen string ifade içerisindeki ilk ve son karakterin yerini değiştirip tekrar ekrana yazdıran console uygulamasını yazınız.
        /// Örnek: Input: Merhaba Hello Algoritma x
        /// Output: aerhabM oellH algoritmA x
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Kelimeleri giriniz: ");
            List<string> inputs = Console.ReadLine().Split(' ').ToList();

            for (int i = 0; i < inputs.Count; i++)
            {
                string word = inputs[i];

                if (word.Length > 1)
                {
                    char firstChar = word[0];
                    char lastChar = word[word.Length - 1];

                    word = word.Remove(0, 1);
                    word = word.Remove(word.Length - 1);

                    word = word.Insert(word.Length, firstChar.ToString());
                    word = word.Insert(0, lastChar.ToString());

                    Console.Write(word + " ");
                }
                else
                {
                    Console.Write(word + " ");
                }
            }
        }
    }
}
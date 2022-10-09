using System;

namespace Consonants
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            Console.Write("Metni giriniz: ");
            string input = Console.ReadLine();
            string[] spltInputArr = input.Split(' ');
            
            char tempChar = ' ';
            bool isTempConsonant;
            bool isCurrentConsonant;
            bool isConsonant = false;

            // every words
            for (int i = 0; i < spltInputArr.Length; i++)
            {
                Char[] charArr = spltInputArr[i].ToCharArray();

                // every letters
                for (int j = 0; j < charArr.Length; j++)
                {
                    isConsonant = false;
                    isTempConsonant = false;
                    isCurrentConsonant = false;

                    if (charArr[j] == 'B' || charArr[j] == 'b' ||
                        charArr[j] == 'C' || charArr[j] == 'c' ||
                        charArr[j] == 'Ç' || charArr[j] == 'ç' ||
                        charArr[j] == 'D' || charArr[j] == 'd' ||
                        charArr[j] == 'F' || charArr[j] == 'f' ||
                        charArr[j] == 'G' || charArr[j] == 'g' ||
                        charArr[j] == 'Ğ' || charArr[j] == 'ğ' ||
                        charArr[j] == 'H' || charArr[j] == 'h' ||
                        charArr[j] == 'J' || charArr[j] == 'j' ||
                        charArr[j] == 'K' || charArr[j] == 'k' ||
                        charArr[j] == 'L' || charArr[j] == 'l' ||
                        charArr[j] == 'M' || charArr[j] == 'm' ||
                        charArr[j] == 'N' || charArr[j] == 'n' ||
                        charArr[j] == 'P' || charArr[j] == 'p' ||
                        charArr[j] == 'R' || charArr[j] == 'r' ||
                        charArr[j] == 'S' || charArr[j] == 's' ||
                        charArr[j] == 'Ş' || charArr[j] == 'ş' ||
                        charArr[j] == 'T' || charArr[j] == 't' ||
                        charArr[j] == 'V' || charArr[j] == 'v' ||
                        charArr[j] == 'Y' || charArr[j] == 'y' ||
                        charArr[j] == 'Z' || charArr[j] == 'z')
                    {
                        isCurrentConsonant = true;
                    }

                    if (tempChar == 'B' || tempChar == 'b' ||
                        tempChar == 'C' || tempChar == 'c' ||
                        tempChar == 'Ç' || tempChar == 'ç' ||
                        tempChar == 'D' || tempChar == 'd' ||
                        tempChar == 'F' || tempChar == 'f' ||
                        tempChar == 'G' || tempChar == 'g' ||
                        tempChar == 'Ğ' || tempChar == 'ğ' ||
                        tempChar == 'H' || tempChar == 'h' ||
                        tempChar == 'J' || tempChar == 'j' ||
                        tempChar == 'K' || tempChar == 'k' ||
                        tempChar == 'L' || tempChar == 'l' ||
                        tempChar == 'M' || tempChar == 'm' ||
                        tempChar == 'N' || tempChar == 'n' ||
                        tempChar == 'P' || tempChar == 'p' ||
                        tempChar == 'R' || tempChar == 'r' ||
                        tempChar == 'S' || tempChar == 's' ||
                        tempChar == 'Ş' || tempChar == 'ş' ||
                        tempChar == 'T' || tempChar == 't' ||
                        tempChar == 'V' || tempChar == 'v' ||
                        tempChar == 'Y' || tempChar == 'y' ||
                        tempChar == 'Z' || tempChar == 'z')
                    {
                        isTempConsonant = true;
                    }

                    if (isCurrentConsonant && isTempConsonant)
                    {
                        isConsonant = true;
                        tempChar = ' ';
                        break;
                    }
                    else
                    {
                        tempChar = charArr[j];
                    }
                }

                Console.Write(isConsonant + " ");
            }
        }
    }
}
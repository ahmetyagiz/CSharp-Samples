using System;

class Program
{
    static void Main(string[] args)
    {
        string inputValue = Console.ReadLine();
        char[] chrArray = inputValue.ToCharArray();

        for (int m = 0; m < chrArray.Length; m++)
        {
            for (int i = 0; i < chrArray.Length; i++)
            {
                while (chrArray[i] == 'A' || chrArray[i] == 'a')
                {
                    Console.Write(chrArray[i]);
                    chrArray[i] = ' ';
                }
            }
            for (int i = 0; i < chrArray.Length; i++)
            {
                while (chrArray[i] == 'E' || chrArray[i] == 'e')
                {
                    Console.Write(chrArray[i]);
                    chrArray[i] = ' ';
                }
            }
            for (int i = 0; i < chrArray.Length; i++)
            {
                while (chrArray[i] == 'I' || chrArray[i] == 'ı')
                {
                    Console.Write(chrArray[i]);
                    chrArray[i] = ' ';
                }
            }
            for (int i = 0; i < chrArray.Length; i++)
            {
                while (chrArray[i] == 'İ' || chrArray[i] == 'i')
                {
                    Console.Write(chrArray[i]);
                    chrArray[i] = ' ';
                }
            }
            for (int i = 0; i < chrArray.Length; i++)
            {
                while (chrArray[i] == 'O' || chrArray[i] == 'o')
                {
                    Console.Write(chrArray[i]);
                    chrArray[i] = ' ';
                }
            }
            for (int i = 0; i < chrArray.Length; i++)
            {
                while (chrArray[i] == 'Ö' || chrArray[i] == 'ö')
                {
                    Console.Write(chrArray[i]);
                    chrArray[i] = ' ';
                }
            }
            for (int i = 0; i < chrArray.Length; i++)
            {
                while (chrArray[i] == 'U' || chrArray[i] == 'u')
                {
                    Console.Write(chrArray[i]);
                    chrArray[i] = ' ';
                }
            }
            for (int i = 0; i < chrArray.Length; i++)
            {
                while (chrArray[i] == 'Ü' || chrArray[i] == 'ü')
                {
                    Console.Write(chrArray[i]);
                    chrArray[i] = ' ';
                }
            }
        }
    }
}
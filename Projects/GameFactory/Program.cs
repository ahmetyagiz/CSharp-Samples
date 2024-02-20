using System;

class Solution
{
    static void Main(string[] args)
    {
        Console.Write("Lütfen bir sayı giriniz: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("GameFactory");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Game");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Factory");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}
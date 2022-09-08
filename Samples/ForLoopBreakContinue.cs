using System;

class ForLoopBreakContinue
{
    static void Main(string[] args)
    {
        //Odd numbers {1, 3, 5, 7, 9...}
        //Even numbers {0, 2, 4, 6, 8...}

        Console.WriteLine("Lütfen bir sayı giriniz");
        int counter = int.Parse(Console.ReadLine());

        for (int i = 0; i <= counter; i++)
        {
            if (i % 2 == 1)
            {
                Console.WriteLine(i);
            }
        }

        //Odd numbers sum and even numbers sum between 1 and 1000
        int oddSum = 0;
        int evenSum = 0;
        for (int i = 1; i <= 1000; i++)
        {
            if (i % 2 == 1)
            {
                oddSum += i;
            }
            else
            {
                evenSum += i;
            }
        }

        Console.WriteLine("Sum of the odd numbers: " + oddSum);
        Console.WriteLine("Sum of the even Numbers: " + evenSum);

        //break, continue

        for (int i = 1; i <= 10; i++)
        {
            if (i == 4)
            {
                //break; //{1, 2, 3, 4}
                continue; //{1, 2, 3, 5, 6, 7, 8, 9}
            }

            Console.WriteLine(i);
        }
    }
}
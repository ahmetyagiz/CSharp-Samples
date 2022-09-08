using System;

class SwitchCase
{
    static void Main(string[] args)
    {
        int month = DateTime.Now.Month;

        //Expression
        switch (month)
        {
            case 1:
                Console.WriteLine("You're in January!");
                break;
            case 2:
                Console.WriteLine("You're in February!");
                break;
            case 3:
                Console.WriteLine("You're in March!");
                break;
            case 4:
                Console.WriteLine("You're in April!");
                break;
            case 5:
                Console.WriteLine("You're in May!");
                break;
            case 6:
                Console.WriteLine("You're in June!");
                break;
            case 7:
                Console.WriteLine("You're in July!");
                break;
            case 8:
                Console.WriteLine("You're in August!");
                break;
            case 9:
                Console.WriteLine("You're in September!");
                break;
            case 10:
                Console.WriteLine("You're in October!");
                break;
            case 11:
                Console.WriteLine("You're in November!");
                break;
            case 12:
                Console.WriteLine("You're in December!");
                break;

            default:
                Console.WriteLine("Wrong Value!");
                break;
        }

        switch (month)
        {
            case 12:
            case 1:
            case 2:
                Console.WriteLine("You're in Winter!");
                break;
            case 3:
            case 4:
            case 5:
                Console.WriteLine("You're in Spring!");
                break;
            case 6:
            case 7:
            case 8:
                Console.WriteLine("You're in Summer!");
                break;
            case 9:
            case 10:
            case 11:
                Console.WriteLine("You're in Fall!");
                break;
            default:
                break;
        }
    }
}
using System;

class IfElseTernary
{
    static void Main(string[] args)
    {
        int time = DateTime.Now.Hour;

        if (time >= 6 && time <= 11)
            Console.WriteLine("Good Morning!");
        else if (time <= 18)
            Console.WriteLine("Have a good day!");
        else
            Console.WriteLine("Good Night!");

        string sonuc = time <= 18 ? "Have a good day!" : "Good Night!";

        sonuc = time >= 6 && time < 11 ? "Good Morning" : time <= 18 ? "Have a good day!" : "Good Night!";

        Console.WriteLine(sonuc);
    }
}

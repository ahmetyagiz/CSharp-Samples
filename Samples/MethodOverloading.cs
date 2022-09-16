using System;

class MethodOverloading
{
    static void Main(string[] args)
    {
        //out parameters
        string num = "999";

        bool isConverted = int.TryParse(num, out int outSayi);

        if (isConverted == true)
        {
            Console.WriteLine("Success!");
            Console.WriteLine(outSayi);
        }
        else
        {
            Console.WriteLine("Failed!");
        }

        Methods instance = new Methods();
        instance.Sum(4, 5, out int toplamSonucu);
        Console.WriteLine(toplamSonucu);

        //Method Overloading
        int value = 999;
        instance.PrintConsole(Convert.ToString(value));
        instance.PrintConsole(value);
        instance.PrintConsole("Ahmet", "Yagiz");
        //Method Signature
        //methodName + parameter count + parameter
    }
}

class Methods
{
    public void Sum(int a, int b, out int sum)
    {
        sum = a + b;
    }

    //Overloading
    public void PrintConsole(string data)
    {
        Console.WriteLine(data);
    }

    public void PrintConsole(int data)
    {
        Console.WriteLine(data);
    }

    public void PrintConsole(string data_1, string data_2)
    {
        Console.WriteLine(data_1 + data_2);
    }
}
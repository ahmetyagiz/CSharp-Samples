using System;

class RecursiveAndExtensionMethods
{
    static void Main(string[] args)
    {
        //Recursive - Öz yinelemeli
        //3^4 = 3*3*3*3

        int result = 1;

        for (int i = 1; i < 5; i++)
        {
            result = result * 3;
            //Console.WriteLine(result);
        }

        Operations instance = new();
        Console.WriteLine(instance.Expo(3, 4));

        //Extension Methods
        string ifade = "Ahmet Yagiz";
        bool sonuc = ifade.CheckSpaces();
        Console.WriteLine(sonuc);

        if (sonuc) //if string has empty characters
        {
            Console.WriteLine(ifade.RemoveWhiteSpaces());
        }

        Console.WriteLine(ifade.MakeUpperCase());
        Console.WriteLine(ifade.MakeLowerCase());

        int[] dizi = { 9, 3, 6, 2, 1, 5, 0 };
        dizi.SortArray();
        dizi.PrintConsole(); //0,1,2,3,5,6,9

        int sayi = 5;
        Console.WriteLine(sayi.IsEvenNumber()); //False
        Console.WriteLine(ifade.GetFirstCharacter()); //A
    }
}

class Operations
{
    public int Expo(int value, int power)
    {
        if (power < 2)
        {
            return value;
        }

        return Expo(value, power - 1 * value);

        //Expo(3,4)
        //Expo(3,3) * 3
        //Expo(3,2) * 3 * 3
        //Expo(3,1) * 3 * 3 * 3
    }
}

public static class Extension
{
    public static bool CheckSpaces(this string param)
    {
        return param.Contains(" ");
    }

    public static string RemoveWhiteSpaces(this string param)
    {
        string[] dizi = param.Split(" ");
        return string.Join("*", dizi);
    }

    public static string MakeUpperCase(this string param)
    {
        return param.ToUpper();
    }

    public static string MakeLowerCase(this string param)
    {
        return param.ToLower();
    }

    public static int[] SortArray(this int[] param)
    {
        Array.Sort(param);
        return param;
    }

    public static void PrintConsole(this int[] param)
    {
        foreach (int item in param)
        {
            Console.WriteLine(item);
        }
    }

    public static bool IsEvenNumber(this int param)
    {
        return param % 2 == 0;
    }

    public static string GetFirstCharacter(this string param)
    {
        return param.Substring(0, 1);
    }
}
using System;

class StringMethods
{
    static void Main(string[] args)
    {
        string str = "Our lesson is C#, Welcome!";
        string str2 = "C#";

        //Length
        Console.WriteLine(str.Length);

        //ToUpper, ToLower
        Console.WriteLine(str.ToUpper());
        Console.WriteLine(str.ToLower());

        //Concat
        Console.WriteLine(String.Concat(str, " Hello!"));

        //Compare, CompareTo
        Console.WriteLine(str.CompareTo(str2)); //0,1,-1

        Console.WriteLine(String.Compare(str, str2, true));
        Console.WriteLine(String.Compare(str, str2, false));

        //Contains
        Console.WriteLine(str.Contains(str2));
        Console.WriteLine(str.EndsWith("Welcome!"));

        //IndexOf
        Console.WriteLine(str.IndexOf("C#")); //14
        Console.WriteLine(str.IndexOf("Ahmet"));

        //Insert
        Console.WriteLine(str.Insert(0, "Hello")); //"HelloOur lesson is C#, Welcome!";
        Console.WriteLine(str.LastIndexOf("e")); //24

        //PadLeft, PadRight
        Console.WriteLine(str + str2.PadLeft(8));
        Console.WriteLine(str + str2.PadLeft(8, '*'));
        Console.WriteLine(str.PadRight(30) + str2);
        Console.WriteLine(str.PadRight(30, '-') + str2);

        //Remove
        Console.WriteLine(str.Remove(10));
        Console.WriteLine(str.Remove(5, 3));
        Console.WriteLine(str.Remove(0, 1));

        //Replace
        Console.WriteLine(str.Replace("C#", "CSharp"));
        Console.WriteLine(str.Replace(" ", "*"));

        //Split
        Console.WriteLine(str.Split(' ')[1]); //lesson

        //Substring
        Console.WriteLine(str.Substring(7)); //son is welcome
        Console.WriteLine(str.Substring(7, 6)); //son is
    }
}
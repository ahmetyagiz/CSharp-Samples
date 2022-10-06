using System;
using System.Collections;
using System.Collections.Generic;

class ArrayListSample
{
    static void Main(string[] args)
    {
        ArrayList liste = new ArrayList();
        liste.Add("Ayşe");
        liste.Add(2);
        liste.Add(true);
        liste.Add('A');

        Console.WriteLine(liste[1]);

        foreach (var item in liste)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("***** Add Range *****");
        string[] renkler = { "kırmızı", "sarı", "yesil" };
        List<int> sayilar = new List<int>() { 1, 8, 3, 7, 9, 92, 5 };
        liste.AddRange(renkler);
        liste.AddRange(sayilar);

        foreach (var item in liste)
        {
            Console.WriteLine(item);
        }

        //Console.WriteLine("***** Sort *****");
        //liste.Sort();
        //different value types can't sort together!

        //Console.WriteLine("***** Binary Search *****");
        //Console.Write(liste.BinarySearch(9));
        // different value types can't find with BinarySearch together!

        Console.WriteLine("***** Reverse *****");
        liste.Reverse();

        foreach (var item in liste)
        {
            Console.WriteLine(item);
        }

        //Clear
        Console.Write("***** Clear *****");
        liste.Clear();

        foreach (var item in liste)
        {
            Console.WriteLine(item); // empty
        }
    }
}
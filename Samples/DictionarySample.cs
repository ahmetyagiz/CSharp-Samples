using System;
using System.Collections.Generic;

    class DictionarySample
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> kullanıcılar = new Dictionary<int, string>();

            kullanıcılar.Add(10, "Ayşe Yılmaz");
            kullanıcılar.Add(12, "Ahmet Yılmaz");
            kullanıcılar.Add(18, "Deniz Arda");
            kullanıcılar.Add(20, "Özcan Coşar");

            // Dizinin elemanlarına erişim
            Console.WriteLine("***** Elemanlara Erişim *****");
            Console.WriteLine(kullanıcılar[12]); //Ahmet Yılmaz
            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item);
            }

            // Count
            Console.WriteLine("***** Count *****");
            Console.WriteLine(kullanıcılar.Count);

            //Contains
            Console.WriteLine("***** Contains *****");
            Console.WriteLine(kullanıcılar.ContainsKey(12));
            Console.WriteLine(kullanıcılar.ContainsValue("Zikriye Ürkmez"));

            //Remove
            Console.WriteLine("***** Remove *****");
            kullanıcılar.Remove(12);

            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item.Value);
            }

            //Keys
            Console.WriteLine("***** Keys *****");
            foreach (var item in kullanıcılar.Keys)
            {
                Console.WriteLine(item);
            }

            //Values
            Console.WriteLine("***** Values *****");
            foreach (var item in kullanıcılar.Values)
            {
                Console.WriteLine(item);
            }
        }
    }

using System;
using System.Collections.Generic;
using System.Collections;

namespace TelephoneDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryLoop directoryLoop = new DirectoryLoop();
            DirectoryMethods directoryMethods = new DirectoryMethods();

            directoryLoop.MainApplication(directoryMethods);
        }
    }

    class DirectoryLoop
    {
        public void MainApplication(DirectoryMethods directoryMethods)
        {
            ArrayList phoneDirectory = new ArrayList() { "ahmet", "yagiz", 530, "Mehmet", "Yılmaz", 550, "John", "Wilson", 130, "Eddie", "Murphy", 720, "Emma", "Watson", 650 };

            while (true)
            {
                MainMenu();

                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    //  (1) Yeni Numara Kaydetmek
                    case 1:
                        directoryMethods.AddNewPhoneNumber(phoneDirectory);
                        break;

                    //  (2) Varolan Numarayı Silmek
                    case 2:
                        directoryMethods.DeletePhoneNumber(phoneDirectory);
                        break;

                    //  (3) Varolan Numarayı Güncelleme
                    case 3:
                        directoryMethods.UpdatePhoneNumber(phoneDirectory);
                        break;

                    // (4) Rehberi Listelemek
                    case 4:
                        directoryMethods.PrintPhoneDirectory(phoneDirectory);
                        break;

                    // (5) Rehberde Arama Yapmak
                    case 5:
                        directoryMethods.SearchPhoneDirectory(phoneDirectory);
                        break;

                    default:
                        Console.WriteLine("Eksik veya hatalı bir giriş yaptınız yaptınız, lütfen tekrar deneyiniz.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static public void MainMenu()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak﻿");
        }
    }

    class DirectoryMethods
    {
        public void AddNewPhoneNumber(ArrayList phoneDirectory)
        {
            Console.Write("Lütfen isim giriniz: ");
            string inputName = Console.ReadLine();

            Console.Write("Lütfen soyisim giriniz: ");
            string inputSurname = Console.ReadLine();

            Console.Write("Lütfen telefon numarası giriniz: ");
            int inputPhoneNumber = int.Parse(Console.ReadLine());

            phoneDirectory.Add(inputName);
            phoneDirectory.Add(inputSurname);
            phoneDirectory.Add(inputPhoneNumber);

            Console.WriteLine("Numara başarıyla kaydedildi!");
            Console.WriteLine(inputName + " " + inputSurname + " " + inputPhoneNumber);
        }

        public void DeletePhoneNumber(ArrayList phoneDirectory)
        {
            while (true)
            {
                Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
                string searchNameInput = Console.ReadLine();

                if (phoneDirectory.Contains(searchNameInput))
                {
                    Console.WriteLine(searchNameInput + " isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                    string deleteInput = Console.ReadLine();

                    int index = phoneDirectory.IndexOf(searchNameInput);

                    if (deleteInput == "y" || deleteInput == "Y")
                    {
                        if (index % 3 == 0) // bu bir isimdir
                        {
                            phoneDirectory.RemoveAt(index + 2);
                            phoneDirectory.RemoveAt(index + 1);
                            phoneDirectory.RemoveAt(index);
                        }
                        else if (index % 3 == 1) // bu bir soyisimdir
                        {
                            phoneDirectory.RemoveAt(index + 1);
                            phoneDirectory.RemoveAt(index);
                            phoneDirectory.RemoveAt(index - 1);
                        }

                        break;
                    }
                    else if (deleteInput == "n" || deleteInput == "N")
                    {
                        Console.WriteLine("Seçiminiz iptal edildi");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("* Silmeyi sonlandırmak için: (1)");
                    Console.WriteLine("* Yeniden denemek için: (2)");

                    string deleteInput = Console.ReadLine();

                    if (deleteInput == "1")
                    {
                        Console.WriteLine("Silme işlemi iptal edildi");
                        break;
                    }
                    else if (deleteInput == "2")
                    {
                        continue;
                    }
                }
            }
        }

        public void UpdatePhoneNumber(ArrayList phoneDirectory)
        {
            while (true)
            {
                Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
                string searchNameInput = Console.ReadLine();

                if (phoneDirectory.Contains(searchNameInput))
                {
                    Console.WriteLine(searchNameInput + " isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                    string deleteInput = Console.ReadLine();

                    int index = phoneDirectory.IndexOf(searchNameInput);

                    if (deleteInput == "y" || deleteInput == "Y")
                    {
                        if (index % 3 == 0) // bu bir isimdir
                        {
                            Console.Write("Yeni isim giriniz: ");
                            phoneDirectory[index] = Console.ReadLine();

                            Console.Write("Yeni soyisim giriniz: ");
                            phoneDirectory[index + 1] = Console.ReadLine();

                            Console.Write("Yeni numara giriniz: ");
                            phoneDirectory[index + 2] = Console.ReadLine();
                        }
                        else if (index % 3 == 1) // bu bir soyisimdir
                        {
                            phoneDirectory.RemoveAt(index + 1);
                            phoneDirectory.RemoveAt(index);
                            phoneDirectory.RemoveAt(index - 1);

                            Console.Write("Yeni isim giriniz: ");
                            phoneDirectory[index - 1] = Console.ReadLine();

                            Console.Write("Yeni soyisim giriniz: ");
                            phoneDirectory[index] = Console.ReadLine();

                            Console.Write("Yeni numara giriniz: ");
                            phoneDirectory[index + 1] = Console.ReadLine();
                        }

                        break;
                    }
                    else if (deleteInput == "n" || deleteInput == "N")
                    {
                        Console.WriteLine("Seçiminiz iptal edildi");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("* Silmeyi sonlandırmak için: (1)");
                    Console.WriteLine("* Yeniden denemek için: (2)");

                    string deleteInput = Console.ReadLine();

                    if (deleteInput == "1")
                    {
                        Console.WriteLine("Silme işlemi iptal edildi");
                        break;
                    }
                    else if (deleteInput == "2")
                    {
                        continue;
                    }
                }
            }
        }

        public void PrintPhoneDirectory(ArrayList phoneDirectory)
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");
            for (int i = 0; i < phoneDirectory.Count; i += 3)
            {
                Console.WriteLine("İsim: " + phoneDirectory[i]);
                Console.WriteLine("Soyisim: " + phoneDirectory[i + 1]);
                Console.WriteLine("Telefon Numarası: " + phoneDirectory[i + 2]);
                Console.WriteLine("-");
            }
        }

        public void SearchPhoneDirectory(ArrayList phoneDirectory)
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");
            Console.WriteLine();
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");

            string inputNumber = Console.ReadLine();
            int index;

            if (inputNumber == "1") // isme göre arama yapma
            {
                Console.WriteLine("Aramak istediğiniz ismi giriniz: ");
                inputNumber = Console.ReadLine();
                index = phoneDirectory.IndexOf(inputNumber);

                if (phoneDirectory.Contains(inputNumber))
                {
                    Console.WriteLine("İsim: " + phoneDirectory[index]);
                    Console.WriteLine("Soyisim: " + phoneDirectory[index + 1]);
                    Console.WriteLine("Numara: " + phoneDirectory[index + 2]);
                }
            }
            else if (inputNumber == "2") // numaraya göre arama yapma
            {
                Console.WriteLine("Aramak istediğiniz numarayı giriniz: ");

                int inputNum = int.Parse(Console.ReadLine());
                int numIndex = phoneDirectory.IndexOf(inputNum);
                
                if (phoneDirectory.Contains(inputNum))
                {
                    Console.WriteLine("İsim: " + phoneDirectory[numIndex - 2]);
                    Console.WriteLine("Soyisim: " + phoneDirectory[numIndex - 1]);
                    Console.WriteLine("Numara: " + phoneDirectory[numIndex]);
                }
            }
        }
    }
}
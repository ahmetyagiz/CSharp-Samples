using System;
using System.Collections;
using System.Collections.Generic;

namespace ToDoApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ToDoLoop toDoLoop = new ToDoLoop();
            toDoLoop.MainApplication();
        }
    }

    class ToDoLoop
    {
        public void MainApplication()
        {
            ToDoMethods toDoMethods = new ToDoMethods();
            Dictionary<string, int> teamMembers = new Dictionary<string, int>();
            teamMembers.Add("Ahmet", 20);
            teamMembers.Add("Mevlüt", 30);
            teamMembers.Add("Ayşe", 40);
            teamMembers.Add("Sinem", 50);

            // to-do
            ArrayList toDoCards = new ArrayList() { "Yapılacak-1", "Bakkala gidip süt al", "Ahmet", "XS",
                                                    "Yapılacak-2", "Fırına gidip ekmek al", "Mevlüt", "S",
                                                    "Yapılacak-3", "Yeni laptop satın al", "Ayşe", "L"};
            // inprogress
            ArrayList inProgressCards = new ArrayList();

            // done
            ArrayList doneCards = new ArrayList();

            while (true)
            {
                MainMenu();

                string strInput = Console.ReadLine();

                switch (strInput)
                {
                    case "1":
                        //(1) Board Listelemek
                        toDoMethods.ListCards(toDoCards, inProgressCards, doneCards);
                        break;
                    case "2":
                        //(2) Board'a Kart Eklemek
                        toDoMethods.AddCard(toDoCards);
                        break;
                    case "3":
                        //(3) Board'dan Kart Silmek
                        toDoMethods.DeleteCard(toDoCards, inProgressCards, doneCards);
                        break;
                    case "4":
                        //(4) Kart Taşımak
                        toDoMethods.CarryCard(toDoCards, inProgressCards, doneCards);
                        break;
                    default:
                        break;
                }

                Console.WriteLine();
            }
        }

        static public void MainMenu()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
        }
    }

    class ToDoMethods
    {
        //(1) Board Listelemek
        public void ListCards(ArrayList toDoCards, ArrayList inProgressCards, ArrayList doneCards)
        {
            Console.WriteLine("TODO Line");
            Console.WriteLine("************************");

            for (int i = 0; i < toDoCards.Count; i += 4)
            {
                Console.WriteLine("Başlık: {0}", toDoCards[i]);
                Console.WriteLine("İçerik: {0}", toDoCards[i + 1]);
                Console.WriteLine("Atanan Kişi: {0}", toDoCards[i + 2]);
                Console.WriteLine("Büyüklük: {0}", toDoCards[i + 3]);
                Console.WriteLine("-");
            }

            Console.WriteLine();
            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("************************");

            for (int i = 0; i < inProgressCards.Count; i += 4)
            {
                Console.WriteLine("Başlık: {0}", inProgressCards[i]);
                Console.WriteLine("İçerik: {0}", inProgressCards[i + 1]);
                Console.WriteLine("Atanan Kişi: {0}", inProgressCards[i + 2]);
                Console.WriteLine("Büyüklük: {0}", inProgressCards[i + 3]);
                Console.WriteLine("-");
            }

            Console.WriteLine();
            Console.WriteLine("DONE Line");
            Console.WriteLine("************************");

            for (int i = 0; i < doneCards.Count; i += 4)
            {
                Console.WriteLine("Başlık: {0}", doneCards[i]);
                Console.WriteLine("İçerik: {0}", doneCards[i + 1]);
                Console.WriteLine("Atanan Kişi: {0}", doneCards[i + 2]);
                Console.WriteLine("Büyüklük: {0}", doneCards[i + 3]);
                Console.WriteLine("-");
            }
        }

        //(2) Board'a Kart Eklemek
        public void AddCard(ArrayList toDoCards)
        {
            Console.Write("Başlık: ");
            string header = Console.ReadLine();
            toDoCards.Add(header);

            Console.Write("İçerik Giriniz: ");
            string content = Console.ReadLine();
            toDoCards.Add(content);

            Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5): ");
            string size = Console.ReadLine();
            toDoCards.Add(size);

            Console.Write("Kişi Seçiniz ");
            string staff = Console.ReadLine();
            toDoCards.Add(staff);

            Console.WriteLine("Kart başarıyla eklendi");
            Console.WriteLine(header + " " + content + " " + size + " " + staff);
        }

        //(3) Board'dan Kart Silmek
        public void DeleteCard(ArrayList toDoCards, ArrayList inProgressCards, ArrayList doneCards)
        {
            while (true)
            {
                Console.WriteLine("Silinecek kartın adını yazınız: ");
                string str = Console.ReadLine();
                int index;
                bool contains = false;

                while (toDoCards.Contains(str))
                {
                    contains = true;
                    index = toDoCards.IndexOf(str);

                    toDoCards.RemoveAt(index + 3);
                    toDoCards.RemoveAt(index + 2);
                    toDoCards.RemoveAt(index + 1);
                    toDoCards.RemoveAt(index);

                    Console.WriteLine(str + " kartı başarıyla silindi");
                }
                while (inProgressCards.Contains(str))
                {
                    contains = true;
                    index = inProgressCards.IndexOf(str);

                    inProgressCards.RemoveAt(index + 3);
                    inProgressCards.RemoveAt(index + 2);
                    inProgressCards.RemoveAt(index + 1);
                    inProgressCards.RemoveAt(index);

                    Console.WriteLine(str + " kartı başarıyla silindi");
                }

                while (doneCards.Contains(str))
                {
                    contains = true;
                    index = doneCards.IndexOf(str);

                    doneCards.RemoveAt(index);
                    doneCards.RemoveAt(index + 1);
                    doneCards.RemoveAt(index + 2);
                    doneCards.RemoveAt(index + 3);

                    Console.WriteLine(str + " kartı başarıyla silindi");
                }

                if (contains == false)
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("* İşlemi sonlandırmak için : (1)");
                    Console.WriteLine("* Yeniden denemek için : (2)");
                    string strInput = Console.ReadLine();

                    if (strInput == "1")
                    {
                        break;
                    }
                    else if (strInput == "2")
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Eksik veya hatalı bir giriş yaptınız. Lütfen tekrar deneyiniz.");
                        continue;
                    }
                }
                else
                {
                    break;
                }
            }
        }

        //(4) Kart Taşımak
        public void CarryCard(ArrayList toDoCards, ArrayList inProgressCards, ArrayList doneCards)
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız: ");
            string headerInput = Console.ReadLine();

            int index = 0;
            bool contains = false;
            string str = "";

            if (toDoCards.Contains(headerInput) && contains == false)
            {
                contains = true;
                index = toDoCards.IndexOf(headerInput);
                Console.WriteLine("Bulunan Kart Bilgileri:");
                Console.WriteLine("**************************************");
                Console.WriteLine("Başlık: {0}", toDoCards[index]);
                Console.WriteLine("İçerik: {0}", toDoCards[index + 1]);
                Console.WriteLine("Atanan Kişi: {0}", toDoCards[index + 2]);
                Console.WriteLine("Büyüklük: {0}", toDoCards[index + 3]);

                Console.WriteLine();

                Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:");
                Console.WriteLine("(1) TODO");
                Console.WriteLine("(2) IN PROGRESS");
                Console.WriteLine("(3) DONE");

                str = Console.ReadLine();

                if (str == "1")
                {
                    toDoCards.Add(toDoCards[index]);
                    toDoCards.Add(toDoCards[index + 1]);
                    toDoCards.Add(toDoCards[index + 2]);
                    toDoCards.Add(toDoCards[index + 3]);

                    toDoCards.Remove(toDoCards[index]);
                    toDoCards.Remove(toDoCards[index]);
                    toDoCards.Remove(toDoCards[index]);
                    toDoCards.Remove(toDoCards[index]);
                }
                else if (str == "2")
                {
                    inProgressCards.Add(toDoCards[index]);
                    inProgressCards.Add(toDoCards[index + 1]);
                    inProgressCards.Add(toDoCards[index + 2]);
                    inProgressCards.Add(toDoCards[index + 3]);

                    toDoCards.Remove(toDoCards[index]);
                    toDoCards.Remove(toDoCards[index]);
                    toDoCards.Remove(toDoCards[index]);
                    toDoCards.Remove(toDoCards[index]);
                }
                else if (str == "3")
                {
                    doneCards.Add(toDoCards[index]);
                    doneCards.Add(toDoCards[index + 1]);
                    doneCards.Add(toDoCards[index + 2]);
                    doneCards.Add(toDoCards[index + 3]);

                    toDoCards.Remove(toDoCards[index]);
                    toDoCards.Remove(toDoCards[index]);
                    toDoCards.Remove(toDoCards[index]);
                    toDoCards.Remove(toDoCards[index]);
                }
            }

            if (inProgressCards.Contains(headerInput) && contains == false)
            {
                contains = true;
                index = inProgressCards.IndexOf(headerInput);
                Console.WriteLine("Bulunan Kart Bilgileri:");
                Console.WriteLine("**************************************");
                Console.WriteLine("Başlık: {0}", inProgressCards[index]);
                Console.WriteLine("İçerik: {0}", inProgressCards[index + 1]);
                Console.WriteLine("Atanan Kişi: {0}", inProgressCards[index + 2]);
                Console.WriteLine("Büyüklük: {0}", inProgressCards[index + 3]);

                Console.WriteLine();

                Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:");
                Console.WriteLine("(1) TODO");
                Console.WriteLine("(2) IN PROGRESS");
                Console.WriteLine("(3) DONE");

                str = Console.ReadLine();

                if (str == "1")
                {
                    toDoCards.Add(inProgressCards[index]);
                    toDoCards.Add(inProgressCards[index + 1]);
                    toDoCards.Add(inProgressCards[index + 2]);
                    toDoCards.Add(inProgressCards[index + 3]);

                    inProgressCards.Remove(inProgressCards[index]);
                    inProgressCards.Remove(inProgressCards[index]);
                    inProgressCards.Remove(inProgressCards[index]);
                    inProgressCards.Remove(inProgressCards[index]);
                }
                else if (str == "2")
                {
                    inProgressCards.Add(inProgressCards[index]);
                    inProgressCards.Add(inProgressCards[index + 1]);
                    inProgressCards.Add(inProgressCards[index + 2]);
                    inProgressCards.Add(inProgressCards[index + 3]);

                    inProgressCards.Remove(inProgressCards[index]);
                    inProgressCards.Remove(inProgressCards[index]);
                    inProgressCards.Remove(inProgressCards[index]);
                    inProgressCards.Remove(inProgressCards[index]);
                }
                else if (str == "3")
                {
                    doneCards.Add(inProgressCards[index]);
                    doneCards.Add(inProgressCards[index + 1]);
                    doneCards.Add(inProgressCards[index + 2]);
                    doneCards.Add(inProgressCards[index + 3]);

                    inProgressCards.Remove(inProgressCards[index]);
                    inProgressCards.Remove(inProgressCards[index]);
                    inProgressCards.Remove(inProgressCards[index]);
                    inProgressCards.Remove(inProgressCards[index]);
                }
            }

            if (doneCards.Contains(headerInput) && contains == false)
            {
                contains = true;
                index = doneCards.IndexOf(headerInput);
                Console.WriteLine("Bulunan Kart Bilgileri:");
                Console.WriteLine("**************************************");
                Console.WriteLine("Başlık: {0}", doneCards[index]);
                Console.WriteLine("İçerik: {0}", doneCards[index + 1]);
                Console.WriteLine("Atanan Kişi: {0}", doneCards[index + 2]);
                Console.WriteLine("Büyüklük: {0}", doneCards[index + 3]);

                Console.WriteLine();

                Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:");
                Console.WriteLine("(1) TODO");
                Console.WriteLine("(2) IN PROGRESS");
                Console.WriteLine("(3) DONE");

                str = Console.ReadLine();

                if (str == "1")
                {
                    toDoCards.Add(doneCards[index]);
                    toDoCards.Add(doneCards[index + 1]);
                    toDoCards.Add(doneCards[index + 2]);
                    toDoCards.Add(doneCards[index + 3]);

                    doneCards.Remove(doneCards[index]);
                    doneCards.Remove(doneCards[index]);
                    doneCards.Remove(doneCards[index]);
                    doneCards.Remove(doneCards[index]);
                }
                else if (str == "2")
                {
                    inProgressCards.Add(doneCards[index]);
                    inProgressCards.Add(doneCards[index + 1]);
                    inProgressCards.Add(doneCards[index + 2]);
                    inProgressCards.Add(doneCards[index + 3]);

                    doneCards.Remove(doneCards[index]);
                    doneCards.Remove(doneCards[index]);
                    doneCards.Remove(doneCards[index]);
                    doneCards.Remove(doneCards[index]);
                }
                else if (str == "3")
                {
                    doneCards.Add(doneCards[index]);
                    doneCards.Add(doneCards[index + 1]);
                    doneCards.Add(doneCards[index + 2]);
                    doneCards.Add(doneCards[index + 3]);

                    doneCards.Remove(doneCards[index]);
                    doneCards.Remove(doneCards[index]);
                    doneCards.Remove(doneCards[index]);
                    doneCards.Remove(doneCards[index]);
                }
            }

            if (contains == false)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* İşlemi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Kart başarıyla taşındı");
            }
        }
    }
}
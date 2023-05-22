using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        // Kullanıcı bilgilerini içeren bir kullanıcı listesi oluşturulur
        List<User> users = new List<User>
        {
            new User("123456", "1234", "John Doe"),
            new User("789012", "5678", "Jane Smith")
        };

        // Giriş işlemi yapılır
        User user = Login(users);

        if (user != null)
        {
            Console.WriteLine("Hoş geldiniz, " + user.Name + "!");

            // Ana döngü
            while (true)
            {
                Console.WriteLine("Yapmak istediğiniz işlemi seçin:");
                Console.WriteLine("1. Para Çekme");
                Console.WriteLine("2. Para Yatırma");
                Console.WriteLine("3. Bakiye Sorgulama");
                Console.WriteLine("4. Gün Sonu");

                int choice = ReadIntInput();

                switch (choice)
                {
                    case 1:
                        Withdraw(user);
                        break;
                    case 2:
                        Deposit(user);
                        break;
                    case 3:
                        CheckBalance(user);
                        break;
                    case 4:
                        EndOfDay(users);
                        break;
                    default:
                        Console.WriteLine("Geçersiz bir seçenek girdiniz. Lütfen tekrar deneyin.");
                        break;
                }
            }
        }
        else
        {
            Console.WriteLine("Giriş başarısız. Lütfen tekrar deneyin.");
        }
    }

    // Kullanıcı girişi yapılır
    static User Login(List<User> users)
    {
        Console.WriteLine("Kullanıcı numaranızı girin:");
        string accountNumber = Console.ReadLine();

        Console.WriteLine("PIN kodunuzu girin:");
        string pin = Console.ReadLine();

        foreach (User user in users)
        {
            if (user.AccountNumber == accountNumber && user.PIN == pin)
            {
                return user;
            }
        }

        return null;
    }

    // Para çekme işlemi gerçekleştirilir
    static void Withdraw(User user)
    {
        Console.WriteLine("Çekmek istediğiniz miktarı girin:");
        decimal amount = ReadDecimalInput();

        if (amount > 0 && user.Balance >= amount)
        {
            user.Balance -= amount;
            Console.WriteLine("Çekilen miktar: " + amount.ToString("C2"));
            Console.WriteLine("Güncel bakiye: " + user.Balance.ToString("C2"));
            LogTransaction(user, "Para Çekme", amount);
        }
        else
        {
            Console.WriteLine("Geçersiz miktar veya yetersiz bakiye. İşlem gerçekleştirilemedi.");
        }
    }

    // Para yatırma işlemi gerçekleştirilir
    static void Deposit(User user)
    {
        Console.WriteLine("Yatırmak istediğiniz miktarı girin:");
        decimal amount = ReadDecimalInput();

        if (amount > 0)
        {
            user.Balance += amount;
            Console.WriteLine("Yatırılan miktar: " + amount.ToString("C2"));
            Console.WriteLine("Güncel bakiye: " + user.Balance.ToString("C2"));
            LogTransaction(user, "Para Yatırma", amount);
        }
        else
        {
            Console.WriteLine("Geçersiz miktar. İşlem gerçekleştirilemedi.");
        }
    }

    // Bakiye sorgulama işlemi gerçekleştirilir
    static void CheckBalance(User user)
    {
        Console.WriteLine("Güncel bakiye: " + user.Balance.ToString("C2"));
        LogTransaction(user, "Bakiye Sorgulama", 0);
    }

    // Gün sonu işlemleri gerçekleştirilir
    static void EndOfDay(List<User> users)
    {
        // Log dosyasına yazma
        string log = GetTransactionLog(users);
        string logFileName = DateTime.Now.ToString("ddMMyyyy") + ".txt";
        File.WriteAllText(logFileName, log);
        Console.WriteLine("Gün sonu işlemleri tamamlandı. Log dosyası oluşturuldu: " + logFileName);

        // Fraud loglarını oluşturma
        List<string> fraudLogs = GetFraudLogs(users);
        Console.WriteLine("Fraud logları:");
        foreach (string fraudLog in fraudLogs)
        {
            Console.WriteLine(fraudLog);
        }
    }

    // Kullanıcı işlemlerini loglama
    static void LogTransaction(User user, string transactionType, decimal amount)
    {
        string log = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " - " +
                     user.AccountNumber + " - " +
                     transactionType + " - " +
                     amount.ToString("C2");

        Console.WriteLine("İşlem logu: " + log);
        user.TransactionLogs.Add(log);
    }

    // Kullanıcı işlem loglarını alır
    static string GetTransactionLog(List<User> users)
    {
        string log = "Transaction Logları:\n";
        foreach (User user in users)
        {
            log += "\n" + user.Name + " (" + user.AccountNumber + "):\n";
            foreach (string transactionLog in user.TransactionLogs)
            {
                log += transactionLog + "\n";
            }
        }
        return log;
    }

    // Fraud loglarını alır
    static List<string> GetFraudLogs(List<User> users)
    {
        List<string> fraudLogs = new List<string>();

        foreach (User user in users)
        {
            if (user.TransactionLogs.Count < 3)
            {
                string log = "Potansiyel fraud: " + user.Name + " (" + user.AccountNumber + ")";
                fraudLogs.Add(log);
            }
        }

        return fraudLogs;
    }

    // Kullanıcıdan tamsayı girişi alır
    static int ReadIntInput()
    {
        int input;
        while (!int.TryParse(Console.ReadLine(), out input))
        {
            Console.WriteLine("Geçersiz giriş. Bir tamsayı girin:");
        }
        return input;
    }

    // Kullanıcıdan ondalık sayı girişi alır
    static decimal ReadDecimalInput()
    {
        decimal input;
        while (!decimal.TryParse(Console.ReadLine(), out input))
        {
            Console.WriteLine("Geçersiz giriş. Bir sayı girin:");
        }
        return input;
    }
}

class User
{
    public string AccountNumber { get; }
    public string PIN { get; }
    public string Name { get; }
    public decimal Balance { get; set; }
    public List<string> TransactionLogs { get; }

    public User(string accountNumber, string pin, string name)
    {
        AccountNumber = accountNumber;
        PIN = pin;
        Name = name;
        Balance = 0;
        TransactionLogs = new List<string>();
    }
}

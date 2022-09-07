using System;

class TryCatchFinally
{
    static void Main(string[] args)
    {
        //Compile time derleyici hatası
        //Run-time error çalışma zamanı hatası
        //TryCatchFinally

        //try
        //{
        //    Console.WriteLine("Bir sayı giriniz:");
        //    int sayi = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Girmiş Olduğunuz Sayı: " + sayi);
        //}
        //catch(Exception ex)
        //{
        //    Console.WriteLine("Hata: " + ex.Message.ToString());
        //}
        //finally
        //{
        //    Console.WriteLine("İşlem Tamamlandı.");
        //}

        try
        {
            //int a = int.Parse(null); //ArgumentNullException exception
            //int a = int.Parse("Test"); //FormatException exception
            int a = int.Parse("-20000000000"); //overflow exception
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Boş değer girdiniz");
            Console.WriteLine(ex);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Veri tipi uygun değil.");
            Console.WriteLine(ex);
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Çok küçük ya da çok büyük bir değer girdiniz.");
            Console.WriteLine(ex);
        }
        finally
        {
            Console.WriteLine("İşlem başarıyla tamamlandı");
        }
    }
}
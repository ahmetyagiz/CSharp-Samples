using System;

    class MethodsRef
    {
        static void Main(string[] args)
        {
            //erisim_belirteci geri_donuctipi metot_adi(parametreListesi/arguman)
            //{
            //komutlar;
            //}

            int a = 2;
            int b = 3;

            //static bir class içerisinden sadece static methodlar erişilebilir

            int result = Sum(a, b);
            Console.WriteLine(result);

            Methods methods = new Methods();
            methods.PrintConsole(result.ToString());

            result = methods.IncreaseAndSum(ref a, ref b);
            methods.PrintConsole(result.ToString()); 
            methods.PrintConsole((a+b).ToString());;
        }

        static int Sum(int value_1, int value_2)
        {
            return value_1 + value_2;
        }
    }

    class Methods
    {
        public void PrintConsole(string str)
        {
            Console.WriteLine(str);
        }

        public int IncreaseAndSum(ref int value_1, ref int value_2)
        {
            value_1 += 1;
            value_2 += 1;
            return value_1 + value_2;
        }
    }
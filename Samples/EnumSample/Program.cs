using System;

namespace EnumSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Days.Sunday);
            Console.WriteLine((int)Days.Saturday);

            int tempature = 10;

            if (tempature <= (int)Weather.Normal)
            {
                Console.WriteLine("The weather not suitable for travel, lets wait a bit");
            }
            else if (tempature >= (int)Weather.Hot)
            {
                Console.WriteLine("The weather not suitable for travel, it's hot");
            }
            else if (tempature <= (int)Weather.Veryhot)
            {
                Console.WriteLine("The weather not suitable for travel, it's very hot");
            }
        }
    }

    enum Days
    {
        Monday = 1,
        Tuesday, //2
        Wednesday, //3
        Thursday, //4
        Friday = 23,
        Saturday, //24
        Sunday //25
    }

    enum Weather
    {
        Cold = 5,
        Normal = 20,
        Hot = 25,
        Veryhot = 30
    }
}

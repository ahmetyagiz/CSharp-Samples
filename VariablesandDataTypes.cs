using System;

class VariablesandDataTypes
{
    static void Main(string[] args)
    {
        Console.WriteLine("");

        byte b = 5;      //1 byte
        sbyte c = 5;     //1 byte

        short s = 5;     //2 byte
        ushort us = 5;   //2 byte

        Int16 i16 = 2;   //2 byte
        int i = 2;       //4 byte
        Int32 int32 = 2; //4 byte
        Int64 i64 = 2;   //8 byte

        uint ui = 2;     //4 byte
        long l = 4;      //8 byte
        ulong ul = 4;

        //Reel sayilar
        float f = 5;     //4 byte 
        double d = 5;    //8 byte
        decimal de = 5;  //16 byte

        char ch = '2'; //2 byte
        string str = "Ahmet";

        bool b1 = true;
        bool b2 = false;

        DateTime dt = DateTime.Now;

        Console.WriteLine(dt);

        object o1 = "x";
        object o2 = "y";
        object o3 = 4;
        object o4 = 4.3;

        string str1 = string.Empty;
        str1 = "Ahmet Yağız"; //unlimited
        string name = "Ahmet";
        string surname = "Yağız";
        string fullName = name + " " + surname; //string concatenate

        //integer definition formats

        int integer1 = 5;
        int integer2 = 3;
        int integer3 = integer1 * integer2;

        bool bool1 = 10 > 2; //true

        //variable conversions
        string str20 = "20";
        int int20 = 20;
        string yeniDeger = str20 + int20.ToString();
        Console.WriteLine(yeniDeger); //output 2020

        int int21 = int20 + Convert.ToInt32(str20);
        Console.WriteLine(int21); //output 40

        int int22 = int20 + int.Parse(str20); //output40

        //datetime

        string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
        Console.WriteLine(dateTime);

        string dateTime2 = DateTime.Now.ToString("dd/MM/yyyy");
        Console.WriteLine(dateTime2);

        string hour = DateTime.Now.ToString("HH:mm");
        Console.WriteLine(hour);
    }
}
using System;

namespace ConstructorSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //syntax
            //class sınıfı
            //access modifiers [veri tipi] ozellikAdi;
            //access modifiers [geri donus tipi] metotAdi ([parametre listesi])
            //{
            //metot komutlari
            //}

            // Access modifiers
            //1. Public : Her yerden erişilebilir.
            //2. Private : Sadece tanımlandığı sınıf içerisinden erişilebilir.
            //3. Internal : Sadece bulunduğu proje içerisinden erişilebilir
            //4. Protected : Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.

            Console.WriteLine("****** Employee - 1 ******");
            Employee employee_1 = new Employee("Ayşe", "Kara", 23425634, "Human Resources");
            employee_1.EmployeeInformation();

            Console.WriteLine("****** Employee - 2 ******");
            Employee employee_2 = new Employee("Deniz", "Arda", 23646789, "Purchasing");
            employee_2.Name = "Deniz";
            employee_2.Surname = "Arda";
            employee_2.Number = 23646789;
            employee_2.Department = "Purchasing";

            employee_2.EmployeeInformation();
            Console.WriteLine("****** Employee - 3 ******");
            Employee employee_3 = new Employee("Ahmet", "Yağız");
            employee_3.EmployeeInformation();
        }
    }

    class Employee
    {
        public string Name;
        public string Surname;
        public int Number;
        public string Department;

        public Employee(string name, string surname, int number, string department)
        {
            this.Name = name;
            this.Surname = surname;
            this.Number = number;
            this.Department = department;
        }

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public void EmployeeInformation()
        {
            Console.WriteLine("Employee Name: {0}", Name);
            Console.WriteLine("Employee Surname: {0}", Surname);
            Console.WriteLine("Employee Number: {0}", Number);
            Console.WriteLine("Employee Department: {0}", Department);
        }
    }
}

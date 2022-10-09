using System;

class StaticClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("Çalışan Sayısı: {0}", Employee.EmployeeCount);

        Employee employee = new Employee("Ayşe", "Yılmaz", "IK");
        Console.WriteLine("Çalışan Sayısı: {0}", Employee.EmployeeCount);
        Employee employee1 = new Employee("Ayşe", "Yılmaz", "IK");
        Employee employee2 = new Employee("Ayşe", "Yılmaz", "IK");
        Console.WriteLine("Çalışan Sayısı: {0}", Employee.EmployeeCount);

        Console.WriteLine("Toplama işlemi sonucu: {0}", Operations.Addition(100, 200));
        Console.WriteLine("Toplama işlemi sonucu: {0}", Operations.Substraction(400, 50));
    }
}

class Employee
{
    private static int employeeCount;

    public static int EmployeeCount { get => employeeCount; }

    private string Name;
    private string Surname;
    private string Department;

    static Employee()
    {
        employeeCount = 0;

    }
    public Employee(string name, string surname, string departmant)
    {
        this.Name = name;
        this.Surname = surname;
        this.Department = departmant;

        employeeCount++;
    }
}

static class Operations
{
    public static long Addition(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }
    public static long Substraction(int sayi1, int sayi2)
    {
        return sayi1 - sayi2;
    }

}
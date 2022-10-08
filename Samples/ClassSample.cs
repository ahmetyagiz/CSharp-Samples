using System;

namespace ClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee_1 = new Employee();
            employee_1.Name = "Ayşe";
            employee_1.Surname = "Kara";
            employee_1.Number = 23425634;
            employee_1.Department = "Human Resources"; 
            employee_1.EmployeeInformation();

            Console.WriteLine("**********");

            Employee employee_2 = new Employee();
            employee_2.Name = "Deniz";
            employee_2.Surname = "Arda";
            employee_2.Number = 23646789;
            employee_2.Department = "Purchasing";
            employee_2.EmployeeInformation();
        }
    }

    class Employee
    {
        public string Name;
        public string Surname;
        public int Number;
        public string Department;

        public void EmployeeInformation()
        {
            Console.WriteLine("Employee Name: {0}", Name);
            Console.WriteLine("Employee Surname: {0}", Surname);
            Console.WriteLine("Employee Number: {0}", Number);
            Console.WriteLine("Employee Department: {0}", Department);
        }
    }
}

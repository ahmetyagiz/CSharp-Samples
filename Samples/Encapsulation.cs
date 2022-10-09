using System;

class Encapsulation
{
    static void Main(string[] args)
    {
        // student 1
        Student student = new Student();
        student.Name = "Ahmet";
        student.Surname = "Yağız";
        student.Number = 293;
        student.Class = 4;

        student.GetStudentInformation();

        student.DecreaseStudentClass();
        student.GetStudentInformation();

        // student 2
        Student student2 = new Student("Deniz", "Arda", 256, 1);

        student2.DecreaseStudentClass();
        student2.GetStudentInformation();
    }
}

class Student
{
    private string name;
    private string surname;
    private int number;
    private int clas;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Surname { get => surname; set => surname = value; }

    public int Number { get => number; set => number = value; }

    public int Class
    {
        get => clas;
        set
        {
            if (value < 1)
            {
                Console.WriteLine("The class can be at least 1!");
                Class = 1;
            }
            else
            {
                clas = value;
            }
        }
    }

    public Student(string name, string surname, int number, int clas)
    {
        Name = name;
        Surname = surname;
        Number = number;
        Class = clas;
    }

    public Student() { }

    public void GetStudentInformation()
    {
        Console.WriteLine("****** Student Information ******");
        Console.WriteLine("Student Name: {0}", this.Name);
        Console.WriteLine("Student Surname: {0}", this.Surname);
        Console.WriteLine("Student Number: {0}", this.Number);
        Console.WriteLine("Student Class: {0}", this.Class);
    }

    public void SkipClass()
    {
        this.Class = this.Class + 1;
    }
    public void DecreaseStudentClass()
    {
        this.Class = this.Class - 1;
    }
}
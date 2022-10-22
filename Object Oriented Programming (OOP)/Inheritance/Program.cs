using System;

namespace Inheritance
{
    class Vehicle  // base class (parent) 
    {
        public string brandName; // vehicle field 

        public void GetTypeName() // vehicle method 
        {
            Console.WriteLine("I am a vehicle");
        }
    }

        class Car : Vehicle  // derived class (child)
        {
            public void GetName()
            {
                Console.WriteLine("My brand name is {0}", brandName);
                Console.WriteLine("I have 4 wheels");
            }
        }

        class Motorcycle : Vehicle  // derived class (child)
        {
            public void GetName()
            {
                Console.WriteLine("My brand name is {0}", brandName);
                Console.WriteLine("I have 2 wheels");
            }
        }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a car object
            Car car = new Car();

            // Define the name of the car
            car.brandName = "TOGG";

            // Print the name of the car
            car.GetName();

            // Print the type of the car (vehicle)
            car.GetTypeName();

            Console.WriteLine();

            // Create a motorcycle object
            Motorcycle motorcycle = new Motorcycle();

            // Define the name of the motorcycle
            motorcycle.brandName = "Kawasaki";

            // Print the name of the motorcycle
            motorcycle.GetName();

            // Print the type of the motorcycle (vehicle)
            motorcycle.GetTypeName();
        }
    }
}
// See https://aka.ms/new-console-template for more information
using OOPSConcepts.ClassAndObject;
using OOPSConcepts.Encapsulation;
using OOPSConcepts.Inheritance;
using OOPSConcepts.Polymorphism;
using OOPSConcepts.Polymorphism.MethodOverloading;
using OOPSConcepts.Polymorphism.MethodOverriding;
using System;

namespace OOPSConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            //Class and Object Concepts.
            Dog labsky = new Dog();
            labsky.breed = "Labsky";
            labsky.color = "White";
            labsky.Age = 5;
            labsky.size = 15;
            labsky.Eat();//Call the Method
            Console.WriteLine("Labsky details : breed:{0},color:{1},Age:{2},size{3}",labsky.breed,labsky.color,labsky.Age,labsky.size);
            Console.WriteLine("Inheritance...........");
            Car car = new Car();
            car.brand = "BMW";
            car.honk();//Call the vehicle method.
            car.start();//Call the car method.
            Console.WriteLine("Method Overloading........");
            Addition addition = new Addition();
            addition.SumOfNumbers(10, 20, 45);//Call the method
            Console.WriteLine("Method Overriding..........");
            //Call the Child Class
            PartTimeEmployee partTime = new PartTimeEmployee();
            partTime.GetSalary();
            //Call the Parent Class
            Employee employee = new PartTimeEmployee();
            employee.GetSalary();
            Console.WriteLine("Encapsulation......");
            Account account = new Account();
            account.SetBalance(1000);
            account.GetBalance();
            Console.ReadLine();
        }
    }
}
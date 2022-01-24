// See https://aka.ms/new-console-template for more information
using OOPSConcepts.ClassAndObject;

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
            Console.ReadLine();
        }
    }
}
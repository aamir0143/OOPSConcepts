using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts.Polymorphism.MethodOverloading
{
    class Addition
    {
        //Method
        public void SumOfNumbers(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("Sum:" + c);
        }
        public void SumOfNumbers(int a, int b, int d)
        {
            int c = a + b + d;
            Console.WriteLine("Sum:" + c);
        }
        public void SumOfNumbers(float a, int b, int d)
        {
            float c = a + b + d;
            Console.WriteLine("Sum:" + c);
        }
        public void SumOfNumbers(int b, float a, int d)
        {
            float c = a + b + d;
            Console.WriteLine("Sum:" + c);
        }
    }
}
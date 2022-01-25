using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts.Abstraction
{
    //Abstract Class
    abstract class Animal
    {
        public int height;
        //Abstract Method (Does not have a body)
        public abstract void AnimalSound();
        //Regular Method
        public static void Sleep() 
        {
            Console.WriteLine(" Zzzzz");
        }
    }
}

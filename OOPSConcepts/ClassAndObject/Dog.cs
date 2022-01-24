using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts.ClassAndObject
{
    public class Dog
    {
        //Charactersticks or Variables of entity
        public string breed, color;
        public int Age, size;
        //Actions or Behavior or Methods of entity
        public void Eat()
        {
            Console.WriteLine("Dog Eat");
        }
    }
}

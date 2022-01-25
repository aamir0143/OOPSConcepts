using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts.Abstraction
{
    //Derived Class (Inherit From Animal)
    class Pig : Animal
    {
        public override void AnimalSound()
        {
            //The Body of AnimalSound() is Provided here.
            Console.WriteLine(" The Pig Says : wee wee ");
        }
    }
}

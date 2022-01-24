using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts.Inheritance
{
    /// <summary>
    /// Base Class (Parent) Vehicle.
    /// </summary>
    class vehicle
    {
        //Instance Variables.
        public string brand = "Ford";
        //Instance Methods.
        public void honk()
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }
}
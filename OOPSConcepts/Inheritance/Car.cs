using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts.Inheritance
{
    /// <summary>
    /// Derive Class (Child) Car.
    /// </summary>
    class Car : vehicle
    {
        //Methods.
        public void start()
        {
            Console.WriteLine("Car started");
        }
    }
}
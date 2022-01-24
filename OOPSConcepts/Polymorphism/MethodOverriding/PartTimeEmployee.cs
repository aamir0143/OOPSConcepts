using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts.Polymorphism.MethodOverriding
{
    class PartTimeEmployee:Employee
    {
        public new void GetSalary()
        {
            Console.WriteLine("Child Salary:250");
        }
    }
}

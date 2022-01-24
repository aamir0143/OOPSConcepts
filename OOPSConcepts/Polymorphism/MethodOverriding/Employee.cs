using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts.Polymorphism.MethodOverriding
{
    class Employee
    {
        public string name;
        public double salary;
        public void EmployeeDetails()
        {
            Console.WriteLine("Name:" + name);
        }
        public void GetSalary()
        {
            Console.WriteLine("Parent Salary:500");
        }
    }
}
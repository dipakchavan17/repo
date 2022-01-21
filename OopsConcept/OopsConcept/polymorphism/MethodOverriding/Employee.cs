using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept.polymorphism.MethodOverriding
{
    internal class Employee
    {
        public string name;
        public double salary;

        public void EmployeeDetails()
        {
            Console.WriteLine("name:" + name);
        }
        public void GetSalary()
        {
            Console.WriteLine("salary:500");
        }
    }
}

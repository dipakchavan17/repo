using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept.polymorphism.MethodOverriding
{
    internal class PartTimeEmployee:Employee
    {
        public void GetSalary()
        {
            Console.WriteLine("salary:250");
        }
    }
}

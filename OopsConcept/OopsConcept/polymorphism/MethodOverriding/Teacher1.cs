using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept.polymorphism.MethodOverriding
{
    internal class Teacher1
    {
        string subject;
        public void display()
        {
            Console.WriteLine("subject=math:" +subject);
        }
    }
}

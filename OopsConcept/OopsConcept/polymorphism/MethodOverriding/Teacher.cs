using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept.polymorphism.MethodOverriding
{
    internal class Teacher
    {
        string name, subject;
        public void TeacherDetails()
        {
            Console.WriteLine("name:"+name);
        }
        public void display()
        {
            Console.WriteLine("subject:"+subject);
        }
    }
}

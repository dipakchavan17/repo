using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Addition
    {
        public static void AdditionNumber()
        {
            int a = 10, b = 20,c;
            c= a + b;
            Console.WriteLine("Addition is {0}", c);
            c = a-b;
            Console.WriteLine("subtraction is {0}", c);
            c = a * b;
            Console.WriteLine("multiplication is {0}", c);
            c = a / b;
            Console.WriteLine("division is {0}", c);
            c = a % b;
            Console.WriteLine("modulus is {0}", c);
            c = a++;
            Console.WriteLine("increment is {0}",c);
            c = a--;
            Console.WriteLine("decrement is {0}", c);









        }
    }
}

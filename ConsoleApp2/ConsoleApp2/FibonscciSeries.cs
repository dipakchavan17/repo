using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class FibonacciSeries
    {
       // public static int first = 0;
        //public static int second = 0;
        public void FindFibonacciSeries()
        {
            Console.WriteLine("please enter how many nmbers we have to generate");
            int number=Convert.ToInt32(Console.ReadLine());
            int first = 0, second = 1;
            int result = 0;
            result = first + second;
            Console.WriteLine(" {0}  {1}  {2}", first, second, result);
            for(int i=2;i<number;i++)
            {
                first = second;
                second = result;
                result = first + second;
                Console.WriteLine(result);
            }

        }
       
       
    }
}

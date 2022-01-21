using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ReverseNumber
    {
        //syntax- accessModifier static returntype methodname
        public static void FindReverseNumber()
        {
            Console.WriteLine("please enter number to reverse");
            int number=Convert.ToInt32(Console.ReadLine());//123 //321
            int reminder, reverse = 0;
            while(number>0)
            {
                reminder = number % 10;//3
                reverse = reverse * 10 + reminder;//3+2=2 //3*10=30+2=32
                number = number / 10;// 12 1 0
            }
            Console.WriteLine("after reverse:" + reverse);        }
    }
}

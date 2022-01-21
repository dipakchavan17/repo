using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class SwapProgram
    {
        public static void SwapNumbers()
        {
            int firstNum, secondNum, temp = 0;
            Console.WriteLine("please enter first number");
            firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter second number");
            secondNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("before exchanging values: first={0}, secondNum{1}", firstNum, secondNum);
            temp = firstNum;
            firstNum = secondNum;
            secondNum = temp;
            Console.WriteLine("After  exchanging values: first={0}, secondNum{1}", firstNum, secondNum);
        }
    }
}

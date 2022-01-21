using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ReverseNUmbers
    {
        public static void ReverseNumbers(string number)
        {
            char[] charNum= number.ToCharArray();
            string tempStr=string.Empty;
            for (int i = charNum.Length-1;i>-1;i--)
            {
                tempStr=tempStr + charNum[i];
            }


        }
    }
}

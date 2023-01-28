using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace java_basics
{
    internal class Armstrong_Number
    {
        public void GetArmstrong_Number()
        {
            int num = 371, rem, sum = 0;
            int temp = num;

            while (num > 0)
            {
                rem = num % 10;
                sum = sum + (rem * rem * rem);
                num = num / 10;

            }
            if (temp == sum)
            {
                Console.WriteLine("armstrong number");

            }
            else
            {
                Console.WriteLine("not an armstrong number");
            }
        }
    }

}





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace java_basics
{
    internal class Palindrome
    {
        public void GetPalindrome()
        {
            int num, sum = 0, temp, rem;

            Console.WriteLine("enter a number");

            num = Convert.ToInt32(Console.ReadLine());
            temp = num;

            while (num > 0)
            {
                rem = num % 10;
                sum = sum * 10 + rem;
                num = num / 10;


            }
            if (sum == temp)
            {
                Console.Write("number is palindrome");
            }
            else
            {
                Console.Write("number is not palindrome");
            }
            Console.ReadLine();



        }

    }
}









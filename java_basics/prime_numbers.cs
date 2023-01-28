using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace java_basics
{
    internal class prime_numbers
    {
        public void Getprime_numbers()
        {
            int i, m = 0, n = 1, flag = 0;

            n = 19;

            //it is the number to be checked
            m = n / 2;
            if (n == 0 || n == 1)
            {
                Console.Write(n + "is not  prime_numbers");

            }
            else
            {
                for (i = 2; i <= m; i++)
                {
                    if (n % i == 0)
                    {
                        Console.WriteLine(n + "is not prime number");
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {
                    Console.Write(n + "is prime number");
                }
            }


        }
    }
}





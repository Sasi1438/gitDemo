using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace java_basics
{
    internal class fibonacci
    {
        public void Getfibonacci()
        {
            int n1 = 0, n2 = 1, n3, number = 10;

            Console.Write(n1 + "" + n2 + "");

            for (int i = 1; i <= number; i++)
            {
                n3 = n1 + n2;

                Console.Write(n3 + "");

                n1 = n2;

                n2 = n3;
            }
        }
    }
}

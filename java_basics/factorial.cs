using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace java_basics
{
    internal class factorial
    {
        public void Getfactorial()
        {
            int fact = 1;

            int number = 6; //it is number to calculate factorial

            for (int i = number; i >= 1; i--)
            {
                fact = fact * i;
            }

            Console.WriteLine(fact);



        }

    }
}

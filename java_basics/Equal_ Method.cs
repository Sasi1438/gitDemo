using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace java_basics
{
    internal class Equal_Method
    {
        public void GetEqual_Method()
        {


            int X = 'a';

            int Y = 'a';
            Console.WriteLine("X:" + X);
            Console.WriteLine("Y:" + Y);

            Console.WriteLine("objects are not equal,hence it returns" + X.Equals(Y));
            Console.WriteLine("objects are equal,hence it returns" + X.Equals(X));

        }
    }
}

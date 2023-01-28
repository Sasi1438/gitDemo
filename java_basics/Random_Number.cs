using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace java_basics
{
    internal class Random_Number
    {
        public void GetRandom_Number()
        {
            Random rd = new Random();
            int num = rd.Next(100, 200);

            Console.WriteLine(num);
            Console.ReadLine();
        }
    }

}






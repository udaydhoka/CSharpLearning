/*  mod 5 operators

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNET
{
    class Program
    {
        public static void Main()
        {

            int num = 10;
            int den = 2;
            int res = num / den;
            int res1 = num % den;
            bool bnum = num != 10 ? true : false;
            Console.WriteLine(bnum);
            Console.WriteLine("result(/) = {0} , result(%)= {1}", res, res1);

            if (num == 10 || den != 2)
            {
                Console.WriteLine("true");
            }

            int a = 12, b = 14;
            int c = a / b;
            int d = a * b;
            int e = a + b * c - d;
            float f = 3.14f, pi = 3.14f;
            float z = f * e;
            bool x = a != 12 ? true : false;
            string s = string.Empty;
            bool i = string.IsNullOrWhiteSpace(s);
            Console.WriteLine(i);
        }
    }
}

//*/
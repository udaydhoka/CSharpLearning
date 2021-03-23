/* mod 3&4 datatypes

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

            bool b = true;
            //bool b = "fa";
            byte B = 255;
            //byte b = -3;
            sbyte sB = -3;
            short s = -3;
            ushort sS = 3;
            int i = -1;
            int j = 1;
            uint u = 3;
            long l = -1232456345456;
            ulong ul = 24325435435432;
            //uint ui = -3;
            float f = 3.14f;
            double d = 12.89485544d;
            decimal D = 3432454352435432.454325435243M;
            string user = "\"uday\"";
            string path1 = "C:\\windows\\users";
            string path = @"C:\windows\users";
            Console.WriteLine(path);
            Console.WriteLine("{0}\n{1}\n{2}", user, i, d);
            Console.WriteLine(decimal.MaxValue);
            //var ji = true;
            //Console.WriteLine(ji.GetType());
            //Console.WriteLine("{0} \t {1} \t {2}",decimal.MaxValue,float.MaxValue, long.MaxValue);
        }
    }

}

//*/
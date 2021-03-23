/* mod 7  type conversion 

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

            int i = 10;
            float f = i;

            float a = 10.45f;
            //int b = a;

            float fa = 13242342392323.56f;
            //int b = (int)a; // converts into incorrect value, doesn't throw any exception
            int b = Convert.ToInt32(a); // throws an exception if theres any error
            Console.WriteLine(b);


            //parse and tryparse

            string s = "100";
            //int j = int.Parse(s);
            int j = 0;
            bool res = int.TryParse(s, out j);
            if (res)
            {
                Console.WriteLine(j);

            }
            else
            {
                Console.WriteLine("please enter a valid string(entered val:{0})", s);

            }
        }
    }
}

//*/

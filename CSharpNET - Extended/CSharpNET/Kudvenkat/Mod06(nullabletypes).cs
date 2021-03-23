/* mod 6 nullable types


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

            string s = null; // string? s = null; throws error
                             // int i = null; // will throw error
            int? i = null;

            bool? areyoumajor = null;

            if (areyoumajor == true)
            {
                Console.WriteLine("user is major");
            }
            else if (areyoumajor == false)
            {
                Console.WriteLine("user is minor");
            }
            else
            {
                Console.WriteLine("user didnt answer the question");
            }


            //converting nullable type to non-nullable

            //without null coalescing 
            int? a = null;
            int b;
            if (a == null)
            {
                b = 0;
            }
            else
            {
                b = a.Value; // or b= int(a)
            }
            Console.WriteLine("value is {0}", b);

            //with null coalescing
            int c = a ?? 0;
            Console.WriteLine("value is {0}", c);
        }
    }

}

//*/
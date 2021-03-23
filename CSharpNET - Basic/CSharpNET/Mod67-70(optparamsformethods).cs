
/* mod 67 Optional paramter for methods using params

using System;

namespace CSharpNET
{
    class Program
    {
        public static void Main()
        {
            AddNumbers(10, 20); // thrid param is optional here 
            AddNumbers(10, 20, 30, 40, 50);
            AddNumbers(10, 20, new object[] { 30, 40, 50 });
        }

        // params has to be at last
        //public static void AddNumbers(int firstNumber, params object[] restOFNumbers, int secondNumber)
        public static void AddNumbers(int firstNumber, int secondNumber, params object[] restOFNumbers)
        {
            int result = firstNumber + secondNumber;
            if(restOFNumbers != null)
            {
                foreach( int n in restOFNumbers)
                {
                    result += n;
                }
            }
            Console.WriteLine("Total: "+ result.ToString());
        }
    }
}

//*/

/* mod 68 Optional parameter for methods using method Overloading

using System;

namespace CSharpNET
{
    class Program
    {
        public static void Main()
        {
            AddNumbers(10, 20);
            AddNumbers(10, 20, new int[] { 30, 40, 50 });

        }

        
        public static void AddNumbers(int fn, int sn, int[] restOfNumbers)
        {
            int res = fn + sn;
            if (restOfNumbers != null)
            {
                foreach (int n in restOfNumbers)
                    res += n;
            }
            Console.WriteLine("Total: "+res);
        }
        // above add method accetps three args, we cant have the option to supply only two
        // this can be achived by overlaoding the method as below

        public static void AddNumbers(int fn, int sn)
        {
            AddNumbers(fn, sn, null);
        }
    }
}

//*/

/* mod 69 Optional parameter for methods by specifying parameter defaults

using System;

namespace CSharpNET
{
    class Program
    {
        public static void Main()
        {
            AddNumnbers(10, 20); //since third param has a default value its, optional
            AddNumnbers(10, 20, new int[] { 30, 40, 50 });

            //named param example
            Test(10, 20); // here 20 is passed to b
            Test(10, c: 20); // here 20 is passed to c
        }

        //here we have specified the third param as null by default, making it as optional
        public static void AddNumnbers(int fn, int sn, int[] restOfNumbers = null)
        {
            int res = fn + sn;
            /// loop thru restOfTheNumbers only if it is not null
            // otherwise you will get a null reference exception
            if (restOfNumbers != null)
            {
                foreach (int n in restOfNumbers)
                    res += n;
            }
            Console.WriteLine("Total" + res);
        }

        // optional param must be at last, else it'll throw error as below
        //public static void AddNumnbers(int fn, int restOfNumbers = 0, int sn) { }

        // named params example
        public static void Test(int a, int b = 10, int c = 20)
        {
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
        }
    }
}

//*/

/* mod 70 Optional parameter for methods by using Optional Parameter

using System;
using System.Runtime.InteropServices;

namespace CSharpNET
{
    class Program
    {
        public static void Main()
        {
            AddNumbers(10, 20);
            AddNumbers(10, 20, new int[] { 30, 40, 50 });
        }
        //remember to add NS refernce of System.Runtime.InteropServices to use optional attrib.
        public static void AddNumbers(int firstNumber, int secondNumber, [Optional] int[] restOfTheNumbers)
        {
            int result = firstNumber + secondNumber;

            // loop thru restOfTheNumbers only if it is not null
            // otherwise you will get a null reference exception
            if (restOfTheNumbers != null)
            {
                foreach (int i in restOfTheNumbers)
                {
                    result += i;
                }
            }

            Console.WriteLine("Total = " + result.ToString());
        }
    }
}

//*/
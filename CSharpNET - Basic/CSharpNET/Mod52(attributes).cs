/* mod 52 Attributes

using System;
using System.Collections.Generic;

namespace CSharpNET
{
    class program
    {
        public static void Main()
        {
            int a = 12, b = 17, c;
            c = Addition.Add(a, b);
            Console.WriteLine(c);
            Addition.Add(new List<int> { 10, 20, 40, 50 });
        }
    }

    class Addition
    {
        [Obsolete()] // just displays warning while using this Add method.
        //[Obsolete("use Add(List<int> numbers) Method")] //warning along with this message
        //[Obsolete("use Add(List<int> numbers) Method",true)] // throws error when tried to use this method.
        public static int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public static int Add(List<int> numbers)
        {
            int sum = 0;
            foreach (var num in numbers)
                sum += num;
            return sum;
        }
    }
}

//*/
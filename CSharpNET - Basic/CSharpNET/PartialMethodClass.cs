using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNET
{
    
    public partial class PartialMethodClass
    {
        //private partial void Print(); // it cant have modifier
        //partial int Print(); // it cant have otherthan void as return type
        
        partial void Print(); // here the partial method is created, but implementation is ignored, but it still executes
        partial void NewPrint(); // here its declared, and implemented in other file
        
        //// double implemtation of this method, throws error
        //partial void NewPrint() 
        //{
        //    Console.WriteLine("Implementating partial method in other file");
        //}
        public void SampleMethod()
        {
            Console.WriteLine("Invoked public method");
            Print();
            NewPrint();
        }

        //// we cant have implemtation and declaration at once
        //partial void Test()
        //{
        //    Console.WriteLine("Test method invoked");
        //}

        ////here the signature isn't matching in declaration and implementation, throws error
        //partial void Detail();
        //partial void Detail(int i)
        //{
        //    Console.WriteLine("Detail() invoked");
        //}
    }

    ////only partial class or struct can have partial methods
    //public class NewClass
    //{
    //    partial void Simple();
    //}
}

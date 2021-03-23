using System;
using AssemblyOne;

namespace AssemblyTwo
{

    //* mod 50 Access Modifiers( Internal & Protected Internal)
    public class AssemblyTwoClass1 : AssemblyOneClass1 //inheriting to access protected internal fields from this class
    {
        public void print()
        {
            AssemblyOneClass1 a1 = new AssemblyOneClass1();
            //Console.WriteLine(a1.Id); // we can't access it, as its of internal field in a class from differnt library
            //Console.WriteLine(a1.n);// we cant access the protected mem by creating an instance of its own class. it has to be from derived class

            //accessing protected internal fied of class from different library, using inheritance
            Console.WriteLine(base.n);
            Console.WriteLine(this.n);

            AssemblyTwoClass1 a2 = new AssemblyTwoClass1();
            Console.WriteLine(a2.n); //accessning protected internal mem in AssemblyOneClass1 from different assembly
        }
    }
    //*/

    //*mod 51 Access Modifiers for types i.e., Internal & Public

    public class ATCO
    {
        public void test()
        {
            AOCO c1 = new AOCO();
            c1.Print();  // we can access public class across libraries

            // we cant access internal class across libraries
            //AOCT c2 = new AOCT();
        }
    }
    //*/
}

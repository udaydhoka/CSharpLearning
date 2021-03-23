using System;

namespace AssemblyOne
{

    //* mod 50 Access Modifiers( Internal & Protected Internal)
    public class AssemblyOneClass1
    {
        internal int Id = 101; //can be access only within this classlibrary file
        protected internal int n = 1;
    }

    public class AssemblyOneClass2
    {
        public static void Main()
        {
            AssemblyOneClass1 a1 = new AssemblyOneClass1();
            Console.WriteLine(a1.Id); //accessing the internal member in differnt class, but with in the same library

            Console.WriteLine(a1.n); //accessing protected internal class member in different class(which is not inherting class1), but within the same library
        }
    }
    //*/
    
    //*mod 51 Access Modifiers for types i.e., Internal & Public
    public class AOCO
    {
        public void Print()
        {
            Console.WriteLine("Hello");
        }
    }

    
    internal class AOCT // or class AOCT, as default would be "internal" for types
    {
        public void Print()
        {
            Console.WriteLine("Hey");
        }
    }

    class Program
    {
        public  void test()
        {
            AOCO c1 = new AOCO();
            c1.Print();  //accessing public class members, as it has no restrictions

            AOCT c2 = new AOCT();  
            c2.Print();  //accessing internal class members, as its the same library file.

        }
    }
    //*/
}


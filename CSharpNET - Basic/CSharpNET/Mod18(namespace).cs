/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace CSharpNET
{
    
    class Program
    {
        public static void Main()
        {
            
        }

    }

}     

//*/


/*mod 18 namespaces

using System;
//using ProjectA.TeamA;
//using ProjectA.TeamB;
using PATA = ProjectA.TeamA; // using alias for a namespace
using PATB = ProjectA.TeamB;
class Program
{
    public static void Main()
    {
        //ClassA.Print();  // using directive is being used here
        ProjectA.TeamB.ClassA.Print(); // fuly qualified names is used
        //ClassA.Print();  // // using directive is being used here
        PATA.ClassA.Print();
        PATB.ClassA.Print();
    }

}

namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team A print Method");
            }
        }
    }
}

namespace ProjectA
{
    namespace TeamB
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team B print Method");
            }
        }
    }
}

//// Namespace using library classes written seperatly in other classes outside the proj
//using System;
//using ProjectA.TeamA; /these are implemented using lib class
//using ProjectA.TeamB;

//class Day2
//{
//    public static void Main()
//    {
//        ProjectA.TeamA.ClassA.Print();
//        ProjectA.TeamB.ClassA.Print();
//    }

//}

//*/

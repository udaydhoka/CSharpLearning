
/* mod 61 Partial class
//see partialclass.cs file for this demo

using System;

namespace CSharpNET
{
    class Program
    {
        public static void Main()
        {
            PartialClass p = new PartialClass() { ID = 1, Name = "uday" };
            p.Print();
        }
    }
     
    //we're extending the partial class defined in partialclass.cs file
    public partial class PartialClass
    {
        // we're accessing a private field and public property defined in other class file
        public void Print()
        {
            Console.WriteLine("{0} \t {1}", Id, Name );
        }
    }
}

//*/

/* mod 62 Creating partial class
// see ParticalClassone.cs file for this demo

using System;

namespace CSharpNET
{
    class Program
    {
        public static void Main()
        {
            ////for rule 3, thorws error as we cant create instance of an abstract class
            //ParticalClassone one = new ParticalClassone();
        }
    }

    //// rule 1, throws errors as partial keyword is missing. 
    //public  class ParticalClassOne
    //{
    //}

    ////rule 2, throws error as accessmodifier here is internal and in other file its public
    //internal partial class ParticalClassOne
    //{
    //}

    ////for rule 1,2 & 3 
    ////here we are not specifying abstract or sealed keyword but its still be considered one
    //public partial class ParticalClassone
    //{
    //}

    ////for rule 4, here we didnt metion it as sealded, where as in other is mentioned
    //public partial class ParticalClassone
    //{
    //}
    ////throws error, as base class is sealed
    //public class Test : ParticalClassOne
    //{ }

    ////for rule 5
    ////accessing Cusotmer class property, though we didnt specify here the inheritance.
    ////public partial class ParticalClassOne
    //{
    //    public void Print()
    //    {
    //        Console.WriteLine(this.MyProperty);
    //    }
    //}

    ////for rule 6
    //public partial class ParticalClassOne : Emp
    //{
    //}
    //public class Emp
    //{
    //    public int MyProperty { get; set; }
    //}

    ////for rule 7
    //public partial class ParticalClassOne : IEmployee
    //{
    //    public void MyDetails()
    //    {}

    //    public void MyProperty()
    //    { }
    //}
    //public interface IEmployee
    //{
    //    void MyDetails();
    //}

    //for rule 8, acessing public member here defined in other file
    //public partial class ParticalClassOne
    //{
    //    public void Print()
    //    {
    //        Console.WriteLine(a);
    //    }
    //}
}

//*/

/* mod 63 partial methods
// see partialMethodClass.cs file for this demo

using System;

namespace CSharpNET
{
    class Program
    {
        public static void Main()
        {
            PartialMethodClass p = new PartialMethodClass();
            p.SampleMethod();
        }
    }

    public partial class PartialMethodClass
    {
        
        partial void NewPrint() // here its implemented, in other file its declared
        {
            Console.WriteLine("Implementating partial method in other file");
        }
    }
}

//*/

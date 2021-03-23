using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNET
{
    //// for rule 1 All the parts spread across different files, must use the partial keyword. Otherwise a compiler error is raised.
    ////for rule  2 All the parts spread across different files, must have the same access modifiers. Otherwise a compiler error is raised. 
    //public partial class ParticalClassOne
    //{
    //}

    //for rule 3, If any of the parts are declared abstract, then the entire type is considered abstract.
    //public abstract partial class ParticalClassone
    //{
    //}

    //for rule 4, If any of the parts are declared sealed, then the entire type is considered sealed. 
    //public sealed partial class ParticalClassOne
    //{
    //}

    ////for rule 5,  If any of the parts inherit a class, then the entire type inherits that class.
    //public partial class ParticalClassOne : Customer
    //{
    //}
    //public class Customer
    //{
    //    public int MyProperty { get; set; }
    //}

    ////for rule 6, C# does not support multiple class inheritance. Different parts of the partial class, must not specify different base classes
    //public partial class ParticalClassOne : Customer
    //{
    //}
    //public class Customer
    //{
    //    public int MyProperty { get; set; }
    //}

    ////for rule 7, Different parts of the partial class can specify different base interfaces, and the final type implements all of the interfaces listed by all of the partial declarations.
    //public partial class ParticalClassOne : ICustomer
    //{
    //}
    //public interface ICustomer
    //{
    //    void MyProperty();
    //}

    ////rule 8, Any members that are declared in a partial definition are available to all of the other parts of the partial class.
    //public partial class ParticalClassOne 
    //{
    //    public int a = 10;
    //}
}

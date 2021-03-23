/* mod 30  interfaces

using System;

interface ICustomer
{
    ////throws error, as interface members cant have defination
    //void Print()
    //{
    //    Console.Write("hello");
    //}

    // public void Print(); // members cant have modifiers, they are by default public
    void Print();

    // int ID; // interfaces cant have fields

    //interface can have properties
    // int MyProperty { get; set; }
}

interface I2
{
    void I2method();
}
public class Customer : ICustomer
{

    // class should implement methods of inherited interface else it'll throw error
    // also the method def should be same as that of interface
    public void Print()
    {
        Console.WriteLine("Implementing Interface method");
    }
}

//class can herit from multiple interfaces 
public class cust : ICustomer,I2
{
    public void I2method()
    {
            Console.WriteLine("Implementing I2 Interface method");
    }

    public void Print()
    {
        Console.WriteLine("Implementing customer Interface method");
    }
   
}
//interface inheriting from another interface
interface Icustomer2 : ICustomer
{
    void print2();
}

// class implementing inherited interface members

public class Customer2 : Icustomer2 
{
    public void Print() // from Icustomer interface, which is inherited by icustomer2
    {
        throw new NotImplementedException();
    }
    // if any of these methods aren't implmented, it'll throw compilation error
    public void print2() // from base Icustomer1 interface
    { 
        throw new NotImplementedException();
    }
}
public class Program
{
    public static void Main()
    {
        Customer c1 = new Customer();
        c1.Print();

        cust c2 = new cust();
        c2.Print();
        c2.I2method();

        // Instance of an interface cant be created
        // ICustomer new = ICustomer(); 

        // but reference variable of interface can point to derived class object
        ICustomer c = new cust();
        c.Print();
    }
}
//*/

/* mod 31 explicit interfaces 

using System;

interface I1
{
    void InterfaceMethod();
}

//another interface with same member method
interface I2
{
    void InterfaceMethod();
}

//for default implementation
interface I3
{
    void InterfaceMethod();
}

////class implementing two interfaces of same member without explicit interfaces
//public class Program : I1,I2
//{
//    // there wont be any compilation error while implementing the method
//    public void InterfaceMethod()
//    {
//        Console.WriteLine("I interface method");
//    }
//    public static void Main()
//    {
//        Program p = new Program();
//        p.InterfaceMethod(); // calling method will execute without any compilation and runtime error.
//        //but there's a ambiguity, that which method is implemented.
//    }
//}

// Implementing explicit interface
public class Program : I1, I2, I3
{
    void I1.InterfaceMethod() // implementing I1 member, no access modifier as explicit interfaces cant have access modifiers
    {
        Console.WriteLine("I1 method");
    }

    void I2.InterfaceMethod()  // implementing I2 member
    {
        Console.WriteLine("I2 method");
    }

    // Default implemetation
    public void InterfaceMethod()
    {
        Console.WriteLine("I3 Default Implementation");
    }
    public static void Main()
    { 
        //using type cassing
        Program p = new Program();
        ((I1)p).InterfaceMethod(); //calls i1 method
        ((I2)p).InterfaceMethod(); //calls i2 method

        //p.interfacemethod // we cant use class var for explicitly implemented interface members, throws error
        
        
        //using polymorphism

        I1 a = new Program();
        I2 b = new Program();

        a.InterfaceMethod();
        b.InterfaceMethod();

        //for default implementation of interface
        p.InterfaceMethod(); // can be used when default implementation is present


    }
}
//*/

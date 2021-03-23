
/* mod 32 Abstract Classes

using System;

public abstract class Customer
{
    public abstract void Print();

    //throws error, as abstract members cant have implementation.
    //public abstract void Print();
    //{
    //}
}

public abstract class Cust : Customer // inheriting abstract class, marking as abstract class
{
    //abstract member method isnt implemented, as the derived class is abstract
    // hence we wont get any build errors

    //abstract class without any abstract members
    public void Prin()
    {
        Console.WriteLine("Inherting abstract class by making dervied class as abstract");
    }

}
public  class Program : Customer // inheriting abstract class
{
    //implementing abstract member method using override method.
    public override void Print()
    {
        Console.WriteLine("Abstract Class");
    }
    public static void Main()
    {
        Program p = new Program();
        p.Print();
        // or 
        Customer c = new Program();
        c.Print();
    }
}
//*/

/* mod 33 abstract classes vs interfaces

using System;

public abstract class Customer
{
    int Id; // they can have fields
    public void Print()
    {
        Console.WriteLine("Methods can be implemented");
    }
}

public interface ICustomer
{
    // int id; // they cant have fields 
    void print();

    //methods cant be implemented
    //void print()
    //{
    //    Console.WriteLine("Methods can't be implemented");
    //}
}

// abstract class can inherit from another abstract class or interface
public abstract class Cust : Customer, ICustomer
{
    public void print()
    {
        throw new NotImplementedException();
    }
}

// interface can only inherit from another interface 
interface ICust : ICustomer // , Customer // cant inherit class
{

}

public class Program
{
    public static void Main()
    {

    }
}
//*/
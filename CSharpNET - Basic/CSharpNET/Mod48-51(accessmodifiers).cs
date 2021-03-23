
/* mod 48 Types vs Type Members, regions
using System;

class Program
{
    public static void Main()
    {

    }
}

class Customer //class is type
{
    #region fields
    private int myVar; //field is type member
    private int myVar1;
    private int myVar2;
    #endregion

    #region properties
    public int MyProperty //property is type member
    {
        get { return myVar; }
        set { myVar = value; }
    }
    #endregion

    #region constructors
    public Customer() //constructor is type member
    { }
    #endregion

    #region methods
    public void Print()  //method is a type member
    {
        Console.WriteLine("Method from class");
    }
    #endregion

}

//*/

/* mod 49 Access Modifiers(private, protected & public
using System;
public class Customer
{
    
    private int _id; // only available within this class
    protected int salary; //available within this class and the class thats inherits this class

    public int Id //available any where, as its public
    {
        get { return _id; } // we can access _id here, as its the same class
        set { _id = value; }
    }

    public void Print()
    {
        Console.WriteLine(salary); // we can access the 
    }

}

public class CorporateCustomer : Customer
{
    public void PrintSalary()
    {
        CorporateCustomer cc = new CorporateCustomer();
        cc.salary = 1000; //we can access this protected member as this class inherits the customer class
                          //or
        this.salary = 1000; //accessing base class fields using this keyword
        //or
        base.salary = 1000; //accessing the base class field using base keyword

        //Customer c1 = new Customer();
        //c.salary = 1; // we cant access the protected mem by creating an instance of its own class. it has to be from derived class
        
    }
}

class Program 
{
   public static void Main()
    {
        Customer c = new Customer();
        //c._id;     //we cant access it as its private 
        //c.salary;  //we cant access it, as the this class isn't inheriting the class customer. as this field is protected
        Console.WriteLine(c.Id); //we can access Id as its public
               
    }
}

//*/

/* mod 50 Access Modifiers( Internal & Protected Internal)

//see class libraries assembly one & two for this demo 

//*/

/* mod 51 Access Modifiers for types i.e., Internal & Public

//see class libraries assembly one & two for this demo 



using System;
using AssemblyOne;
using AssemblyTwo;

namespace CSharpNET
{
    class Solution
    {
        public static void Main()
        {
            ATCO ass2 = new ATCO();
            ass2.test();       
        }
    }
}


//*/
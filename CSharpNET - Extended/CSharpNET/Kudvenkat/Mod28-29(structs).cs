/* mod 28 structs

using System;

public struct Customer
{
    private int _id;
    private string _name;

    public int ID
    {
        get
        {
            return this._id;
        }

        set
        {
            this._id = value;
        }
    }

    

    //generated using refractor setting (RC)
    public string Name { get => _name; set => _name = value; }

    //struct cant have parameterless constructor
    //public Customer(); 

    //constructor
    public Customer(int id,string name)
    {
        this._id = id;
        this._name = name;
    }

    public void PrintDetails ()
    {
        Console.WriteLine(" Id = {0} && Name = {1} ", _id, _name);
    }
}


public class Program
{
    public static void Main()
    {
        Customer c1 = new Customer(101, "Uday");
        c1.PrintDetails();

        Customer c2 = new Customer();
        c2.ID = 102;
        c2.Name = "uday 2";
        c2.PrintDetails();

        //object initializer syntax
        Customer c3 = new Customer
        {
            ID = 103,
            Name = "uday 3"
        };
        c3.PrintDetails();
    }
}
//*/

/*mod 29 struct and classes differences( value and reference type var diff)

using System;

//public sealed class cust // if we mark class as sealed, it cant inherited
public class Cust
{
 public int Id { get; set; }
 public string Name { get; set; }

   //classes can have explicit paramaterless constructs
   public Cust()
   { }
   // classes can have destructors
   ~Cust()
   {

   }
}

public struct Customer
{
   public int Id { get; set; }
   public string Name { get; set; }

   //structs cant have explicit paramaterless constructs
   //public Customer()
   //{ }

   // structs cant have destructors
   //~Customer()
   //{

   //}
}

public class Program
{
   public static void Main()
   {
      
       Cust c1 = new Cust();
       c1.Id = 1;
       c1.Name = "Uday";

       Cust c2 = c1; // assigning one reference variable to other 
       c2.Name = "uday renamed in class2 "; // changing c2 will affect c1 as its a reference variable

       Console.WriteLine("from c1 : "+c1.Name + " \t from c2 : " + c2.Name);

        Customer s1 = new Customer()
        {
            Id = 1,
            Name = "uday"
        };

        Customer s2 = s1;
        s2.Name = "uday renamed in struct2 ";
        Console.WriteLine("From s1 : " + s1.Name + " \t From s2 : " + s2.Name);



        //since int is also a struct
        int i = 10;
        int j = i; //assigning one value variable to other 
        j += 1; // changing j will not affect i as its value variable type
        Console.WriteLine("i = {0} j = {1}", i, j);
    }
}
//*/
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


/* mod 23 polymorphism

using System;

public class Employee
{
    public string FirstName = "FN";
    public string LastName = "LN" ;

    public virtual void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}

public class FullTimeEmp : Employee
{   
    // override key word allows this method to be accessed when virtual base class method is called, hence implementing polymorphism
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " - fulltime");
    }
}

public class PartTimeEmp : Employee
{
    // override key word allows this method to be accessed when virtual base class method is called, hence implementing polymorphism
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " - parttime");
    }
}

public class TempEmp : Employee
{
    //// override key word allows this method to be accessed when virtual base class method is called, hence implementing polymorphism
    //public  override void PrintFullName()
    //{
    //    Console.WriteLine(FirstName + " " + LastName + " - temporary");
    //}

    //since we dont have override keyword here , this method wont be called when an virtual method of same name is called in base class
    public void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " - temporary");
    }
}


public class Program
{
    public static void Main()
    {
        Employee[] Emp = new Employee[4];

        Emp[0] = new Employee();
        Emp[1] = new FullTimeEmp();
        Emp[2] = new PartTimeEmp();
        Emp[3] = new TempEmp();

        foreach(Employee e in Emp)
        {
            e.PrintFullName();
        }
    }
}
//*/

/* mod 24 diff in method overriding and method  hiding

using System;

public class Baseclass
{
    public virtual void print()
    {
        Console.WriteLine("I'm a base class method");
    }
}

// method overriding 
public class DerivedClas: Baseclass
{
    public override void print()
    {
        Console.WriteLine("I'm a Dervied class method");
    }
}

//method hiding
public class childclass : Baseclass
{
    public new void print()
    {
        Console.WriteLine("I'm a child class method");
    }
}


class Program
{
    public static void Main()
    {
        //method overriding
        Baseclass B = new DerivedClas();
        B.print();

        //method hiding
        Baseclass b = new childclass();
        b.print();
    }

}
//*/

/* mod 25 method overloading

using System;

public class Program
{
    public static void Main()
    {
        // overloading  based on no of parameters
        add(10, 20);
        add(10, 20, 30);

        // overloading  based on type of parameters
        add(1.4f, 2.4f);
        add(10, 1.4f);

        // overloading  based on kind of parameters
        int o;
        add(1, 2, 3, 4);
        add(1, 2, 3, out o);

    }

    // overloading  based on no of parameters
    public static void add(int fn, int sn)
    {
        Console.WriteLine("sum = {0}", fn + sn);
    }
    public static void add(int fn, int sn, int tn)
    {
        Console.WriteLine("sum = {0}", fn + sn + tn);
    }

    // overloading  based on type of parameters

    public static void add(float fn, float sn)
    {
        Console.WriteLine("sum = {0}", fn + sn);
    }

    public static void add(int fn, float sn)
    {
        Console.WriteLine("sum = {0}", fn + sn);
    }

    // overloading  based on kind of parameters

    public static void add(int fn, int sn, int tn,int frn)
    {
        Console.WriteLine("sum = {0}", fn + sn + tn+frn);
    }

    public static void add(int fn, int sn, int tn,out int frn)
    {
        Console.WriteLine("sum = {0}", fn + sn + tn);
        frn = fn + sn + tn;
    }

    //// overloading isnt possible based only on return type
    //public static int add(int fn, int sn, int tn, int frn)
    //{
    //    Console.WriteLine("sum = {0}", fn + sn + tn + frn);
    //    return fn + sn + tn + frn;
    //}

    ////overloading isnt possible based only on params parameter
    //public static void add(int fn, int sn, int [] tn)
    //{
    //    Console.WriteLine("sum = {0}", fn + sn);
    //}
    //public static void add(int fn, int sn,params int[] tn)
    //{
    //    Console.WriteLine("sum = {0}", fn + sn);
    //}


}
//*/
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


/* mod 19 classes

using System;

class Customer
{
    //data fields
    string _firstname;
    string _lastname;

    ////constructor without parametets type 1
    //public Customer()
    //{
    //    _firstname = "No first name provided";
    //    _lastname = " No last name provided";
    //}

    //constructor without parameters type 2
    public Customer()
       : this("no first name provided", "no last name provided")
    {}



    //constructor
    public Customer(string FN, string LN)
    {
        _firstname = FN;
        this._lastname = LN;
    }

    //method or behaviour
    public void PrintFullName()
    {
        Console.WriteLine("Full Name: {0}", this._lastname + "" + this._lastname);
    }

    //destructor
    ~Customer()
    {
        //code to clean up the resources
    }
}

class Progam
{
    public static void Main()
    {
        Customer c1 = new Customer("uday", "kuruva"); // using param construct
        c1.PrintFullName();
        Customer c2 = new Customer(); // using default constructor
        c2.PrintFullName();
    }
}



//// demo for default constructor provided by .net ,which is parameter less

//using System;

//class Customer
//{
//    //data fields
//    string _firstname;
//    string _lastname;

//    ////constructor
//    //public Customer(string FN, string LN)
//    //{
//    //    _firstname = FN;
//    //    this._lastname = LN;
//    //}

//    //method or behaviour
//    public void PrintFullName()
//    {
//        Console.WriteLine("Full Name: {0}", this._lastname + "" + this._lastname);
//    }

//    //destructor
//    ~Customer()
//    {
//        //code to clean up the resources
//    }
//}

//class Progam
//{
//    public static void Main()
//    {
//        Customer c1 = new Customer();
//        c1.PrintFullName();
//    }
//}

//*/

/*mod 20 static and instance class members
using System;

class Circle
{
    //float _PI = 3.14f;
    //static float _PI = 3.14f;  // using static fields
    int _radius;
    static float _PI; // defining static member , so that they can initialized using static constructor

    // public static Circle() //throws error as we cant use static constructor with public access modifier
    static Circle()
    {
        Console.WriteLine("Static Construtor called"); // to demo.. static construct are called before instance constructor and only once
        Circle._PI = 3.141f;  // initializing static field using static constructor
    }

    // Circle(int Radius) // defining this as a private constructor will give compile error for the code written in main class , as we are accessing this construtor 
    public Circle(int Radius) // here the acces modifier enables it to be accessed outside the class
    {
        Console.WriteLine("Instance Construtor called"); // to demo.. instance const. are called for every obj of class created
        this._radius = Radius;
    }

    //static method demo
    public static void print()
    {
        Console.WriteLine("static method eg , accessing by class name instead of instance name");
    }

    public float CalculateArea()
    {
        //return this._PI * this._radius * this._radius;
        return Circle._PI * this._radius * this._radius; // calling static field using class name
    }
}

// for demo.. of static const is called before creating the instance of the class or during the reference to the static fields
class demoforstaticconst
{
    public static int _new;

    static demoforstaticconst()
    {
        Console.WriteLine("Const called before the value of field is refered");
        demoforstaticconst._new = 123;
        
    }
}

class Program
{
    public static void Main()
    {

        Console.WriteLine("{0}", demoforstaticconst._new);

        Circle c1 = new Circle(5);
        float Area1 = c1.CalculateArea();
        Console.WriteLine("Area2 : {0}", Area1);
        
        //c1.print(); // wont work since its static method
        Circle.print(); // demo of static method

        Circle c2 = new Circle(7);
        float Area2 = c2.CalculateArea();
        Console.WriteLine("Area2 : {0}", Area2);

        

    }
} 
//*/

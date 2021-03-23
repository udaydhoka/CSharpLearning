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


/*mod 21 inheritance 

using System;

public class Employee
{
    public string FirstName; // we'd never use public access modifier for class fields
    public string LastName; // rather we'd use properties to expose it outside the class
    public string Email;

    //demo for parent class const are called first
    public Employee()
    {
        Console.WriteLine("ParentClass Constructor called ");
    }

    // demo for using base keyword
    public Employee(string emp)
    {
        Console.WriteLine(emp);
    }

    public void PrintName()
    {
        Console.WriteLine("Full Name: {0}", FirstName + " " + LastName);
    }
}
 public class FullTimeEmp : Employee
{
   public float YearlySalary;

    public FullTimeEmp()
    {
        Console.WriteLine("ChildClass Constructor called in fulltime");
    }

}

public class PartTimeEmp : Employee
{
   public float HourlyRate;

    public PartTimeEmp() : base("Calling parameterized construct in base class using base keyword from partime")
    {
        Console.WriteLine("ChildClass Constructor called in Partime ");
    }
}

// multiple class inhertiance is not supported in C#
// below lines throws compilation errors
// public class A:Employee,FullTimeEmp
//{
//  string Newfeild;
//}

// C# supports multi-level inheritance
// below code works fine
//public class A : FullTimeEmp
//{
//    string Newfeild;
//}

public class Program
{
    public static void Main()
    {
       FullTimeEmp FTE = new FullTimeEmp();
        FTE.FirstName = "uday";
        FTE.LastName = "kumar";
        FTE.YearlySalary = 500000;
        // FTE.hourlyrate doesnt exists since its specific to parttime emp class
        FTE.PrintName();

        PartTimeEmp PTE = new PartTimeEmp();
        PTE.FirstName = "fn";
        PTE.LastName = "ln";
        PTE.HourlyRate = 500;
        // PTE.yearly salary doesn't exits since its specfic to fulltime emp class
        PTE.PrintName();

    }
}
//*/

/* mod 22 method hiding

using System;

public class Employee
{
    public string FirstName;
    public string LastName;

    public void Print()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}

public class FullTimeEmp : Employee
{

  

}

public class PartTimeEmp : Employee
{
    // hiding print method of base class
    // public void Print()  // will give compiler warning as we are hiding the print method  to void compiler warning , we have to use new keyword.

    // hiding print method of base class
    public new void Print()
    {
        base.Print(); // to call base class method , which is hidden method in childclass , using 'base' 
        Console.WriteLine(FirstName + " " + LastName + "-contractor");
    }

}

public class Program
{
    public static void Main()
    {
        FullTimeEmp FTE = new FullTimeEmp();
        FTE.FirstName = "full time ";
        FTE.LastName = "employee";
        FTE.Print();

        PartTimeEmp PTE = new PartTimeEmp();
        PTE.FirstName = "part time";
        PTE.LastName = "employee";
        PTE.Print();

        //calling base class hidden method using child class by type casting
        ((Employee)PTE).Print();

        //calling base class hidden method using child class by type casting on reference variable
        Employee e = new PartTimeEmp();
        e.FirstName = "par time";
        e.LastName = "employee";
        e.Print();

        // child class reference var cant be pointed to parent class obj , vice-versa is alone possible 
        //PartTimeEmp temp = new Employee();

    }
}
//*/

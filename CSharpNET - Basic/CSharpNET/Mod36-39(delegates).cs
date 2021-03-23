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

/* mod 36 delegates

using System;

//creating a delegate, its syntax is similar to method. 
//it should have same return type and parameterts as of method for which its pointing
//it could point to all the methods, with void return type and string as parameter

public delegate void DelegatePrint(string msg); //its defined outside the class

class Program
{
    public static void Main()
    {
        //creating a instance of delegate
        DelegatePrint d = new DelegatePrint(Print); //arg should be name of the function to be pointed by delegate
        d("Hey there!");

        DelegatePrint d1 = new DelegatePrint(Hello);
        d1("Hellow");


        //throws error the sign of delegate != sign of method
        //example of type safe pointer
        //DelegatePrint d2 = new DelegatePrint(PrintHello); 
        //d("Print hello method");
        
    }

    public static void Print(string strMsg)
    {
        Console.WriteLine(strMsg);
    }

    public static void Hello(string msge)
    {
        Console.WriteLine(msge);
    }
    public static int PrintHello()
    {
        Console.WriteLine();
        return 1;
    }


}

//class Program
//{
//    public delegate void NewDelegate(); // delegate nested in the class
//    public static void Main()
//    {

//        NewDelegate d1 = Program.Details;
//        Program p = new Program();
//        d1 += p.Contact;
//        //d1 += Program.Number; // we cant add this method, as its return type is int and thus the signature mismatches
//        d1.Invoke();
//    }

//    public static void Print()
//    {
//        Console.WriteLine("Print Method");
//    }

//    public static void Details()
//    {
//        Console.WriteLine("Details method");
//    }

//    public void Contact()
//    {
//        Console.WriteLine("Instance method");
//    }

//    public static int Number()
//    {
//        Console.WriteLine("int return type");
//        return 1;
//    }
//}
//*/

/* Need for delegates(own code)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharpNET
{
    //class employee
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public int Salary { get; set; }

    //    private bool? promote = null;

    //    public bool? Promote
    //    {
    //        get { return promote = null; }
    //    }


    //    public void PromotionElgibilty()
    //    {
    //        if (Salary < 5000)
    //        {
    //            Console.WriteLine(" {0}: Eligible for Promotion", Name);
    //            promote = true;
    //        }

    //    }

    //    public void Promotion()
    //    {
    //        bool p = promote ?? false;
    //        if (p)
    //        {
    //            Salary += 2000;
    //        }
    //    }


    //}

    //class Program
    //{
    //    public static void Main()
    //    {
    //        List<employee> emp = new List<employee>();
    //        emp.Add(new employee { Id = 1, Name = "A", Salary = 3000 });
    //        emp.Add(new employee { Id = 2, Name = "B", Salary = 6000 });
    //        emp.Add(new employee { Id = 3, Name = "C", Salary = 5000 });

    //        //foreach(employee one in emp)
    //        //{
    //        //    one.PromotionElgibilty();
    //        //}
    //        // if we wanna change the promotion eligibilty we cant as its declared in the other for which assume we dont have access
    //        //we could write our method in some cases like below

    //        foreach (employee one in emp)
    //        {
    //            if (one.Salary <= 5000)
    //            {
    //                Console.WriteLine("{0} is promoted", one.Name);
    //            }
    //        }

    //        //but say emp class has some var(promote) which is readonly and then only set by the promotion method to increase the salary , then the above method is useless

    //        // then we could apply delegates here
    //    }
    //}

    public delegate bool DPromote(employee e);
    public class employee
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        private bool? promote = null;

        public bool? Promote
        {
            get { return promote = null; }            
        }


        public void PromotionElgibilty(employee e, DPromote d)
        {
             if (d(e))
                {
                    Console.WriteLine(" {0}: Eligible for Promotion", Name);
                    promote = true;
                }
            
           

        }

        public  void Promotion()
        {
            bool p = promote ?? false;
            if (p)
            {
                Salary += 2000;
            }
        }


    }
    
    class Program
    {
         public static void Main()
         {
            List<employee> emp = new List<employee>();
            emp.Add(new employee { Id = 1, Name = "A", Salary = 3000 });
            emp.Add(new employee { Id = 2, Name = "B", Salary = 6000 });
            emp.Add(new employee { Id = 3, Name = "C", Salary = 5000 });

            DPromote d = new DPromote(Promt);
            
            foreach(employee e in emp)
            {
                e.PromotionElgibilty(e, d);                
            }          
           
         }
        public static bool Promt(employee e)
        {
            bool o;
            return  o = e.Salary < 5000 ? true : false;
        }
    } 
}
//*/

/* mod 37 & 38 delegates usage

//  37: the following program works fine, but if someone had to use but with different scenario for promotion he cant use the existing class
// they had to either change the class code or use different one

//using System;
//using System.Collections.Generic;
//class Program
//{
//    public static void Main()
//    {
//        List<Employee> empList = new List<Employee>();

//        empList.Add(new Employee() { number = 1, name = "uday", salary = 1000, experience = 1 });
//        empList.Add(new Employee() { number = 2, name = "jay", salary = 4000, experience = 4 });
//        empList.Add(new Employee() { number = 3, name = "ayan", salary = 7000, experience = 7 });
//        empList.Add(new Employee() { number = 4, name = "pro", salary = 3000, experience = 3 });

//        Employee.Promotion(empList);
//    }
//}

//class Employee
//{
//    public int number { get; set; }
//    public string name { get; set; }
//    public int salary { get; set; }
//    public int experience { get; set; }

//    public static void Promotion(List<Employee> emp)
//    {
//        foreach(Employee e in emp)
//        {
//            if (e.experience >= 4)
//                Console.WriteLine(e.name + "Promoted");
//        }
//    }

//}

//// 38: by using  the delegate, we have enabled the user to plugin his own logic here.

//using System;
//using System.Collections.Generic;
//class Program
//{
//    public static void Main()
//    {
//        List<Employee> empList = new List<Employee>();

//        empList.Add(new Employee() { number = 1, name = "uday", salary = 1000, experience = 1 });
//        empList.Add(new Employee() { number = 2, name = "jay", salary = 4000, experience = 4 });
//        empList.Add(new Employee() { number = 3, name = "ayan", salary = 7000, experience = 7 });
//        empList.Add(new Employee() { number = 4, name = "pro", salary = 3000, experience = 3 });

//        IsPromotable promotable = new IsPromotable(Promote); //instance creation of delegate
//        Employee.Promotion(empList,promotable);  // calling static method of Employee class
//    }
//    public static bool Promote(Employee el) // called by static method in emp class
//    {
//        bool answer;
//        return answer = el.experience <= 3 ? true :  false; // we're defining the logic here, which can be changed anytime without interuppting the class
//    }
//}

//delegate bool IsPromotable(Employee empl); //delegate with return type bool added

//class Employee
//{
//    public int number { get; set; }
//    public string name { get; set; }
//    public int salary { get; set; }
//    public int experience { get; set; }

//    public static void Promotion(List<Employee> emp, IsPromotable isEligible) //passing delegate as parameter, in runtime it'll be the method delegate pointing to
//    {
//        foreach (Employee e in emp)
//        {
//            if (isEligible(e))  //invokes the method, delegate is pointing to which matches the sign of delegate, which is return in program class
//                Console.WriteLine(e.name + "Promoted");
//        }
//    }

//}

//using lamda expression

using System;
using System.Collections.Generic;
class Program
{
    public static void Main()
    {
        List<Employee> empList = new List<Employee>();

        empList.Add(new Employee() { number = 1, name = "uday", salary = 1000, experience = 1 });
        empList.Add(new Employee() { number = 2, name = "jay", salary = 4000, experience = 4 });
        empList.Add(new Employee() { number = 3, name = "ayan", salary = 7000, experience = 7 });
        empList.Add(new Employee() { number = 4, name = "pro", salary = 3000, experience = 3 });

        //usig lamda function
        Employee.Promotion(empList, el => el.experience <=3); //instance creation of delegate  // calling static method of Employee class
    }
    
}

delegate bool IsPromotable(Employee empl); //delegate with return type bool added

class Employee
{
    public int number { get; set; }
    public string name { get; set; }
    public int salary { get; set; }
    public int experience { get; set; }

    public static void Promotion(List<Employee> emp, IsPromotable isEligible) //passing delegate as parameter, in runtime it'll be the method delegate pointing to
    {
        foreach (Employee e in emp)
        {
            if (isEligible(e))  //invokes the method, delegate is pointing to which matches the sign of delegate, which is return in program class
                Console.WriteLine(e.name + "Promoted");
        }
    }

}

//*/

/* mod 39 multicast delegates

using System;

public delegate void Sampledelegate(); //delegate with void return type
public delegate int ReturnTypeDelegate(); // delegate with return type
public delegate void OutParamDelegate(out int i); // delegate with out parameter

public class Program
{
    public static void Main()
    {
        //using + and - to create multicast delegate
        Sampledelegate d1, d2, d3, d4, d5;
        d1 = new Sampledelegate(Sample1);
        d2 = new Sampledelegate(Sample2);
        d3 = new Sampledelegate(Sample3);

        d4 = d1 + d2 + d3; //d4 is multicase delegate
        d4();

        d5 = d1 + d2 + d3 - d2; //d4 is multicase delegate
        d5();

        //using += and -= to create a multicast delegate 
        Sampledelegate d = new Sampledelegate(Sample1);
        d += Sample2;
        d += Sample3;
        d();

        d -= Sample3;
        d();

        // multicast delegate created using methods with return types

        ReturnTypeDelegate rd = new ReturnTypeDelegate(Return1);
        rd += Return2;
        int i = rd(); // i will have the value returned from return2 method i.e., 2 . As its invoked at last
        Console.WriteLine("value return from method {0}", i);


        //multicast delegate with out param
        OutParamDelegate od = new OutParamDelegate(Out1);
        od += Out2;
        int j = 0;
        od(out j); //  j will have the value 2, as a result of out2 method as that was invoked at last
        Console.WriteLine("value of out param from methods {0}", j);
    }
    public static void Sample1()
    {
        Console.WriteLine("Sample 1 method invoked");
    }
    public static void Sample2()
    {
        Console.WriteLine("Sample 2 method invoked");
    }
    public static void Sample3()
    {
        Console.WriteLine("Sample 3 method invoked");
    }

    public static int Return1()
    {
        return 1;
    }

    public static int Return2()
    {
        return 2;
    }

    public static void Out1(out int a)
    {
        a = 1;
    }

    public static void Out2(out int b)
    {
        b = 2;
    }
}
//*/
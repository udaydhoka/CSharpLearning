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

/* mod 16 methods
using System;

class Program
{
   public static void Main()
    {
        Program p = new Program();
        p.EvenNumberFunctions();  //Calling Instance metnod
        Program.OddNumberFunctions(); // calling static method
        Program.EvenNumberFunctionWithParam(30); //calling func with param
        int sum = p.add(10, 20); // calling func with return 
        Console.WriteLine(sum);

        //LocalFuntions
        int a = 2, b = 3, c;
        void sumAddition()
        {
            c = a+b;
        }
        sumAddition();
        Console.WriteLine(c);
    }

    //Instance method
    public  void EvenNumberFunctions()
    {
        int start = 0;
        while (start <= 20)
        {
            Console.WriteLine(start);
            start = start + 2;
        }

    }

    //static method
    public static void OddNumberFunctions()
    {
        int start = 1;
        while (start <= 20)
        {
            Console.WriteLine(start);
            start = start + 2;
        }

    }

    // method with param
    public static void EvenNumberFunctionWithParam(int target)
    {
        int start = 0;
        while (start <= target)
        {
            Console.WriteLine(start);
            start = start + 2;
        }

    }

    //returning function
    public int add(int FN,int SN)
    {
        return FN + SN;
    }
        
}
//*/

/* mod 17 parameters
using System;

class Program
{
    //call by value
    public static void Main()
    {
        int i = 0;
        SimpleMethod(i);
        Console.WriteLine(i);
    }

    public static void SimpleMethod(int j)
    {
        j = 101;
    }


    ////pass by reference
    //public static void Main()
    //{
    //    int i = 0;
    //    SimpleMethod(ref i);
    //    Console.WriteLine(i);
    //}

    //public static void SimpleMethod(ref int j)
    //{
    //    j = 101;
    //}


    //// out parameters
    //public static void Main()
    //{
    //    int Total = 0;
    //    int Product = 0;
    //    Calculate(10, 20, out Total, out Product);
    //    Console.WriteLine("sum = {0},product = {1}", Total, Product);

    //}

    //public static void Calculate(int FN, int SN, out int Sum, out int Product)
    //{
    //    Sum = FN + SN;
    //    Product = FN * SN;

    //}


    //// parameter arrays (params)
    //public static void Main()
    //{
    //    int[] Numbers = new int[3];

    //    Numbers[0] = 1;
    //    Numbers[1] = 2;
    //    ParamsMethod();
    //    ParamsMethod(Numbers);
    //    ParamsMethod(1, 2, 3, 4, 5, 6);
    //    WithoutParams(Numbers);
    //    // WithoutParams();  wont work , parameter has to be supplied
    //    // WithoutParams(1, 2, 3); wont accept the arguments

    //}

    //public static void ParamsMethod(params int[] Numbers)
    //{
    //    Console.WriteLine("There are {0} numbers", Numbers.Length);

    //    foreach (int i in Numbers)
    //        Console.WriteLine(i);

    //}
    //public static void WithoutParams(int[] num)
    //{
    //    Console.WriteLine(num.Length);
    //    foreach (int i in num)
    //        Console.WriteLine(i);
    //}
}
//*/

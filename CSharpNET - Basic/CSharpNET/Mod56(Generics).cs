
/* mod 56 Generics

using System;

namespace CSharpNet
{
    class Program
    {
        public static void Main()
        {
            bool res = AreEqual1(10, 20); 
            //res = AreEqual1("a","b"); // only allows int, can overcoem this using method2

            res = AreEqual2(10, 20); //accepts int, but converts to obj(boxing) for comparison, performance issues
            res = AreEqual2("A", "A"); // accepts string
            res = AreEqual2(10, "a"); //accepts different datatype params, not strongly typed

            res = AreEqual3<int>(10, 20); // works on value types without boxing
            //res = AreEqual3<int>(10, "a"); // strongly typed
            res = AreEqual3<string>("uday","uday");

            if (res)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");

            //calling static method from generic class Customer
            Customer<int>.Equals(10, 10);
        }
        //works only for int, cant be used with other datatypes
        public static bool AreEqual1(int a, int b) 
        {
            return a == b;
        }

        //works for all, but does boxing and unboxing(performance issue)
        // also accepts two different datatypes as params(not strongly typed
        public static bool AreEqual2(object a, object b)
        {
            return a == b;
        }

        //generic method
        //strongly typed, doesnt do boxing and unboxing
        public static bool AreEqual3<T>(T a,T b)
        {
            return a.Equals(b);
        }
    }

    //generic class
    class Customer<Y>
    {
        public static void AreEqual(Y a, Y b)
        {
            Console.WriteLine(a.Equals(b));
        }
    }
    
}
//*/
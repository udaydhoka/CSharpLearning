/* mod 100 Func delegate in C#

using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpNET
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee { ID = 101, Name = "Mark"},
                new Employee { ID = 102, Name = "John"},
                new Employee { ID = 103, Name = "Mary"}
            };

            // Create a Func delegate
            Func<Employee, string> func = e => "Name = " + e.Name;
            // Pass the delegate to the Select() LINQ function
            IEnumerable<string> name = employees.Select(func);

            // The above output can be achieved using lambda expression as shown below
            IEnumerable<string> names = employees.Select(e => "Name = " + e.Name);

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }


            //passig morethan one input param to func

            Func<int, int, string> func1 = (fn, sn) => "Sum = " + (fn + sn).ToString();
            string res = func1(10, 20);
            Console.WriteLine(res);
        }
    }
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

    }
}
//*/
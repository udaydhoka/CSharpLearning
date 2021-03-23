/* mod 99 Lamda expression in C#
// also see WindowsFormsApp1-->form3 for demo

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

            //using anonymous method
            //Employee employee = employees.Find(delegate (Employee x) { return x.ID == 102; });

            //Lamda expression
            Employee employee = employees.Find(x => x.ID == 102);
            Console.WriteLine("ID = {0}, Name {1}", employee.ID, employee.Name);

            //Employee employee = employees.Find((Emp x) => x.ID == 102); //speciying the input type

            //Linq examples

            int count = employees.Count(x => x.Name.StartsWith("M"));
            Console.WriteLine("Count = " + count);
        }

            
    }

    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

    }
}
//*/
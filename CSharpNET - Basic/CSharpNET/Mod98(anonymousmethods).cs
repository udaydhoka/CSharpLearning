/* mod 98 Anonymous methods
// also see WindowsFormsApp1-->form3 for demo

using System;
using System.Collections.Generic;

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

            // Step 2: Create an instance of Predicate<Employee>
            // delegate and pass the method name as an argument
            // to the delegate constructor
            Predicate<Employee> predicate = new Predicate<Employee>(FindEmployee);

            // Step 3: Now pass the delegate instance as
            // the argument for Find() method
            Employee e = employees.Find(x=> predicate(x));
            Console.WriteLine(e.ID);

            // Anonymous method is being passed as an argument to
            // the Find() method. This anonymous method replaces
            // the need for Step 1, 2 and 3
            Employee employee = employees.Find(delegate (Employee x){ return x.ID == 102; });
            Console.WriteLine("ID = {0}, Name {1}",employee.ID, employee.Name);
        }

        // Step 1: Create a method whose signature matches
        // with the signature of Predicate<Employee> delegate
        static bool FindEmployee(Employee E)
        {
            return E.ID == 102;
        }
    }

    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

    }
}
//*/
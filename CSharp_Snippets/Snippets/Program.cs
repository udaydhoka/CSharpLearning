using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Snippets.DependencyInjecton;

namespace Snippets
{
    class Program
    {
        static void Main(string[] args)
        {
            ///singleton 

            //Singleton first = Singleton.GetInstance;
            //Singleton second = Singleton.GetInstance;

            ///dependency injection

            //EmployeeBL employeeBL = new EmployeeBL(new EmployeeDAL());
            //List<Employee> employees = employeeBL.GetAllEmployees();
            //foreach (var item in employees)
            //{
            //    Console.WriteLine(item.ID + " " + item.Name + " " + item.Department);
            //}

            OnStrings.ParanthesisCheckOnString();
        }
    }

    
}

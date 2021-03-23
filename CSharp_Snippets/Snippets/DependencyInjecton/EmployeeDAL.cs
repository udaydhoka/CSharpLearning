using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippets.DependencyInjecton
{

    class EmployeeDAL : IEmployeeDAL
    {
        public List<Employee> SelectAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee { ID = 1, Name = "Uday", Department = "IT" });
            employees.Add(new Employee { ID = 2, Name = "Kumar", Department = "HR" });
            employees.Add(new Employee { ID = 3, Name = "Kuruva", Department = "Finance" });

            return employees;
        }
    }
}

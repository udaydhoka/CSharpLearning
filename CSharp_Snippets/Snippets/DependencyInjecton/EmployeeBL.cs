﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippets.DependencyInjecton
{
    class EmployeeBL
    {
        IEmployeeDAL employeeDAL;

        public EmployeeBL(IEmployeeDAL employeeDAL)
        {
            this.employeeDAL = employeeDAL;
        }

        public List<Employee> GetAllEmployees()
        {            
            return employeeDAL.SelectAllEmployees();
        }
    }
}

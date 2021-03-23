using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippets.DependencyInjecton
{
    interface IEmployeeDAL
    {
        List<Employee> SelectAllEmployees();
    }
}

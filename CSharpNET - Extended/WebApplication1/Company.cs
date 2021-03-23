using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Gender { get; set; }
    }

    public class Company
    {
        private List<Employee> ListEmployees;

        public Company()
        {
            ListEmployees = new List<Employee>();
            ListEmployees.Add(new Employee() { EmployeeId = 1, EmployeeName = "Uday", Gender = "Male" });
            ListEmployees.Add(new Employee() { EmployeeId = 2, EmployeeName = "Kumar", Gender = "Male" });
            ListEmployees.Add(new Employee() { EmployeeId = 3, EmployeeName = "Jon", Gender = "Male" });
            ListEmployees.Add(new Employee() { EmployeeId = 4, EmployeeName = "Merry", Gender = "Female" });
        }        

        // Use "this" keyword to create an indexer
        // This indexer takes employeeId as parameter
        // and returns employee name
        public string this[int eId]
        {
            // Just like properties indexers have get and set accessors
            get
            {
                return ListEmployees.FirstOrDefault(x => x.EmployeeId == eId).EmployeeName;
            }
            set
            {
                ListEmployees.FirstOrDefault(x => x.EmployeeId == eId).EmployeeName = value;
            }
        }

        //mod 66

        //// indexers can be overlaoded based on number and type of parameters 
        //// not on return type, so below code wil through error
        //public int this[int eid]
        //{   get { return 1; }
        //    set { }
        //}


        //possible
        //public void this[int id, string sex] { }


        //public string this[string name]
        //{
        //    get
        //    {
        //        return ListEmployees.FirstOrDefault(x => x.EmployeeName == name).Gender;
        //    }
        //    set
        //    {
        //        ListEmployees.FirstOrDefault(x => x.EmployeeName == name).Gender = value;
        //    }
        //}

        public string this[string sex]
        {
            get
            {
                // Returns the total count of employees whose gender matches
                // with the gender that is passed in.
                return ListEmployees.Count(x => x.Gender == sex).ToString();
            }
            set
            {
                // Changes the gender of all employees whose gender matches
                // with the gender that is passed in.
                foreach (var emp in ListEmployees)
                {
                    if (emp.Gender == sex)
                        emp.Gender = value;
                }
            }
        }
    }
}

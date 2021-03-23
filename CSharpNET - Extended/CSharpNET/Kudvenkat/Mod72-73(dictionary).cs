/* mod 72 & 73 Dictionary in C#

using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpNET
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer c1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 20000
            };

            Customer c2 = new Customer()
            {
                ID = 102,
                Name = "Pam",
                Salary = 30000
            };

            Customer c3 = new Customer()
            {
                ID = 103,
                Name = "Mike",
                Salary = 15000
            };

            // Create a Dictionary, CustomerID is the key. Type is int
            // Customer object is the value. Type is Customer
            Dictionary<int, Customer> dictCustomers = new Dictionary<int, Customer>();

            // Add customer objects to the dictionary
            dictCustomers.Add(c1.ID, c1);
            dictCustomers.Add(c2.ID, c2);
            dictCustomers.Add(c3.ID, c3);

            // Retrieve the value (Customer object) from the dictionary,
            // using key (customer ID). The fastest way to get a value
            // from the dictionary is by using its key
            Customer c101 = dictCustomers[101];            
            Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}",c101.ID,c101.Name,c101.Salary);
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------");

            // looping through the key values pairs in dict
            // we could also use implicitly types variable "var" here
            //foreach (var item in dictCustomers)
            foreach (KeyValuePair<int,Customer> item in dictCustomers)
            {
                Console.WriteLine("key = {0}", item.Key);
                Customer cust = item.Value;
                Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);                
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------");

            //looping through the keys in the dictionary
            //foreach (var item in dictCustomers.Keys)
            foreach (int item in dictCustomers.Keys)
            {
                Console.WriteLine(item);                
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------");

            //looping through the values in dict
            //foreach (var item in dictCustomers.Values)
            foreach (var cust in dictCustomers.Values)
            {
                Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);                
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------");

            ////adding duplicate key values, code will compile. But throws runtime error
            ////error:  System.ArgumentException: An item with the same key has already been added.
            //// so, keys in the dict must be unique
            //dictCustomers.Add(c1.ID, c1);

            //checking for duplicate key before adding 
            if (!dictCustomers.ContainsKey(c1.ID))
                dictCustomers.Add(c1.ID, c1);
            
            ////even when we retirve the value for key which is not present we get runtime error
            ////System.Collections.Generic.KeyNotFoundException: The given key was not present in the dictionary.
            //Customer cnew =  dictCustomers[107];

            //checking for key, before retrieving its value
            if (dictCustomers.ContainsKey(107))
            {
                Customer cnew = dictCustomers[107];
            }

            //the above condition could be written using TryGetValue()
            if(dictCustomers.TryGetValue(107, out Customer c ))
            {
                Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);                
            }
            else
            {
                Console.WriteLine("Customer 107 is not found");                
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------");

            //count of items in dict using its property
            Console.WriteLine("Total key/value pairs in dict using countproperty : {0}", dictCustomers.Count);
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------");

            //using count()
            Console.WriteLine("Total key/value pairs in dict using count() : {0}",dictCustomers.Count());
            Console.WriteLine("Total numbers of customer items in dict whose salary is > 15000 is :   " + dictCustomers.Count(x => x.Value.Salary > 15000));
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------");

            // To remove an item from the dictionary, use Remove() method
            dictCustomers.Remove(101);
            //if we specify the key, which is not present in the dict, it wont throw any error
            dictCustomers.Remove(10);
            Console.WriteLine("Count of items in dict after removal:  " + dictCustomers.Count);
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------");

            // To remove all items from the dictionary, use Clear() method
            dictCustomers.Clear();
            Console.WriteLine("Count of items in dict after clearing:  " + dictCustomers.Count);
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------");

            //creating an arry or List of customer obj
            //Customer[] customers = new Customer[] { c1, c2, c3 };
            List<Customer> customers = new List<Customer> { c1, c2, c3 };

            //converting an array or list to dictionary
            //below function works for both list and arrya
            Dictionary<int,Customer>  dict = customers.ToDictionary(cust => cust.ID, cust => cust);

            foreach (var item in dict)
            {
                Console.WriteLine("key = {0}", item.Key);
                Customer cust = item.Value;
                Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------");

            
        }
    }

    class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

    }
}

//*/


/* mod 74 & 74 List in C#

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

            //throws compile time error
            //Customer[] customers = new Customer[2] { c1, c2, c3 };

            Customer[] arrayCustomers = new Customer[2];
            arrayCustomers[0] = c1;
            arrayCustomers[1] = c2;
            // The following line will throw an exception, Index was outside the bounds of the array. 
            // This is because, arrays does not grow in size automatically.
            //customers[2] = c3;  // though array size is 2, its taking values, it wont throw compile error but will give runtime error
            


            // doesn't throw any compile or runtime error
            //List<Customer> customers1 = new List<Customer>(3) { c1, c1 };

            List<Customer> listCustomers = new List<Customer>(2);
            listCustomers.Add(c1);
            listCustomers.Add(c2);
            // Adding an element beyond the initial capacity of the list will not throw an exception.
            listCustomers.Add(c3); //wont give any error, as lists grow in size 

            // Items can be retrieved from the list by index. The following code will 
            // retrieve the first item from the list. List index is ZERO based.
            Customer cust = listCustomers[0];
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}",cust.ID, cust.Name, cust.Salary);
            Console.WriteLine("------------------------------------------------");

            // foreach or for loop can be used to iterate thru all the items in the list
            // Using for loop
            for (int i = 0;i<listCustomers.Count; i++)
            {
                Customer c = listCustomers[i];
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
            }
            Console.WriteLine("------------------------------------------------");

            // Using foreach loop
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
            }
            Console.WriteLine("------------------------------------------------");

            //// All generic collection classes including List are strongly typed. This means 
            //// if you have created a List of type Customer, only objects of type Customer 
            //// can be added to the list. If you try to add an object of different type you would 
            //// get a compiler error. The following line will raise a compiler error.
            //listCustomers.Add("This will not compile");

            //adding childclass obj into baseclass lists
            ImpCustomer IC = new ImpCustomer();
            listCustomers.Add(IC);

            // If you want to insert an item at a specific index location of the list, use Insert() method. 
            // The following line will insert customer3 object at index location 0.
            listCustomers.Insert(0, c3);
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
            }
            Console.WriteLine("------------------------------------------------");

            // To get the index of specific item in the list use Indexof() method
            Console.WriteLine("Index of Customer3 object in the List = " + listCustomers.IndexOf(c3));
            Console.WriteLine("------------------------------------------------");

            //overloaded methods of indexof
            Console.WriteLine("Index of Customer3 object in the List = " + listCustomers.IndexOf(c3,1));
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("Index of Customer3 object in the List = " + listCustomers.IndexOf(c3,1,3));            
            Console.WriteLine("------------------------------------------------");

            //throws error
            //Console.WriteLine("Index of Customer3 object in the List = " + listCustomers.IndexOf(c3, 1, 8));

            // To check if an item exists in the list use Contains() function
            // This method returns true if the items exists, else false
            //Console.WriteLine(listCustomers.Contains(c2));
            if (listCustomers.Contains(c2))
            {
                Console.WriteLine("Customer2 object exists in the list");
            }
            else
            {
                Console.WriteLine("Customer2 object does not exist in the list");
            }
            Console.WriteLine("------------------------------------------------------");


            // To check if an item exists in the list based on a condition, then use Exists() function
            // This method returns true if the items exists, else false
            //Console.WriteLine(listCustomers.Exists(x => x.ID == 101));
            if (listCustomers.Exists(x => x.Name.StartsWith("M")))
            {
                Console.WriteLine("List contains customer whose name starts with M");
            }
            else
            {
                Console.WriteLine("List does not contain a customer whose name starts with M");
            }
            Console.WriteLine("------------------------------------------------------");


            // Find() method searches for an element that matches the conditions defined by 
            // the specified lambda expression and returns the first matching item from the list
            Customer cfind =  listCustomers.Find(x => x.Salary > 15000);
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cfind.ID, cfind.Name, cfind.Salary);
            Console.WriteLine("------------------------------------------------------");

            // FindLast() method searches for an element that matches the conditions defined
            // by the specified lambda expression and returns the Last matching item from the list
            Customer cfindlast = listCustomers.FindLast(x => x.Salary > 15000);
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cfindlast.ID, cfindlast.Name, cfindlast.Salary);
            Console.WriteLine("------------------------------------------------------");

            // FindAll() method returns all the items from the list that
            // match the conditions specified by the lambda expression
            List<Customer> cfindall = listCustomers.FindAll(x => x.Salary > 15000);
            foreach(Customer c in cfindall)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
            }
            Console.WriteLine("------------------------------------------------------");

            // FindIndex() method returns the index of the first item, that matches the 
            // condition specified by the lambda expression. There are 2 other overloads
            // of this method which allows us to specify the range of elements to 
            // search, with in the list.
            Console.WriteLine("Index of the first matching customer object whose salary is greater 5000 =" +
                listCustomers.FindIndex(customer => customer.ID == 103));
            //Console.WriteLine(listCustomers.FindIndex(x => x.Salary > 15000));
            //Console.WriteLine(listCustomers.FindIndex(1, x => x.Salary > 15000));
            //Console.WriteLine(listCustomers.FindIndex(1, 1, x => x.Salary > 15000));
            Console.WriteLine("------------------------------------------------------");

            
            

            // FindLastIndex() method returns the index of the last item, 
            // that matches the condition specified by the lambda expression. 
            // There are 2 other overloads of this method which allows us to specify 
            // the range of elements to search, with in the list.
            Console.WriteLine("Index of the Last matching customer object whose salary is greater 5000 = " +
                listCustomers.FindLastIndex(customer => customer.ID == 103));
            Console.WriteLine("------------------------------------------------------");

            // To convert an array to a List, use ToList() method
            Customer[] arrayCust = new Customer[] { c1, c2, c3 };
            List<Customer> arrayToList =  arrayCust.ToList();
            foreach(var c in arrayToList)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
            }
            Console.WriteLine("------------------------------------------------------");

            // To convert a List to an array, use ToLArray() method
            Customer[] listToArray =  listCustomers.ToArray();
            foreach(var c in listToArray)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
            }
            Console.WriteLine("------------------------------------------------------");

            // To convert a List to a Dictionary use ToDictionary() method
            //Dictionary<int,Customer> listToDictionary =  listCustomers.ToDictionary(x => x.ID, x => x);
            Dictionary<int, Customer> dictionaryCustomers = listCustomers.ToDictionary(x => x.ID); // here value field is optional as we are convetig list, its values will be value for dict


            //Remove() function
            // Remove() function removes only the first matching item from the list.
            listCustomers.Remove(c3);
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
            }
            Console.WriteLine("------------------------------------------------");

            //RemoveAt()
            // RemoveAt() function, removes the item at the specified index in the list.
            listCustomers.RemoveAt(2);
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
            }
            Console.WriteLine("------------------------------------------------");

            //remvoeall() 
            // RemoveAll() function removes all the items that matches the specified condition.
            listCustomers.RemoveAll(x => x.Salary > 15000);
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
            }
            Console.WriteLine("------------------------------------------------");

            //clear()
            // If you want to remove all the elements from the list without specifying 
            // any condition, then use Clear() function.
            listCustomers.Clear();

            Console.WriteLine(" Total Items in the List = " + listCustomers.Count);

        }
    }
    

    class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }

    class ImpCustomer : Customer
    { }
}

//*/

/* mod 76 List class and Ranges

using System;
using System.Collections.Generic;

namespace CSharpNET
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 4000,
                Type = "RetailCustomer"
            };

            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "Pam",
                Salary = 7000,
                Type = "RetailCustomer"
            };

            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "Rob",
                Salary = 5500,
                Type = "RetailCustomer"
            };

            Customer customer4 = new Customer()
            {
                ID = 104,
                Name = "John",
                Salary = 6500,
                Type = "CorporateCustomer"
            };

            Customer customer5 = new Customer()
            {
                ID = 105,
                Name = "Sam",
                Salary = 3500,
                Type = "CorporateCustomer"
            };


            List<Customer> listCustomers = new List<Customer>();
            // Add() method allows you to add one at a time to the end of the list
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            List<Customer> listCorporateCustomers = new List<Customer>();
            listCorporateCustomers.Add(customer4);
            listCorporateCustomers.Add(customer5);

            // AddRange() allows you to add another list of items, to the end of the list
            listCustomers.AddRange(listCorporateCustomers);

            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}",
                    customer.ID, customer.Name, customer.Salary, customer.Type);
            }
            Console.WriteLine("------------------------------------------------------");


            // GetRange() function returns a list of items from the list.
            List<Customer> corporateCustomers = listCustomers.GetRange(3, 2);
            foreach (Customer customer in corporateCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}",
                    customer.ID, customer.Name, customer.Salary, customer.Type);
            }
            Console.WriteLine("------------------------------------------------------");


            // RemoveRange() method removes a range of elements from the list. 
            // This function expects 2 parameters, i.e the start index in the 
            // list and the number of elements to remove.
            listCustomers.RemoveRange(0, 2);
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}",
                    customer.ID, customer.Name, customer.Salary, customer.Type);
            }
            Console.WriteLine("------------------------------------------------------");


            // InsertRange() allows you, to insert another list of items to your list at the specified index
            listCustomers.InsertRange(0, listCorporateCustomers);

            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}",
                    customer.ID, customer.Name, customer.Salary, customer.Type);
            }
            Console.WriteLine("------------------------------------------------------");
        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Type { get; set; }
    }
}

//*/

/* mod 77 Sorting a list of Simple Types

using System;
using System.Collections.Generic;

namespace CSharpNET
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 9, 5, 3, 8, 2, 6, 7 };
            Console.WriteLine("Numbers before sorting");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            numbers.Sort();
            Console.WriteLine("Numbers after sorting");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            numbers.Reverse();
            Console.WriteLine("Numbers after reversing");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            List<string> alphbet = new List<string>() { "a", "e", "g", "z", "b" };
            Console.WriteLine("Alphabet before sorting");
            foreach (var item in alphbet)
            {
                Console.WriteLine(item);
            }

            alphbet.Sort();
            Console.WriteLine("Alphabet after sorting");
            foreach (var item in alphbet)
            {
                Console.WriteLine(item);
            }

            alphbet.Reverse();
            Console.WriteLine("Alphabet before reversing");
            foreach (var item in alphbet)
            {
                Console.WriteLine(item);
            }
        }
    }

}

//*/

/* mod 78 sorting a list of Complex Types

using System;
using System.Collections.Generic;

namespace CSharpNET
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 4000
            };

            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "John",
                Salary = 7000
            };

            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "Ken",
                Salary = 5500
            };

            List<Customer> listCutomers = new List<Customer>();
            listCutomers.Add(customer1);
            listCutomers.Add(customer2);
            listCutomers.Add(customer3);

            Console.WriteLine("Customers before sorting");
            foreach (Customer customer in listCutomers)
            {
                Console.WriteLine(customer.Name + " - " + customer.Salary);
            }
            Console.WriteLine("--------------------------------------");

            // Sort() method should sort customers by salary
            listCutomers.Sort();
            
            Console.WriteLine("Customers after sorting by salary");
            foreach (Customer customer in listCutomers)
            {
                Console.WriteLine(customer.Name + " - " + customer.Salary);
            }
            Console.WriteLine("--------------------------------------");

            // To sort customers by name instead of salary
            SortByName sortByName = new SortByName();

            listCutomers.Sort(sortByName);

            Console.WriteLine("Customers after sorting by name");
            foreach (Customer customer in listCutomers)
            {
                Console.WriteLine(customer.Name + " - " + customer.Salary);
            }
        }

    }

    class Customer : IComparable<Customer>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public int CompareTo(Customer other)
        {
            //using salary to sort

            //if (this.Salary > other.Salary)
            //    return 1;
            //else if (this.Salary < other.Salary)
            //    return -1;
            //else
            //    return 0;


            // OR, Alternatively you can also invoke CompareTo() method. 
            return this.Salary.CompareTo(other.Salary);

            //using name to sort
            //return this.Name.CompareTo(other.Name);
        }
    }

    //creating a additional class to implement sort by using icomparer interface over icomparable 

    class SortByName : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }

}

//*/

/* mod 79 sorting a list of Complex types using a comparsion delegate

using System;
using System.Collections.Generic;

namespace CSharpNET
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 4000
            };

            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "John",
                Salary = 7000
            };

            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "Ken",
                Salary = 5500
            };

            List<Customer> listCutomers = new List<Customer>();
            listCutomers.Add(customer1);            
            listCutomers.Add(customer3);
            listCutomers.Add(customer2);

            Console.WriteLine("Customers before sorting");
            foreach (Customer customer in listCutomers)
            {
                Console.WriteLine(customer.ID + " - " + customer.Name);
            }
            Console.WriteLine("--------------------------------------");

            //// Approach 1
            //// Step 2: Create an instance of Comparison delegate
            //Comparison<Customer> cComp = new Comparison<Customer>(CustComparer);

            //// Step 3: Pass the delegate instance to the Sort method
            //listCutomers.Sort(cComp);

            //// Approach 2: Using delegate keyword
            //listCutomers.Sort(delegate (Customer x, Customer y) { return x.ID.CompareTo(y.ID)});

            // Aaproach 3: Using lambda expression
            listCutomers.Sort((x, y) => x.ID.CompareTo(y.ID));

            Console.WriteLine("Customers after sorting");
            foreach (Customer customer in listCutomers)
            {
                Console.WriteLine(customer.ID + " - " + customer.Name);
            }
        }

        // Approach 1 - Step 1
        // Method that contains the logic to compare customers
        private static int CustComparer(Customer x, Customer y)
        {
            return x.ID.CompareTo(y.ID);
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

/* mod 80 Useful Functions of List

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CSharpNET
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 4000
            };

            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "John",
                Salary = 7000
            };

            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "Ken",
                Salary = 5500
            };

            List<Customer> listCutomers = new List<Customer>();
            listCutomers.Add(customer1);
            listCutomers.Add(customer2);
            listCutomers.Add(customer3);


            Console.WriteLine("Customers List");
            foreach (Customer customer in listCutomers)
            {
                Console.WriteLine(customer.Name + " - " + customer.Salary);
            }
            Console.WriteLine("--------------------------------------");


            //TrueForAll()
            Console.WriteLine("Are all salaries > 5000 = " + listCutomers.TrueForAll(x => x.Salary > 5000));           

            Console.WriteLine("Are all salaries > 3000 = " + listCutomers.TrueForAll(x => x.Salary > 3000));
            Console.WriteLine("--------------------------------------");

            // ReadOnlyCollection will not have Add() or Remove() methods
            ReadOnlyCollection<Customer> readOnlyList = listCutomers.AsReadOnly();
            //readOnlyList.Add(); doesnt have add,insert, remove methods
            Console.WriteLine("Count of Elements in List is " + readOnlyList.Count);
            Console.WriteLine("--------------------------------------");

            // listCutomers list is created with an initial capacity of 100
            // but only 3 items are in the list. The filled percentage is 
            // less than 90 percent threshold.
            List<Customer> newList = new List<Customer>(100) { customer1, customer2, customer3 };
            Console.WriteLine("Capacity before trimming is " + newList.Capacity);
            // Invoke TrimExcess() to set the capacity to the actual number of elements in the List
            newList.TrimExcess();
            Console.WriteLine("Capacity after trimming is " + newList.Capacity);
            Console.WriteLine("--------------------------------------");
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
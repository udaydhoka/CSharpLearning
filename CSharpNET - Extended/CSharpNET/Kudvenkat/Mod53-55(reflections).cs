/* mod 53 Reflections

using System;
using System.Reflection;

namespace CSharpNet
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer()
        {
            this.Id = -1;
            this.Name = string.Empty;
        }
        public Customer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public void PrintID()
        {
            Console.WriteLine("Id: {0}",this.Id); ;
        }
        public void PrintName()
        {
            Console.WriteLine("Name = {0}",this.Name);
        }
    }

    class Program
    {
        public static void Main()
        {
            Type T = Type.GetType("CSharpNet.Customer"); // or
            
            //Type t = typeof(Customer);  // or
            //Customer c = new Customer(); 
            //Type t = c.GetType();

            Console.WriteLine(T.FullName);
            Console.WriteLine(T.Name);
            Console.WriteLine(T.Namespace);
            Console.WriteLine(T.IsAbstract);
            Console.WriteLine();
            Console.WriteLine("Properties in Customer Class");
            PropertyInfo[] properties = T.GetProperties();
            foreach (var property in properties)
                Console.WriteLine(property.PropertyType.Name + " " + property.Name);
            Console.WriteLine();            
            Console.WriteLine("Constructors in Customer class");
            ConstructorInfo[] constructors = T.GetConstructors();
            foreach (var constructor in constructors)
                Console.WriteLine(constructor.ToString());
            Console.WriteLine();
            Console.WriteLine("Methods in Customer class");
            MethodInfo[] methods = T.GetMethods();
            foreach (var method in methods)
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);
            Console.WriteLine();

        }        
        
    }
}

//*/

/* mod 54 Reflections example using winforms app
 * 
 * Look at winformsapp1 project for this demo
 * Code in mod 53 is implemented using winforms app
 * 
 */

/* mod 55 Late Binding using Reflections

using System;
using System.Reflection;

namespace CSharpNet
{
   

    class Program
    {
        public static void Main()
        {
            //// early Binding
            //Customer c1 = new Customer();
            //string fullName = c1.GetFullName("uday", "kumar");
            //Console.WriteLine(fullName);

            //late binding

            // Load the current executing assembly as the Customer class is present in it.
            Assembly executingAsembly = Assembly.GetExecutingAssembly();

            // Load the Customer class for which we want to create an instance dynamically
            Type classType = executingAsembly.GetType("CSharpNet.Customer");

            // Create the instance of the customer type using Activator class 
            object classObj = Activator.CreateInstance(classType);

            // Get the method information using the customerType and GetMethod()
            MethodInfo classMethod = classType.GetMethod("GetFullName");

            // Create the parameter array and populate first and last names
            string[] parameters = new string[2] { "uday", "kumar" };

            // Invoke the method passing in customerInstance and parameters array
            string s = (string)classMethod.Invoke(classObj, parameters);

            Console.WriteLine(s);
          
        }
    }

    class Customer
    {

        public string GetFullName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }
    }


}

//*/
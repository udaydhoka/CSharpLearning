/*mod 57 Overriding ToString() method

using System;

namespace CSharpNET
{
    class Program
    {
        public static void Main()
        {
            int a = 10;
            string s = a.ToString();
            Console.WriteLine(s + "\t" + s.GetType());

            Program p = new Program();
            Console.WriteLine(p.ToString()); // prints namespce.classname if ToString() isn't overridden
        }

        //overriding ToString() method of System.Object
        public override string ToString()
        {
            return "Executing new overridden ToString() method";
        }
    }


}

//*/

/* mod 58 Overriding Equals() method

using System;

namespace CSharpNET
{
    public enum Gender
    {
        Unknown,
        Male,
        Female
    }
    class Program
    {
        public static void Main()
        {
            int i = 20, j = 20;
            Console.WriteLine("Comparing ints");
            Console.WriteLine(i==j);
            Console.WriteLine(i.Equals(j));
            Console.WriteLine();

            Gender g1 = Gender.Female;
            Gender g2 = Gender.Male;
            Console.WriteLine("Comparing Enums");
            Console.WriteLine(g1==g2);
            Console.WriteLine(g1.Equals(g2));
            Console.WriteLine();


            Customer c1 = new Customer() { firstName = "uday", lastName = "kumar" };
            Customer c2 = c1;
            Console.WriteLine("Comparing one obj of class referred by two vars");
            Console.WriteLine(c1==c2);  //it'll be true
            Console.WriteLine(c1.Equals(c2)); //it'lbe ture
            Console.WriteLine();

            Customer c3 = new Customer() { firstName = "uday", lastName = "kumar" };           
            Console.WriteLine("Comparing two obj(same data) of same class referred by two vars");
            Console.WriteLine(c3 == c1); //it'll be false 
            Console.WriteLine(c3.Equals(c1));  //it'd true, but will give as false, when overrided it'll be true
            Console.WriteLine();

        }
    }

    public class Customer
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        //overriding Equals()
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is Customer))
                return false;
            return (this.firstName == ((Customer)obj).firstName) && (this.lastName == ((Customer)obj).lastName);
        }
        public override int GetHashCode()
        {
            return this.firstName.GetHashCode() ^ this.lastName.GetHashCode();
        }
    }
}

//*/

/* mod 59 Difference between Convert.ToString() & ToString()

using System;

namespace CSharpNET
{
    class Program
    {
        public static void Main()
        {
            string s = null;
            //Console.WriteLine(s.ToString()); // throws nulll ref exception
            Console.WriteLine(Convert.ToString(s)); //gives empty string

            Customer c = new Customer();
            Console.WriteLine(c.ToString()); //both the methods prints NS.className
            Console.WriteLine(Convert.ToString(c));

            Customer c1 = null;
            Console.WriteLine(c1.ToString()); // throws null ref exception
            Console.WriteLine(Convert.ToString(c1)); // prints empry string

        }
    }

    class Customer
    {
        public int MyProperty { get; set; }
    }
    
}

//*/

/* mod 60 Difference between System.String and System.Text.StringBuilder

using System;
using System.Text;

namespace CSharpNET
{
    class Program
    {
        public static void Main()
        {
            string s = "C#"; // creates a new obj
            s += "Tutorial"; //creates a new obj, and leaves the previous one orphaned
            s += "for beginners"; //creates a new obj, and leaves the previous one orphaned
            Console.WriteLine(s);

            StringBuilder userString = new StringBuilder("C#");
            userString.Append("Tutorial"); // doesn't create new obj
            userString.Append("for beginners"); // doesn't create new obj
            Console.WriteLine(userString.ToString());


        }
    }
}

//*/
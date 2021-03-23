/* mod 26 need for properties 

// demonstrating need for properties

using System;

public class Student
{
    public int ID; //  this shouldn't be negative 
    public string Name; // name shouldn't be null
    public int PassMark = 35; // this should be readonly

}

public class program
{
    public static void Main()
    {
        Student C1 = new Student();

        // we can easily violate the business condition and assign the values , as the fields are public
        C1.ID = -101; // assigning negative value
        C1.Name = null; // assigning null
        C1.PassMark = 0; // changing read only member value
        Console.WriteLine("Id = {0} , Name = {1} , PassMark = {2}", C1.ID, C1.Name, C1.PassMark);
    }
}

//using System;

//public class Student
//{
//    private int _id; //  this shouldn't be negative 
//    private string _name; // name shouldn't be null
//    private int _passMark = 35; // this should be readonly

//    //method to set id value with conditions
//    public void SetId(int Id)
//    {
//        if (Id <= 0) // checking for business condition
//        {
//            throw new Exception("Student Id can't be Negative");
//        }
//        this._id = Id; // else part
//    }
//    //method to read the id value
//    public int GetId()
//    {
//        return this._id;
//    }

//    //method to set anme 
//    public void SetName(string Name)
//    {
//        //we cant use assignmet operations in ternary expression
//        if (string.IsNullOrEmpty(Name))
//            throw new Exception("Name Can't be Null");
//        this._name = Name;
//    }

//    //method to retrice name 
//    public string GetName()
//    {

//        //if( string.IsNullOrEmpty(this._name))
//        //      return "No Name"; 
//        //else
//        //     return this._name;
//        //using ternary operator
//        return string.IsNullOrEmpty(this._name) ? "No Name" : this._name;

//    }
//    //making passmark field as readonly by defining only getmethod
//    public int GetPassMark()
//    {
//        return this._passMark;
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        Student C1 = new Student();

//        // we can't violate the business condition, cause we've a check at setter method
//        //C1.SetId(-101); // assigning negative value will throw an exception
//        C1.SetId(101);
//        Console.WriteLine("Id : {0}", C1.GetId()); // using get method to retrive value
//        //C1.SetName(null); // assigning null will throw exception
//        C1.SetName("uday"); //if not assigned ,getname will give default value
//        Console.WriteLine("Nmae : {0}", C1.GetName()); // to retrive name using get method
//        // since we dont have setter method for passmark we can only read it . Making it readonly param
//        Console.WriteLine("PassMark = {0}", C1.GetPassMark());
//    }
//}
//*/

/* mod 27 properties in C#

using System;

public class Student
{
    private int _id; //  this shouldn't be negative 
    private string _name; // name shouldn't be null
    private int _passMark = 35; // this should be readonly

    //using get and set accessor for id field
    // it'd be of type int , since it has a get accessor which returns int
    public int Id // property name can be same or different from defined in fields section
    {
        set
        {
            if (value <= 0) // value keyword will have the data password into the method
            {
                throw new Exception("Student Id can't be Negative");
            }
            this._id = value;
        }
        get
        {
            return this._id;
        }
    }
    
    //using get & set accessor
    public string Name // it'd be of type string , since it has a get accessor which returns string
    {
        set
        {
            if (string.IsNullOrEmpty(value)) // value keyword will have the data password into the method
                throw new Exception("Name Can't be Null");
            this._name = value;
        }
        get
        {
            return string.IsNullOrEmpty(this._name) ? "No Name" : this._name;
        }
    }
          
    //making passmark field as readonly by using only get accessor
    public int PassMark
    {
        get
        {
            return this._passMark;
        }
    }

     //private string _city;
    //public string City
    //{
    //    get
    //    {
    //        return this._city;
    //    }
    //    set
    //    {
    //        this._city = value;
    //    }
    //}

    //Instead we can use auto-implemented properties of C#
    // less code and easy to manage
    public string City { get; set; }
}

public class Program
{
    public static void Main()
    {
        Student C1 = new Student();
                
        C1.Id = 101;
        Console.WriteLine("Id : {0}", C1.Id); 
        
        C1.Name ="uday"; 
        Console.WriteLine("Nmae : {0}", C1.Name);

        //C1.PassMark = 34; // we cant assign the value , as its only a read only
        Console.WriteLine("PassMark = {0}", C1.PassMark); // we can read it without any error
    }
}
//*/
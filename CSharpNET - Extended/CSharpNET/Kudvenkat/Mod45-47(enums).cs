/* mod 45 Why Enums
using System;

namespace CSharpNET
{
    class WhyEnums
    {
        public static void Main()
        {
            Customer[] customers = new Customer[3];
            customers[0] = new Customer()
            {
                Name = "mark",
                Gender = 1  // here we dont know what is male or female unless we look at the doc
            };

            customers[1] = new Customer()
            {
                Name = "mike",
                Gender = 0
            };

            customers[2] = new Customer()
            {
                Name = "mary",
                Gender = 2
            };

            foreach (Customer c in customers)
            {
                Console.WriteLine("Name = {0} and Gender = {1}", c.Name, GetGender(c.Gender)); //here we cant use gender directly as its number
            }
        }

        public static string GetGender(int gender)
        {
            switch (gender)
            {
                case 0:
                    return "unknown";
                case 1:
                    return "Male";
                case 2:
                    return "female";
                default:
                    return "invalid data";
            }
        }
    }
}

// 0 - unknown 
// 1 - male
// 2 - female
class Customer
{
    public String Name { get; set; }
    public int Gender { get; set; }  //defining gender as int, for compatibility with some func
}

//*/

/* mod 46 Enums Example
using System;

namespace CSharpNET
{
    //creating enum
    public enum Gender
    {
        Unknown,
        Male,
        Female
    }

    // 0 - unknown
    // 1 - male
    // 2 - female
    class Customer
    {
        public String Name { get; set; }
        public Gender Gender { get; set; } //creating prop of type enum
    }
    class WhyEnums
    {
        public static void Main()
        {
            Customer[] customers = new Customer[3];
            customers[0] = new Customer()
            {
                Name = "mark",
                Gender = Gender.Male
            };

            customers[1] = new Customer()
            {
                Name = "mike",
                Gender = Gender.Unknown
            };

            customers[2] = new Customer()
            {
                Name = "mary",
                Gender = Gender.Female
            };

            foreach (Customer c in customers)
            {
                Console.WriteLine("Name = {0} and Gender = {1}", c.Name, GetGender(c.Gender));
            }
        }

        public static string GetGender(Gender gender) //parameter of type Gender(enum)
        {
            switch (gender)
            {
                case Gender.Unknown:
                    return "unknown";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "female";
                default:
                    return "invalid data";
            }
        }
    }

}

//*/

/* mod 47 Enums

using System;

namespace CSharpNET
{

    //public enum Gender //uses default underlying type ie., int
    //{
    //    Unknown,
    //    Male,
    //    Female
    //}

    //public enum Gender  : short //changing underlying type to short
    //{
    //    Unknown,
    //    Male,
    //    Female 
    //}

    //assigning different values to members of enum
    public enum Gender : short //changing type to short
    {
        Unknown = 1, //we can also values for member
        Male, // now its number will be automatically 2 
        Female = 10 // we can also specify the different number for different members
    }

    public enum Season
    {
        winter = 1,
        spring,
        summer = 10
    }

    class Enums
    {
        public static void Main()
        {
            //int [] values = (int[])Enum.GetValues(typeof(Gender)); //gender is name of enum, to get the type we are using typeof as it expects enumtype as param
            //foreach(int value in values)
            //{
            //    Console.WriteLine(value);
            //}

            short[] values = (short[])Enum.GetValues(typeof(Gender)); //gender is name of enum, to get the type we are using typeof as it expects enumtype as param
            foreach (short value in values)
            {
                Console.WriteLine(value);
            }

            string[] names = Enum.GetNames(typeof(Gender));

            foreach (string n in names)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine(typeof(Gender));

            //Gender gender = 3; //throws error as enums are strongly typed
            Gender gender = (Gender)3;

            //int n = Gender.Female; //throws compile error
            int num = (int)Gender.Female;
            Console.WriteLine(num);

            //Gender gender1 = Season.spring; //though they've same underlying types we cant do it 
            Gender gnder = (Gender)Season.spring;
        }
    }

}

//*/

/* extension

using System;

namespace CSharpNET
{
    public enum Colour
    {
        Violet,
        Indigo,
        Blue,
        Green,
        Yellow,
        Orange,
        Red
    }

    class Rainbow
    {
        public Colour colour { get; set; }

        public int WaveLength { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rainbow[] rainbow = new Rainbow[4];
        }
    }
}
*/
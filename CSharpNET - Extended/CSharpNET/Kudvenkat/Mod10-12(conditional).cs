/* mod 10 if, if..else, if..elseif..else 



//*/

/* mod 11 switch & break

using System;

class Program
{
   public static void Main()
    {

        Console.Write("Enter Number: ");
        int i = int.Parse(Console.ReadLine()); //we'd also use console.read method which reads only int values        
        switch (i)
        {
            case 10:
            case 20:
            case 30:
                Console.WriteLine("Your Number is {0}", i);
                break;
            default:
                Console.WriteLine("Invalid Number");
                break;
        }
    }
}
//*/

/* mod 12 switch , break & goto

using System;

class Program
{
   public static void Main()
    {

            int totalcoffeecost = 0;
            start:
            Console.WriteLine("Please select your coffee choice:");
            Console.WriteLine("1-small, 2-medium, 3-large");
            int userchoice = int.Parse(Console.ReadLine());
            switch (userchoice)
            {
                case 1:
                    totalcoffeecost += 1;
                    break;
                case 2:
                    totalcoffeecost += 2;
                    break;
                case 3:
                    totalcoffeecost += 3;
                    break;
                default:
                    Console.WriteLine("Invalid choice \'{0}\'", userchoice);
                    goto start;
            }

            decide:

            Console.WriteLine("Do you want to buy another coffee - yes or no");
            string userdecision = Console.ReadLine();

            switch(userdecision.ToLower())
            {
                case "yes":
                    goto start;
                case "no":
                    break;
                default:
                    Console.WriteLine("Invalid Choice \"{0}\".Please try again..",userdecision);
                    goto decide;
            }
            Console.WriteLine("Thanks for shopping");
            Console.WriteLine("Bill Amount = {0}", totalcoffeecost);
        }
    }
//*/
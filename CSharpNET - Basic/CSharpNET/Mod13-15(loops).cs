
/*mod 13 while loop

using System;

class Program
{
   public static void Main()
    {

        Console.WriteLine("please enter the target:");
        int input = int.Parse(Console.ReadLine());
        int start = 0;
        while (start<= input)
        {
            Console.Write(start + " ");
            start = start + 2;
        }
    }
}
//*/

/* mod 14 do-while

using System;

class Program
{
   public static void Main()
    {

        // string userchoice = "";
        string userchoice = string.Empty;
        do
        {
            Console.WriteLine("please enter the target:");
            int input = int.Parse(Console.ReadLine());
            int start = 0;
            while (start <= input)
            {
                Console.Write(start + " ");
                start = start + 2;
            }

            do
            {
                Console.WriteLine("Do you want to continue - yes or no ?");

                userchoice = Console.ReadLine().ToLower();

                if (userchoice != "yes" && userchoice != "no")
                {
                    Console.WriteLine("Invalid Choice, please say yer or no");
                }
            } while (userchoice != "yes" && userchoice != "no");

        } while (userchoice == "yes");

         //start:
            //    Console.WriteLine("Enter the Targer Number: ");
            //    int num, start = 0;
            //    if (int.TryParse(Console.ReadLine(), out num))
            //    {
            //        while (start <= num)
            //        {
            //            Console.Write(start + " ");
            //            start++;
            //        }
            //        Console.WriteLine("Do you wish to continue: yes or no");
            //        string s = Console.ReadLine();
            //        if (s.ToLower() == "yes")
            //            goto start;
            //        else
            //            Console.WriteLine("GoodBye!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid string enntered");
            //        Console.WriteLine("Do you wish to continue: yes or no");
            //        string s = Console.ReadLine();
            //        if (s.ToLower() == "yes")
            //            goto start;
            //        else
            //            Console.WriteLine("GoodBye!");

            //    }
    }
}
//*/

/* implementing switch goto example with do while

using System;

class Program
{
   public static void Main()
    {

        int totalcoffeecost = 0;
        string userdecision = string.Empty;

        do
        {
            int userchoice = 0;
            do
            {
                Console.WriteLine("Please select your coffee choice:");
                Console.WriteLine("1-small, 2-medium, 3-large");
                string s = Console.ReadLine();
                bool b = int.TryParse(s, out userchoice);
                if (b)
                {
                    if (userchoice != 1 && userchoice != 2 && userchoice != 3)
                    {
                        Console.WriteLine("Invalid choice \'{0}\'", userchoice);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice \'{0}\'", s);
                }
                    if (userchoice == 1)
                    {
                        totalcoffeecost += 1;
                    }
                    else if (userchoice == 2)
                    {
                        totalcoffeecost += 2;
                    }
                    else if (userchoice == 3)
                    {
                        totalcoffeecost += 3;
                    }
                } while (userchoice != 1 && userchoice != 2 && userchoice != 3);


            do
            {
                Console.WriteLine("Do you want to buy another coffee - yes or no");
                userdecision = Console.ReadLine().ToLower();
                if (userdecision != "yes" && userdecision != "no")
                {
                    Console.WriteLine("Invalid Choice \"{0}\".Please try again..", userdecision);
                }
            } while (userdecision != "yes" && userdecision != "no");

            }while (userdecision == "yes");

            Console.WriteLine("Thanks for shopping");
            Console.WriteLine("Bill Amount = {0}", totalcoffeecost);

        }
   }
//*/

/* mod 15 for and foreach

using System;

class Program
{
   public static void Main()
    {

            int[] num = new int[3];
            num[0] = 0;
            num[1] = 1;
            num[2] = 2;
            int i = 0;
            while (i < num.Length)
            {
                Console.WriteLine("output from while loop");
                Console.WriteLine(num[i]);
                i++;
            }

            for (int j = 0; j < num.Length; j++)
            {
                Console.WriteLine("output from for loop");
                Console.WriteLine(num[j]);
            }

            foreach (int k in num)
            {
                Console.WriteLine("output from foreach loop");
                Console.WriteLine(k);
            }

            // using break in for loop
            for (int a=0;a<=20;a++)
            {
                Console.Write(a);

                if (a == 10)
                    break;

            }

            //using continue 

            for (int b = 0; b <= 20; b++)
            {
                if (b % 2 == 1)
                    continue;
                Console.WriteLine(b);           
            }
        }
    }
//*/

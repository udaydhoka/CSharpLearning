/* mod 40 Exception Handling 

using System;
using System.IO; // for using streamreader 

class ExceptionHandling
{
    public static void Main()
    {
        StreamReader streamReader = null; // defined here instead of try block, else finally block wont recognise the variable
        try
        {
            streamReader = new StreamReader(@"C:\Mine\Dev\CSharp\data.txt"); //if theres exception here, the below lines never executes
            Console.WriteLine(streamReader.ReadToEnd());
            //streamReader.Close(); //add it to finally block, if exception occurs it still runs and releases the resources
        }
        catch(FileNotFoundException e) //specific exception, has additional prop
        {
            //we've to write this details into our logs
            //Console.WriteLine(e.Message);
            //Console.WriteLine(e.StackTrace);

            //then display the generic info to the users
            Console.WriteLine("Please check if the file {0} exists", e.FileName); //filename is specfic to this exception
        }
        catch(Exception ex) //this(general exception) has to be at last, else it'll throw compiler error
        {
            //we've to write this details into our logs            
            //Console.WriteLine(ex.StackTrace);

            //then display the generic info to the users
            Console.WriteLine(ex.Message);
        }
        finally
        {
            if(streamReader != null) //if obj is not created due to error, it'll throw error hence the condition
                streamReader.Close();
            Console.WriteLine("Executed finally block");
           
        }


    }

}
//*/

/* mod 41 Inner Exception
using System;
using System.IO;

class InnerException
{
    public static void Main()
    {
        try
        {
            
            try
            {
                Console.WriteLine("Enter first Number");
                int Fn = Convert.ToInt32(Console.ReadLine());
                //int.TryParse(Console.ReadLine(), out int Fn); //commented to allow exceptions, then handle them

                Console.WriteLine("Enter second Number");
                //int.TryParse(Console.ReadLine(), out int Sn);
                int Sn = Convert.ToInt32(Console.ReadLine());

                int result = Fn / Sn;
                Console.WriteLine("Result = {0}", result);
            }
            catch (Exception ex)
            {
                string logFilePath = @"C:\Mine\Dev\CSharp\log1.txt";
                if (File.Exists(logFilePath))
                {
                    StreamWriter streamWriter = new StreamWriter(logFilePath);
                    streamWriter.WriteLine(ex.GetType().FullName);
                    streamWriter.WriteLine(ex.Message);
                    streamWriter.WriteLine(ex.StackTrace);
                    streamWriter.Close();
                    Console.WriteLine(ex.Message);
                }
                else
                {
                    throw new FileNotFoundException(logFilePath + "is not present" , ex); //passing original excep ex as inner exception to it
                }

            }
        }
        catch(Exception e)
        {

            Console.WriteLine(e.GetType().Name); //will have file not found exception

            if (e.InnerException != null)
                Console.WriteLine(e.InnerException.GetType().Name); //will have original exception
        }
    }
}
//*/

/* mod 42 Custom Exceptions

using System;
using System.IO;
using System.Runtime.Serialization;
public class CustomException
{
    public static void Main()
    {
        //    throw new UserAlreadyLoggedInException();

        //    throw new UserAlreadyLoggedInException("user already logged in - no duplicate session is allowed");

        //    throw new UserAlreadyLoggedInException("user already logged in -no duplicate session is allowed",throw new FileNotFoundException);

        try
        {
            throw new UserAlreadyLoggedInException("user already logged in - no duplicate session is allowed");
        }
        catch(UserAlreadyLoggedInException ex)
        {
            Console.WriteLine(ex.Message);
        }
    } 
}

[Serializable]
public class UserAlreadyLoggedInException : Exception
{
    public UserAlreadyLoggedInException():base()
    { }
    public UserAlreadyLoggedInException(string message): base(message)
    { }
    public UserAlreadyLoggedInException(string message,Exception innerException):base(message,innerException)
    {

    }

    public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context) : base(info, context)
    {

    }
}
//*/

/* mod 43 Exception handling abuse
using System;
 
public class Program
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Enter Numnerator"); //should have displayed the range here
            int Fn = Convert.ToInt32(Console.ReadLine()); // should have used tryparse here, rather than catch block

            Console.WriteLine("Enter Denaminator");
            int Sn = Convert.ToInt32(Console.ReadLine());

            int result = Fn / Sn; //should have checked if dn is zero,than catching it as exception
            Console.WriteLine("Result = {0}", result);
        }
        catch(FormatException)
        {
            Console.WriteLine("Enter Valid Number");
        }
        catch(StackOverflowException)
        {
            Console.WriteLine("Enter Numbers within the range of {0} - {1}", int.MinValue,int.MaxValue);
        }
        catch(DivideByZeroException)
        {
            Console.WriteLine("Denominator cant be Zero");
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

}

//*/

/* mod 44 preventing exception handling abuse
using System;

public class Program
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Enter Numnerator");            
            if(int.TryParse(Console.ReadLine(), out int Fn))
            {
                Console.WriteLine("Enter Denaminator");
                if(int.TryParse(Console.ReadLine(), out int Sn) && Sn !=0)
                {
                    int result = Fn / Sn;
                    Console.WriteLine("Result = {0}", result);
                }
                else
                {
                    if(Sn == 0)
                        Console.WriteLine("Denominator cant be Zero");
                    else
                        Console.WriteLine("Enter Numbers within the range of {0} - {1}", int.MinValue, int.MaxValue);
                }

                
            }
            else
            {
                Console.WriteLine("Enter Numbers within the range of {0} - {1}", int.MinValue, int.MaxValue);
            }

            
        }
        // the following has been taken care by editing the above code
        //catch (FormatException)
        //{
        //    Console.WriteLine("Enter Valid Number");
        //}
        //catch (StackOverflowException)
        //{
        //    Console.WriteLine("Enter Numbers within the range of {0} - {1}", int.MinValue, int.MaxValue);
        //}
        //catch (DivideByZeroException)
        //{
        //    Console.WriteLine("Denominator cant be Zero");
        //}
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

}

//*/
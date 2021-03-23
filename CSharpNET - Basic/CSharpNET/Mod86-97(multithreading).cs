/* mod 86 Multithreading in C#
 * 
 * see windowsFormsApp1--> form2 for the demo
 * 
 */

/* mod 87 Advantanges and disadvantages of multithreading 
 * 
 */

/* mod 88 Threadstart delegate

using System;
using System.Threading;

namespace CSharpNET
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ////using normal method
            //Thread t = new Thread(Number.PrintNumbers);
            //t.Start();

            // Create an instance ThreadStart delegate
            ThreadStart threadStart = new ThreadStart(Number.PrintNumbers);
            Thread t = new Thread(threadStart);
            // Pass the traget number to the start function, which
            // will then be passed automatically to PrintNumbers() function
            t.Start();

            Thread t1 = new Thread(new ThreadStart(Number.PrintNumbers));
            t1.Start();

            Thread t2 = new Thread(() => Number.PrintNumbers());
            t2.Start();

            Thread t3 = new Thread(delegate () { Number.PrintNumbers(); });
            t3.Start();
        }

        class Number
        {
            public static void PrintNumbers()
            {
                Console.WriteLine("Printing Numbers");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

}

//*/

/* mod 89 ParameterizedThreadstart delegate

using System;
using System.Threading;

namespace CSharpNET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the target number");
            object target = Console.ReadLine();

            // Create an instance ParameterizedThreadStart delegate
            ParameterizedThreadStart p = new ParameterizedThreadStart(Number.PrintNumbers);

            // Pass the traget number to the start function, which
            // will then be passed automatically to PrintNumbers() function
            Thread t = new Thread(p);
            t.Start(target);


            //above code can also be written as below
            //here, though we are not passing ParameterizedThreadStart as arg, the start method is still accepting args
            //thats becuase,  the compiler implicitly converts new Thread(Number.PrintNumbers)  to new Thread(new ParameterizedThreadStart(Number.PrintNumbers)).
            Thread t1 = new Thread(Number.PrintNumbers);
            t1.Start(target);

            //but here, we can pass anything as i/p target, as the start method passes object
            //see by passing a string a input
            // this is the draw back of ParameterizedThreadStart, which is resolved in next mod
        }

        class Number
        {
            public static void PrintNumbers(object obj)
            {
                int number = 0;
                if(int.TryParse(obj.ToString(), out number))
                {
                    for (int i = 0; i <= number; i++)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}

//*/

/* mod 90 Passing data to the Thread function in a type safe manner

using System;
using System.Threading;

namespace CSharpNET
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user for the target number
            Console.WriteLine("Please enter the target number");
            // Read from the console and store it in target variable
            int target = Convert.ToInt32(Console.ReadLine());

            // Create an instance of the Number class, passing it
            // the target number that was read from the console
            Number number = new Number(target);

            // Specify the Thread function
            Thread T1 = new Thread(new ThreadStart(number.PrintNumbers));
            // Alternatively we can just use Thread class constructor as shown below
            // Thread T1 = new Thread(number.PrintNumbers);
            T1.Start();
        }
    }

    // Number class also contains the data it needs to print the numbers
    class Number
    {
        int _target;

        // When an instance is created, the target number needs to be specified
        public Number(int n)
        {
            // The targer number is then stored in the class private variable _target
            this._target = n;
        }

        // Function prints the numbers from 1 to the traget number that the user provided
        public void PrintNumbers()
        {
            for (int i = 0; i < this._target; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
//*/

/* mod 91 Retrieving data from Thread function using callback method

using System;
using System.Threading;

namespace CSharpNET
{
    // Step 1: Create a callback delegate. The actual callback method
    // signature should match with the signature of this delegate.
    public delegate void SumOfNumbersCallback(int sumOfNumbers);

    // Step 2: Create Number class to compute the sum of numbers and
    // to call the callback method

    class Number
    {
        // The traget number this class needs to compute the sum of numbers
        int _target;

        // Delegate to call when the the Thread function completes                 
        // computing the sum of numbers
        SumOfNumbersCallback _callbackMethod;

        // Constructor to initialize the target number and the callback delegateinitialize
        public Number(int target, SumOfNumbersCallback callbackMethod)
        {
            this._target = target;
            this._callbackMethod = callbackMethod;
        }

        // This thread function computes the sum of numbers and then invokes
        // the callback method passing it the sum of numbers
        public void ComputeSumOfNumbers()
        {
            int sum = 0;
            for (int i = 1; i <= _target; i++)
            {
                sum = sum + i;
            }

            if (_callbackMethod != null)
            {
                _callbackMethod(sum);
            }
        }
    }

    // Step 3: This class consumes the Number class created in Step 2
    class Program
    {
        // Callback method that will receive the sum of numbers
        public static void PrintSumOfNumbers(int sum)
        {
            Console.WriteLine("Sum of numbers is " + sum);
        }
        public static void Main()
        {
            // Prompt the user for the target number
            Console.WriteLine("Please enter the target number");
            // Read from the console and store it in target variable
            int target = Convert.ToInt32(Console.ReadLine());

            // Create an instance of callback delegate and to it's constructor
            // pass the name of the callback function (PrintSumOfNumbers)
            SumOfNumbersCallback callbackMethod = new SumOfNumbersCallback(PrintSumOfNumbers);

            // Create an instance of Number class and to it's constrcutor pass the target
            // number and the instance of callback delegate
            Number number = new Number(target, callbackMethod);

            // Create an instance of Thread class and specify the Thread function to invoke
            Thread T1 = new Thread(new ThreadStart(number.ComputeSumOfNumbers));
            T1.Start();
        }
    }    

}
//*/

/* mod 92 Thread.Join() & Thread.IsAlive()

using System;
using System.Threading;

namespace CSharpNET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main started");

            Thread t1 = new Thread(Thread1Function);
            t1.Start();

            Thread t2 = new Thread(Thread2Function);
            t2.Start();

            if(t1.Join(1000))
                Console.WriteLine("Thread1Function Completed");
            else
                Console.WriteLine("Thread1Function hasn't completed in one sec");

            t2.Join();
            Console.WriteLine("Thread2Function completed");


            for (int i = 0; i < 10; i++)
            {
                if (t1.IsAlive)
                {
                    Console.WriteLine("Thread1Function is still running");
                    Thread.Sleep(500);
                }
                else
                {
                    Console.WriteLine("Thread1Function Completed");
                    break;
                }
            }

            Console.WriteLine("Main Completed");
        }
        public static void Thread1Function()
        {
            Console.WriteLine("Thread1Funciton started");
            Thread.Sleep(5000);
            Console.WriteLine("Thread1Function is about to return"); 
        }

        public static void Thread2Function()
        {
            Console.WriteLine("Thread2Funciton started");
        }
    }
}
//*/

/* mod 93 Protecting shared resources from concurrent access in multithreading

using System;
using System.Threading;
using System.Diagnostics;

namespace CSharpNET
{
    class Program
    {
        //declaring Total var as the shared resource here
        static int Total = 0;
        static void Main(string[] args)
        {
            ////single thread example
            //AddOneMillion();
            //AddOneMillion();
            //AddOneMillion();
            //always the output would be 3M
            //Console.WriteLine("Total is " + Total);

            //multithread example

            Stopwatch stopwatch = Stopwatch.StartNew(); //used to measure the time taken

            Thread t1 = new Thread(AddOneMillion);
            Thread t2 = new Thread(AddOneMillion);
            Thread t3 = new Thread(AddOneMillion);

            t1.Start(); t2.Start(); t3.Start();
            t1.Join(); t2.Join(); t3.Join();

            //output is always different for each execution
            Console.WriteLine("Total " + Total);

            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds); //displaying the time taken
        }

        //using Interlocked class
        static void AddOneMillion()
        {
            for (int i = 0; i < 1000000; i++)
            {
                ////here ++ operater isnt thread safe
                //Total++;

                Interlocked.Increment(ref Total);
            }
        }

        ////using locking
        //static object _lock = new object();
        //static void AddOneMillion()
        //{
        //    for (int i = 0; i < 1000000; i++)
        //    {
        //        lock(_lock)
        //        {
        //            Total++;
        //        }

        //    }
        //}
    }
}
//*/

/* mod 94 Monitor v/ s lock

using System;
using System.Threading;
using System.Diagnostics;

namespace CSharpNET
{
    class Program
    {
        //declaring Total var as the shared resource here
        static int Total = 0;
        static void Main(string[] args)
        {                        
            Thread t1 = new Thread(AddOneMillion);
            Thread t2 = new Thread(AddOneMillion);
            Thread t3 = new Thread(AddOneMillion);

            t1.Start(); t2.Start(); t3.Start();
            t1.Join(); t2.Join(); t3.Join();

            //output is always different for each execution
            Console.WriteLine("Total " + Total);           
        }

        //using lock 

        //static object _lock = new object();
        //static void AddOneMillion()
        //{
        //    for (int i = 0; i < 1000000; i++)
        //    {
        //        lock (_lock)
        //        {
        //            Total++;
        //        }

        //    }
        //}

        //using Monitor class

        static object _lock = new object();
        static void AddOneMillion()
        {
            for (int i = 0; i < 1000000; i++)
            {
                // Acquires the exclusive lock
                //Monitor.Enter(_lock);
                //try
                //{
                //    Total++;
                //}
                //finally
                //{
                     // Releases the exclusive lock
                //    Monitor.Exit(_lock);
                //}

                bool lockTaken = false;
                // Acquires the exclusive lock
                Monitor.Enter(_lock, ref lockTaken);
                try
                {
                    Total++;
                }
                finally
                {
                    // Releases the exclusive lock
                    if(lockTaken)
                       Monitor.Exit(_lock);
                }
            }
        }
    }
}
//*/

/* mod 95 Deadlocks in multithreaded programs

using System;
using System.Threading;

namespace CSharpNET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main started");
            Account accountA = new Account(101, 5000);
            Account accountB = new Account(102, 3000);

            AccountManager accountManagerA = new AccountManager(accountA, accountB, 1000);
            Thread t1 = new Thread(accountManagerA.Transfer);
            t1.Name = "T1";

            AccountManager accountManagerB = new AccountManager(accountB, accountA, 2000);
            Thread t2 = new Thread(accountManagerB.Transfer);
            t2.Name = "T2";

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            Console.WriteLine("Main Completed");
        }
    }

    public class Account
    {
        #region fields
        double _balance;
        int _id;
        #endregion

        #region properties
        public int ID
        {
            get
            {
                return _id;
            } 
        }
        #endregion

        #region constructors
        public Account(int id, double balance)
        {
            this._id = id;
            this._balance = balance;
        }
        #endregion

        #region methods
        public void Withdraw(double amount)
        {
            _balance -= amount;
        }
        public void Deposit(double amount)
        {
            _balance += amount;
        }
        #endregion
    }

    public class AccountManager
    {
        #region fields
        Account _fromAccount;
        Account _toAccount;
        double _amountToTransfer;
        #endregion

        #region Constructors
        public AccountManager(Account fromAccount, Account toAccount, double amountToTransfer)
        {
            this._fromAccount = fromAccount;
            this._toAccount = toAccount;
            this._amountToTransfer = amountToTransfer;
        }
        #endregion

        #region methods
        public void Transfer()
        {
            Console.WriteLine(Thread.CurrentThread.Name + " trying to acquire lock on " + _fromAccount.ID.ToString());

            lock (_fromAccount)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " acquired lock on "+ _fromAccount.ID.ToString());
                Thread.Sleep(1000); //potential cause for deadlock
                Console.WriteLine(Thread.CurrentThread.Name + " suspended for 1 second");
                Console.WriteLine(Thread.CurrentThread.Name +" back in action and trying to acquire lock on "+ _toAccount.ID.ToString());

                lock (_toAccount)
                {
                    Console.WriteLine("This will not be executed due to deadlock");
                    _fromAccount.Withdraw(_amountToTransfer);
                    _toAccount.Deposit(_amountToTransfer);
                }
            }
        }
        #endregion
    }
}
//*/

/* mod 96 Resolving Deadlocks in multithreaded programs

using System;
using System.Threading;

namespace CSharpNET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main started");
            Account accountA = new Account(101, 5000);
            Account accountB = new Account(102, 3000);

            AccountManager accountManagerA = new AccountManager(accountA, accountB, 1000);
            Thread t1 = new Thread(accountManagerA.Transfer);
            t1.Name = "T1";

            AccountManager accountManagerB = new AccountManager(accountB, accountA, 2000);
            Thread t2 = new Thread(accountManagerB.Transfer);
            t2.Name = "T2";

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            Console.WriteLine("Main Completed");
        }
    }

    public class Account
    {
        #region fields
        double _balance;
        int _id;
        #endregion

        #region properties
        public int ID
        {
            get
            {
                return _id;
            } 
        }
        #endregion

        #region constructors
        public Account(int id, double balance)
        {
            this._id = id;
            this._balance = balance;
        }
        #endregion

        #region methods
        public void Withdraw(double amount)
        {
            _balance -= amount;
        }
        public void Deposit(double amount)
        {
            _balance += amount;
        }
        #endregion
    }

    public class AccountManager
    {
        #region fields
        Account _fromAccount;
        Account _toAccount;
        double _amountToTransfer;
        #endregion

        #region Constructors
        public AccountManager(Account fromAccount, Account toAccount, double amountToTransfer)
        {
            this._fromAccount = fromAccount;
            this._toAccount = toAccount;
            this._amountToTransfer = amountToTransfer;
        }
        #endregion

        #region methods
        public void Transfer()
        {
            object _lock1, _lock2;
            //specifying order for locking

            if (_fromAccount.ID < _toAccount.ID)
            {
                _lock1 = _fromAccount;
                _lock2 = _toAccount;
            }
            else
            {
                _lock1 = _toAccount;
                _lock2 = _fromAccount;
            }
            Console.WriteLine(Thread.CurrentThread.Name + " trying to acquire lock on " + ((Account)_lock1).ID.ToString());

            lock (_lock1)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " acquired lock on "+ ((Account)_lock1).ID.ToString());
                Thread.Sleep(1000); //potential cause for deadlock
                Console.WriteLine(Thread.CurrentThread.Name + " suspended for 1 second");
                Console.WriteLine(Thread.CurrentThread.Name +" back in action and trying to acquire lock on "+ ((Account)_lock2).ID.ToString());

                lock (_lock2)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " acquired lock on " + ((Account)_lock2).ID.ToString());
                    _fromAccount.Withdraw(_amountToTransfer);
                    _toAccount.Deposit(_amountToTransfer);
                    Console.WriteLine(Thread.CurrentThread.Name + " Transfered "+ _amountToTransfer.ToString() + " from "+ _fromAccount.ID.ToString() + " to "+ _toAccount.ID.ToString());
                }
            }
        }
        #endregion
    }
}
//*/

/* mod 97 Performance implications of a multithreaded program

using System;
using System.Threading;
using System.Diagnostics;

namespace CSharpNET
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(Environment.ProcessorCount); //prints the number of cores 
            Stopwatch stopwatch = Stopwatch.StartNew();
            OddNumbersSum();
            EvenNumbersSum();
            stopwatch.Stop();
            Console.WriteLine("Total time taken without threads " + stopwatch.ElapsedMilliseconds);

            Stopwatch stopwatch1 = Stopwatch.StartNew();
            Thread t1 = new Thread(OddNumbersSum);
            Thread t2 = new Thread(EvenNumbersSum);

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            stopwatch1.Stop();
            Console.WriteLine("Total time taken with multiple threads " + stopwatch1.ElapsedMilliseconds);

        }

        public static void EvenNumbersSum()
        {
            double sum = 0;
            for (int i = 0; i <= 50000000; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("Sum of even numbers = {0}", sum);
        }

        public static void OddNumbersSum()
        {
            double sum = 0;
            for (int i = 0; i <= 50000000; i++)
            {
                if (i % 2 == 1)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("Sum of odd numbers = {0}", sum);
        }
    }
}
//*/
using System;
using System.Collections.Generic;

namespace gradebook
{

    class Program
    {        
        static void Main(string[] args)
        {
            //var book = new InMemoryBook("My InMemory Grade book");
            IBook book = new DiskBook("My Disk Book");
            book.GradeAdded += OnGradeAdded;
                        
            EnterGrades(book);

            var stats = book.GetStatistics();

            System.Console.WriteLine($"For the book named {book.Name}");
            System.Console.WriteLine($"The average grade is {stats.Average:N1}");
            System.Console.WriteLine($"The Lowest grade is {stats.Low:N1}");
            System.Console.WriteLine($"The Highest grade is {stats.High:N1}");
            System.Console.WriteLine($"Letter Grade is {stats.Letter}");
        }

        private static void EnterGrades(IBook book)
        {
            
            while (true)
            {
                System.Console.WriteLine("Enter the Grade or enter 'Q' to quit");
                string s = System.Console.ReadLine();
                if (s == "Q")
                    break;
                try
                {
                    book.AddGrade(double.Parse(s));
                }
                catch (ArgumentException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
                finally
                {
                    System.Console.WriteLine("***");
                }

            };
        }

        static void OnGradeAdded(object senders, EventArgs e)
        {
            System.Console.WriteLine("A grade was added");
        }
    }
}

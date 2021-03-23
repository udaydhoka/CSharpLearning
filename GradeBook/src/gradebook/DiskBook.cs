using System;
using System.IO;


namespace gradebook
{
    public class DiskBook : Book
    {
        public DiskBook(string name) : base(name)
        {
            
        }

        public override event GradeAddedDelegate GradeAdded;

        public override void AddGrade(double grade)
        {
            if(grade <= 100 && grade >= 0)
            {
                // if(!File.Exists(@"C:\Mine\Dev\CSharp\GradeBook\src\DiskBook.txt"))
                // {
                //     using(StreamWriter str = File.CreateText(@"C:\Mine\Dev\CSharp\GradeBook\src\DiskBook.txt"))
                //     {
                //         str.WriteLine(grade);
                //     }
                // }                                                
                
                using(var writer = File.AppendText($"{Name}.txt"))
                {
                    writer.WriteLine(grade);
                    if(GradeAdded != null)
                    {
                        GradeAdded(this , new EventArgs());
                    }
                }
                
            }
        }
               
        public override Statistics GetStatistics()
        {
           var result = new Statistics();

           using(var reader = File.OpenText($"{Name}.txt"))
           {
               var line = reader.ReadLine();
               while(line != null)
               {
                   var num = double.Parse(line);
                   result.Add(num);
                   line = reader.ReadLine();
               }
            
           }

           return result;

        }
       
    }
}
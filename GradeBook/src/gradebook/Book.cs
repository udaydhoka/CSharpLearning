using System;
using System.Collections.Generic;

namespace gradebook
{
    
     public abstract class Book : NameObject, IBook
    {
        public Book(string name) : base(name)
        {
        }  

        public abstract event GradeAddedDelegate GradeAdded;

        public abstract void AddGrade(double grade);

        public abstract  Statistics GetStatistics();                
        
    }
    
}
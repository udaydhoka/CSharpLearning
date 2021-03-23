using System;

namespace gradebook
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args);   
    
    public interface IBook
    {
        void AddGrade(double grade);
        Statistics GetStatistics();
        string Name {get;}
        event GradeAddedDelegate GradeAdded;
    }
}
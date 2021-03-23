using System;
using Xunit;
using gradebook;

namespace gradebook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAveragreGrade()
        {
            //arrange
            var book = new InMemoryBook("");
            book.AddGrade(89.1);
            book.AddGrade(69.0);
            book.AddGrade(77.9);

            //act            
            var res = book.GetStatistics();

            //assert
            Assert.Equal(78.7,res.Average, 1);
            Assert.Equal(69.0,res.Low,1);
            Assert.Equal(89.1,res.High,1);
            Assert.Equal('C',res.Letter);
        }
    }
}

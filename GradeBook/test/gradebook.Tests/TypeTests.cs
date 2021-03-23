using System;
using Xunit;
using gradebook;

namespace gradebook.Tests
{

    public delegate string WriteLogDelegate(string logMessage);

    public class TypeTests
    {
        int count = 0;

        [Fact]
        public void WriteLogDelegateCanPointtoMethod()
        {
            WriteLogDelegate log = ReturnMessage;
            log += ReturnMessage;
            log += IncrementCode;

            var res = log.Invoke("Hello");
            Assert.Equal(3,count);

        }

        string IncrementCode(string msg)
        {
            count++;
            return msg.ToLower();
        }

        string ReturnMessage(string msg)
        {
            count++;
            return msg;
        }

        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
        //Given
        string name = "uday";
        //When
        string ss = MakeUpperCase(name);
        //Then
        Assert.Equal("uday",name);
        Assert.Equal("UDAY",ss);
        }

        private string MakeUpperCase(string name)
        {
           return name.ToUpper();
        }

        [Fact]
        public void PassByRefValueType()
        {
            var x = GetInt();
            SetInt(ref x);
            Assert.Equal(42,x);
        }

        private void SetInt(ref int x)
        {
            x = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void PassByRefRefType()
        {
            //arrange
            var book1 = GetBook("Book 1");
            GetBookSetName(ref book1,"New Name");
                         
            //act                        

            //assert
            Assert.Equal("New Name", book1.Name);
          
        }
         private void GetBookSetName(ref InMemoryBook book, string name)
        {
            book = new InMemoryBook(name);
        }


         [Fact]
        public void PassByValueRefType()
        {
            //arrange
            var book1 = GetBook("Book 1");
            GetBookSetName(book1,"New Name");
                         
            //act                        

            //assert
            Assert.Equal("Book 1", book1.Name);
          
        }
         private void GetBookSetName(InMemoryBook book, string name)
        {
            book = new InMemoryBook(name);
        }

         [Fact]
        public void CanSetNameFromReference()
        {
            //arrange
            var book1 = GetBook("Book 1");
            SetName(book1,"New Name");

            //act                        

            //assert
            Assert.Equal("New Name", book1.Name);
          
        }
         private void SetName(InMemoryBook book, string name)
        {
            book.Name = name;
        }
        

        [Fact]
        public void GetBookReturnsDiffferentObjects()
        {
            //arrange
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");
            

            //act            
            

            //assert
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1,book2);
        }

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            //arrange
            var book1 = GetBook("Book 1");
            var book2 = book1;
            

            //act            
            

            //assert
            Assert.Same(book1,book2);
            Assert.True(object.ReferenceEquals(book1,book2));

        }

        InMemoryBook GetBook(string name)
        {
            return new InMemoryBook(name);
        }

       
    }
}

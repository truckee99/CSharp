using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CSharp.Test
{
   public class TypeTests
    {
        [Fact]
        public void StringBehaveLikeValueTypeByString()
        {
            //arrange
            string name = "Scott";
            name = ReturnString();
         

            //act
            Assert.Equal("Bob", name);

            //assert
        }


        [Fact]
        public void StringBehaveLikeValueType()
        {
            //arrange
            string name = "Scott";
            name = "Bob";
            MakeUpperCase(name);

            //act
            Assert.Equal("Bob", name);

            //assert
        }


        private string ReturnString()
        {
            return "Bob";
        }

        private void MakeUpperCase(string name)
        {
            name.ToUpper();
        }

        [Fact]
        public void ValueTypePassedByReference()
        {
            //arrange
            var x = GetInt();
            SetInt(ref x);

            //act
            Assert.Equal(42, x);

            //assert
        }

        private int SetInt(ref int x)
        {
            return x = 42;
        }


        [Fact]
        public void ValueTypePassedByValue()
        {
            //arrange
           var x = GetInt();
            SetInt(x);

            //act
            Assert.Equal(3, x);

            //assert
        }

        private int SetInt(int x)
        {
            return x = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        private void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);

        }


        [Fact]
        public void PassParameterByReference()
        {
            //arrange
            var book1 = GetBook("Book 1");
            GetBookSetName(ref book1, "New Name");

            //act
            Assert.Equal("New Name", book1.Name);


            //assert
        }

        private void GetBookSetNameUsingOut(out Book book, string name)
        {
            book = new Book(name);

        }


        [Fact]
        public void PassParameterByReferenceUsingOut()
        {
            //arrange
            var book1 = GetBook("Book 1");
            GetBookSetNameUsingOut(out book1, "New Name");

            //act
            Assert.Equal("New Name", book1.Name);


            //assert
        }

        [Fact]
        public void PassParameterByValueString()
        {
            //arrange
            var book1 = GetBook("Book 1");
            SetNameByValue("New Name");

            //act
            Assert.Equal("Book 1", book1.Name);


            //assert
        }


        private string SetNameByValue( string name)
        {
            return name = "Book 2";


        }


        [Fact]
        public void PassParameterByValue()
        {
            //arrange
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            //act
            Assert.Equal("Book 1", book1.Name);


            //assert
        }

        private void GetBookSetName(Book book, string name)
        {
             book = new Book(name);
      

        }


        [Fact]
        public void ChangeChangeReferenceName()
        {
            //arrange
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            //act
            Assert.Equal("New Name", book1.Name);
     

            //assert
        }

     

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            //arrange
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            //act
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
        
            //assert
        }

        [Fact]
        public void TwoVariablesReferenceSameObject()
        {
            //arrange
            var book1 = GetBook("Book 1");
            var book2 = book1;

            //act
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 1", book2.Name);
            Assert.True(Object.ReferenceEquals(book1, book2));
            Assert.Same(book1, book2);

            //assert
        }

        private Book GetBook(string name)
        {
            return new Book(name);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

    }
}

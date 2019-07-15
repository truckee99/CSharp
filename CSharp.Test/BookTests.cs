using System;
using Xunit;

namespace CSharp.Test
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            //arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            //act

            var result = book.GetStatistics();


            Assert.Equal(85.6, result.Average,1);
            Assert.Equal(90.5, result.High);
            Assert.Equal(77.3, result.Low);
            //assert
        }

        [Fact]
        public void ValidateGrades()
        {
            var book = new Book("");
            book.AddGrade(-5);
            book.AddGrade(101);
            book.AddGrade(98.3);

            var result = 1;
            var expected = book.Grades.Count;

            Assert.Equal(result, expected);

        }
    }
}

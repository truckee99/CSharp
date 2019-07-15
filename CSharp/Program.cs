using System;
using System.Collections.Generic;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //double x = 12.2;
            //double y = 22.5;
            //double z;
            //var grades = new List<double>() { 12.3, 43.2, 11.2 };

            //grades.Add(1);

            //var numberArray = new[] { 12.3, 43.2, 11.2 };

            //double result = 0.0;

            var book = new Book("My Grade Book");
            book.AddGrade(22.25);
            book.AddGrade(89.25);
            book.AddGrade(91.25);
          var stats=  book.GetStatistics();


            Console.WriteLine($"The lowest is {stats.Low:N1}");
            Console.WriteLine($"The highest is {stats.High:N1}");
            Console.WriteLine($"The average Grade is {stats.Average:N1}");


            Console.ReadLine();
        }
    }
}

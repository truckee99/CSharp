using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
  public  class Book
    {

        public Book(string name)
        {
            Grades = new List<double>();

            //the keyword this refers to the current object
            this.Name = name; 
        }

        public List<double> Grades { get; set; }
        public string Name { get; set; }

        public void AddLetterGrade(char letter)
        {
            switch(letter)
            {
                case 'A': AddGrade(90);
                    break;
                case 'B': AddGrade(80);
                    break;
                case 'C':
                    AddGrade(70);
                    break;
                case 'D':
                    AddGrade(60);
                    break;
                default: AddGrade(0);
                    break;
            }
        }

        public void AddGrade(double grade)
        {
            if(grade <= 100 && grade >=0)
            {
                Grades.Add(grade);
                
            }
            else
            {
                Console.WriteLine($"Invalid Value");
            }
        
        }

        public Statistics GetStatistics()
        {
            var stats = new Statistics();

            stats.Low = double.MaxValue;
            stats.High = double.MinValue;
            stats.Average = 0.00;

            //foreach (var number in Grades)
            //{
            //    stats.High = Math.Max(number, stats.High);
            //    stats.Low = Math.Min(number, stats.Low);
            //    stats.Average += number;
            //}

            //var index = 0;

            //do
            //{
            //    stats.High = Math.Max(Grades[index], stats.High);
            //    stats.Low = Math.Min(Grades[index], stats.Low);
            //    stats.Average += Grades[index];
            //    index++;
            //}
            //while (index < Grades.Count);

            //while (index < Grades.Count) 
            //{
            //    stats.High = Math.Max(Grades[index], stats.High);
            //    stats.Low = Math.Min(Grades[index], stats.Low);
            //    stats.Average += Grades[index];
            //    index++;
            //}

            for(int i=0; i< Grades.Count; i++)
            {
                if (Grades[i] == 50)
                {
                    //break;
                    continue;
                }

                  stats.High = Math.Max(Grades[i], stats.High);
                  stats.Low = Math.Min(Grades[i], stats.Low);
                  stats.Average += Grades[i];
                 
            }

            stats.Average /= Grades.Count;

            return stats;

        }


  
    }
}

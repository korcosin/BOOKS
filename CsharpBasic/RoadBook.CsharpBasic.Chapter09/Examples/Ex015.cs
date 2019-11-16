using System;
using System.Collections.Generic;

namespace RoadBook.CsharpBasic.Chapter09.Examples
{
    public class Ex015
    {
        public void Run()
        {
            List<Model.Student> students = new List<Model.Student>()
            {
                new Model.Student { Id = "S001", Name = "Dexter", Grade = 3, Major = "Software" },
                new Model.Student { Id = "D001", Name = "Ellin", Grade = 3, Major = "Design" },
                new Model.Student { Id = "S002", Name = "Jeffrey", Grade = 4, Major = "Software" },
                new Model.Student { Id = "D002", Name = "Sienna", Grade = 4, Major = "Design" },
                new Model.Student { Id = "S003", Name = "Pil", Grade = 4, Major = "Software" },
                new Model.Student { Id = "S006", Name = "Clint", Grade = 3, Major = "Software" },
                new Model.Student { Id = "S004", Name = "Khan", Grade = 2, Major = "Software" },
                new Model.Student { Id = "A001", Name = "Mike", Grade = 2, Major = "Advertisement" },
                new Model.Student { Id = "S005", Name = "Sven", Grade = 2, Major = "Software" },
                new Model.Student { Id = "T001", Name = "Peter", Grade = 1, Major = "Theater" },
            };

            int sum = 0;
            int max = 0;
            int min = 100;
            double avg = 0;

            for (int idx = 0; idx < students.Count; idx++)
            {
                int grade = students[idx].Grade;

                sum += grade;

                if (max < grade)
                {
                    max = grade;
                }

                if (min > grade)
                {
                    min = grade;
                }
            }

            avg = sum / (double)students.Count;
            Console.WriteLine("SUM : {0}", sum);
            Console.WriteLine("Max : {0}", max);
            Console.WriteLine("Min : {0}", min);
            Console.WriteLine("Avg : {0}", avg);
        }
    }
}
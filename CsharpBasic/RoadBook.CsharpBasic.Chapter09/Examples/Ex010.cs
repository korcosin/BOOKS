using System;
using System.Collections.Generic;

namespace RoadBook.CsharpBasic.Chapter09.Examples
{
    public class Ex010
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

            dynamic tmpStudents;

            for (int idx = 0; idx < students.Count; idx++)
            {
                for (int idx_j = idx + 1; idx_j < students.Count; idx_j++)
                {
                    if (students[idx].Grade > students[idx_j].Grade)
                    {
                        tmpStudents = students[idx];
                        students[idx] = students[idx_j];
                        students[idx_j] = tmpStudents;
                    }
                }
            }

            for (int idx = 0; idx < students.Count; idx++)
            {
                Console.WriteLine("{0} : {1}", students[idx].Name, students[idx].Grade);
            }
        }
    }
}
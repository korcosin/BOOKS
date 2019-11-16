using System;
using System.Collections.Generic;

namespace RoadBook.CsharpBasic.Chapter09.Examples
{
    public class Ex012
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
            
            int softCnt = 0;
            int designCnt = 0;
            int theaterCnt = 0;
            int adCnt = 0;

            for (int idx = 0; idx < students.Count; idx++)
            {
                switch (students[idx].Major)
                {
                    case "Software":
                        softCnt++;
                        break;
                    case "Design":
                        designCnt++;
                        break;
                    case "Theater":
                        theaterCnt++;
                        break;
                    case "Advertisement":
                        adCnt++;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine("SoftWare : {0}", softCnt);
            Console.WriteLine("Design : {0}", designCnt);
            Console.WriteLine("Theater : {0}", theaterCnt);
            Console.WriteLine("Advertisement : {0}", adCnt);
        }
    }
}
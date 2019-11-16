using System;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    public class Ex005
    {
        public void Run()
        {
            int[][] gradeOfStudent = {
                new int[] { 100, 98, 95 },
                new int[] { 90, 100, 100 },
                new int[] { 95, 96, 95 },
                new int[] { 88, 92, 98 }
            };

            for (int idx_i = 0; idx_i < gradeOfStudent.Length; idx_i++)
            {
                for (int idx_j = 0; idx_j < gradeOfStudent[idx_i].Length; idx_j++)
                {
                    Console.WriteLine( "{0}번째 학생의 {1}번째 과목 성적 : {2}", 
                        (idx_i + 1), (idx_j + 1 ), gradeOfStudent[idx_i][idx_j]
                    );
                }
            }
        }
    }
}
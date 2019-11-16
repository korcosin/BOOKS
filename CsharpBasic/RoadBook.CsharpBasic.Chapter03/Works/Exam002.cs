using System;

namespace RoadBook.CsharpBasic.Chapter03.Works
{
    public class Exam002
    {
        public void Run()
        {
            Console.WriteLine("중간고사 성적을 입력하세요: ");
            int mid_grade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("기말고사 성적을 입력하세요: ");
            int fin_grade = Convert.ToInt32(Console.ReadLine());

            double average = ( mid_grade + fin_grade ) / 2.0;

            char grade;
            if ( average >= 90 )
            {
                grade = 'A';
            }
            else if ( average < 90 && average >= 80 )
            {
                grade = 'B';
            }
            else if ( average < 80 && average >= 70)
            {
                grade = 'C';
            }
            else
            {
                grade = 'F';
            }

            Console.WriteLine("최종 학점은 '{0}' 입니다", grade);
        }
    }
}
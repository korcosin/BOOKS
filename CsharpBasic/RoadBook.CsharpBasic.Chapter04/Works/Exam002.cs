using System;

namespace RoadBook.CsharpBasic.Chapter04.Works
{
    public class Exam002
    {
        public void Run()
        {
            Random r = new Random();
            int question_number = r.Next(1, 50);
            int answer_number = 0;

            Console.WriteLine("1~50 사이의 특정 숫자를 맞춰보세요");
            do
            {
                answer_number = Convert.ToInt32(Console.ReadLine());

                if (question_number != answer_number)
                {
                    Console.WriteLine("틀렸습니다. {0}!", question_number > answer_number ? "UP" : "DOWN");
                }
            } while (question_number != answer_number);

            Console.WriteLine("정답입니다");
        }
    }
}

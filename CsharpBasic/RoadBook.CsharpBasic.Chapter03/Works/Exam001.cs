using System;

namespace RoadBook.CsharpBasic.Chapter03.Works
{
    public class Exam001
    {
        public void Run()
        {
            Random r = new Random();
            int number01 = r.Next(1,100);
            int number02 = r.Next(1,100);

            Console.WriteLine("{0} + {1} = ?", number01, number02);
            int answer = Convert.ToInt32(Console.ReadLine());

            if (number01 + number02 == answer)
            {
                Console.WriteLine("정답");
            }
            else
            {
                Console.WriteLine("오답");
            }
        }
    }
}
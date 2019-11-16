using System;

namespace RoadBook.CsharpBasic.Chapter04.Works
{
    public class Exam001
    {
        public void Run()
        {
            Console.WriteLine("숫자를 입력해주세요");
            int number = Convert.ToInt32(Console.ReadLine());

            int fact = 1;
            for (int idx = number; idx > 0; idx--)
            {
                fact *= idx;
            }

            Console.WriteLine("{0}! = {1}", number, fact);
        }
    }
}

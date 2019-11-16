using System;

namespace RoadBook.CsharpBasic.Chapter04.Examples
{
    public class Ex009
    {
        public void Run()
        {
            Random rand = new Random();
            int target_number = rand.Next(1, 10);

            Console.WriteLine("제가 생각하고 있는 1 ~ 10 사이의 숫자를 맞춰보세요(0 입력시 힌트를 드립니다)");

            int count = 0;
            int answer = 0;
            while ((answer = Convert.ToInt32(Console.ReadLine())) != target_number)
            {
                if (answer == 0)
                {
                    Console.WriteLine("힌트: 제가 생각하고 있는 숫자는 2로 나누었을 때 나머지가 {0}입니다.", target_number % 2);
                    continue;
                }
                Console.WriteLine("틀렸어요!");
                count++;
            }

            Console.WriteLine("정답입니다. 맞추기까지 {0}번 소요되었습니다", count);
        }
    }
}
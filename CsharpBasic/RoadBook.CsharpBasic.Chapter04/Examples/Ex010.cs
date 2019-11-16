using System;

namespace RoadBook.CsharpBasic.Chapter04.Examples
{
    public class Ex010
    {
        public void Run()
        {
            Random rand = new Random();
            int target_number = rand.Next(1, 10);

            Console.WriteLine("제가 생각하고 있는 1 ~ 10 사이의 숫자를 맞춰보세요");

            int count = 0;
            bool isMatched = false;
            do
            {
                if (Convert.ToInt32(Console.ReadLine()) == target_number)
                {
                    isMatched = true;
                    Console.WriteLine("정답입니다. 맞추기까지 {0}번 소요되었습니다", count);
                }
                else
                {
                    Console.WriteLine("틀렸어요!");
                    count++;
                }
            } while (isMatched == false);

            
        }
    }
}
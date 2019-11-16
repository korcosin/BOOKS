using System;

namespace RoadBook.CsharpBasic.Chapter06.Works
{
    public class Exam001
    {
        public void Run()
        {
            int[] ages = new int[10];

            for (int idx = 0; idx < ages.Length; idx++)
            {
                Console.Write("{0}번째 사람의 나이를 입력하세요: ", idx + 1);
                ages[idx] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("나이 입력이 완료되었습니다.");

            int _20_down = 0, _20 = 0, _30 = 0, _40 = 0, _50 = 0, _60_up = 0;
            for (int idx = 0; idx < ages.Length; idx++)
            {
                if (ages[idx] < 20)
                {
                    _20_down++;
                }
                else if (ages[idx] >=20 && ages[idx] <30)
                {
                    _20++;
                }
                else if (ages[idx] >= 30 && ages[idx] < 40)
                {
                    _30++;
                }
                else if (ages[idx] >= 40 && ages[idx] < 50)
                {
                    _40++;
                }
                else if (ages[idx] >= 50 && ages[idx] < 60)
                {
                    _50++;
                }
                else
                {
                    _60_up++;
                }
            }
          
            Console.WriteLine("20대 미만: {0}명", _20_down);
            Console.WriteLine("20대: {0}명", _20);
            Console.WriteLine("30대: {0}명", _30);
            Console.WriteLine("40대: {0}명", _40);
            Console.WriteLine("50대: {0}명", _50);
            Console.WriteLine("60대 이상: {0}명", _60_up);
        }
    }
}
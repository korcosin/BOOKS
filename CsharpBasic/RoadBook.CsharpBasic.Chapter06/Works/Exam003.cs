using System;
using System.Collections.Generic;

namespace RoadBook.CsharpBasic.Chapter06.Works
{
    public class Exam003
    {
        public void Run()
        {
            Console.Write("몇 명의 인원에게 무료 혜택을 제공할까요? ");
            int limit = Convert.ToInt32(Console.ReadLine());

            Queue<string> queue = new Queue<string>();
            Console.Write("무료 영화 선착순 예매 시스템입니다.");
            while (true)
            {
                Console.Write("이름을 입력해주세요(q: 종료): ");
                string name = Console.ReadLine();

                if (name == "q") break;
                queue.Enqueue(name);
            }
            Console.WriteLine("무료 영화 관람권 당첨자는");
            for (int idx = 0; idx < limit; idx++)
            {
                Console.WriteLine(queue.Dequeue());
            }
            Console.WriteLine("입니다.");
        }
    }
}

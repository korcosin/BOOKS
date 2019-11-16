using System;
using System.Collections.Generic;

namespace RoadBook.CsharpBasic.Chapter06.Works
{
    public class Exam004
    {
        public void Run()
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>()
            {
                { "A", new List<string> { "대한민국", "프랑스", "미국", "이집트" } },
                { "H", new List<string> { "일본", "브라질", "독일", "스페인" } }
            };

            while (true)
            {
                Console.Write("조 추첨 결과 어느 조를 조회할까요? (q: 종료) :");
                string group = Console.ReadLine();

                if (group == "q") break;

                List<string> nation = dict[group];
                Console.WriteLine("{0}조에 속한 나라는", group);
                for (int idx = 0; idx < nation.Count; idx++)
                {
                    Console.WriteLine(nation[idx]);
                }
                Console.WriteLine("입니다.");
            }
        }
    }
}

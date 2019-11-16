using System;
using System.Collections.Generic;

namespace RoadBook.CsharpBasic.Chapter06.Works
{
    public class Exam002
    {
        public void Run()
        {
            List<int> numbers = new List<int>();

            for (int idx = 0; idx < 5; idx++)
            {
                Console.Write("숫자를 입력해주세요: ");
                numbers.Add(Convert.ToInt32(Console.ReadLine()));
            }

            numbers.Sort();

            Console.Write("오름차순 정렬 결과 : ");
            
            for (int idx = 0; idx < numbers.Count; idx++)
            {
                Console.Write("{0}", numbers[idx]);
                if ((idx + 1) < numbers.Count) {
                    Console.Write(",");
                }
            }

            Console.WriteLine();
        }
    }
}

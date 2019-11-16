using System;

namespace RoadBook.CsharpBasic.Chapter04.Examples
{
    public class Ex005
    {
        public void Run()
        {
            int fact_result = 1;

            for (int index = 5; index > 0; index--)
            {
                fact_result *= index;
            }

            Console.WriteLine("5!은 {0}입니다.", fact_result);
        }
    }
}
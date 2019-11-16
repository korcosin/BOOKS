using System;

namespace RoadBook.CsharpBasic.Chapter05.Examples
{
    public class Ex007
    {
        public void Run()
        {
            dynamic result = Sum(1, 2, 3, 4, 5);
            Console.WriteLine("1 ~ 5까지의 합은 {0}", result);
        }

        private int Sum(params int[] number)
        {
            int result = 0;

            for (int idx = 0; idx < number.Length; idx++)
            {
                result += number[idx];
            }

            return result;
        }
    }
}
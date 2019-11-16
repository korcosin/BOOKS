using System;

namespace RoadBook.CsharpBasic.Chapter07.Examples
{
    public class Ex003
    {
        public void Run()
        {
            Console.Write("숫자를 입력하세요 : ");

            try
            {
                int number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("입력된 숫자는 {0}", number);
            }
            catch (Exception)
            {
                Console.WriteLine("예외 상황 발생");
            }
        }
    }
}
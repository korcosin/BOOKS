using System;
using RoadBook.CsharpBasic.Chapter07.Examples.UserException;

namespace RoadBook.CsharpBasic.Chapter07.Examples
{
    public class Ex008
    {
        public void Run()
        {
            Console.Write("두개의 숫자를 입력 하세요 : ");

            try
            {
                int number1 = Convert.ToInt32(Console.ReadLine());
                int number2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(Divide(number1, number2));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private int Divide(int number1, int number2)
        {
            if (number2 == 0)
            {
                throw new MyStyleException("0으로 나눌수 없습니다!!");
            }

            return number1 / number2;
        }
    }
}
using System;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    public class Ex008
    {
        public void Run()
        {
            Console.WriteLine("숫자를 입력하세요");
            int number = Convert.ToInt32(Console.ReadLine());

            bool isOddNumber = ((number % 2 == 1) ? true : false);

            if (number > 0 && isOddNumber)
            {
                Console.WriteLine("{0}은 양의 홀수입니다.", number);
            }
            else if (number > 0 && !isOddNumber)
            {
                Console.WriteLine("{0}은 양의 짝수입니다.", number);
            }
            else if (number < 0 && isOddNumber)
            {
                Console.WriteLine("{0}은 음의 홀수입니다.", number);
            }
            else if (number < 0 && !isOddNumber)
            {
                Console.WriteLine("{0}은 음의 짝수입니다.", number);
            }
            else
            {
                Console.WriteLine("{0}은 zero입니다.", number);
            }
        }
    }
}
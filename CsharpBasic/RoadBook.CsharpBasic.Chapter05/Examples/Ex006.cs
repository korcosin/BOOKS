using System;

namespace RoadBook.CsharpBasic.Chapter05.Examples
{
    public class Ex006
    {
        public void Run()
        {
            int number01 = 10;
            int number02 = 3;

            dynamic result01 = Sum(number01, number02);
            dynamic result02 = Minus(number01, number02);
            dynamic result03 = Multiple(number01, number02);
            dynamic result04 = Divide(number01, number02);

            Console.WriteLine("{0}과 {1}의 사칙연산 결과 값 : {2}, {3}, {4}, {5}",
                number01,
                number02,
                result01,
                result02,
                result03,
                result04
            );
        }

        private int Sum(int number01, int number02)
        {
            return number01 + number02;
        }
        private int Minus(int number01, int number02)
        {
            return number01 - number02;
        }
        private int Multiple(int number01, int number02)
        {
            return number01 * number02;
        }
        private double Divide(int number01, int number02)
        {
            return (double)number01 / number02;
        }
    }
}
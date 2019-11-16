using System;

namespace RoadBook.CsharpBasic.Chapter09.Examples
{
    public class Ex005
    {
        private delegate int RunCalc(int a, int b);

        public void run()
        {
            RunCalc calc = (a, b) => a + b;
            Console.WriteLine(calc(1, 2));

            calc = (a, b) => a * b;
            Console.WriteLine(calc(1, 2));
        }
    }
}
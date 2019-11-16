using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter09.Examples
{
    public class Ex003
    {
        private delegate int RunCalc(int a, int b);

        private static int Sum(int number1, int number2)
        {
            return number1 + number2;
        }

        private static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        public void Run()
        {
            RunCalc calc = delegate (int a, int b)
            {
                return a / b;
            };
            
            Console.WriteLine(calc(10, 2));
        }
    }
}
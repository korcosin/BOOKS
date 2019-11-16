using System; 

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    public class Ex009
    {
        public void Run()
        {
            int number01 = 10;
            double number02 = number01;
            int number03 = (int)number02;

            Console.WriteLine("number01 변수의 타입은 {0}", number01.GetType());
            Console.WriteLine("number02 변수의 타입은 {0}", number02.GetType());
            Console.WriteLine("number03 변수의 타입은 {0}", number03.GetType());
        }
    }
}
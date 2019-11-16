using System; 

namespace RoadBook.CsharpBasic.Chapter02.Works
{
    public class Exam001
    {
        public void Run()
        {
            int number01;
            int number02;

            Console.WriteLine("숫자를 두개 입력하세요:");
            number01 = Convert.ToInt32(Console.ReadLine());
            number02 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}은 {1}보다 큽니다. (참/거짓: {2})", 
                number01, 
                number02, 
                (number01 > number02)
            );
        }
    }
}

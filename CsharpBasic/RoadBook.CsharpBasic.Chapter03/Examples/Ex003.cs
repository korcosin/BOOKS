using System;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    public class Ex003
    {
        public void Run()
        {
            const int zero = 0;

            if (zero == 0)
            {
                Console.WriteLine("첫번째 if문입니다.");
                Console.WriteLine("zero는 0이기 때문에 출력을 합니다.");
            }
            else
            {
                Console.WriteLine("첫번째 else문입니다.");
                Console.WriteLine("조건절에 해당하기 때문에 출력에서 제외됩니다..");
            }

            if (zero == 1)
            {
                Console.WriteLine("두번째 if문입니다.");
                Console.WriteLine("zero는 1이 아니기 때문에 출력에서 제외됩니다.");
            }
            else
            {
                Console.WriteLine("두번째 else문입니다.");
                Console.WriteLine("조건절에 해당하지 않기 때문에 출력을 합니다.");
            }
        }
    }
}
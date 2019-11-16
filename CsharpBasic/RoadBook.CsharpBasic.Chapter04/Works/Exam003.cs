using System;

namespace RoadBook.CsharpBasic.Chapter04.Works
{
    public class Exam003
    {
        public void Run()
        {
            Console.WriteLine("***** 안녕하세요 Road Bank입니다 *****");
            Console.WriteLine("1: 잔액조회");
            Console.WriteLine("2: 입금");
            Console.WriteLine("3: 출금");
            Console.WriteLine("0: 종료");
            Console.WriteLine("**************************************");

            int money = 0;
            while(true)
            {
                int input = Convert.ToInt32(Console.ReadLine());

                if(input == 0) { break; }

                switch (input)
                {
                    case 1:
                        Console.WriteLine("잔액은 '{0}'원입니다.", money);
                        break;
                    case 2:
                        Console.WriteLine("입금할 금액을 입력하세요");
                        money += Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("입금되었습니다.");
                        break;
                    case 3:
                        Console.WriteLine("출금할 금액을 입력하세요");
                        money -= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("출금되었습니다.");
                        break;
                    default:
                        Console.WriteLine("잘 못 입력하였습니다.");
                        break;
                }
            }

            Console.WriteLine("감사합니다.");
        }
    }
}

using System;

namespace RoadBook.CsharpBasic.Chapter05.Works
{
    public class Exam003
    {
        public void Run()
        {
            Console.WriteLine("***** 안녕하세요 Road Bank입니다 *****");
            Console.WriteLine("1: 계좌 만들기");
            Console.WriteLine("2: 잔액 조회");
            Console.WriteLine("3: 입금");
            Console.WriteLine("4: 출금");
            Console.WriteLine("0: 종료");
            Console.WriteLine("**************************************");

            Model.BankAccount bankAccount = new Model.BankAccount()
            {
                PrimaryName = "",
                UserName = "",
                Money = 0
            };
            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());

                if (input == 0) { break; }

                switch (input)
                {
                    case 1:
                        Console.Write("통장 고유이름을 입력하세요: ");
                        bankAccount.PrimaryName = Console.ReadLine();
                        Console.Write("통장 개설자의 이름을 입력하세요: ");
                        bankAccount.UserName = Console.ReadLine();
                        Console.WriteLine("'{0}'님의 '{1}'이 개설되었습니다.", bankAccount.UserName, bankAccount.PrimaryName);
                        break;
                    case 2:
                        Console.WriteLine("잔액은 '{0}'원입니다.", bankAccount.Money);
                        break;
                    case 3:
                        Console.WriteLine("입금할 금액을 입력하세요");
                        bankAccount.Money += Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("입금되었습니다.");
                        break;
                    case 4:
                        Console.WriteLine("출금할 금액을 입력하세요");
                        bankAccount.Money -= Convert.ToInt32(Console.ReadLine());
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

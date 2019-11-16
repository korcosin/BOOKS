using System;
using System.IO;

namespace RoadBook.CsharpBasic.Chapter08.Works
{
    public class Exam002
    {
        Model.BankAccount bankAccount;
        public void Run()
        {
            Console.WriteLine("***** 안녕하세요 Road Bank입니다 *****");
            Console.WriteLine("1: 계좌 만들기");
            Console.WriteLine("2: 잔액 조회");
            Console.WriteLine("3: 입금");
            Console.WriteLine("4: 출금");
            Console.WriteLine("0: 종료");
            Console.WriteLine("**************************************");

            Start();
            
            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());

                if (input == 0) { break; }

                switch (input)
                {
                    case 1:
                        Console.Write("통장 고유이름을 입력하세요: ");
                        string primaryName = Console.ReadLine();
                        Console.Write("통장 개설자의 이름을 입력하세요: ");
                        string userName = Console.ReadLine();

                        CreateAccount(primaryName, userName);
                        break;
                    case 2:
                        CheckMyMoney();
                        break;
                    case 3:
                        Console.WriteLine("입금할 금액을 입력하세요");
                        Deposit(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 4:
                        Console.WriteLine("출금할 금액을 입력하세요");
                        WithDraw(Convert.ToInt32(Console.ReadLine()));
                        break;
                    default:
                        Console.WriteLine("잘 못 입력하였습니다.");
                        break;
                }
            }

            Exit();
        }

        private void Start()
        {
            string logFilePath = string.Format(@"{0}\bankLog", Environment.CurrentDirectory);
            DirectoryInfo directory = new DirectoryInfo(logFilePath);

            if (directory.Exists && directory.GetFiles().Length > 0)
            {
                FileInfo file = directory.GetFiles()[0];
                string[] bankInfo = file.Name.Split('-');
                int money = 0;
                using (StreamReader sr = new StreamReader(file.FullName))
                {
                    money = Convert.ToInt32(sr.ReadLine());
                }

                bankAccount = new Model.BankAccount()
                {
                    PrimaryName = bankInfo[0],
                    UserName = bankInfo[1].Replace(".txt", ""),
                    Money = money
                };

                Console.WriteLine("이미 계좌가 있습니다");
            }
        }

        private void CreateAccount(string primaryName, string userName)
        {
            bankAccount = new Model.BankAccount()
            {
                PrimaryName = primaryName,
                UserName = userName,
                Money = 0
            };
            
            Console.WriteLine("'{0}'님의 '{1}'이 개설되었습니다.", bankAccount.UserName, bankAccount.PrimaryName);
        }

        private void CheckMyMoney()
        {
            Console.WriteLine("잔액은 '{0}'원입니다.", bankAccount.Money);
        }

        private void Deposit(int money)
        {
            bankAccount.Money += money;
            Console.WriteLine("입금되었습니다.");
        }

        private void WithDraw(int money)
        {
            if (bankAccount.Money > money)
            {
                bankAccount.Money -= money;
                Console.WriteLine("출금되었습니다.");
            }
            else
            {
                Console.WriteLine("잔액이 부족합니다!");
            }
        }

        private void Exit()
        {
            if(bankAccount != null)
            {
                string directory = string.Format(@"{0}\bankLog\",
                    Environment.CurrentDirectory
                );
                string filename = string.Format(@"{0}-{1}.txt",
                    bankAccount.PrimaryName,
                    bankAccount.UserName
                );

                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                using (StreamWriter sw = new StreamWriter(directory + filename, false))
                {
                    sw.WriteLine(bankAccount.Money);
                }
            }
            Console.WriteLine("감사합니다.");
        }
    }
}
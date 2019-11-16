using System;

namespace RoadBook.CsharpBasic.Chapter07.Examples
{
    public class Ex006
    {
        public void Run()
        {
            Console.Write("숫자를 입력 하세요 : ");

            int number = 0;

            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Format Exception : 숫자가 아닌 값을 입력 했습니다.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow Exception : 숫자의 범위를 초과 했습니다.");
            }
            catch (Exception e)
            {
                Console.WriteLine("예측 하지 못한 예외 상황 발생, 관리자에게 문의하세요");
                Console.WriteLine("에러 코드 : {0}", e.HResult);
                Console.WriteLine("에러 메시지 : {0}", e.Message);
            }

            Console.WriteLine("입력 된 숫자는 {0}", number);
        }
    }
}
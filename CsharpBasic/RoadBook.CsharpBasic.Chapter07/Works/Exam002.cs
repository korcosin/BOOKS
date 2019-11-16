using System;

namespace RoadBook.CsharpBasic.Chapter07.Works
{
    public class Exam002
    {
        public void Run()
        {
            byte number;
            Console.Write("숫자를 입력하세요: ");
            try
            {
                number = Convert.ToByte(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
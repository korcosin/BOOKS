using System; 

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    public class Ex003
    {
        public void Run()
        {
            bool bCalculate01 = (1 + 2 == 3);
            bool bCalculate02 = ((12 > 8) && (8 < 20));
            bool isContainsWord = "Hello Csharp".Contains("Hello");

            Console.WriteLine("1 + 2 = 3 ? ({0})", bCalculate01);
            Console.WriteLine("12는 8보다 크고 8은 20보다 작다 ? ({0})", bCalculate02);
            Console.WriteLine("Hello Csharp 문장에 Hello가 포함되어 있다 ? ({0})", isContainsWord);
        }
    }
}
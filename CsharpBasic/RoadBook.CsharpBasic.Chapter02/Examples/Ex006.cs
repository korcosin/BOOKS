using System; 

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    public class Ex006
    {
        public void Run()
        {
            #region >> 정수형 변수
            sbyte shortByteNumber = 127;
            byte byteNumber = 0;
            short shortNumber = 32767;
            int intNumber = 20000;
            long longNumber = 50000;
            #endregion

            #region >> 실수형 변수
            float floatNumber = 3.14f;
            double doubleNumber = 1.5;
            decimal decimalNumber = 5.5m;
            #endregion

            Console.WriteLine("정수 : {0}, {1}, {2}, {3}, {4}", shortByteNumber, byteNumber, shortNumber, intNumber, longNumber);
            Console.WriteLine("실수 : {0}, {1}, {2}", floatNumber, doubleNumber, decimalNumber);

            #region >> 문자열 변수
            char ch = 'A';
            string strMessage = "Hello Csharp";
            #endregion

            Console.WriteLine(ch);
            Console.WriteLine("{0}{1}{2}{3}{4}", strMessage[0], strMessage[1], strMessage[2], strMessage[3], strMessage[4]);
            Console.WriteLine(strMessage);

            #region >> 참/거짓 변수
            bool bCalculate = (1 + 2 == 3);
            bool bCalculate2 = ((12 > 8) && (8 < 20));
            bool isContainsWord = "Hello Csharp".Contains("Hello");
            #endregion

            Console.WriteLine("1 + 2 = 3 ? ({0})", bCalculate);
            Console.WriteLine("(12는 8보다 크고 8은 20보다 작다 ? ({0})", bCalculate2);
            Console.WriteLine("Hello Csharp 문장에 Hello가 포함되어 있다 ? ({0})", isContainsWord);

            #region >> 만능 변수
            object objValue = 1;
            var vValue = "var";
            dynamic dValue = true;
            #endregion

            Console.WriteLine("object 변수 값은 {0}", objValue);
            Console.WriteLine("var 변수 값은 {0}", vValue);
            Console.WriteLine("dynamic 변수 값은 {0}", dValue);
        }
    }
}
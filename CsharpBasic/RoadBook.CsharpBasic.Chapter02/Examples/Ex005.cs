using System; 

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    public class Ex005
    {
        public void Run()
        {
            object objHello = "Hello World";
            var vHello = "Hello World";
            dynamic dHello = "Hello World";

            bool isContainsWord01 = objHello.ToString().Contains("Hello");
            bool isContainsWord02 = vHello.ToString().Contains("Hello");
            bool isContainsWord03 = dHello.ToString().Contains("Hello");

            Console.WriteLine("object 변수에 Hello가 포함되어 있다 ? {0}", isContainsWord01);
            Console.WriteLine("var 변수에 Hello가 포함되어 있다 ? {0}", isContainsWord02);
            Console.WriteLine("dynamic 변수에 Hello가 포함되어 있다 ? {0}", isContainsWord03);
        }
    }
}
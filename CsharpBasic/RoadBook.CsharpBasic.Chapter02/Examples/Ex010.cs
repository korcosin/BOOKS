using System; 

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    public class Ex010
    {
        public void Run()
        {
            string strNumber = "10";
            
            int convertNumber = Convert.ToInt32(strNumber);
            int parseNumber = Int32.Parse(strNumber);

            Console.WriteLine("{0} + {1} = {2}", convertNumber, parseNumber, convertNumber + parseNumber);
        }
    }
}
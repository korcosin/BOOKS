using System; 

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    public class Ex007
    {
        public void Run()
        {
            int korean = 100;
            int english = 100;
            int math = 98;
            int sports = 97;

            int totalScore = korean + english + math + sports;

            Console.WriteLine("성적 총점 {0}", totalScore);
            Console.WriteLine("평균 {0}", totalScore / 4);
        }
    }
}
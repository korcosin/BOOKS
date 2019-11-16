using System;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    public class Ex010
    {
        public void Run()
        {
            Console.WriteLine("최근 본 영화 제목을 입력하세요");
            string movieTitle = Console.ReadLine();
            Console.WriteLine("{0}의 관람 평점을 입력하세요(1점~5점사이)", movieTitle);
            int rating = Convert.ToInt32(Console.ReadLine());

            switch (rating)
            {
                case 1:
                    Console.WriteLine("{0} 영화는 환불을 받고 싶을 정도로 최악의 영화군요", movieTitle);
                    break;
                case 2:
                    Console.WriteLine("{0} 영화는 지루한 영화군요", movieTitle);
                    break;
                case 3:
                    Console.WriteLine("{0} 영화는 시간 때우기 좋은 그 이상 그 이하도 아닌 영화군요", movieTitle);
                    break;
                case 4:
                    Console.WriteLine("{0} 영화는 흥미를 유발할 만한 완성도 높은 영화군요", movieTitle);
                    break;
                case 5:
                    Console.WriteLine("{0} 영화는 당신의 최고의 영화 하나로 기억되겠군요", movieTitle);
                    break;
                default:
                    Console.WriteLine("평점 계산에 실패하였습니다.");
                    break;
            }
        }
    }
}